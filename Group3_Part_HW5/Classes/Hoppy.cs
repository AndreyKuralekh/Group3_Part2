namespace Group3_Part_HW5
{
    public class Hobby
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Hobby() :this("Noname")
        {         
        }
        public Hobby(string name) : this(name, "NoName")
        {
            this.Name = name;
        }
        public Hobby(string name, string description) : this(name, description, "Nothing")
        {
            this.Name = name;
            this.Description = description;
        }
        public Hobby(string name, string description, string type) 
        {
            this.Name = name;
            this.Description = description;
            this.Type = type;
        }

    }
}
