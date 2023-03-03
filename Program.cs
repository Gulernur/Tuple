using System.ComponentModel.DataAnnotations;

namespace Tuple
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Occupation { get; set; }
        public decimal Salary { get; set; }

        public Tuple<string, int, string, decimal> GetPersonInfo(
            string name,
            int age,
            string occupation,
            decimal salary
        )
        {
            return new Tuple<string, int, string, decimal>(name, age, occupation, salary);
        }
    }

    class Program
    {
        static void Main(string[] args) { }
    }
}
