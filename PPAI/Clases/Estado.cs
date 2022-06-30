using System;
public class Estado {
    private String nombre;
    private String descripcion;
    private String ambito;
    private bool esReservable;
    private bool esCancelable;

    public Estado (String Nombre,String Descripcion,String Ambito,bool EsReservable, bool EsCancelable){
        nombre = Nombre;
        descripcion = Descripcion;
        ambito = Ambito;
        esCancelable = EsCancelable;
        esReservable =EsReservable;

    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String mostrar(){
        return this.ambito;
    }

    public bool esAmbitoRT(){
        if(ambito == "RT" ) return true;
        return false;
    }

    public bool esDisponible(){
        if(nombre == "Disponible")return true;
        return false;
    }

    public bool esConfirmado(){
        if(nombre == "Confirmado")return true;
        return false;
    }

    public bool esPendienteDeConfirmacion(){
        if(nombre == "PendienteDeConfirmacion")return true;
        return false;
    }


}
