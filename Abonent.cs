namespace PhoneBook_entity
{
    public class Abonent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }

        public Abonent()
        {
                
        }
        public Abonent(int id, string name, string lastname, string phone)
        {
            Id = id;
            Name = name;    
            Lastname = lastname;    
            Phone = phone;
        }
    }
}
