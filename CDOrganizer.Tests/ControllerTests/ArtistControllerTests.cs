using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CDOrganizer.Controllers;
using CDOrganizer.Models;

namespace CDOrganizer.Tests
{
    [TestClass]
    public class ArtistsControllerTest
    {

      [TestMethod]
      public void Index_HasCorrectModelType_ArtistList()
      {
        ViewResult indexView = new ArtistsController().Index() as ViewResult;
        var result = indexView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(List<Artist>));
      }


    }
  }
