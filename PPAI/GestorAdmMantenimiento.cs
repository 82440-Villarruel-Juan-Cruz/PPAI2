using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Windows.Forms;
using System.Linq;
using PPAI.Clases;

public class GestorAdmMantenimiento
{

    #region Atributos
    private Usuario usuarioLogueado;
    private Sesion sesionActual;
    private List<Estado> estados;
    private List<Estado> estadosDisponibles;
    private DateTime fechaHoraActual;
    private PersonalCientifico personalCientifico;
    private List<AsignacionReesponsableTecnicoRT> listaART;
    private List<RecursoTecnologico> listaRecursosTecnologicosDisponiles;
    private RecursoTecnologico RTselecccionado;
    private DateTime fechaInahbilitacion;
    private String razonMantenimiento;
    private List<Turno> turnosConfirmadosOPendientesDeConfirmacion;
    private List<AsignacionCientificoDelCl> asignacionCientificoDelCls;
    private List<PersonalCientifico> ListaEmail;
    #endregion

    #region Metodos

        #region Metodos Paso 1 
    //Comienzo del CU (Paso 1 ) 
    public void nuevoMantenimientoCorrectivo(){
        GenerarDatos();
        BuscarUsuarioLogueado();
        obtenerDatosRTAMostrar();
        obtenerFechaHoraActual();
    }

    //Obtener Fecha y Hora Actual (Paso 1) 
    private void obtenerFechaHoraActual(){
        fechaHoraActual = DateTime.Now;
    }
    //Buscar Los Recursos Tecnologicos Asignados al Responsable Logueado (Paso 1) Diferente Nombre
    private DataTable obtenerDatosRTAMostrar(){
        
        foreach (AsignacionReesponsableTecnicoRT art in listaART) {
            if(art.getPersonalCientifico().esTuUsuario(usuarioLogueado) && art.getRecursoTecnologico().estaDisponible() && !listaRecursosTecnologicosDisponiles.Contains(art.getRecursoTecnologico())){
                listaRecursosTecnologicosDisponiles.Add(art.getRecursoTecnologico());
            }
        }
        DataTable tabla = new DataTable();
        tabla.Columns.Add("Tipo Nombre");
        tabla.Columns.Add("Numero");
        tabla.Columns.Add("Marca");
        tabla.Columns.Add("Modelo");
        tabla.Columns.Add("Estado");
        foreach (RecursoTecnologico rt in listaRecursosTecnologicosDisponiles)
        {
            tabla.Rows.Add(rt.getTiponombre(), rt.getNumeroRT(), rt.getMarca(), rt.getModelo(), rt.getEstado());
        }
        return tabla;


    }   

    public DataTable agruparRTPorTipo()
    {
        DataTable dt = obtenerDatosRTAMostrar();
        dt.AsEnumerable().OrderBy(p => p.Field<String>("Tipo Nombre"));
        return dt;
    }

    // Busca el Usuario Logueado ( Paso 1 ) 
    private void BuscarUsuarioLogueado(){
        usuarioLogueado = sesionActual.getUsuario();
    }
   

    #endregion

        #region Metodos Paso 2 

    //Toma La seleccion del RT en la pantalla
    public void tomarSeleccionRT(RecursoTecnologico seleccion)
    {
        RTselecccionado = seleccion;
    }

    public void tomarDatosMantenimientoCorrectivo(DateTime fecha, String RazonMantenimieto)
    {
        this.fechaInahbilitacion = fecha;
        razonMantenimiento = RazonMantenimieto;
        verificarTurnosConfirmadosYPendientes();
    }


    // Entra al Recurso tecnologico y Buscar los turnos Confirmardos o Pendientes de Confirmar ( Paso 2 ) 
    private void verificarTurnosConfirmadosYPendientes()
    {
        turnosConfirmadosOPendientesDeConfirmacion = RTselecccionado.buscarTurnoConfirmadoOPEndientesDentroDelPlazo(fechaInahbilitacion);
    }

