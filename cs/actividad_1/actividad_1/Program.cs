namespace actividad_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa");
        Console.WriteLine("Introduce el número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el número final: ");
        
        int fin = int.Parse(Console.ReadLine());

        for (int i = inicio; i >= fin; i--)
        {
            if (i < inicio)
            {
                Console.Write("-");
            }
            Console.Write(i);
        }
    }
}
