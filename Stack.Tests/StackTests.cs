using System;
using DataStructures;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Adding_An_Item_To_Stack_Changes_Minimum_Count()
        {
            DataStructures.Stack stack = new DataStructures.Stack();
            stack.Push(2);
            Assert.AreEqual(2, stack.GetMinimumItem());

        }

        [TestMethod]
        public void Adding_An_Item_To_ModifiedStack_Changes_Minimum_Count()
        {
            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
            stack.Push(2);
            Assert.AreEqual(2, stack.GetMinimumItem());

        }


        [TestMethod]
        public void Adding_Items_In_Descending_Order_Sets_Minimum_To_Last_Value()
        {
            DataStructures.Stack stack = new DataStructures.Stack();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Assert.AreEqual(1, stack.GetMinimumItem());
        }

        [TestMethod]
        public void Adding_Items_To_ModifiedStack_In_Descending_Order_Sets_Minimum_To_Last_Value()
        {
            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            Assert.AreEqual(1, stack.GetMinimumItem());
        }


        [TestMethod]
        public void Adding_Items_In_Descending_Order_Then_Popping_Sets_Minimum_To_Previous_Minimum_Value()
        {
            DataStructures.Stack stack = new DataStructures.Stack();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(2, stack.GetMinimumItem());
        }

        [TestMethod]
        public void Adding_Items_To_ModifiedStack_In_Descending_Order_Then_Popping_Sets_Minimum_To_Previous_Minimum_Value()
        {
            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            stack.Pop();
            Assert.AreEqual(2, stack.GetMinimumItem());
        }


        [TestMethod]
        public void GetMinimum_Returns_Zero_For_Empty_Stack()
        {
            DataStructures.Stack stack = new DataStructures.Stack();
            Assert.AreEqual(0, stack.GetMinimumItem());
        }

        [TestMethod]
        public void GetMinimum_Returns_Zero_For_Empty_ModifiedStack()
        {
            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
            Assert.AreEqual(0, stack.GetMinimumItem());
        }


        [TestMethod]
        public void GetMinimum_Runs_In_Constant_Time_For_One_Million_Items()
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

            DataStructures.Stack stack = new DataStructures.Stack();
            for (int i = 0; i <= 1000000; i++)
            {
                stack.Push(i);
            }
            watch.Start();
            int result = stack.GetMinimumItem();
            watch.Stop();
            
            Assert.AreEqual(0, watch.ElapsedMilliseconds);
        }

        [TestMethod]
        public void GetMinimum_Runs_In_Constant_Time_For_One_Million_Items_Modified()
        {
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
           
            for (int i = 0; i <= 1000000; i++)
            {
                stack.Push(i);
            }
            watch.Start();
            int result = stack.GetMinimumItem();
            watch.Stop();
        }

        [TestMethod]
        public void MinStack_Count_Less_Than_Stack_Count_For_One_Million_Items_Modified()
        {
            DataStructures.ModifiedStack stack = new DataStructures.ModifiedStack();
            for (int i = 0; i < 1000000; i++)
            {
                stack.Push(i);
            }
            Assert.AreNotEqual(1000000, stack.GetMinStackCount());
        }

        [TestMethod]
        public void MinStack_Count_Equals_Stack_Count_For_One_Million_Items()
        {
            DataStructures.Stack stack = new DataStructures.Stack();
            for (int i = 0; i < 1000000; i++)
            {
                stack.Push(i);
            }
            Assert.AreEqual(1000000, stack.GetMinStackCount());
        }
    }
}
