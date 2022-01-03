using Xunit;
using PrimeService;
using System.Collections.Generic;
using System;

namespace PrimeService.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Dipne", LastName = "Giri" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        [Theory]
        [InlineData("Dipen","","LastName")]
        [InlineData("","Giri","FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName,string lastName, string paramName)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(paramName,()=> DataAccess.AddPersonToPeopleList(people,newPerson));
        }
    }
}