using LinqUI;

internal class Program
{
  static void Main(string[] args)
  {
    GetContactsWithMultipleAddresses(); Console.WriteLine();
    GetContactsFirstName(); Console.WriteLine();
    GetFirstTwoContacts(); Console.WriteLine();
    GetTwoContactsAfterTheFirstTwo(); Console.WriteLine();
    GetContactsOrderByLastName(); Console.WriteLine();
    GetContactsOrderByLastNameDesc(); Console.WriteLine();

    Console.ReadLine();
  }

  private static void GetContactsWithMultipleAddresses()
  {
    var data = SampleData.GetContactData();
    var results = data.Where(x => x.AddressesIds.Count > 1);

    Console.WriteLine($"This contacts have more than 1 address:");

    foreach (var item in results)
    {
      Console.WriteLine($"{item.FirstName} {item.LastName} - Addresses: {item.AddressesIds.Count}");
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
}