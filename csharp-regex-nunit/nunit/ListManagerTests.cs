using NUnit.Framework;
using System.Collections.Generic;

public class ListManager
{
    public void AddElement(List<int> list, int element) => list.Add(element);
    public void RemoveElement(List<int> list, int element) => list.Remove(element);
    public int GetSize(List<int> list) => list.Count;
}

[TestFixture]
public class ListManagerTests
{
    ListManager manager;
    List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void Add_Element_Test()
    {
        manager.AddElement(list, 1);
        Assert.Contains(1, list);
    }

    [Test]
    public void Remove_Element_Test()
    {
        list.Add(1);
        manager.RemoveElement(list, 1);
        Assert.IsFalse(list.Contains(1));
    }

    [Test]
    public void Size_Test()
    {
        list.Add(1);
        list.Add(2);
        Assert.AreEqual(2, manager.GetSize(list));
    }
}
