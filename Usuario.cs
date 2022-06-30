using System;

public class Usuario
{
    private String clave;
    private String usuario;

    private boolean habilitado;
    private PersonalCientifico personalCientifico;

    public Usuario(String clave, String usuario, boolean habilitado)
    {
        this.clave = clave;
        this.habilitado = habilitado;
        this.usuario = usuario;
    }
    public void Habilitar()
    {
        habilitado = true;
    }
    public void Inhabilitar()
    {
        habilitado = false;
    }
    public void modificarPassword(String nuevaPassword)
    {
        clave = nuevaPassword;
    }

    public void setPersonalCientifica(PersonalCientifico pf)
    {
        this.personalCientifico = pf;

    }

    public PersonalCientifico getPersonalCientifico() { return personalCientifico; }

    public boolean getHabilitado()
    {
        return habilitado;
    }
    public String getUsuario() { return usuario; }



}
