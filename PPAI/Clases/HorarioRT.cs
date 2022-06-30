using System;

public class HorarioRT {

    private DayOfWeek diaSemana;
    private DateTime horaDesde;
    private DateTime horaHasta;
    private DateTime vigenciaDesde;
    private DateTime vigenciaHasta;

    public HorarioRT(DayOfWeek diaSemana, DateTime horaDesde, DateTime horaHasta,DateTime vigenciaDesde,DateTime vigenciaHasta){
        this.diaSemana = diaSemana;
        this.horaDesde = horaDesde;
        this.horaHasta = horaHasta;
        this.vigenciaDesde = vigenciaDesde;
        this.vigenciaHasta = vigenciaHasta;
    }


}
