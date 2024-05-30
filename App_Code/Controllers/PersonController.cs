using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

/// <summary>
/// Summary description for PersonTypeController
/// </summary>
/// 
public class PersonController : ApiController
{
    public PersonController()
    {
    }

    public IEnumerable<Person> GetAll()
    {
        return People;
    }

    public bool DeleteById(int id)
    {
        return false;
    }

    //public ActionResult Update(Person person)
    //{
    //    if(!ModelState.IsValid) { return BadRequest(); }
    //    return person;
    //}

    public Person Add(Person person)
    {
        return person;
    }

    public List<Person> People = new List<Person>()
    {
        new Person() { ID = 1, Age = 10, FullName = "John Doe", Type = 1 },
        new Person() { ID = 2, Age = 10, FullName = "Heath Roy", Type = 2 },
        new Person() { ID = 3, Age = 10, FullName = "Ellsworth Lloyd", Type = 2 },
        new Person() { ID = 4, Age = 10, FullName = "Allyson Bray", Type = 2 },
        new Person() { ID = 5, Age = 10, FullName = "Humberto Bright", Type = 2 },
        new Person() { ID = 6, Age = 10, FullName = "Mitzi Sharp", Type = 2 },
        new Person() { ID = 7, Age = 10, FullName = "Bernie Roberts", Type = 2 },
        new Person() { ID = 8, Age = 10, FullName = "Claudio Silva", Type = 2 },
        new Person() { ID = 9, Age = 10, FullName = "Aurelio Horn", Type = 2 },
        new Person() { ID = 10, Age = 10, FullName = "Florence Hale", Type = 2 }
    };

}