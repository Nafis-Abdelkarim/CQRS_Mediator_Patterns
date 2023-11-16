using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel GetPerson(int id);
        PersonModel InsertPeople(string firstName, string lastName);
    }
}