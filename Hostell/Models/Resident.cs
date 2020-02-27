namespace Hostell.Models
{
    public class Resident
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sname { get; set; }
        public string DateOfBirthday { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public int BlockId { get; set; }
        public Block Block { get; set; }
    }
}
