using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaperRockScissors;
using System;

namespace GameUnitTest
{
    [TestClass]
    public class GameUnitTestClass
    {
        [TestMethod]
        public void UserInputTestMethod()
        {
            
            String userInputResults ="";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(">>Do you choose rock, paper or scissors" +
                "<<rock", () =>
            {
                userInputResults = PaperRockScissors.PaperRockScissorsClass.GetUserInput();
            });

            Assert.AreEqual("rock", userInputResults);
            
        }

        [TestMethod]
        public void BadUserInput()
        {

            String userInputResults = "";

            IntelliTect.TestTools.Console.ConsoleAssert.Expect(">>Do you choose rock, paper or scissors" +
                "<<123", () =>
                {
                    userInputResults = PaperRockScissors.PaperRockScissorsClass.GetUserInput();
                });

            Assert.AreEqual("123", userInputResults);

        }

        [TestMethod]
        public void PlayAgainMethod()
        {
            bool ExpectedResult = true;
            bool ActualResult = false;

            IntelliTect.TestTools.Console.ConsoleAssert.Expect("" +
                ">>Do you want to try again? Y/N" +
                "<<y", () =>
                {
                    ActualResult = PaperRockScissors.PaperRockScissorsClass.PlayAgainMethod();
                });


            Assert.AreEqual( ExpectedResult, ActualResult);
           
        }

        [TestMethod]
        public void WhoWon()
        {
                      
            var input = Tuple.Create("Player", 20);

            PaperRockScissorsClass.WhoWon(input);

            string expectedOutput = $@">>Congrats! Player won with score 20!";

           }
    }
}
