using System;
using System.Collections.Generic;
using System.IO;

namespace Session07FilesExamples
{
    
    class Program
    {
        //Deklarerat separatorn
        const string _seperator = ";";

        static void Main(string[] args)
        {
            //Läsa in en fils textinnehåll
            //Filestream för att läsa filens innehåll som btes från början till slut
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                //Streamreader för att konvertera bytes till tecken
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Såhär kan man få ut all text på en gång
                    string fileContent = reader.ReadToEnd();
                }
            }

            //Går att skriva såhär istället
            string simpleReadFileContent = File.ReadAllText("maxfritid.csv");

            //Definiera en lista som vi kan lagra produktdatat i
            List<Product> products = new List<Product>();

            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    while(line != null)
                    {
                        //Logik för raden
                        string[] columns = line.Split(_seperator);

                        try
                        {

                            Product product = new Product
                            {
                                Id = ConvertToInt(columns[0]),
                                ProductNumber = columns[2],
                                ProductName = columns[3],
                                ProductBrand = ConvertToNullableInt(columns[4]),
                                ProductSupplier = columns[5],
                                ProductSynonyms = ConvertToArray(columns[6])
                            };

                            products.Add(product);
                            //Placera behandling av produkten efter inläsningen, i samma try-sats
                            //För att undvika behandling av ogiltig data
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        line = reader.ReadLine();
                    }
                }
            }

            PrintProducts(products);

        }

        static Product CreateProduct(string[] columns)
        {
            return new Product
            {
                Id = ConvertToInt(columns[0]),
                ProductNumber = columns[2],
                ProductName = columns[3],
                ProductBrand = ConvertToNullableInt(columns[4]),
                ProductSupplier = columns[5],
                ProductSynonyms = ConvertToArray(columns[6])
            };
        }

        static void PrintProducts(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}: {product.ProductName}");
            }
        }

        //Konvertera till int
        static int ConvertToInt(string input)
        {
            int.TryParse(input, out int result);

            return result;
        }

        //Konverterar till int?
        static int? ConvertToNullableInt(string input)
        {
            if(int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        //Konvertera till array
        static string[] ConvertToArray (string input)
        {
            if (input == null)
                return new string[0];

            return input.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
