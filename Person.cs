namespace SerializableAppv2
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(int id, string name, string surname, int age)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
        }

    }

}
