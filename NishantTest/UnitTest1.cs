using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NishantTest
{
  

   [TestClass]
    public class UnitTest1
    {
        //creating an instance of the class
        NishantGame.Nishant test = new NishantGame.Nishant();

        //implement a test function to test if the bullet is between 1 and 6
        [TestMethod]
            public void TestMethod1()
            {
                //calling the method from the instance
                int testresult = test.SpinFunc();

                //checking the return value of the function
                Assert.IsTrue(testresult < 7 && testresult > 0);
            }


            [TestMethod]
            public void TestMethod2()
            {
              

                int testResultShootingAwayFunc = test.ShootingAwayFunc();

                Assert.IsTrue(testResultShootingAwayFunc <= 4 && testResultShootingAwayFunc > 0);
            }

            [TestMethod]
            public void TestMethod3()
            {
                int testresultShootingAwayFunc2 = test.ShootingAwayFunc2();

                Assert.IsTrue(testresultShootingAwayFunc2 < 7 && testresultShootingAwayFunc2 > 0);

            }
        }
    }




