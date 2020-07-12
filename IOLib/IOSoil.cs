using System;
using System.IO;

namespace IOLib
{
public class IOSoil
{
        public string Name {get; set;}=string.Empty;
        public string FileSource{get; set;}=string.Empty;

        public string FileFormat{get; set;}=string.Empty;
        
        ///
        ///In (mm/meter) unit.
        ///
        public double TotalAvailableMoisture;

        ///
        ///In (mm/day) unit.
        ///
        public double MaximumRainInfiltrationRate;

        ///
        ///In (cm) unit.
        ///
        public double MaximumRootingDepth;

        ///
        ///In (%) unit.
        ///
        public double InitialMoistureDepletion;

        
        public override string ToString()
        {
            return Name;
        }

        public static IOSoil Load(string filePath)
        {
             IOSoil soil = null;
             //check:
             if(filePath== string.Empty){throw new Exception();}
             if (File.Exists(filePath)==false ){throw new FileNotFoundException();}

             //call appropriate loading function:     
             string fileExtension= Path.GetExtension(filePath);
             if (fileExtension==".SOI")
             {
               soil=LoadFromCropwatFile(filePath);
             }
            return soil;
        }

        private static IOSoil LoadFromCropwatFile(string filepath)
        {
            IOSoil soil= null;
             try
             {
                 soil=new IOSoil();
                 soil.FileSource=filepath;

                 StreamReader strmReader = new StreamReader(filepath);
                 soil.FileFormat=strmReader.ReadLine().Trim();
                 soil.Name= strmReader.ReadLine().Trim();

                 //loading data:
                 string line3= strmReader.ReadLine();
                 string line4=strmReader.ReadLine();
                 string line5=strmReader.ReadLine();             
                 string line6= strmReader.ReadLine();
                 //string line7=strmReader.ReadLine();
                 //string line8=strmReader.ReadLine(); 
                 //string line9= strmReader.ReadLine();
                 //string line10=strmReader.ReadLine();
                 strmReader.Close();

                 soil.TotalAvailableMoisture=Convert.ToDouble(line3.Trim());
                 soil.MaximumRainInfiltrationRate=Convert.ToDouble(line4.Trim());
                 soil.MaximumRootingDepth =Convert.ToDouble(line5.Trim());
                 soil.InitialMoistureDepletion =Convert.ToDouble(line6.Trim());
                 
             }   
             catch(Exception ex)
             {   
                 soil=null;
                 throw ex;
             }   
            return soil;
        }
}

}