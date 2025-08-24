

namespace ConsoleApp22
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Department Department { get; set; } 
        public int DepartmentId { get; set; }
    }
    internal class PartTimeEmployee : Employee {
        public int HourWorked { get; set; }
        public int HourRate { get; set; }



    }
    internal class FullTimeEmployee : Employee
    {

        public int MonthSalary { get; set; }


    }
    public class  Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = [];
        
    }
}
