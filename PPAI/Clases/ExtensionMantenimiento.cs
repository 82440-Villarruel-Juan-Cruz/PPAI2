using System;

public class ExtensionMantenimiento {
    private DateTime fechaHoraFinPrevista;
    private DateTime fechaHoraFin;
    private String motivoMantenimiento;

    public ExtensionMantenimiento (DateTime fechaHoraFinPrevista,DateTime fechaHoraInicio,DateTime fechaHoraFin,String motivoMantenimiento){
        this.motivoMantenimiento = motivoMantenimiento;
        this.fechaHoraFinPrevista = fechaHoraFinPrevista;
        this.fechaHoraFin = fechaHoraFin;

    }

    public String getMotivoMantenimiento() {
        return motivoMantenimiento;
    }
}

