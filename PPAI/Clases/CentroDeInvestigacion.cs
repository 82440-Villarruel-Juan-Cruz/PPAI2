using System;

public class CentroDeInvestigacion {
    private String  nombre;
    private String direccion;
    private String edificio;
    private String piso;//Piso?
    private String cordenadas;
    private int telefonosContacto;
    private String correoElectronico;
    private  int numeroResolucionCreacion;
    private DateTime fechaResolucionCreacion;
    private String reglamento;
    private String caracteristicasGenerales;
    private String motivoBaja;
    private DateTime fechaAlta;
    private DateTime fechaBaja;
    private DateTime tiempoAntelacionReserva;

    public CentroDeInvestigacion(String Nombre, String Direccion,String Edificio, String Piso, String Coordernadas, String CorreElectronico, int TelefonosContacto, int NumeroResolucionCreacion
            , String Reglamento, String CaracteristicasGenerales, String MotivoBaja , DateTime TiempoAntelacionReserva , DateTime FechaAlta , DateTime FechaBaja, DateTime FechaResolcuionCreacion) {
        nombre = Nombre;
        direccion = Direccion;
        edificio = Edificio;
        piso = Piso;
        cordenadas = Coordernadas;
        correoElectronico = CorreElectronico;
        reglamento = Reglamento;
        caracteristicasGenerales = CaracteristicasGenerales;
        motivoBaja = MotivoBaja;
        telefonosContacto = TelefonosContacto;
        numeroResolucionCreacion = NumeroResolucionCreacion;
        fechaAlta = FechaAlta;
        fechaBaja = FechaBaja;
        fechaResolucionCreacion = FechaResolcuionCreacion;
        tiempoAntelacionReserva = TiempoAntelacionReserva;

    }

 //   public  void  mostrarCI();

   // public String miDirectorActual(){
      //  return
    //}


}