    public DataTable ObtenerDatosTurno()
    {
        DataTable table = new  DataTable();
        ListaEmail = new List<PersonalCientifico>();
        table.Columns.Add("Fecha");
        table.Columns.Add("Hora");
        table.Columns.Add("Nombre Cientifico");
        table.Columns.Add("Apellido Cientifico");
        table.Columns.Add("Email");
        foreach (AsignacionCientificoDelCl art in asignacionCientificoDelCls)
        {
            //Esta lista de Turnos ya son los turnos asignados al recurso tecnologico seleccionado
           
            foreach (Turno tr in turnosConfirmadosOPendientesDeConfirmacion)
            {
                if (art.getTurnos().Contains(tr))
                {
                    DateTime fechaHoraInicio = tr.getFechaHoraInicio();
                    PersonalCientifico pf = art.getCientifico();
                    agregarListaMail(pf);
                    string nombreCientifico = pf.getNombre();
                    string apellidoCientifico = pf.getApellido();
                    string emailCientifico = pf.getEmail();
                    table.Rows.Add(fechaHoraInicio.Date.ToString(), fechaHoraInicio.Hour.ToString(), nombreCientifico, apellidoCientifico, emailCientifico);
                }        
            }
        }
          return table;     
    }

    public DataTable ordenarTurnosPorCientifico()
    {
        DataTable dt = ObtenerDatosTurno();
        dt.AsEnumerable().OrderBy(p => p.Field<String>("Apellido Cientifico"));
        return dt;
    }


    private void agregarListaMail(PersonalCientifico pf)
    {
        if (!ListaEmail.Contains(pf))
        {
            ListaEmail.Add(pf);
        }
    }

        #endregion

        #region Metodos Paso 3

    // Cambio el Estado de todos los turnos 

    public DataTable crearMantenimientoCorrectivo()
    {

        RTselecccionado.crearMantenimientoCorrectivo();
        RTselecccionado.CambiarEstado(fechaInahbilitacion, "Con Ingreso en Mantenimiento correctivo");
        cancelarTurnoConReserva();

        DataTable tabla = new DataTable();
        tabla.Columns.Add("Tipo Nombre");
        tabla.Columns.Add("Numero");
        tabla.Columns.Add("Marca");
        tabla.Columns.Add("Modelo");
        tabla.Columns.Add("Estado");
        RecursoTecnologico rt = RTselecccionado;
        tabla.Rows.Add(rt.getTiponombre(), rt.getNumeroRT(), rt.getMarca(), rt.getModelo(), rt.getEstado());
        enviarNotificacionViaMail();
        return tabla;

    }

    private void cancelarTurnoConReserva()
    {
        foreach (Turno tr in turnosConfirmadosOPendientesDeConfirmacion)
        {
            tr.CambiarEstado(fechaInahbilitacion, "Cancelado por Mantenimiento correctivo");
        }

    }


