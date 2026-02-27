using NaiFar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiFar.Testing
{
    [TestFixture]
    public class DepartementTest
    {
        [Test]
        public void IsNaamUpper()
        {
            Department department = new Department();
            department.Naam = "digital";
            Assert.That(department.Naam,
            Is.EqualTo("DIGITAL"));
        }
    }
}
