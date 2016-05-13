using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comp123_S2016_Lesson1B;

namespace Lesson1TestProject
{
    
    public class Lesson1UnitTest
    {
        
        public void OutputStringToConsoleTestMethod()
        {
// Arrange
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter UserName: ";
// Act
            actualResult = Comp123_S2016_Lesson1B.OutputStringToConsole(outputString, hasNewLine);


// Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
