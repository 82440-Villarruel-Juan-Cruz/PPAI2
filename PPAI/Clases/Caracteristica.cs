using System;
public class Caracteristica {

    public String nombre;
    public String descripcion;


    public Caracteristica (String nombre,String descripcion){
        this.nombre = nombre;
        this.descripcion = descripcion;
    }
    public Caracteristica getCateristicas(){
        return new Caracteristica(this.nombre,this.descripcion);
    }


}
