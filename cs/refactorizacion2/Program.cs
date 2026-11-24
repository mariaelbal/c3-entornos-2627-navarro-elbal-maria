class Program
{
    static void Main(string[] args)
    {
        double[] notasEv1 = { 6.5, 4.0, 8.0, 7.5 };
        double[] notasEv2 = { 3.0, 5.0, 4.5, 4.0 };

        // Cálculo Evaluación 1
        double suma1 = 0;
        for (int i = 0; i < notasEv1.Length; i++)
        {
            suma1 += notasEv1[i];
        }
        double media1 = suma1 / notasEv1.Length;
        Console.WriteLine("Media Ev1: " + media1);
        if (media1 >= 5) Console.WriteLine("Aprobada");
        else Console.WriteLine("Suspensa");

        // Cálculo Evaluación 2
        double suma2 = 0;
        for (int i = 0; i < notasEv2.Length; i++)
        {
            suma2 += notasEv2[i];
        }
        double media2 = suma2 / notasEv2.Length;
        Console.WriteLine("Media Ev2: " + media2);
        if (media2 >= 5) Console.WriteLine("Aprobada");
        else Console.WriteLine("Suspensa");
    }
}