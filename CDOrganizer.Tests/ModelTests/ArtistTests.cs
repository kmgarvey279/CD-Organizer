using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDOrganizer.Models;
using System.Collections.Generic;
using System;

namespace CDOrganizer.Tests
{
  [TestClass]
  public class ArtistTest : IDisposable
  {

    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstancesOfArtist_Artist()
    {
      Artist newArtist = new Artist("name");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "name";
      Artist newArtist = new Artist(name);
      string result = newArtist.GetName();
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsArtistsList_ArtistList()
    {
      Artist newArtist1 = new Artist("name1");
      Artist newArtist2 = new Artist("name2");
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetCDs_ReturnsEmptyCD_CDList()
    {
      string name = "name";
      Artist newArtist = new Artist(name);
      List<CD> newList = new List<CD> { };
      List<CD> result = newArtist.GetCDs();
      CollectionAssert.AreEqual(newList, result);

    }

    [TestMethod]
    public void AddCD_AssociatesCDWithArtist_CDList()
    {
      string title = "title";
      string name ="name";
      CD newCD = new CD(title);
      List<CD> newList = new List<CD> { newCD };
      Artist newArtist = new Artist(name);
      newArtist.AddCD(newCD);
      List<CD> result = newArtist.GetCDs();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_int()
    {
      string name = "name";
      Artist newArtist = new Artist(name);
      int result = newArtist.GetId();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      string name01 = "name1";
      string name02 = "name2";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      Artist result = Artist.Find(2);
      Assert.AreEqual(newArtist2, result);
    }

  }
}
