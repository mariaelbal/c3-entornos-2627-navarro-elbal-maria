class Program
{
    static void Main(string[] args)
    {
        double saldo = 500.0;
        string operacion = "retirar";
        double cantidad = 150.0;

        if (operacion == "ingresar")
        {
            if (cantidad > 0)
            {
                saldo = saldo + cantidad;
                Console.WriteLine("Operación realizada. Saldo actual: " + saldo);
            }
            else
            {
                Console.WriteLine("Error: la cantidad debe ser mayor que cero.");
            }
        }
        else if (operacion == "retirar")
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                Console.WriteLine("Operación realizada. Saldo actual: " + saldo);
            }
            else
            {
                Console.WriteLine("Error: saldo insuficiente o cantidad no válida.");
            }
        }
    }
}
