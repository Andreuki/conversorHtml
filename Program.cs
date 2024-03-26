/*Crea un "convertidor básico de texto a HTML", 
 * que leerá un archivo de texto de origen y creará un archivo HTML a partir de su contenido
 */
using System;
using System.IO;
namespace ejercicio206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el nombre de fichero de entrada");
            string nombreEntrada = Console.ReadLine()+".txt";
            string nombreSalida = nombreEntrada.Replace(".txt", ".html");
            StreamReader ficheroEntrada = File.OpenText(nombreEntrada);
            StreamWriter ficheroSalida = File.CreateText(nombreSalida);
            ficheroSalida.WriteLine("<html>");
            ficheroSalida.WriteLine("<body>");
            string lineas;
            do
            {
                lineas = ficheroEntrada.ReadLine();
                if (lineas != null) {
                    ficheroSalida.WriteLine("<p>" + lineas + "</p>");
                }
            } while (lineas != null);
            ficheroEntrada.Close();
            ficheroSalida.WriteLine("</body>");
            ficheroSalida.WriteLine("</html>");
            ficheroSalida.Close();
            Console.WriteLine("Conversión terminada");
        }
    }
}
