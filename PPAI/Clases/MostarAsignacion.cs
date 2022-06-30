using System;

public class MostarAsignacion {
    private PersonalCientifico pf;
    private Turno tr;

    public MostarAsignacion(PersonalCientifico pf, Turno tr) {
        this.pf = pf;
        this.tr = tr;
    }

    public PersonalCientifico getPf() {
        return pf;
    }

    public void setPf(PersonalCientifico pf) {
        this.pf = pf;
    }

    public Turno getTr() {
        return tr;
    }

    public void setTr(Turno tr) {
        this.tr = tr;
    }


    /*
    private final ObjectProperty<PersonalCientifico> pf = new SimpleObjectProperty<>();
    private final ObjectProperty<Turno> tr = new SimpleObjectProperty<>();


    public MostarAsignacion(PersonalCientifico pf, Turno tr) {
        this.pf.set(pf);
        this.tr.set(tr);
    }

    public PersonalCientifico getPf() {
        return pf.get();
    }

    public void setPf(PersonalCientifico pf) {
        this.pf.set(pf);
    }

    public Turno getTr() {
        return tr.get();
    }

    public void setTr(Turno tr) {
        this.tr.set(tr);
    }

    public ObjectProperty<PersonalCientifico> pfProperty() {
        return pf;
    }

    public ObjectProperty<Turno> trProperty() {
        return tr;
    }*/
}
