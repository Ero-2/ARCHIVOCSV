using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "datos.csv"; // Ruta del archivo CSV

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                Console.WriteLine("El archivo CSV no existe.");
                return;
            }

            // Lista para almacenar los datos del CSV
            List<string[]> csvData = new List<string[]>();

            // Leer y procesar el archivo CSV
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    csvData.Add(values);
                }
            }

            // Mostrar los datos del CSV en la consola
            Console.WriteLine("Datos del archivo CSV:");
            foreach (var row in csvData)
            {
                foreach (var col in row)
                {
                    Console.Write($"{col}\t");
                }
                Console.WriteLine();
            }
        }

    }

    
}