namespace PracticeLINQ
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
    public class LINQ
    {
        List<Person> people = new List<Person>
            {
                new Person { Name = "Chandler Bing", Age = 34, City = "NYC", Salary = 70000, DepartmentId = 1 },
                new Person { Name = "Monica Geller", Age = 32, City = "NYC", Salary = 80000, DepartmentId = 3 },
                new Person { Name = "Monica Geller", Age = 42, City = "NYC", Salary = 75000, DepartmentId = 2 },
                new Person { Name = "Phoebe Buffay", Age = 31, City = "NYC", Salary = 50000, DepartmentId = 1 },
                new Person { Name = "Joey Tribbiani", Age = 36, City = "NYC", Salary = 85000, DepartmentId = 3 },
                new Person { Name = "Rachel Green", Age = 33, City = "NYC", Salary = 95000, DepartmentId = 2 }
            };

        readonly List<Department> departments = new List<Department>
            {
                new Department { Id = 1, DepartmentName = "HR"},
                new Department { Id = 2, DepartmentName = "IT"},
                new Department { Id = 3, DepartmentName = "Finance"}
            };


        public void QuerySyntax()
        {
            var query = from person in people
                        where person.Age > 30
                        where person.Name == "Ross Geller"
                        orderby person.Age
                        select person;

            foreach (var person in query)
            {
                Console.Write($"{person.Name} - {person.Age} - {person.City}");
                Console.WriteLine();
            }
            Console.WriteLine("--- / Query Syntax / ---");
        }

        public void MethodSyntax()
        {
            var methodQuery = people
                .GroupBy(x => new { x.City, x.Age, x.Name })
                .Select(g => new
                {
                    City = g.Key.City,
                    Age = g.Key.Age,
                    Name = g.Key.Name,
                    TotalSalary = g.Sum(p => p.Salary),
                    AvgSalary = g.Average(p => p.Salary),
                    Count = g.Count(),
                    People = g.Select(p => p).ToList()
                }
                );

            //foreach (var person in methodQuery)
            //{
            //    Console.Write($"{person.Name} - {person.Age} - {person.City}");
            //    Console.WriteLine();

            //}

            foreach (var group in methodQuery)
            {
                //Console.WriteLine($"City: {new { group.City, group.Age }}");
                //foreach (var person in group.People)
                //{
                //    Console.WriteLine($"  {person.Name} - {person.Age}");
                //}

                Console.WriteLine($"Name: {group.Name}, City: {group.City}, Age: {group.Age}");
                Console.WriteLine($"Total salary: {group.TotalSalary}");
                Console.WriteLine($"Average Salary: {group.AvgSalary}");
                Console.WriteLine($"Count: {group.Count}");
                foreach (var person in group.People)
                {
                    Console.WriteLine($"{person.Name} - {person.Age} - {person.Salary}");
                }
            }
            Console.WriteLine("--- / Method Syntax / ---");
        }

        public void JoinQuery()
        {
            var query = people
                .Join(departments,
                person => person.DepartmentId,
                department => department.Id,
                (person, department) => new
                {
                    Name = person.Name,
                    City = person.City,
                    Age = person.Age,
                    Department = department.DepartmentName,
                });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name} - {item.Age} - {item.Department}");
            }
        }

    }
}