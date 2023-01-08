

using Collections2.Models;


//Celsius celsius=new Celsius(3);
//Kelvin kelvin = celsius;
//Console.WriteLine(kelvin.Degree);


//static List<Author> GetAllAuthors()
//{
//    List<Author> author = new();
//    Author author1 = new()
//    {
//        Name = "Islam",
//        Surname = "Velizade",
//        Age = 55
//    };
//    Author author2 = new()
//    {
//        Name = "Eli",
//        Surname = "Vahabzade",
//        Age = 25
//    };
//    Author author3 = new()
//    {
//        Name = "Ceyhun",
//        Surname = "Eliyev",
//        Age = 50
//    };
//    Author author4 = new()
//    {
//        Name = "Aytac",
//        Surname = "Velizade",
//        Age = 30
//    };
//    author.Add(author1);
//    author.Add(author2);
//    author.Add(author3);
//    author.Add(author4);
//    return author;

//}

//static void GetAuthorByAge()
//{
//    var authors = GetAllAuthors();
//    var result = authors.FindAll(m => m.Age > 40);
//    foreach (var item in result)
//    {
//        Console.WriteLine(item.Name + " " + item.Surname);
//    }

//}
//GetAuthorByAge();


//static List<Employee> GetAllEmployee()
//{
//    List<Employee> employee = new();
//    Employee employee1 = new Employee()
//    {
//        Name = "Elekber",
//        Surname = "Velizade",
//        Birthday = new DateTime(1996, 10, 05),
//        Salary = 2200
//    };
//    Employee employee2 = new Employee()
//    {
//        Name = "Xelil",
//        Surname = "Cavadov",
//        Birthday = new DateTime(1993, 09, 05),
//        Salary = 1500
//    };
//    Employee employee3 = new Employee()
//    {
//        Name = "Nezrin",
//        Surname = "Celilova",
//        Birthday = new DateTime(2000, 08, 10),
//        Salary = 2500
//    };
//    Employee employee4 = new Employee()
//    {
//        Name = "Gunay",
//        Surname = "Besirova",
//        Birthday = new DateTime(1992, 10, 05),
//        Salary = 900
//    };
//    employee.Add(employee1);
//    employee.Add(employee2);
//    employee.Add(employee3);
//    employee.Add(employee4);
//    return employee;
//}

//static int GetEmployeeByBirthdayAndSalary(DateTime start, DateTime end)
//{
//    var employes = GetAllEmployee();
//    var result = employes.FindAll(m => m.Birthday > start && m.Birthday < end && m.Salary > 2000).Count;
//    return result;
//}

//var startDate = new DateTime(1995, 10, 05);
//var endDate = new DateTime(2022, 09, 05);
//Console.WriteLine(GetEmployeeByBirthdayAndSalary(startDate, endDate));



