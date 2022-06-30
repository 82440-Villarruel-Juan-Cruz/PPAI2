using System;
using System.Collections.Generic;

public class RecursoTecnologico {
    private int numeroRT;
    private DateTime fechaAlta;
    //private   colecion de imagenes
    private int periocidadMantenimientoPrev;
    private int duracionMantenimientoPrev;
    private int fraaccionHorarioTurnos;
    private CambioEstadoRT cambioEstadoRT;
    private TipoRecursoTecnologico tipo;
    private String marca;
    private String modelo;
    private List<Turno> turnos;
    private String tiponombre;

    public void setTipo(TipoRecursoTecnologico tipo) {
        this.tipo = tipo;
        tiponombre = tipo.nombre;
    }

    public String getTiponombre() {
        return tiponombre;
    }

    public void setTurnos(List<Turno> turnos) {
        this.turnos = turnos;
    }

    public List<Turno> getTurnos() {
        return turnos;
    }

    public int getNumeroRT() {
        return numeroRT;
    }

    public String getModelo() {
        return modelo;
    }

    public String getMarca() {
        return marca;
    }

    public RecursoTecnologico(int numeroRT, DateTime fechaAlta, int periocidadMantenimientoPrev, int duracionMantenimientoPrev, int fraaccionHorarioTurnos) {
        this.numeroRT = numeroRT;
        this.fechaAlta = fechaAlta;
        this.periocidadMantenimientoPrev = periocidadMantenimientoPrev;
        this.duracionMantenimientoPrev = duracionMantenimientoPrev;
        this.fraaccionHorarioTurnos = fraaccionHorarioTurnos;
    }

    public bool estaDisponible() {
        return cambioEstadoRT.estaAhoraDisponible();
    }

    private void setTipoRecursoTecnologico(TipoRecursoTecnologico tp) {
        this.tipo = tp;

    }
    private String getTipoRecursoTecnologicoNombre(){
        return tiponombre;
    }

    public void setCambioEstadoRT(CambioEstadoRT cambioEstadoRT) {
        this.cambioEstadoRT = cambioEstadoRT;
    }

    public string getEstado()
    {
        return cambioEstadoRT.getEstado().getNombre();
    }


    public void setMarca(Marca m) {
        marca = m.getNombre();

    }

    public void setModelo(Modelo model) {
        modelo = model.getNombre();
    }

    public List<Turno> buscarTurnoConfirmadoOPEndientesDentroDelPlazo(DateTime fechaMantenimiento) {
        List<Turno> turnosConfirmadosOPendientesDeConfirmacion = new List<Turno>();
        foreach (Turno tr in turnos
        ) {
            if (tr.getFechaHoraInicio() < (fechaMantenimiento)) { // Aca irira el Metodo es ultimo?
                if (tr.estaConfirmado() || tr.estaPendienteDeConfirmacion()) {
                    turnosConfirmadosOPendientesDeConfirmacion.Add(tr);
                }
            }

        }
        return turnosConfirmadosOPendientesDeConfirmacion;
    }

    public void CambiarEstado(DateTime fecha,String estado){
        cambioEstadoRT.setFechaHoraHasta(fecha);
        cambioEstadoRT = new CambioEstadoRT(fecha,DateTime.MinValue);
        cambioEstadoRT.setEstadoNombre(estado);

    }

    public void crearMantenimientoCorrectivo()
    {
        Mantenimiento mantenimiento = new Mantenimiento();  

    }
}





