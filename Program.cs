

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

        }

        static void Temperaturas()
        {

        }

        static void InversionArreglo()
        {

        }
    }
}