    public void enviarNotificacionViaMail()
    {
        SmtpClient cliente = new SmtpClient()
        {
            Host = "smtp-mail.outlook.com",
            Port = 587,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            EnableSsl = true,
            Credentials = new NetworkCredential()
            {
                UserName = "genaroBProducciones@hotmail.com",
                Password = "genaroPROD"
            }
        };

        String texto = String.Format(" EL recurso tecnologico que usted reservo,{0}, entrara en Mantenimiento Correctivo, disculpe las molestias ocaciondas, el mismo estara disponible para {1} ", RTselecccionado.getModelo(), fechaInahbilitacion.Date.ToShortDateString());

        
        MailAddress mailAddress = new MailAddress("genaroBProducciones@hotmail.com", "Genaro B Producciones");

        #region Datos
        MailAddress Para = new MailAddress("genarobergesio@gmail.com", "Genarito");
        MailAddress Para2 = new MailAddress("jcbosetti@gmail.com", "Juan 2");
        MailAddress Para3 = new MailAddress("villarrueljuan312@gmail.com", "Juan El Original");
        MailAddress Para4 = new MailAddress("fermin.stura00@gmail.com", "Ferchu");
        // MailAddress Para5 = new MailAddress("mickaelacrespo@gmail.com", "Mica"); // Mail Profe
        // MailAddress Para6 = new MailAddress("maurobastasiniprof@gmail.com", "Mauro"); // Mail Profe
        // MailAddress Para7 = new MailAddress("jmeles@gmail.com", "Judith"); // Mail Profe
        #endregion

        MailMessage mailMessage = new MailMessage()
        {
            From = mailAddress,
            Subject = "Recurso entra en Mantenimiento",
            Body = texto,
            IsBodyHtml = true,
        };

        foreach (PersonalCientifico pr in ListaEmail)
        {
            MailAddress _to = new MailAddress(pr.getEmail(), pr.getApellido());
            mailMessage.To.Add(_to);
        }

        mailMessage.To.Add(Para);
        mailMessage.To.Add(Para2);
        mailMessage.To.Add(Para3);
        mailMessage.To.Add(Para4);/*
        mailMessage.To.Add(Para5);
        mailMessage.To.Add(Para6);
        mailMessage.To.Add(Para7);*/

        try
        {
            cliente.Send(mailMessage);
            MessageBox.Show("Enviado Correctamente");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error en el envio {0}", ex.Message);
            throw;
        }
     
    }

    public void MandarWhats()
    {
        WhatsApp whatsApp = new WhatsApp();
        String texto = String.Format(" EL recurso tecnologico que usted reservo,{0}, entrara en Mantenimiento Correctivo, disculpe las molestias ocaciondas, el mismo estara disponible para {1} ", RTselecccionado.getModelo(), fechaInahbilitacion.Date.ToShortDateString());
        whatsApp.MandarMensaje(texto);
    }

    #endregion


    #region Metodos de La Pantalla




    // Toma los datos de Fecha de Mantenimiento


    //Obtener el Usuario Logueado
    public Usuario getUsuario()
    {
        return usuarioLogueado;
    }
    //Obtener Personal Cientifico
    public PersonalCientifico getPersonalCientifico()
    {
        return personalCientifico;
    }

    // Retorna Los turnos Confirmados O Pendientes de Confirmacion del Recurso Tecnologico
    public List<Turno> getTurnosConfirmadosOPendientesDeConfirmacion()
    {
        return turnosConfirmadosOPendientesDeConfirmacion;
    }

    // Retorno Los Recursos Tecnologicos Disponibles para el Cientifico
    public List<RecursoTecnologico> getListaRecursosTecnologicosDisponiles()
    {
        return listaRecursosTecnologicosDisponiles;
    }

    // Retorna el Recurso Tecnologico Seleccioando
    public RecursoTecnologico getRTselecccionado()
    {
        return RTselecccionado;
    }

    // Retonar la Asignacion De Cientificos del CL
    public List<AsignacionCientificoDelCl> getAsignacionCientificoDelCls()
    {
        return asignacionCientificoDelCls;
    }
    #endregion


