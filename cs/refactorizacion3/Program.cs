class Program
{
    static void Main(string[] args)
    {
        double saldo = 500.0;
        string operacion = "retirar";
        double cantidad = 150.0;

        if (operacion == "ingresar")
        {
            saldo = IngresarDinero(saldo, cantidad);
        }
        else if (operacion == "retirar")
        {
            saldo = RetirarDinero(saldo, cantidad);
        }

        double IngresarDinero(double saldoActual, double cantidadIngresar)
        {
            if (cantidadIngresar > 0)
            {
                saldoActual += cantidadIngresar;
                MostrarSaldo(saldoActual);
            }
            else
            {
                Console.WriteLine("Error: la cantidad debe ser mayor que cero.");
            }
            return saldoActual;
        }

        double RetirarDinero(double saldoActual, double cantidadRetirar)
        {
            if (cantidadRetirar > 0 && cantidadRetirar <= saldoActual)
            {
                saldoActual -= cantidadRetirar;
                MostrarSaldo(saldoActual);
            }
            else
            {
                Console.WriteLine("Error: saldo insuficiente o cantidad no válida.");
            }
            return saldoActual;
        }

        void MostrarSaldo(double saldoActual)
        {
            Console.WriteLine("Operación realizada. Saldo actual: " + saldoActual);
        }
    }
}