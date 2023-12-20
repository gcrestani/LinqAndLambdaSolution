using LinqUI.Models;

namespace LinqUI
{
  public static class SampleData
  {
    public static List<ContactModel> GetContactData()
    {
      List<ContactModel> output = new List<ContactModel>
      {
        new ContactModel {Id = 1, FirstName = "Guilherme", LastName = "Crestani", AddressesIds = new List<int>{1, 2, 3 }},
        new ContactModel {Id = 2, FirstName = "Joao", LastName = "Silva", AddressesIds = new List<int>{4}},
        new ContactModel {Id = 3, FirstName = "Maria", LastName = "Salvador", AddressesIds = new List<int>{4,5}},
        new ContactModel {Id = 4, FirstName = "Alberto", LastName = "Antunes", AddressesIds = new List<int>{1,3,5 }},
        new ContactModel {Id = 5, FirstName = "Carlos", LastName = "Aguiar", AddressesIds = new List<int>{1}}
      };

      return output;
    }

    public static List<AddressModel> GetAddressData()
    {
      List<AddressModel> output = new() 
      {
        new AddressModel { Id = 1, City="São Paulo", State ="SP"},
        new AddressModel { Id = 2, City="Sao Jose dos Campos", State ="SP"},
        new AddressModel { Id = 3, City="Belo Horizonte", State ="MG"},
        new AddressModel { Id = 4, City="Rio de Janeiro", State ="RJ"},
        new AddressModel { Id = 5, City="Extrema", State ="MG"},

      };

      return output;
    }
  }
}
