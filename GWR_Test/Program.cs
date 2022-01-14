using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized; 

namespace GWR_Test
{
    class Shape
    {
        public int ShapeId { get; set; }
        public int NoOfSides { get; set; }
        public int SideLength { get; set; }

     
    
        static void Main(string[] args)
        {
            int AllShape = 0;
            while (AllShape < 25)
            {
                Console.WriteLine();
                AllShape++;
            }

            using (TextFieldParser parser = new TextFieldParser(@"c:\Users\myfek\Downloads\Shapes.csv"))
            {

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {
                        //TODO: Process field
                    }
                    Console.WriteLine(fields.Length);
                    string configvalue1 = ConfigurationManager.AppSettings["countOfShapes"];
                    Console.WriteLine("the value of Key0: " + configvalue1);
                    string configvalue2 = ConfigurationManager.AppSettings["logfilelocation"];
                    Console.WriteLine("The value of Key1: " + configvalue2);
                    
                }

                
            }
        }
    }
}
 
