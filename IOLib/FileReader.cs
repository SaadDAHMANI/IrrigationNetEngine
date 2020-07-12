using System;
using System.IO;

namespace IOLib
{
      
    public class FileReader
    {
    public FileReader(string targetFile)
    {
    this.FilePath=targetFile;
    }
        private string mFilePath=string.Empty;
        public string FilePath
        {
            get{return mFilePath;}
            set {mFilePath=value;}
        }

public IOCrop Read()
{  
    IOCrop crop =null;
     if(FilePath== string.Empty){throw new Exception("Err in file path");}
     if (File.Exists(FilePath)==false ){throw new FileNotFoundException();}
     
     try
     {
     crop = new IOCrop();
     StreamReader strmReader= new StreamReader(FilePath);
     crop.FileSource = FilePath;
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
          crop=null;
          throw ex;
      }       
     return crop;
    }
}
}
