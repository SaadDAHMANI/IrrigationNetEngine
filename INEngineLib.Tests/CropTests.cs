using System;
using Xunit;

using INEngineLib;

namespace INEngineLib.Tests
{
    public class CropTests
    {

        //
        //Crop under test.
        //  
         readonly Crop Crop_uts;        
         
         //constructur:
         public CropTests()
         {
             Crop_uts= new Crop();             
         }

         [Fact]
         public void InitialStageWhenNegativeInput()
         {
             Crop_uts.InitialStage=-10;
             Assert.Equal(0, Crop_uts.InitialStage);             
         }

          [Fact]  
         public void DevelopmentStageWhenNegativeInput()
         {
             Crop_uts.DevelopmentStage =-256;             
             Assert.Equal(0,Crop_uts.DevelopmentStage);
         }

         [Fact]
         public void MidSeasonStageWhenNegativeInput()
         {
             Crop_uts.MidSeasonStage=-150; 
             Assert.Equal(0,Crop_uts.MidSeasonStage);
         }

         [Fact]
         public void LateSeasonStageWhenNegativeInput()
         {
             Crop_uts.LateSeasonStage=-31;
             Assert.Equal(0,Crop_uts.LateSeasonStage);   
         }

         [Fact]
         public void RoutingDepth1WhenNegativeInput()
         {
             Crop_uts.RoutingDepth1=-57;
             Assert.Equal(0,Crop_uts.RoutingDepth1);
         }

         [Fact]
         public void RoutingDepth2WhenNegativeInput()
         {
             Crop_uts.RoutingDepth2=-57;
             Assert.Equal(0,Crop_uts.RoutingDepth2);
         }

         [Fact]
         public void CriticalDepletion1WhenNegativeInput()
         {
             Crop_uts.CriticalDepletion1=-11;
             Assert.Equal(0, Crop_uts.CriticalDepletion1);
         }

         [Fact]
         public void CriticalDepletion2WhenNegativeInput()
         {
             Crop_uts.CriticalDepletion2=-15;
             Assert.Equal(0, Crop_uts.CriticalDepletion2);
         }

         [Fact]
         public void CriticalDepletion3WhenNegativeInput()
         {
             Crop_uts.CriticalDepletion3=-121;
             Assert.Equal(0, Crop_uts.CriticalDepletion3);
         }

         [Fact]
         public void YieldResponse1WhenNegativeInput()
         {
             Crop_uts.YieldResponse1=-12;
             Assert.Equal(0, Crop_uts.YieldResponse1);
         }

         [Fact]
         public void YieldResponse2WhenNegativeInput()
         {
             Crop_uts.YieldResponse2=-122;
             Assert.Equal(0, Crop_uts.YieldResponse2);
         }

         [Fact]
         public void YieldResponse3WhenNegativeInput()
         {
             Crop_uts.YieldResponse3=-312;
             Assert.Equal(0, Crop_uts.YieldResponse3);
         }

          [Fact]
         public void YieldResponse4WhenNegativeInput()
         {
             Crop_uts.YieldResponse4=-142;
             Assert.Equal(0, Crop_uts.YieldResponse4);
         }

          [Fact]
         public void YieldResponse5WhenNegativeInput()
         {
             Crop_uts.YieldResponse5=-125;
             Assert.Equal(0, Crop_uts.YieldResponse5);
         }

        [Fact]
        public void HarvestDateWhenCropLifIs10Days()
        {
            Crop_uts.PlantingDate=Convert.ToDateTime("#07/15/2020#").AddDays(10);
            DateTime predictedHarvestDate = Convert.ToDateTime("#07/25/2020#");
            Assert.Equal(predictedHarvestDate, Crop_uts.HarvestDate);
        }
        [Fact] 
        public void HarvestDateWhenCropLifIs160Days()
        {
             Crop_uts.PlantingDate=Convert.ToDateTime("#07/15/2020#");
             Crop_uts.InitialStage =40;
             Crop_uts.DevelopmentStage =40;
             Crop_uts.MidSeasonStage=40 ;
             Crop_uts.LateSeasonStage=40;
            DateTime predictedHarvestDate = Convert.ToDateTime("#12/22/2020#");
            Assert.Equal(predictedHarvestDate, Crop_uts.HarvestDate);
        }
        [Fact]
          public void HarvestDateWhenCropLifeSatgesContainsNegativeValues()
        {
             Crop_uts.PlantingDate=Convert.ToDateTime("#07/15/2020#");
             Crop_uts.InitialStage =-10;
             Crop_uts.DevelopmentStage =16;
             Crop_uts.MidSeasonStage=32 ;
             Crop_uts.LateSeasonStage=-40;
            DateTime predictedHarvestDate = Convert.ToDateTime("#09/01/2020#");
            Assert.Equal(predictedHarvestDate, Crop_uts.HarvestDate);
        }

        [Fact]
        public void Kc1WhenNegativeInput()
        {
            Crop_uts.Kc1=-25;
            Assert.Equal(0,Crop_uts.Kc1);
        }

        [Fact]
        public void Kc2WhenNegativeInput()
        {
            Crop_uts.Kc2=-5;
            Assert.Equal(0,Crop_uts.Kc2);
        }

        [Fact]
        public void Kc3WhenNegativeInput()
        {
            Crop_uts.Kc2=-2;
            Assert.Equal(0,Crop_uts.Kc3);
        }
        

    }
}
