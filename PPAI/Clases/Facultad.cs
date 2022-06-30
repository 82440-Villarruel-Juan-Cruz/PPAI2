using System;
using System.Collections.Generic;

public class Facultad {
    private  String nombre;
    private String domicilio;
    private List<CentroDeInvestigacion> centrodeInvestigacion;

    public Facultad(String nombre,String domicilio, List<CentroDeInvestigacion> centrodeInvestigacion){
        this.nombre = nombre;
        this.domicilio = domicilio;
        this.centrodeInvestigacion = centrodeInvestigacion;
    }


}
