using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String data = new String('a', 5);
            //string name = "Берик";

            //char letter = name[2];
            //var result = name.Reverse();
            //foreach(var character in result)
            //{
            //    Console.Write(character);
            //}
            //Console.WriteLine();

            //string sentence = "Это пшеница, которая в темнемч улане хранится";
            //string[] splitedText = sentence.Split(' ');
            //Console.WriteLine(splitedText.Length);

            //name = name + "Великий";
            //name=name.Substring(3);
            //name.ToUpper();
            //var name = "Антон";
            //var address = "Астана, Сейфуллина 33б кв.15";
            //var iin = "123456789111";
            //var text = "Здравствуйте, " + name + " проживающий по адресу " +
            //    address + " с ИИН " + iin;

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Здравствуйте, ");
            //stringBuilder.Append(name);
            //stringBuilder.Append(" проживающий по адресу ");
            //stringBuilder.Append(address);
            //stringBuilder.Append(" с ИИН ");
            //stringBuilder.Append(iin);

            //var bigText = String.Format("Здравствуйте, {0} проживающий по адресу {1} с ИИН {2}.",name,address,iin);

            //var anotherText = $"Здравствуйте, {name} проживающий по адресу {address} с ИИН {iin}.";
            //var path= @"C:\Program Files\Cisco Packet Tracer 7.1.1\bin\audio"

            //Console.WriteLine(text);
            //Console.WriteLine(stringBuilder.ToString());
            int[] a = new int[5];

            double[,] b = new double[3, 4];
            //for (int i = 0; i <a.Length ; i++)
            //{

            //     a[i] = int.Parse(Console.ReadLine());
                
                
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            Random random = new Random(10);
            double temp;

            for (int i=0;i<=b.GetUpperBound(0);i++)
            {
                for (int j=0;j<=b.GetUpperBound(1);j++)
                {
                    //Random random = new Random(30);
                    b[i, j] = random.Next(10) + random.NextDouble();

                }
            }
            for (int i = 0; i <= b.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= b.GetUpperBound(1); j++)
                {
                    Console.Write(b[i,j]+" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
            


        
            
           


        }
    }
}
