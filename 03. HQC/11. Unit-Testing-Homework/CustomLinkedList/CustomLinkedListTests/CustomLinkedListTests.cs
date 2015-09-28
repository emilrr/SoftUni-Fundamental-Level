namespace CustomLinkedListTests
{
    using System;
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CustomLinkedListTests
    {
        [TestMethod]
        public void TestList_Count_ShouldBeZero()
        {
            DynamicList<int> list = new DynamicList<int>();

            Assert.AreEqual(0, list.Count, "Count is not zero when initialize DynamicList!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestList_GetNegativeIndex()
        {
            DynamicList<int> list = new DynamicList<int>();
            int value = list[-1];
        }

        [TestMethod]
        public void TestList_Add_ShouldHasNineItem()
        {
            DynamicList<int> list = new DynamicList<int>();
            int count = 9;

            for (int number = 0; number < count; number++)
            {
                list.Add(number);
            }

            Assert.AreEqual(count, list.Count, "Count is not nine when add a nine items to DynamicList!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestList_GetIndex_ShouldThrowException()
        {
            DynamicList<int> list = new DynamicList<int>();
            int getterIndexTest = 9;

            list.Add(getterIndexTest);
            int value = list[5];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestList_SetIndex_ShouldThrowException()
        {
            DynamicList<int> list = new DynamicList<int>();
            int setterIndexTest = 9;

            list[3] = setterIndexTest;
        }

        [TestMethod]
        public void TestList_GetIndex_ShouldReturnCorrectNumber()
        {
            DynamicList<int> list = new DynamicList<int>();
            int number = 15;

            list.Add(number);
            int actual = list[0];

            Assert.AreEqual(15, actual, "Numbers are not the equal!");
        }

        [TestMethod]
        public void TestList_RemoveAt_GivenIndex()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.RemoveAt(1);
            int firstNumber = list[0];
            int secondNumber = list[1];
            Assert.AreEqual(0, firstNumber, "The first number should be the first entered in the list.");
            Assert.AreEqual(2, secondNumber, "The second number should be the third entered after removing the second from the list.");
        }

        [TestMethod]
        public void TestList_Count_AfterRemoveElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");

            list.Remove("two");
            int count = list.Count;

            Assert.AreEqual(2, count, "The count of elements of the list should be 2 after removing an element.");
        }

        public void TestList_ReturnValue_AfterRemoveNonExistingElementFromList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("one");
            list.Add("two");
            int index = list.Remove("three");

            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        [TestMethod]
        public void TestList_Contain_ShouldReturnTrue()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            bool isFound = list.Contains("third");

            Assert.IsFalse(isFound, "The element is not in the list and Contains should return false.");
        }

        [TestMethod]
        public void TestList_Contain_ShouldReturnFalse()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");

            bool isFound = list.Contains("second");

            Assert.IsTrue(isFound, "The element is in the list and Contains should return true.");
        }
    }
}
