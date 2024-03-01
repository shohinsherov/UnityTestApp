using UnityTestApp.Services;

namespace UnityTestApp.UTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }



        [Test]
        public void TestSwapperLevel1()
        {
            ReplacementLevel1 swapperLevel1 = new ReplacementLevel1();
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var result = swapperLevel1.GetReplacements(numbers);

            string Out = "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizz-buzz";
            Assert.That(string.Join(", ", result), Is.EqualTo(Out));
        }

        [Test]
        public void TestSwapperLevel2()
        {
            ReplacementLevel2 swapperLevel2 = new ReplacementLevel2();
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            var result = swapperLevel2.GetReplacements(numbers);

            string Out = "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, fizz-buzz-guzz, fizz-buzz-muzz-guzz";
            Assert.That(string.Join(", ", result), Is.EqualTo(Out));
        }

        [Test]
        public void TestSwapperLevel3()
        {
            ReplacementLevel3 swapperLevel3 = new ReplacementLevel3();
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            var result = swapperLevel3.GetReplacements(numbers);

            string Out = "1, 2, dog, muzz, cat, dog, guzz, muzz, dog, cat, 11, fizz-muzz, 13, guzz, good-boy, good-boy-muzz, good-boy-guzz, good-boy-muzz-guzz";
            Assert.That(string.Join(", ", result), Is.EqualTo(Out));
        }

    }
}