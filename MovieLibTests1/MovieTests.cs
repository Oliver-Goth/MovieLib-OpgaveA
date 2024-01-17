using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLib.Tests
{
    [TestClass()]
    public class MovieTests : Movie
    {
        [TestMethod()]
        public void ValidateIdTooShort()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Movie() { Id = 0, Title = "The Matrix", ReleaseYear = 1999 }.Validate());
        }
        [TestMethod()]
        public void ValidateTitleIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Movie() { Id = 1, Title = null, ReleaseYear = 1999 }.Validate());
        }
        [TestMethod()]
        public void ValidateTitleTooShort()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Movie() { Id = 1, Title = "", ReleaseYear = 1999 }.Validate());
        }
        [TestMethod()]
        public void ValidateReleaseYearTooShort()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Movie() { Id = 0, Title = "The Matrix", ReleaseYear = 1800 }.Validate());
        }
    }
}