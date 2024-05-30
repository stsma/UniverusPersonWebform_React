using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PersonRepositories
/// </summary>
public class PersonRepository: IPersonRepository
{
    public PersonRepository()
    {
        GetPerson();

    }

    private void GetPerson()
    {
        throw new NotImplementedException();
    }

    public Person AddItem(Person item)
    {
        throw new NotImplementedException();
    }

    public bool DeleteItemById(int Id)
    {
        throw new NotImplementedException();
    }

    public Person GetItemById(int Id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Person> GetItems()
    {
        throw new NotImplementedException();
    }

    public Person UpdateItem(Person itemChanges)
    {
        throw new NotImplementedException();
    }
    
    private void CreateMockUpPeople()
    {
        var people = new List<Person> {
                new Person() { Age = 10, FullName = "John Doe", Type = 1 },
                new Person() { Age = 10, FullName = "Heath Roy", Type = 2 },
                new Person() { Age = 10, FullName = "Ellsworth Lloyd", Type = 2 },
                new Person() { Age = 10, FullName = "Allyson Bray", Type = 2 },
                new Person() { Age = 10, FullName = "Humberto Bright", Type = 2 },
                new Person() { Age = 10, FullName = "Mitzi Sharp", Type = 2 },
                new Person() { Age = 10, FullName = "Bernie Roberts", Type = 2 },
                new Person() { Age = 10, FullName = "Claudio Silva", Type = 2 },
                new Person() { Age = 10, FullName = "Aurelio Horn", Type = 2 },
                new Person() { Age = 10, FullName = "Florence Hale", Type = 2 }
            };

    }
}