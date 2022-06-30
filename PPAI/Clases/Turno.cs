using System;

public class Turno {
    private DateTime fechaGeneracion;
    private DateTime fechaHoraInicio;
    private DateTime fechaHoraFin;
    private DayOfWeek diaSemana;
    private CambioEstadoTurno cambioEstadoTurno;
    private String nombreCientifico;



    public Turno (DateTime fechaGeneracion,DateTime fechaHoraInicio,DateTime fechaHoraFin,DayOfWeek diaSemana){
        this.diaSemana = diaSemana;
        this.fechaGeneracion = fechaGeneracion;
        this.fechaHoraFin = fechaHoraFin;
        this.fechaHoraInicio = fechaHoraInicio;
    }

    public void setNombreCientifico(String nombreCientifico) {
        this.nombreCientifico = nombreCientifico;
    }

    public DateTime getFechaHoraInicio() {
        return  fechaHoraInicio;
    }

    public DateTime getFechaHoraFin() {
        return fechaHoraFin;
    }
    
    public void MostrarTurno(){

    }

    public void setCambioEstadoTurno(CambioEstadoTurno cambioEstadoTurno) {
        this.cambioEstadoTurno = cambioEstadoTurno;
    }

    public bool estoyDisponible(){
     return false ;
    }

    public bool estaConfirmado(){
        return cambioEstadoTurno.estaConfirmado();
    }

    public bool estaPendienteDeConfirmacion(){
        return cambioEstadoTurno.estaPendienteConfirmacion();
    }

    public string getNombreEstado()
    {
        return cambioEstadoTurno.getEstado().getNombre();
    }

    public void CambiarEstado(DateTime fecha,String estado){
        cambioEstadoTurno.setFechaHoraHasta(fecha);
        cambioEstadoTurno = new CambioEstadoTurno(fecha, DateTime.MinValue);
        cambioEstadoTurno.setEstadoNombre(estado);

    }

    public DateTime getFechaGeneracion() {
        return fechaGeneracion;
    }
}
