using Microsoft.EntityFrameworkCore;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            using var context = new Context();

            var partime = new PartTimeEmployee
            {
                Name = "joe",
                Email = "ddd@gmail",
                Address="cairo"
                ,
                HourRate = 1
                , HourWorked = 1
                



            };
            var Fulltime = new FullTimeEmployee
            {
                Name = "joe",
                Email = "ddd@gmail",
                Address = "cairo"
                ,
                MonthSalary = 100




            };
            //context.Employees.AddRange(partime,Fulltime);
            //context.SaveChanges();
            // context.partTimeEmployees.Add(partime);
            // context.FullTimeEmployees.Add(Fulltime);
            // context.SaveChanges();
            var dep = new Department
            {
                Name = "IT"
            };
            var employees1 = new List<Employee> {

            new Employee{Name="ahmed",Address="cairo",Email="aaa"},
            new Employee{Name="joe",Address="cairo",Email="bbb"}




            };
            //dep.Employees = employees1;
            //context.departments.Add(dep);
            //context.SaveChanges();
            var employees2 = new List<Employee> {

            new Employee{Name="ahmed",Address="cairo",Email="aaa",DepartmentId=1},
            new Employee{Name="joe",Address="cairo",Email="bbb",DepartmentId=1}




            };

            // context.Employees.AddRange(employees2);
            //context.SaveChanges();

            var employees3 = new List<Employee> {

            new Employee{Name="ahmed",Address="cairo",Email="aaa",Department=dep},
            new Employee{Name="joe",Address="cairo",Email="bbb",Department=dep}




            };
            //  context.Employees.AddRange(employees3 );
            //context.SaveChanges();
            if (context.Employees.Count() == 0)
            {
                //context.Employees.AddRange(employees1 );
                //context.SaveChanges();

            }

            if(context.Database.GetPendingMigrations().Count() > 0)
            {
                //context.Database.Migrate();


            }
            //  var emp = context.Employees.FirstOrDefault(x => x.Id == 1);
            // context.Entry(emp).Reference(x => x.Department).Load();

            // var emp2 = context.Employees.Include(x=>x.Department).FirstOrDefault(x => x.Id == 2);
            var emp = context.Employees.Select(x => new
            {
                x.Id,
                x.Name,
                depname = x.Department.Name,
                depid=x.Department.Id



            }).Where(x => x.Id == 1);
            var emp1 = context.Employees.ToList();
            var empl = context.Employees.Local.FirstOrDefault(x => x.Id == 1);
            if (emp1 == null) {


                empl = context.Employees.FirstOrDefault(x => x.Id == 1);



            }
            empl = context.Employees.Find(1);
        }
    }
}
