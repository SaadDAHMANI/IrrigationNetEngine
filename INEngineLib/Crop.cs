using System;
using IOLib;

namespace INEngineLib
{
    public class Crop
    {
        //
        //Crop name.
        //
        public string Name {get; set;}=string.Empty;

        //
        //Data storage file.
        //
        public string FileSource{get; set;}=string.Empty;

        //
        //Storage file format.
        //
        public string FileFormat{get; set;}=string.Empty;

        //
        //Planting date (date).
        //
        public DateTime PlantingDate {get; set;}=DateTime.Now;

        //
        //Harvest date (date).
        //
         public DateTime HarvestDate
         {
             get{return PlantingDate.AddDays(LifeInDays); }
         }

         //
        // Crop life duration in (days).
        //   
         public double LifeInDays
         {
             get {return (InitialStage+DevelopmentStage+MidSeasonStage+LateSeasonStage);}
         }   

        private double _InitialStage=0;
        //
        //In (days) unit.
        //
        public double InitialStage
        {
            get{return _InitialStage;}
            set {_InitialStage=Math.Max(value,0);}
        }

        private double _DevelopmentStage;
        //
        //In (days) unit.
        //
        public double DevelopmentStage
        {
            get {return _DevelopmentStage;}
            set {_DevelopmentStage =Math.Max(value,0);}
        }
        
        private double _MidSeasonStage;
        //
        //In (days) unit.
        //
        public double MidSeasonStage
        {
            get{return _MidSeasonStage;}
            set{_MidSeasonStage =Math.Max(value,0);}
        }
        
        private double _LateSeasonStage;
        //
        //In (days) unit.
        //
        public double LateSeasonStage
        {
            get{ return _LateSeasonStage;}
            set {_LateSeasonStage=Math.Max(value,0);}
        }
       
        public double Kc1;

         public double Kc2;

         public double Kc3;

        //
        //In (meter) unit.
        //
         public double RoutingDepth1;

        //
        //In (meter) unit.
        //   
         public double RoutingDepth2;

         public double CriticalDepletion1;

         public double CriticalDepletion2;

         public double CriticalDepletion3;

         public double YieldResponse1;

         public double YieldResponse2;

         public double YieldResponse3;

         public double YieldResponse4;

         public double YieldResponse5;
         
        //
        //In (meter) unit.
        //
         public double CropHeight;

    
    ///
    /// Get Crop object from IOCrop object. 
    ///
 public static Crop ConvertFrom(IOCrop ioCrp)
 {       
     if (Equals(ioCrp, null)) {return null;}
     Crop newCrop = new Crop();
     
     try
     {    
     
     newCrop.Name =ioCrp.Name;
     newCrop.FileSource=ioCrp.FileSource;
     newCrop.FileFormat=ioCrp.FileFormat;

     newCrop.InitialStage =ioCrp.InitialStage;
     newCrop.DevelopmentStage =ioCrp.DevelopmentStage;
     newCrop.MidSeasonStage=ioCrp.MidSeasonStage;
     newCrop.LateSeasonStage=ioCrp.LateSeasonStage;

     newCrop.Kc1=ioCrp.Kc1;
     newCrop.Kc2=ioCrp.Kc2;
     newCrop.Kc3=ioCrp.Kc3;

     newCrop.RoutingDepth1= ioCrp.RoutingDepth1;
     newCrop.RoutingDepth2=ioCrp.RoutingDepth2;

     newCrop.CriticalDepletion1=ioCrp.CriticalDepletion1;
     newCrop.CriticalDepletion2=ioCrp.CriticalDepletion2;
     newCrop.CriticalDepletion3=ioCrp.CriticalDepletion3;

     newCrop.YieldResponse1=ioCrp.YieldResponse1;
     newCrop.YieldResponse2=ioCrp.YieldResponse2;
     newCrop.YieldResponse3=ioCrp.YieldResponse3;  
     newCrop.YieldResponse4=ioCrp.YieldResponse4;
     newCrop.YieldResponse5=ioCrp.YieldResponse5;

     newCrop.CropHeight=ioCrp.CropHeight;
     }
     catch(Exception ex) 
     { //newCrop= null; 
     throw ex;}
     return newCrop; 
 }

 

    
    }
}