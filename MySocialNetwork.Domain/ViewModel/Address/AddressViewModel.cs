namespace MySocialNetwork.Domain.ViewModel.Address
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public bool Main { get; private set; }
    }
}
