namespace _35__tabListContact
{

    class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public Contact(int id, string name, string firstName)
        {
            this.Id = id;
            this.Name = name;
            this.FirstName = firstName;
        }
    }
}
