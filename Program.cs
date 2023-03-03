using System.ComponentModel.DataAnnotations;

namespace Tuple
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Occupation { get; set; }
        public decimal Salary { get; set; }

        public Person (string name, int age, string occupation, decimal salary)
        {
            this.Name = name;
            this.Age = age;
            this.Occupation = occupation; 
            this.Salary = salary;
        }

        public Tuple<string, int, string, decimal> GetPersonInfo(Person person)
        {
            return new Tuple<string, int, string, decimal>(person.Name, person.Age, person.Occupation, person.Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 30, "Software Engineer", 75000.00m);

            var (name, age, occupation, salary) = person.GetPersonInfo(person);

            Console.WriteLine(
                $"{name} is {age} years old and works as a {occupation}, earning {salary:C} per year."
            );
        }
    }
}
