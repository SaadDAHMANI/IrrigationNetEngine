using System;
using System.IO;
namespace IOLib
{
    public class IOCrop
    {
        public string Name {get; set;}=string.Empty;
        public string FileSource{get; set;}=string.Empty;

        public string FileFormat{get; set;}=string.Empty;
        
        //
        //In (days) unit.
        //
        public double InitialStage;

        //
        //In (days) unit.
        //
        public double DevelopmentStage;
        
        //
        //In (days) unit.
        //
        public double MidSeasonStage;
        
        //
        //In (days) unit.
        //
        public double LateSeasonStage;
       
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

        public override string ToString() 
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} ; Kcs = {7} {8} {9} ; RoutingDepths ={10} {11} ; CriticalDepletions = {12} {13} {14} ; YieldResponses= {15} {16} {17} {18} {19} ; CropHeight ={20}." , FileSource ,FileFormat, Name, InitialStage ,DevelopmentStage, MidSeasonStage, LateSeasonStage, Kc1, Kc2, Kc3, RoutingDepth1, RoutingDepth2, CriticalDepletion1, CriticalDepletion2, CriticalDepletion3, YieldResponse1, YieldResponse2, YieldResponse3, YieldResponse4 , YieldResponse5, CropHeight);
        }

public static IOCrop Load(string filePath)
{
    IOCrop crop =null;
    //check:
    if(filePath== string.Empty){throw new Exception();}
    if (File.Exists(filePath)==false ){throw new FileNotFoundException();}

     //call appropriate loading function:     
    string fileExtension= Path.GetExtension(filePath);
    if (fileExtension==".CRO")
    {
        crop=LoadFromCropwatFile(filePath);
    }
    return crop; 
}
private static IOCrop LoadFromCropwatFile(string filePath)
{  
    IOCrop crop = new IOCrop();  
    try
     {
     
     crop.FileSource = filePath;

     StreamReader strmReader= new StreamReader(filePath);
     crop.FileFormat = strmReader.ReadLine().Trim();

     crop.Name= strmReader.ReadLine().Trim();
     string line3 = strmReader.ReadLine().Trim(); 
     string line4 = strmReader.ReadLine().Trim();
     string line5 = strmReader.ReadLine().Trim();
     string line6 = strmReader.ReadLine().Trim();
     string line7 = strmReader.ReadLine().Trim();
     string line8 = strmReader.ReadLine().Trim();

     strmReader.Close();     
     
     //Load Development satges in days from the file:
     string[] data= line3.Split(' '); 
     crop.InitialStage= Convert.ToDouble(data[0]);
     crop. DevelopmentStage= Convert.ToDouble(data[1]);
     crop.MidSeasonStage= Convert.ToDouble(data[2]);
     crop.LateSeasonStage = Convert.ToDouble(data[3]);

     //Load Kc values:
     data= line4.Split(' ');
     crop.Kc1=Convert.ToDouble(data[0]);
     crop.Kc2=Convert.ToDouble(data[2]);
     crop.Kc3=Convert.ToDouble(data[4]);

     //Load rooting depths:
     data= line5.Split(' ');
     crop.RoutingDepth1= Convert.ToDouble(data[0]);
     crop.RoutingDepth2= Convert.ToDouble(data[2]);

     //Load critical fractions:
     data= line6.Split(' ');
     crop.CriticalDepletion1= Convert.ToDouble(data[0]);
     crop.CriticalDepletion2= Convert.ToDouble(data[2]);
     crop.CriticalDepletion3= Convert.ToDouble(data[4]);

     //Load yield responses:
     data= line7.Split(' ');
     crop.YieldResponse1= Convert.ToDouble(data[0]);
     crop.YieldResponse2= Convert.ToDouble(data[2]);
     crop.YieldResponse3= Convert.ToDouble(data[4]);
     crop.YieldResponse4= Convert.ToDouble(data[6]);
     crop.YieldResponse5= Convert.ToDouble(data[8]);

     //Load crop height:
     crop.CropHeight= Convert.ToDouble(line8);

     }
     catch(Exception ex)
      {
          //crop=null;
          throw ex;
      }       
     return crop;
    }

    }
}