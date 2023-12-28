using LinqUI.Models;

namespace LinqUI
{
  public static class SampleData
  {
    public static List<ContactModel> GetContactData()
    {
      List<ContactModel> output = new List<ContactModel>
      {
        new ContactModel {Id = 1, FirstName = "Guilherme", LastName = "Crestani", CarId = new List<int>{1, 2, 3 }, Adresses = new List<int>{1, 2, 3 }},
        new ContactModel {Id = 2, FirstName = "Joao", LastName = "Silva", CarId = new List<int>{4}, Adresses = new List<int>{4,6}},
        new ContactModel {Id = 3, FirstName = "Maria", LastName = "Salvador", CarId = new List<int>{4,5}, Adresses = new List<int>{4,5}},
        new ContactModel {Id = 4, FirstName = "Alberto", LastName = "Antunes", CarId = new List<int>{1,3,5 }, Adresses = new List<int>{1,3}},
        new ContactModel {Id = 5, FirstName = "Carlos", LastName = "Aguiar", CarId = new List<int>{1 }, Adresses = new List<int>{1}}
      };

      return output;
    }

    public static List<AddressModel> GetAddressData()
    {
      List<AddressModel> output = new()
      {
        new AddressModel { Id = 1, ContactId = 1, City="São Paulo", State ="SP"},
        new AddressModel { Id = 2, ContactId = 2, City="Sao Jose dos Campos", State ="SP"},
        new AddressModel { Id = 3, ContactId = 3, City="Belo Horizonte", State ="MG"},
        new AddressModel { Id = 4, ContactId = 4, City="Rio de Janeiro", State ="RJ"},
        new AddressModel { Id = 5, ContactId = 5, City="Extrema", State ="MG"},
        new AddressModel { Id = 6, ContactId = 1, City="Sao Jose dos Campos", State ="SP"},
        new AddressModel { Id = 7, ContactId = 2, City="Belo Horizonte", State ="MG"},
        new AddressModel { Id = 8, ContactId = 1, City="Rio de Janeiro", State ="RJ"},
        new AddressModel { Id = 9, ContactId = 4, City="Extrema", State ="MG"},
      };

      return output;
    }
  }
}
