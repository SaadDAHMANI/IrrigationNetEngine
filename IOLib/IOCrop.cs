using System;
namespace IOLib
{
    public class IOCrop
    {
        public string Name;
        public string FileSource;

        public string FileFormat;

        public double InitialStage;
        public double DevelopmentStage;
        public double MidSeasonStage;
        public double LateSeasonStage;
       
        public double Kc1;

         public double Kc2;

         public double Kc3;

         public double RoutingDepth1;

         public double RoutingDepth2;

         public double CriticalDepletion1;

         public double CriticalDepletion2;

         public double CriticalDepletion3;

         public double YieldResponse1;

         public double YieldResponse2;

         public double YieldResponse3;

         public double YieldResponse4;

         public double YieldResponse5;

         public double CropHeight;

        public override string ToString() 
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} ; Kcs = {7} {8} {9} ; RoutingDepths ={10} {11} ; CriticalDepletions = {12} {13} {14} ; YieldResponses= {15} {16} {17} {18} {19} ; CropHeight ={20}." , FileSource ,FileFormat, Name, InitialStage ,DevelopmentStage, MidSeasonStage, LateSeasonStage, Kc1, Kc2, Kc3, RoutingDepth1, RoutingDepth2, CriticalDepletion1, CriticalDepletion2, CriticalDepletion3, YieldResponse1, YieldResponse2, YieldResponse3, YieldResponse4 , YieldResponse5, CropHeight);
        }
    }
}