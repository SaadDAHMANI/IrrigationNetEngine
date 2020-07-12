using System;
using IOLib;
using INEngineLib;

namespace IrrigationNetConsole
{
    class Program
    {

        static void Main(string[] args)
        {
             string cropfile=string.Format(@"{0}\Data\crops\FAO\TOMATO.CRO", AppDomain.CurrentDomain.BaseDirectory);
             Console.WriteLine("The directory is :");
             Console.WriteLine(cropfile);         
             
             //crop data:
             IOCrop ioCrop= new IOCrop();
             ioCrop =IOCrop.Load(cropfile);

             Crop crp = Crop.ConvertFrom(ioCrop);
             Console.WriteLine("Crop = {0}.", crp.Name);   
             Console.WriteLine("Planting Date = {0}.", crp.PlantingDate);
             Console.WriteLine("Life = {0} days.",crp.LifeInDays);
             Console.WriteLine("Harvest Date = {0}.", crp.HarvestDate);

             //soil data:
             string soilFile =string.Format(@"{0}\Data\soils\FAO\LIGHT.SOI", AppDomain.CurrentDomain.BaseDirectory);
            
             IOSoil sol = IOSoil.Load(soilFile);
             Console.WriteLine(sol.TotalAvailableMoisture); 

             //string[] data=sol.Content.Split(' ');
             //foreach(string value in data)
             //{
               //  Console.WriteLine(value);
             //}
             

        }
    }
}