using Calastone;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Calstone.Tests
{
    public class ProgramTests
    {

        [Test]
        public void When_ArgumentIsNull_ArgumentNullException_IsThrown()
        {
            ArgumentNullException e = Assert.Throws<ArgumentNullException>(() => Program.Main(null));

            Assert.That(e != null);
        }

        [Test]
        public void When_ArgumentIsInvalid_ArgumentException_IsThrown()
        {
            ArgumentException e = Assert.Throws<ArgumentException>(() => Program.Main(new[] { "o" }));

            Assert.That(e.Message == "No file exists at the provided pathname");
        }

        [Test]
        public void When_ArgumentIsMissing_ArgumentNullException_IsThrown()
        {
            ArgumentNullException e = Assert.Throws<ArgumentNullException>(() => Program.Main(new string[0]));

            Assert.That(e != null);
        }
    }
}