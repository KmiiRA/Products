using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        //Metodo retorna una lista de productos tomada del archivo de texto.
        public List<Product> ReadProcuts()
        {
            private string filePath = "productos.txt";

        //Desarrollar por el estudiante.
        //Leer la lista de productos de un txt y cargarlo en una lista.

        public List<Product> ReadProcuts()
        {
            var products = new List<Product>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        var product = new Product();
                        product.Id = int.Parse(parts[0]);
                        product.Name = parts[1];
                        product.Price = float.Parse(parts[2]);
                        products.Add(product);
                    }
                }
            }
            return products;
        }


       
        }

        public void SaveProduct(Product product)
        {
            //Desarrollar por el estudiante.
            //Guardar el producto en un txt.

            var line = $"{product.Id},{product.Name},{product.Price}";
            File.AppendAllText(filePath, line + Environment.NewLine);

        }

    }
}
