using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDOrganizer.Models;
using System.Collections.Generic;
using System;

namespace CDOrganizer.Tests
{
  [TestClass]
  public class CDTest : IDisposable
  {

    public void Dispose()
    {
      CD.ClearAll();
    }

    [TestMethod]
    public void CDConstructor_CreatesInstancesOfCD_CD()
    {
      CD newCD = new CD("title");
      Assert.AreEqual(typeof(CD), newCD.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "title";
      CD newCD = new CD(title);
      string result = newCD.GetTitle();
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CDList()
    {
      List<CD> newCD = new List<CD> { };
      List<CD> result = CD.GetAll();
      CollectionAssert.AreEqual(newCD, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCD_CDList()
    {
      CD newCD1 = new CD("test");
      CD newCD2 = new CD("test2");
      List<CD> newList = new List<CD> { newCD1, newCD2};
      List<CD> result = CD.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_CDInstantiateWithAnIdAndGetterReturns_Int()
    {
      CD newCD = new CD("test");
      int result = newCD.GetId();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectCD_CD()
    {
      CD newCD1 = new CD("title1");
      CD newCD2 = new CD("title2");
      CD result = CD.Find(2);
      Assert.AreEqual(newCD2, result);
    }

  }
}
