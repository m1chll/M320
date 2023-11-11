using System;
using Stack;

namespace StackTest;

[TestClass]
public class StringStackTest
{
    [TestMethod]
    public void TestPushPop()
    {
        // Arrange
        StringStack stack = new StringStack(3);

        // Act
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");

        // Assert
        Assert.AreEqual("Three", stack.Pop());
        Assert.AreEqual("Two", stack.Pop());
        Assert.AreEqual("One", stack.Pop());
        Assert.AreEqual("Stack is empty", stack.Pop());
    }

    [TestMethod]
    public void TestPeek()
    {
        // Arrange
        StringStack stack = new StringStack(3);

        // Act
        stack.Push("One");
        stack.Push("Two");

        // Assert
        Assert.AreEqual("Two", stack.Peak());
        stack.Pop();
        Assert.AreEqual("One", stack.Peak());
        stack.Pop();
        Assert.AreEqual("Stack is empty", stack.Peak());
    }

    [TestMethod]
    public void TestClear()
    {
        // Arrange
        StringStack stack = new StringStack(3);

        // Act
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");
        stack.Clear();

        // Assert
        Assert.AreEqual(true, stack.IsEmpty);
    }

    [TestMethod]
    public void TestCount()
    {
        // Arrange
        StringStack stack = new StringStack(4);

        // Act
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");

        // Assert
        Assert.AreEqual(3, stack.Count);
    }

    [TestMethod]
    public void TestIsFull()
    {
        // Arrange
        StringStack stack = new StringStack(4);

        // Act
        stack.Push("One");
        stack.Push("Two");
        stack.Push("Three");

        // Assert
        Assert.AreEqual(false, stack.IsFull);
        stack.Push("Four");
        Assert.AreEqual(true, stack.IsFull);
    }
}