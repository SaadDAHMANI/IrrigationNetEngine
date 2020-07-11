using IOLib;
namespace IrrigationNetConsole
{
    public class Crop
    {
        public string Name {get; set;}

        ///
        /// Initial stage development [in days].
        ///
        public double InitialStage ;
        public double DevelopmentStage;
        public double MidSeasonStage;
        public double LateSeasonStage;
    
    ///
    /// Get Crop object from IOCrop object. 
    ///
 public static Crop ConvertFrom(IOCrop ioCrp)
 {
     Crop newCrop = null;
     if (Equals(ioCrp, null)) {return null;}
     newCrop = new Crop();
     newCrop.Name =ioCrp.Name;
     newCrop.InitialStage =ioCrp.InitialStage;
     newCrop.DevelopmentStage =ioCrp.DevelopmentStage;
     newCrop.MidSeasonStage=ioCrp.MidSeasonStage;
     newCrop.LateSeasonStage=ioCrp.LateSeasonStage;
     return newCrop; 
 }

 

    
    }
}