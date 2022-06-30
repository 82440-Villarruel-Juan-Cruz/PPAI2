using System;

public class PersonalCientifico {
    private String legajo;
    private String nombre ;
    private String apellido;
    private int numeroDocumento;
    private String correoElectronicoInstitucional;
    private String correoElectronicoPersonal;
    private String telefonoCelular;
    private Usuario usuario;

    public PersonalCientifico(String legajo, String nombre, String apellido, String correoElectronicoInstitucional, String correoElectronicoPersonal, String telefonoCelular, int numeroDocumento){
        this.legajo = legajo;
        this.nombre = (nombre);
        this.apellido = apellido;
        this.numeroDocumento = numeroDocumento;
        this.correoElectronicoPersonal = correoElectronicoPersonal;
        this.correoElectronicoInstitucional = correoElectronicoInstitucional;
        this.telefonoCelular = telefonoCelular;
    }

    public void setUsuario(Usuario user){
        this.usuario = user;
    }
    private void inhabilitarUsuario(){
        usuario.Inhabilitar();
    }
    private void habilitarUsuario(){
        usuario.Habilitar();
    }
    private bool tengoUsuarioHabilitado(){
        if (usuario.getHabilitado()){
            return true;
        }
        return false;
    }
    public bool esTuUsuario(Usuario user){
        if (user.getUsuario() == usuario.getUsuario()) return true;
        return false;
    }

    public String getNombre() {
        return nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public String getEmail()
    {
        return correoElectronicoInstitucional;
    }

}
