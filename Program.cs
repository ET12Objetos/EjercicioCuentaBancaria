using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nro Cuenta: ");
            int nroCuenta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese nro Titular: ");
            int nroTitular = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Moneda Cuenta: ");
            string monedaCuenta = Console.ReadLine();

            CuentaBancaria miCuenta = new CuentaBancaria(nroCuenta, nroTitular, monedaCuenta);

            miCuenta.Informar();

            Console.Write("Ingrese Monto Dinero: ");
            double dinero = Convert.ToDouble(Console.ReadLine());

            miCuenta.DepositarUn(dinero);

            miCuenta.Informar();

            Console.Write("Ingrese Monto Dinero a Retirar: ");
            dinero = Convert.ToDouble(Console.ReadLine());

            miCuenta.RetirarUn(dinero);

            miCuenta.Informar();
        }
    }
}
