using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Address_Book.Models
{
  public class AddressBookDatabaseInitializer : DropCreateDatabaseAlways<AddressBookDatabaseContext> //DropCreateDatabaseIfModelChanges<RecordContext>
  {
    protected override void Seed(AddressBookDatabaseContext context)
    {
         GetRecords().ForEach(p => context.Records.Add(p));
    }
    
    private static List<Record> GetRecords()
    {
      var records = new List<Record> 
      {
                new Record
                {
                    RecordID = 1,
                    Name = "Bober",
                    LastName = "Bobrenko", 
                    Patronymic="Bobrenkovich",
                    Phone = "0123454566",
                    Address = "SomeCountry, SomeCity, SomeStreet 51/29"
               },
                new Record 
                {
                    RecordID = 2,
                    Name = "Boberiko",
                    LastName = "Boberenko", 
                    Patronymic="Bobrenkovich",
                    Phone = "0123454566",
                    Address = "SomeCountry, SomeCity, SomeStreet 52/29"
               }
      };

      return records;
    }
  }
}