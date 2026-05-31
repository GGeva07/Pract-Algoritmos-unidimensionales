

namespace AlgoritmosUnidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nAlgoritmos Unidimensionales");
                Console.WriteLine("1 Ventas Diarias");
                Console.WriteLine("2 Temperaturas");
                Console.WriteLine("3 Inversion de Arreglo");
                Console.WriteLine("4 Salir");
                Console.Write("Seleccione una ");

                string? opcion = Console.ReadLine();

                if (string.IsNullOrEmpty(opcion)) continue;

                switch (opcion)
                {
                    case "1":
                        VentasDiarias();
                        break;
                    case "2":
                        Temperaturas();
                        break;
                    case "3":
                        InversionArreglo();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void VentasDiarias()
        {
            double[] ventas = new double[7];
            double total = 0;
            double maxVenta = 0;
            int diaMax = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese la venta del día {i + 1}: ");
                while (!double.TryParse(Console.ReadLine() ?? "0", out ventas[i]))
                {
                    Console.Write("entrada invalida ingrese un numero correcto");
                }
                total += ventas[i];

                if (i == 0 || ventas[i] > maxVenta)
                {
                    maxVenta = ventas[i];
                    diaMax = i + 1;
                }
            }

            double promedio = total / 7;

            Console.WriteLine($"\nTotal vendido en la semana {total}");
            Console.WriteLine($"Promedio diario {promedio}");
            Console.WriteLine($"Dia con la venta maxima: Dia {diaMax} ({maxVenta})");
        }

        static void Temperaturas()
        {

        }

        static void InversionArreglo()
        {

        }
    }
}
