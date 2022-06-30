using System;
using System.Collections.Generic;

public class Marca {
    private String nombre;
    private List<Modelo> listaDeModelos;

    public Marca(String nombre, List<Modelo> listaDeModelos){
        this.nombre = nombre;
        this.listaDeModelos = listaDeModelos;
    }

    public String getNombre() {
        return nombre;
    }
}

