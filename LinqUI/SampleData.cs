using LinqUI.Models;

namespace LinqUI
{
  public static class SampleData
  {
    public static List<ContactModel> GetData()
    {
      List<ContactModel> output = new List<ContactModel>
      {
        new ContactModel {Id = 1, FirstName = "Guilherme", LastName = "Crestani", AddressIds = new List<int>{1, 2, 3 }},
        new ContactModel {Id = 1, FirstName = "Joao", LastName = "Silva", AddressIds = new List<int>{4}},
        new ContactModel {Id = 1, FirstName = "Maria", LastName = "Salvador", AddressIds = new List<int>{5,6}},
        new ContactModel {Id = 1, FirstName = "Alberto", LastName = "Antunes", AddressIds = new List<int>{7,12 }},
        new ContactModel {Id = 1, FirstName = "Carlos", LastName = "Aguiar", AddressIds = new List<int>{8,9,10,11}}
      };

      return output;
    }
  }
}