    private void GenerarDatos(){
        // Inicializar Listas
        listaART = new List<AsignacionReesponsableTecnicoRT>();
        listaRecursosTecnologicosDisponiles = new List<RecursoTecnologico>();
        estados = new List<Estado>();
        estadosDisponibles = new List<Estado>();
        turnosConfirmadosOPendientesDeConfirmacion = new List<Turno>();
        asignacionCientificoDelCls = new List<AsignacionCientificoDelCl>();


        //Personal Cientifico
        PersonalCientifico pc = new PersonalCientifico("82444", "Max", "Verstappen", "jcbosetti@unc.edu.ar", "amantedelaaceituna@yahoo.com", "351456897", 417111111);
        PersonalCientifico pc2 = new PersonalCientifico("82010", "Juan Jose", "Martinez", "jjmartinez@unc.edu.ar", "amantedelaaceituna@yahoo.com", "35145776897", 417111111);
        PersonalCientifico pc3 = new PersonalCientifico("83123", "Juan ", "Garcia", "jgarcia@unc.edu.ar", "amantedelaaceituna@yahoo.com", "35188797", 4784274);
        PersonalCientifico pc4 = new PersonalCientifico("82443", "Maitas", "Perez", "mpereez@unc.edu.ar", "amantedelaaceituna@yahoo.com", "35147586897", 41717811);
        PersonalCientifico pc5 = new PersonalCientifico("45444", "Cruz", "Gimenze", "cgimenze@unc.edu.ar", "amantedelaaceituna@yahoo.com", "35168597", 417471111);

        // Recurso Tecnologico 
        RecursoTecnologico recursoTecnologico = new RecursoTecnologico(3, DateTime.Parse("2009/5/10"), 50, 15, 60);
        TipoRecursoTecnologico tipo = new TipoRecursoTecnologico("Casco", "Parte de la Armadura MARK III ");
        Marca marca = new Marca("Stark Industries", null);
        Modelo modelo = new Modelo("MARK III");
        recursoTecnologico.setMarca(marca);
        recursoTecnologico.setModelo(modelo);
        recursoTecnologico.setTipo(tipo);

        RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico(4, DateTime.Parse("1977/12/25"), 50, 20, 40);
        TipoRecursoTecnologico tipo1 = new TipoRecursoTecnologico("Sable Laser", "Del lado Oscuro ");
        Marca marca1 = new Marca("SkyWalker", null);
        Modelo modelo1 = new Modelo("El Bobafeet");
        recursoTecnologico1.setMarca(marca1);
        recursoTecnologico1.setModelo(modelo1);
        recursoTecnologico1.setTipo(tipo1);

        RecursoTecnologico recursoTecnologico2 = new RecursoTecnologico(2, DateTime.Parse("1999/6/8"), 50, 18, 10);
        TipoRecursoTecnologico tipo2 = new TipoRecursoTecnologico("Asistente de Trama", "Arturito ");
        Marca marca2 = new Marca("Light Side", null);
        Modelo modelo2 = new Modelo("AR-D2");
        recursoTecnologico2.setMarca(marca2);
        recursoTecnologico2.setModelo(modelo2);
        recursoTecnologico2.setTipo(tipo2);



        //Establezco la sesion Actual
        sesionActual = new Sesion(DateTime.MinValue,DateTime.Now);
        //Establezco el Usuario que se logueo
        usuarioLogueado = new Usuario("fiona4","OgroAnonimo",true);


        personalCientifico = pc;
        usuarioLogueado.setPersonalCientifica(pc);
        sesionActual.setUsuario(usuarioLogueado);


        AsignacionReesponsableTecnicoRT asig = new AsignacionReesponsableTecnicoRT(DateTime.Parse("2021/12/25"), DateTime.Parse("2022/8/5"));
        asig.setPersonalCientifico(pc);
        asig.setRecursoTecnologico(recursoTecnologico);

        AsignacionReesponsableTecnicoRT asig2 = new AsignacionReesponsableTecnicoRT(DateTime.Parse("2022/1/10"), DateTime.Parse("2022/9/4"));
        asig2.setPersonalCientifico(pc);
        asig2.setRecursoTecnologico(recursoTecnologico1);

        AsignacionReesponsableTecnicoRT asig3 = new AsignacionReesponsableTecnicoRT(DateTime.Parse("2022/2/12"), DateTime.Parse("2022/10/10"));
        asig3.setPersonalCientifico(pc);
        asig3.setRecursoTecnologico(recursoTecnologico2);


        pc.setUsuario(usuarioLogueado);

        Estado disponible = new Estado("Disponible", null, "RecursoTecnologico", true, false);
        Estado confirmado = new Estado("Confirmado", null, "RecursoTecnologico", true, false);
        Estado pendienteconfirmacion = new Estado("Pendiente Confirmacion", null, "RecursoTecnologico", true, false);



        CambioEstadoRT ceRT = new CambioEstadoRT(DateTime.Parse("2022/5/10"), DateTime.MinValue);
        ceRT.setEstado(disponible);
        recursoTecnologico.setCambioEstadoRT(ceRT);
        recursoTecnologico1.setCambioEstadoRT(ceRT);
        recursoTecnologico2.setCambioEstadoRT(ceRT);


        listaART.Add(asig);
        listaART.Add(asig2);
        listaART.Add(asig3);

        

        List<Turno> listilla = new List<Turno>();
        List<Turno> listilla2 = new List<Turno>();
        List<Turno> listilla3 = new List<Turno>();



        Turno turnito = new Turno(DateTime.Parse("2022/5/28"),DateTime.Parse("2022/6/18  18:00:00"), DateTime.Parse("2022/7/15 19:00:00"), DayOfWeek.Monday);     
        CambioEstadoTurno cet = new CambioEstadoTurno(DateTime.Parse("2022/6/18"), DateTime.MinValue);
        Estado estate = new Estado("Disponible","","Turnos",true,true);
        cet.setEstado(estate);
        turnito.setCambioEstadoTurno(cet);

        Turno turnito2 = new Turno(DateTime.Parse("2022/5/10 19:00:00"), DateTime.Parse("2022/6/30  19:00:00"), DateTime.Parse("2022/7/21  19:00:00"), DayOfWeek.Monday);
        CambioEstadoTurno cet2 = new CambioEstadoTurno(DateTime.Parse("2022/6/30"), DateTime.MinValue);
        Estado estate2 = new Estado("Confirmado","","Turnos",false,true);
        cet2.setEstado(estate2);
        turnito2.setCambioEstadoTurno(cet2);

        Turno turnito3 = new Turno(DateTime.Parse("2022/4/12 19:00:00"), DateTime.Parse("2022/5/10  19:00:00"), DateTime.Parse("2022/10/21  19:00:00"), DayOfWeek.Monday);
        CambioEstadoTurno cet3 = new CambioEstadoTurno(DateTime.Parse("2022/5/10"), DateTime.MinValue);
        Estado estate3 = new Estado("Confirmado", "", "Turnos", false, true);
        cet3.setEstado(estate3);
        turnito3.setCambioEstadoTurno(cet3);

        Turno turnito4 = new Turno(DateTime.Parse("2022/3/10  19:00:00"), DateTime.Parse("2022/6/20 18:00:00"), DateTime.Parse("2022/10/20  17:00:00"), DayOfWeek.Monday);
        CambioEstadoTurno cet4 = new CambioEstadoTurno(DateTime.Parse("2022/5/10"), DateTime.MinValue);
        Estado estate4 = new Estado("Confirmado", "", "Turnos", false, true);
        cet4.setEstado(estate4);
        turnito4.setCambioEstadoTurno(cet4);



        listilla.Add(turnito);
        listilla.Add(turnito2);
        listilla.Add(turnito3);

        listilla2.Add(turnito4);

        listilla3.Add(turnito2);
        listilla3.Add(turnito3);

        //Asignacion de Turnos al Recurso Tecnologico

        recursoTecnologico.setTurnos(listilla);
        recursoTecnologico1.setTurnos(listilla2);
        recursoTecnologico2.setTurnos(listilla3);


        //Crear Asignacion Cientifico
        AsignacionCientificoDelCl acl = new AsignacionCientificoDelCl(DateTime.MinValue, DateTime.MinValue);
        //Set Cientifio y Turnos
        acl.setCientifico(personalCientifico);
        acl.setTurnos(listilla);
        //Asignar a variable
        AsignacionCientificoDelCl acl2 = new AsignacionCientificoDelCl(DateTime.MinValue, DateTime.MinValue);
        acl2.setCientifico(pc2);
        acl2.setTurnos(listilla2);

        AsignacionCientificoDelCl acl3 = new AsignacionCientificoDelCl(DateTime.MinValue, DateTime.MinValue);
        acl3.setCientifico(pc3);
        acl3.setTurnos(listilla3);

        asignacionCientificoDelCls.Add(acl);
        asignacionCientificoDelCls.Add(acl2);
        asignacionCientificoDelCls.Add(acl3);

    }

    #endregion

}

