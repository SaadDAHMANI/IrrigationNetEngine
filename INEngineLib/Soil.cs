using System;
using IOLib;

namespace INEngineLib
{
    public class Soil
    {
                public string Name {get; set;}=string.Empty;
        public string FileSource{get; set;}=string.Empty;

        public string FileFormat{get; set;}=string.Empty;
        
        ///
        ///In (mm/meter) unit.
        ///
        public double TotalAvailableMoisture{get; set;}=0;

        ///
        ///In (mm/day) unit.
        ///
        public double MaximumRainInfiltrationRate {get; set;}=0;

        ///
        ///In (cm) unit.
        ///
        public double MaximumRootingDepth{get; set;}=0;

        ///
        ///In (%) unit.
        ///
        public double InitialMoistureDepletion{get; set;}=0;

        ///
        ///In (mm/meter) unit.
        ///
        public double InitialAvailableMoisture {get; set;}=0;

        public override string ToString()
        {
            return Name;
        }

        public static Soil ConvertFrom(IOSoil ioSoil)
        {
            
            if (object.Equals(ioSoil,null)){return null;}
            Soil sol = new Soil();
            try
            {
                    
             sol.FileFormat=ioSoil.FileFormat;
             sol.FileSource=ioSoil.FileSource;
             sol.Name=ioSoil.Name;
             sol.TotalAvailableMoisture=ioSoil.TotalAvailableMoisture;
             sol.MaximumRainInfiltrationRate=ioSoil.MaximumRainInfiltrationRate;
             sol.MaximumRootingDepth=ioSoil.MaximumRootingDepth;
             sol.InitialMoistureDepletion=ioSoil.InitialMoistureDepletion;
             sol.InitialAvailableMoisture=ioSoil.TotalAvailableMoisture;
            }
            catch (Exception ex)
            {//sol=null; 
            throw ex;}
            return sol;
        }

 
     
    }
}
