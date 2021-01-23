using System;

namespace ClassDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> OyuncularVeTuslari = new MyDictionary<string, int>();

            OyuncularVeTuslari.Add("Esma", 5);
            OyuncularVeTuslari.Add("Buket", 6);
            OyuncularVeTuslari.Add("Eda", 5);
            OyuncularVeTuslari.Add("Zeynep", 3);
            OyuncularVeTuslari.Add("Kaan", 4);

            OyuncularVeTuslari.Yazdir();
     
        }
    }

    
}
