using System;
public class Sesion {
    private DateTime fechaHoraInicio;
    private DateTime fechaHoraFin;
    private Usuario usuario;

    public Sesion (DateTime fechaHoraFin, DateTime fechaHoraInicio){
        this.fechaHoraFin = fechaHoraFin;
        this.fechaHoraInicio = fechaHoraInicio;
    }

    public Usuario getUsuario(){
        return usuario;
    }

    public void setUsuario(Usuario usuario) {
        this.usuario = usuario;
    }
}
