namespace LinqUI.Models
{
  public class ContactModel
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> AddressesIds { get; set; }

  }
}
