using System;

namespace Ejercicio1
{
    public class CuentaBancaria
    {
        public int nroCuenta { get; set; }

        public int nroTitular { get; set; }

        public string moneda { get; set; }

        public double saldo { get; set; }

        public CuentaBancaria(int nroCuenta, int nroTitular, string moneda)
        {
            this.nroCuenta = nroCuenta;
            this.nroTitular = nroTitular;
            this.moneda = moneda;
            this.saldo = 0;
        }

        public void Informar()
        {
            Console.WriteLine($"El saldo de la cuenta: {nroCuenta}, es: {saldo} {moneda}");
        }

        public void DepositarUn(double dinero)
        {
            if (dinero <= 0)
            {
                throw new Exception("Dinero incorrecto");
            }

            this.saldo = this.saldo + dinero;
        }

        public void RetirarUn(double dinero)
        {
            if (dinero <= 0)
            {
                throw new Exception("Dinero incorrecto");
            }

            if (dinero > this.saldo)
            {
                //Console.WriteLine("Saldo cuenta incorrecto");
                //Exception
                throw new Exception("Saldo cuenta incorrecto");
            }

            this.saldo = this.saldo - dinero;
        }
    }
}