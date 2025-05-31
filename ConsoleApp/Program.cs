using BusinessLogic;
using DataPersistence;
using Entities;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        

        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Digite la opción deseada: ");
        Console.WriteLine("1. Agregar un producto.");
        Console.WriteLine("2. Consultar listado de productos.");
        Console.WriteLine("0. Salir.");

        var option = Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:

                Console.WriteLine("Digite la información del producto: ");

                Console.Write("Digite el Id: ");
                var id=Int32.Parse(Console.ReadLine());

                Console.Write("Digite el nombre: ");
                var name=Console.ReadLine();

                Console.Write("Digite el precio: ");
                var price = double.Parse(Console.ReadLine());

                Console.Write("Digite el stock: ");
                var stock = Int32.Parse(Console.ReadLine());

                var myProduct=new Product() { Id=id, Name=name, Price=price, Stock=stock };

                var pm = new ProductManager();

                try
                {
                    pm.AddProduct(myProduct);
                }
                catch(Exception ex)
                {  
                    Console.WriteLine(ex.Message);
                }

                break;

            case 2:

                Console.WriteLine("Listado de los productos existentes: ");

                break;

            case 0:
                    Console.WriteLine("Saliendo...");
                    break;

            default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
         }
          
    }
}