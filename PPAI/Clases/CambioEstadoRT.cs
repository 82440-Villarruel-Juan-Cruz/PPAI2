using System;

public class CambioEstadoRT {
    private DateTime fechaHoraDesde;
    private DateTime fechaHoraHasta;
    private Estado estado = new Estado("", "", "", false, false);

    public CambioEstadoRT (DateTime fechaHoraDesde,DateTime fechaHoraHasta){
        this.fechaHoraDesde = fechaHoraDesde;
        this.fechaHoraHasta = fechaHoraHasta;
    }

    public Estado getEstado(){
        return estado;
    }

    public bool estaAhoraDisponible(){
     return   estado.esDisponible();
    }

    public void setFechaHoraDesde(DateTime fechaHoraDesde) {
        this.fechaHoraDesde = fechaHoraDesde;
    }

    public void setFechaHoraHasta(DateTime fechaHoraHasta) {
        this.fechaHoraHasta = fechaHoraHasta;
    }

    public void setEstado(Estado estado) {
        this.estado = estado;
    }

    public void setEstadoNombre(String nombre){
        estado.setNombre(nombre);
    }
}
