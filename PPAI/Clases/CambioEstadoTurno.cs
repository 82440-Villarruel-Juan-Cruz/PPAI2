using System;

public class CambioEstadoTurno {
    private DateTime fechaHoraDesde;
    private DateTime fechaHoraHasta;
    private Estado estado = new Estado("", "", "", false, false);

    public CambioEstadoTurno (DateTime fechaHoraDesde,DateTime fechaHoraHasta){
        this.fechaHoraDesde = fechaHoraDesde;
        this.fechaHoraHasta = fechaHoraHasta;

    }

    public Estado getEstado() {
        return estado;
            }
    public bool estaConfirmado(){
        return   estado.esConfirmado();
    }

    public bool estaPendienteConfirmacion(){
        return   estado.esPendienteDeConfirmacion();
    }

    public void setFechaHoraHasta(DateTime fechaHoraHasta) {
        this.fechaHoraHasta = fechaHoraHasta;
    }
    public void setEstadoNombre(String nombre){
        estado.setNombre(nombre);
    }

    public void setEstado(Estado estado) {
        this.estado = estado;
    }
}
