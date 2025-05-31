using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class ProductManager
    {

        private FileManager fileManager = new FileManager();

        public void AddProduct(Product product)
        {
            //Aplicar validaciones


            if (string.IsNullOrEmpty(product.Name))
            {

                throw new ArgumentException("El nombre no puede estar vacío.");

            }

            if (product.Price <= 0)
            {

                throw new ArgumentException("El precio debe ser mayor a 0.");

            }

            if (product.Stock < 0)
            {

                throw new ArgumentException("El stock no puede ser menor a 0.");

            } 

            //Si pasa las validadciones enviamos a guardar en el txt

            var fm = new FileManager();
            fm.SaveProduct(product);

        }

        public List<Product> GetProducts()
        {

            var list = new List<Product>();
            return fileManager.ReadProcuts();

        }

    }
}
