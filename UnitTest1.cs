using CodilityDemoTest;
using System.Diagnostics;

namespace CodilityDemoUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(5,0,2, "AABBAABBAA")]
        [DataRow(1,2,1, "AABBABAB")]
        [DataRow(0,2,0, "ABAB")]
        [DataRow(0,0,10, "BB")]
        public void ResultStringShouldMatchExpected(int AA, int AB, int BB, string expected)
        {
            //Arrange
            var sut = new Solution();
            
            //Act
            var result = sut.solution(AA, AB, BB);

            //Assert
            Debug.WriteLine($"input: AA:{AA},AB:{AB} BB:{BB} result string: {result}");
            Assert.AreEqual( expected, result );  
        }
    }
}
