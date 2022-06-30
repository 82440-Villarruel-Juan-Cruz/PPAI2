using System;
public class Mantenimiento {

    private DateTime fechaHoraInicioPrevista;
    private DateTime fechaHoraInicio;
    private DateTime fechaHoraFin;
    private String motivoMantenimiento;

    public Mantenimiento (DateTime fechaHoraInicioPrevista,DateTime fechaHoraInicio,DateTime fechaHoraFin,String motivoMantenimiento){
        this.motivoMantenimiento = motivoMantenimiento;
        this.fechaHoraInicioPrevista = fechaHoraInicioPrevista;
        this.fechaHoraFin = fechaHoraFin;
        this.fechaHoraInicio = fechaHoraInicio;
    }
    public Mantenimiento (){
        motivoMantenimiento = "";
        fechaHoraInicio = DateTime.MinValue;
        fechaHoraFin= DateTime.MinValue;
        fechaHoraInicioPrevista = DateTime.MinValue;

    }

    public void Inicialiar(DateTime fechaHoraFin){
        this.fechaHoraFin = fechaHoraFin;
    }


}
