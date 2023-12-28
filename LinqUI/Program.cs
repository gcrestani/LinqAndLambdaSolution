using LinqUI;

internal class Program
{
  static void Main(string[] args)
  {
    GetContactsWithMultipleCars(); Console.WriteLine();
    GetContactsFirstName(); Console.WriteLine();
    GetFirstTwoContacts(); Console.WriteLine();
    GetTwoContactsAfterTheFirstTwo(); Console.WriteLine();
    GetContactsOrderByLastName(); Console.WriteLine();
    GetContactsOrderByLastNameDesc(); Console.WriteLine();
    
    Console.WriteLine("\nLinq:\n");
    LinqContactsWithMoreThanOneCar(); Console.WriteLine();
    LinqGetContactsWithAddresses(); Console.WriteLine();
    LinqReturnAddressesOfContacts(); Console.WriteLine();
    LinqReturnAddressesOfContactsUsingList(); Console.WriteLine();

    Console.ReadLine();
  }

  private static void GetContactsWithMultipleCars()
  {
    var data = SampleData.GetContactData();
    var results = data.Where(x => x.CarId.Count > 1);

    Console.WriteLine($"This contacts have more than 1 Car:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName} - Cars: {item.CarId.Count}");
    }
  }
  private static void GetContactsFirstName()
  {
    var data = SampleData.GetContactData();
    var results = data.Select(x => x.FirstName);

    Console.WriteLine($"This are the contacts first name:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item}");
    }
  }

  private static void GetFirstTwoContacts()
  {
    var data = SampleData.GetContactData();
    var results = data.Take(2);

    Console.WriteLine($"This are the first two contacts:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName}");
    }
  }

  private static void GetTwoContactsAfterTheFirstTwo()
  {
    var data = SampleData.GetContactData();
    var results = data.Skip(2).Take(2);

    Console.WriteLine($"This are the two contacts after the first two:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName}");
    }
  }

  private static void GetContactsOrderByLastName()
  {
    var data = SampleData.GetContactData();
    var results = data.OrderBy(x => x.LastName);

    Console.WriteLine($"This are all contacts ordered by Last Name:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName}");
    }
  }

  private static void GetContactsOrderByLastNameDesc()
  {
    var data = SampleData.GetContactData();
    var results = data.OrderByDescending(x => x.LastName);

    Console.WriteLine($"This are all contacts ordered by Last Name Desc:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName}");
    }
  }

  private static void LinqContactsWithMoreThanOneCar()
  {
    var contacts = SampleData.GetContactData();

    var contactsWithMoreThanOneCar = from c in contacts
                                     where c.CarId.Count() > 1
                                     select c;

    Console.WriteLine("This contacts have more than 1 Car");
    foreach (var contact in contactsWithMoreThanOneCar)
    {
      Console.WriteLine(contact.FirstName + " " + contact.LastName);
    }
  }

  private static void LinqGetContactsWithAddresses()
  {
    var contacts = SampleData.GetContactData();
    var addresses = SampleData.GetAddressData();

    var contactsWithMoreThanOneAddress = from c in contacts
                                         join a in addresses
                                         on c.Id equals a.ContactId
                                         select new { c.FirstName, c.LastName, a.City, a.State };

    Console.WriteLine("This contacts have more than 1 Address");
    foreach (var contact in contactsWithMoreThanOneAddress)
    {
      Console.WriteLine(contact.FirstName + " " + contact.LastName + " - " + contact.City);
    }
  }

  private static void LinqReturnAddressesOfContacts()
  {
    var contacts = SampleData.GetContactData();
    var addresses = SampleData.GetAddressData();

    var contactWithAddresses = from c in contacts
                               select new { c.FirstName, c.LastName, Address = addresses.Where(a => a.ContactId.Equals(c.Id)) };

    Console.WriteLine("Contacts and their addresses Qty");
    foreach (var contact in contactWithAddresses)
    {
      Console.WriteLine(contact.FirstName + " " + contact.LastName + " - Addresses Count: " + contact.Address.Count());
    }
  }

  private static void LinqReturnAddressesOfContactsUsingList()
  {
    var contacts = SampleData.GetContactData();
    var addresses = SampleData.GetAddressData();

    var contactWithAddresses = from c in contacts
                               select new { c.FirstName, c.LastName, Address = addresses.Where(a => c.Adresses.Contains(a.Id)) };

    Console.WriteLine("Contacts and their addresses Qty");
    foreach (var contact in contactWithAddresses)
    {
      Console.WriteLine(contact.FirstName + " " + contact.LastName + " - Addresses Count: " + contact.Address.Count());
    }
  }

}