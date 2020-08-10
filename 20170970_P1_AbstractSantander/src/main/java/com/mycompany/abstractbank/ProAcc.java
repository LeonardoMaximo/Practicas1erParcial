package com.mycompany.abstractbank;

import javax.swing.JOptionPane;

public class ProAcc extends AbstractClass {

    public ProAcc(String Cliente, String CuentaTipo, double Saldo) {
        super(Cliente, CuentaTipo, Saldo);
    }

    @Override
    public void Depo(double Deposito) {
        double Total = 0;
        Total = getSaldo() + Deposito;
        setSaldo(Total);
        setMovimiento();
        JOptionPane.showMessageDialog(null, getCliente() + ", Se completó su Deposito");
    }

    @Override
    public void Ret(double Retiro) {
        double ActualizaSaldo = 0;
        if (Retiro > getSaldo()) {
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
        IVA = .16;
        if (getSaldo() < 10000) {//Calcule el IVA de $250.. igual a 40 mas los 250 de comision.. igual a 294;
            Corte = getSaldo() - (250 * IVA);
            setSaldo(TotalCorte);
        } else {
            //Saldo sin comisiones
            getSaldo();
        }
    }

}
