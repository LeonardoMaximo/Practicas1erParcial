package com.mycompany.abstractbank;

public abstract class AbstractClass {

    private String Cliente, CuentaTipo;
    private int Movimiento;
    private double Saldo;

    //Constructor de la clase, recibe parámetros de tipo de cuenta y Saldo
    public AbstractClass(String Cliente, String CuentaTipo, double Saldo) {
        this.Cliente = Cliente;
        this.CuentaTipo = CuentaTipo;
        this.Saldo = Saldo;
    }

    //Getters y Setters
    public String getCliente() {
        return Cliente;
    }

    public void setCliente(String Cliente) {
        this.Cliente = Cliente;
    }

    public String getCuentaTipo() {
        return CuentaTipo;
    }

    public void setCuentaTipo(String CuentaTipo) {
        this.CuentaTipo = CuentaTipo;
    }

    public int getMovimiento() {
        return Movimiento;
    }

    public void setMovimiento() {
        this.Movimiento += 1;
    }

    public double getSaldo() {
        return Saldo;
    }

    public void setSaldo(double Saldo) {
        this.Saldo = Saldo;
    }

    //MÉTODOS
    public abstract void Depo(double Deposito);

    public abstract void Ret(double Retiro);

    public abstract void Consulta();

    public abstract void Corte();
}
