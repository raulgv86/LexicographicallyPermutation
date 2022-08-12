using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lexicographically_Permutation;

namespace PermutationTesting
{
    [TestClass]
    public class UnitTest1
    {
        private static Permutation _permutation = new Permutation();

        public UnitTest1()
        {
            
        }

        [TestMethod]
        public void NextPermutation_Ok()
        {
            string vector = "123";
            string result = _permutation.next_lexicographic(vector);
            
            Assert.AreEqual("132", result);
        }

        [TestMethod]
        public void NextPermutation_Failed()
        {
            string vector = "654";
            string result = _permutation.next_lexicographic(vector);

            Assert.AreNotEqual("465", result);
        }
    }
}
