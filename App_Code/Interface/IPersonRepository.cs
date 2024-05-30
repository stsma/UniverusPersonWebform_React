using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Summary description for IPersonRepository
/// </summary>
public interface IPersonRepository
{
    Person GetItemById(int Id);
    Person AddItem(Person item);
    IEnumerable<Person> GetItems();
    Person UpdateItem(Person itemChanges);
    bool DeleteItemById(int Id);
}