using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int opc = 0;
        while(opc != 4)
        {
            Console.Clear();
            Console.WriteLine("MENU SERIE FIBONACCI");
            Console.WriteLine("1. Encuentre el n-esimo numero de la serie.");
            Console.WriteLine("2. Es tu numero parte de la serie?.");
            Console.WriteLine("3. Muestra los primeros m numeros de la serie.");
            Console.WriteLine("4. Salir.");
            opc = Int32.Parse(Console.ReadLine());
        switch (opc)
        {
            case 1:
                punto1();
                Console.ReadKey();
                break;
            case 2:
                punto2();
                Console.ReadKey();
                break;
            case 3:
                punto3();
                Console.ReadKey();
                break;
            case 4:
                Console.WriteLine("Hasta Luego");
                break;
            default:
                Console.WriteLine("Invalido");
                break;
        }}
        
    }

    public static void punto1()
    {
        Console.Write("Ingrese n: ");
        int n = Int32.Parse(Console.ReadLine());
        int f0 = 0;
        int f1 = 1;
        int fk = 0;
        for (int i = 1; i <= n; i++)
        {
            fk = f1 + f0;
            f1 = f0;
            f0 = fk;
        }
        Console.WriteLine($"F{n} = {fk}");
    }
    public static void punto2()
    {
        Console.Write("Ingrese el numero: ");
        int n = Int32.Parse(Console.ReadLine());
        int f0 = 0;
        int f1 = 1;
        int fk = 0;
        for (int i = 1; i <= n; i++)
        {
            fk = f1 + f0;
            f1 = f0;
            f0 = fk;
            if (fk == n)
            {
                Console.WriteLine($"{n} es numero de Fibonacci");
                return;
            }
        }
        Console.WriteLine($"{n} no es numero de Fibonacci");
    }
    public static void punto3()
    {
        Console.Write("Ingrese m: ");
        int m = Int32.Parse(Console.ReadLine());
        int f0 = 0;
        int f1 = 1;
        int fk = 0;
        for (int i = 1; i <= m; i++)
        {
            Console.Write($"{fk} ");
            fk = f1 + f0;
            f1 = f0;
            f0 = fk;
        }
    }
}