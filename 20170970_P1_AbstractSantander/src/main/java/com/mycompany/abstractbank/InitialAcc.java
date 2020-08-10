package com.mycompany.abstractbank;

import javax.swing.JOptionPane;

public class InitialAcc extends AbstractClass {

    public InitialAcc(String Cliente, String CuentaTipo, double Saldo) {
        super(Cliente, CuentaTipo, Saldo);
    }

    //CUENTA INTERMEDIA 
    @Override
    public void Depo(double Deposito) {
        double Limite = 0;
        Limite = getSaldo() + Deposito;

        if (Limite > 20000 || Deposito > 4000) {
            JOptionPane.showMessageDialog(null, getCliente() + ", No se puede completar su Depósito");
        } else {
            setSaldo(Limite);
            setMovimiento();
        }
    }

    @Override
    public void Ret(double Retiro) {
        double ActualizaSaldo = 0;
        if (Retiro > 4000 || Retiro > getSaldo()) {
            JOptionPane.showMessageDialog(null, "No se puede completar su Retiro");
        } else {
            ActualizaSaldo = getSaldo() - Retiro;
            setSaldo(ActualizaSaldo);
            setMovimiento();
        }
    }

    @Override
    public void Consulta() {
        getSaldo();
    }

    @Override
    public void Corte() {
        double Corte = 0;
        double IVA = 0;
        IVA = 1.16;
        if (getMovimiento() > 4) {//Se calcula la comisión por cada movimiento extra mas IVA de 1.16 
            Corte = getSaldo() - (((getMovimiento() - 4) * 25) * IVA);
            setSaldo(Corte);
        } else {
            //Saldo sin comisiones
            getSaldo();
        }
    }

}
