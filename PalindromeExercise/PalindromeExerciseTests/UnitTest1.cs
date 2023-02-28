using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]   
        [InlineData("Kayak", true)]
        [InlineData("excalibur", false)]
        [InlineData("rotator", true)]
        [InlineData("ottoman", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //arange

            //act
            var actual = WordSmith.IsAPalindrome(word);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
