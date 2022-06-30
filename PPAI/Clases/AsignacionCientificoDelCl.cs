using System;

using System.Collections.Generic;

public class AsignacionCientificoDelCl {
    private DateTime fechaDesde;
    private DateTime fechaHasta;
    private PersonalCientifico cientifico;
    private List<Turno> turnos;

    public AsignacionCientificoDelCl(DateTime fechaDesde,DateTime fechaHasta){
        this.fechaDesde = fechaDesde;
        this.fechaHasta = fechaHasta;
    }

    public void setCientifico(PersonalCientifico cientifico) {
        this.cientifico = cientifico;
    }

    public void setTurnos(List<Turno> turnos) {
        this.turnos = turnos;
    }

    public PersonalCientifico getCientifico() {
        return cientifico;
    }

    public List<Turno> getTurnos() {
        return turnos;
    }
}
