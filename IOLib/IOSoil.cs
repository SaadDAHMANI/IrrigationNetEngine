using System;
using System.IO;

namespace IOLib
{
public class IOSoil
{
        public string Name;
        public string FileSource;

        public string FileFormat;

        public string Content;

        public override string ToString()
        {
            return Content;
        }

        public static IOSoil Load(string filepath)
        {
            IOSoil soil= null;
             if(File.Exists(filepath)==false){throw new FileNotFoundException();}
             try
             {
                 soil=new IOSoil();
                 StreamReader strmReader = new StreamReader(filepath);
                 string content = strmReader.ReadToEnd();
                 soil.Content=content;
                 

             }   
             catch(Exception ex){throw ex;}   
            return soil;
        }
}

}