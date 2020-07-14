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
