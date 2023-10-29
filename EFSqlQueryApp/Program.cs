using EFSqlQueryApp;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using (ApplicationContext context = new ApplicationContext())
{
    //SqlParameter param = new SqlParameter("@age", 30);
    int age = 40;
    var empls = context.Employees
                        .FromSqlRaw("SELECT * FROM Employees WHERE Age <= {0}", age)
                        .OrderBy(e => e.Age);

    foreach(var e in empls)
        Console.WriteLine($"{e.Id} {e.Name} {e.Age}");

    //string name = "Iren";
    //age = 31;
    //int cId = 5;
    //int pId = 1;

    //int rows = context.Database.ExecuteSqlInterpolated($"INSERT INTO Employees (Name, Age, CompanyId, PositionId) VALUES ({name}, {age}, {cId}, {pId})");
    //Console.WriteLine(rows);

    //SqlParameter param = new("@age", 30);
    //var empls2 = context.Employees
    //                    .FromSqlRaw("SELECT * FROM GetUsersByAge (@age)", param);

    //foreach (var e in empls2)
    //    Console.WriteLine($"{e.Id} {e.Name} {e.Age} {e.CompanyId}");

    //var empls3 = context.GetUsersByAge(30);
    //foreach (var e in empls3)
    //    Console.WriteLine($"{e.Id} {e.Name} {e.Age} {e.CompanyId}");

    SqlParameter param = new SqlParameter("@title", "Yandex");
    var empls5 = context.Employees
                        .FromSqlRaw("GetUsersByCompany @title", param);
    foreach (var e in empls5)
        Console.WriteLine($"{e.Id} {e.Name} {e.Age} {e.CompanyId}");
}