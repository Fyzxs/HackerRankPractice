using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteMeForHackerRank
{
    [TestClass]
    public class Stairs
    {
        [TestMethod]
        public void ShouldWriteSinglePoundGivenOne()
        {
            //arrange

            //act
            string result = Step(1);
            
            //assert
            result.Should().Be("#");
        }

        [TestMethod]
        public void ShouldWriteTwoStepPoundGiven2()
        {
            //arrange

            //act
            string result = Step(2);

            //assert
            result.Should().Be(" #\r\n##");
        }
        [TestMethod]
        public void ShouldSpotCheck()
        {
            //arrange

            //act
            string result = Step(11);

            //assert
            result.Should().Be(
@"          #
         ##
        ###
       ####
      #####
     ######
    #######
   ########
  #########
 ##########
###########");
        }

        private static string Step(int numSteps)
        {
            StringBuilder sb = new StringBuilder();
            for (int stepIndex = 1; stepIndex <= numSteps; stepIndex++)
            {
                sb.Append(new string(' ', numSteps - stepIndex));
                sb.Append(new string('#', stepIndex));
                
                if (stepIndex >= numSteps) { continue; }

                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}
