package com.mycompany.abstractbank;

import javax.swing.JOptionPane;

public class InterAcc extends AbstractClass {

    public InterAcc(String Cliente, String CuentaTipo, double Saldo) {
        super(Cliente, CuentaTipo, Saldo);
    }

    //CUENTA INTERMEDIA 
    @Override
    public void Depo(double Deposito) {
        double Total = 0;
        Total = getSaldo() + Deposito;
        if (Deposito > 7000) {
            JOptionPane.showMessageDialog(null, getCliente() + ", No se puede completar su Depósito");
        } else {
            setSaldo(Total);
            setMovimiento();
        }
    }

    @Override
    public void Ret(double Retiro) {
        double ActualizaSaldo = 0;
        if (Retiro > 7000 || Retiro > getSaldo()) {
            JOptionPane.showMessageDialog(null, getCliente() + ", No se puede completar su Retiro");
        } else {
            ActualizaSaldo = getSaldo() - Retiro;
            setSaldo(ActualizaSaldo);
            setMovimiento();
        }
    }

    @Override
    public void Consulta() {
        JOptionPane.showMessageDialog(null, getCliente() + ", Su saldo es: " + getSaldo());
    }

    @Override
    public void Corte() {
        double TotalCorte = 0;
        TotalCorte = getSaldo();
        double Corte = 0;
        double IVA = 0;
        IVA = 1.16;
        if (getSaldo() < 3000) {//Calcule el IVA de $150.. igual a 24 mas los 150 de comision.. igual a 174;
            Corte = getSaldo() - (150 * IVA);
            setSaldo(TotalCorte);
        } else {
            //Saldo sin comisiones
            getSaldo();
        }
    }

}
