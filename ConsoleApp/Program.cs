public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Digite la opción deseada: ");
        Console.WriteLine("1. Agregar un producto.");
        Console.WriteLine("2. Consultar listado de productos.");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Digite la información del producto: ");
                break;

            case 2:
                Console.WriteLine("Listado de productos existentes: ");
                break;

            case 9:
                Console.WriteLine("Saliendo...");
                break;

            default:
                Console.WriteLine("Opción incorrecta.");
                break;
        }
    }
}