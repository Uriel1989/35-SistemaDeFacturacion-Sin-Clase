using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _35_SistemaDeFacturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Sistema de Facturacion.");

            Console.WriteLine("Ingrese un numero para iniciar el ingreso de datos o ingrese 0 para concluir la carga:");
            int NumeroIngresado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor ingrese los datos de Cliente: ");

            Console.WriteLine("Ingrese el nombre de la razon social:");

            string RazonSocial = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el CUIT del cliente en cuestion: ");
            int CUIT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del responsable de compras:");
            string ResponsableDeCompras = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese numero dia, numero de mes y año de la fecha de entrega: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            int mes = Convert.ToInt32(Console.ReadLine());
            int año = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nombre del vendedor: ");
            string NombreDeVendedor = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ahora por favor ingrese los siguientes datos para la factura: ");

            Console.WriteLine("Ingrese el codigo del producto:");
            int Codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto en cuestion: ");
            int Cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio unitario: ");
            double PrecioUnitario = Convert.ToDouble(Console.ReadLine());

            
                    double Subtotal = PrecioUnitario * Cantidad;
                    double GranTotal = Subtotal * 1.21;

                    Console.WriteLine("Datos de facturacion:");
                    Console.WriteLine("Razon social: " + RazonSocial + Environment.NewLine + "CUIT: " + CUIT + Environment.NewLine + "Responsable de compras: " 
                        + ResponsableDeCompras + "Fecha de compra: " + dia + " " + mes + " " + año + " " + Environment.NewLine + 
                        "Nombre del venderdor: " + NombreDeVendedor + "Condigo de Compra: " + Codigo + Environment.NewLine + "Subtotal: " 
                        + Subtotal + Environment.NewLine + "Gran Total: " + GranTotal);
              




            Console.ReadKey();
        }
    }
}
