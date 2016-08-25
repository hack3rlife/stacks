using System.Collections.Generic;
using com.hack3rlife.datastructures;
using NUnit.Framework;

namespace com.hack3rlife.datastructures
{
    [TestFixture]
    public class StackUnitTest
    {
        [Test]
        public void PushTest()
        {
            // arrange
            var stack = new Stack<int>();

            // act
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);

            // assert
            var expected = 2;
            var actual = stack.Top();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PopTest()
        {
            // arrange
            var stack = new Stack<int>();
            stack.Push(0);
            stack.Display();
            stack.Push(1);
            stack.Display();
            stack.Push(2);
            stack.Display();

            // act
            var value = stack.Pop();
            stack.Display();

            // assert
            var expected = 1;
            var actual = stack.Top();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ClearTest()
        {
            // arrange
            var stack = new Stack<int>();
            stack.Push(0);
            stack.Display();
            stack.Pop();
            stack.Display();
            stack.Push(2);
            stack.Display();

            // act
            stack.Clear();

            // assert
            Assert.IsNull(stack);
        }

        [Test]
        public void EnumeratorTest()
        {
            // arrange
            var actual = new List<int>();
            var expected = new List<int>() { 2, 1, 0 };

            var stack = new Stack<int>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);


            // act
            var enumerator = stack.GetEnumerator();

            while (enumerator.MoveNext())
            {
                actual.Add(enumerator.Current);
            }

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
