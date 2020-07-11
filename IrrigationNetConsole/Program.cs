using System;
using IOLib;

namespace IrrigationNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
             string fileName=string.Format(@"{0}\Data\crops\KURN-COTTON.CRO", AppDomain.CurrentDomain.BaseDirectory);
             Console.WriteLine("The directory is :");
             Console.WriteLine(fileName);
           

             IOLib.FileReader reader  = new IOLib.FileReader(fileName);
             IOCrop crop=reader.Read();

             Crop cr = new Crop();

             Console.WriteLine(crop.ToString());   
                     
        }
    }
}
