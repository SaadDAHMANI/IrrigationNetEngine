using System;
using IOLib;
using INEngineLib;

namespace IrrigationNetConsole
{
    class Program
    {

        static void Main(string[] args)
        {
             string fileName=string.Format(@"{0}\Data\crops\FAO\TOMATO.CRO", AppDomain.CurrentDomain.BaseDirectory);
             Console.WriteLine("The directory is :");
             Console.WriteLine(fileName);         
              
             IOLib.FileReader reader  = new IOLib.FileReader(fileName);
             IOCrop crop=reader.Read();
             Console.WriteLine(crop.ToString());   

             //soil data:

             string soilFile =string.Format(@"{0}\Data\soils\FAO\LIGHT.SOI", AppDomain.CurrentDomain.BaseDirectory);
            
             IOSoil sol = IOSoil.Load(soilFile);
             Console.WriteLine (sol.ToString ()); 

             string[] data=sol.Content.Split(' ');
             foreach(string value in data)
             {
                 Console.WriteLine(value);
             }

        }
    }
}