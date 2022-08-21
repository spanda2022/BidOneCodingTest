using NUnit.Framework;
using BidOneCodingTest.Models;

namespace NUnitBidOneCodingTest
{
    public class PersonDetailsTests
    {
        private readonly PersonViewModel personViewModel;
        public PersonDetailsTests()
        {
            personViewModel = new PersonViewModel();
        }

        [Test]
        [TestCase("","Panda")]
        [TestCase("Panda", "Panda")]
        [TestCase("123", "Panda")]
        public void LastName(string lName,string expected)
        {
            personViewModel.LastName = lName;

            Assert.AreEqual(expected, personViewModel.LastName);
        }

        [Test]
        [TestCase("", "Sanghamitra")]
        [TestCase("Mitra", "Mitra")]
        [TestCase("123", "Mitra")]
        public void FirstName(string fName, string expected)
        {
            personViewModel.FirstName = fName;

            Assert.AreEqual(expected, personViewModel.FirstName);
        }

    }
}