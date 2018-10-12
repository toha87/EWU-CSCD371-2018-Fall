using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                userInputResults = PaperRockScissors.Program.GetUserInput();
            });

            Assert.AreEqual("rock", userInputResults);
            
        }

        [TestMethod]
        public void ComputerInputTestMethod()
        {
            String PlayerInput = "rock";
            int ComputerInput = 1;

            var Player =  Tuple.Create("Player", 100);
            var Computer = Tuple.Create("Computer", 100);

            IntelliTect.TestTools.Console.ConsoleAssert.Expect($">>" +
                ">>Congrats! { winner.Item1} won with score { winner.Item2}!" +
                "<<rock", () =>
                {
                    Computer = PaperRockScissors.Program.GameAction();
                });

            Assert.AreEqual(Computer.Item1 +" " +Computer.Item2, Computer);



        }


    }
}
