namespace FirstApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        private string firstame;
        private string lastname;
        public string Firstame { get => firstame; set => firstame = value; }
        public string Lastname { get => lastname; set => lastname = value; }

        public Person()
        {
            
        }
        public Person(string fn, string ln)
        {
            Id = IncrementId();
            firstame= fn;
            lastname= ln;
        }
        private int IncrementId()
        {
            return ++Id;
        }
        public string ToString()
        {
            return $"id : {Id} , nom complet {firstame} {lastname}";
        }
        
    }
}
