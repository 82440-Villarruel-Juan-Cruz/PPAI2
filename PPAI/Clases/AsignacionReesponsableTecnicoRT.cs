using System;

public class AsignacionReesponsableTecnicoRT {
    private DateTime fechaDesde;
    private DateTime fechaHasta;
    private RecursoTecnologico recursoTecnologico;
    private PersonalCientifico personalCientifico;

    public AsignacionReesponsableTecnicoRT(DateTime fechaDesde,DateTime fechaHasta){
        this.fechaDesde = fechaDesde;
        this.fechaHasta = fechaHasta;
    }

    public PersonalCientifico getPersonalCientifico() {
        return personalCientifico;
    }

    public RecursoTecnologico getRecursoTecnologico() {
        return recursoTecnologico;
    }

    public void setPersonalCientifico(PersonalCientifico personalCientifico) {
        this.personalCientifico = personalCientifico;
    }

    public void setRecursoTecnologico(RecursoTecnologico recursoTecnologico) {
        this.recursoTecnologico = recursoTecnologico;
    }

    
}
