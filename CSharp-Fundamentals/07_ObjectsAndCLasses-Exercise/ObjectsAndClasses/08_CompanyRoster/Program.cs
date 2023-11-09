namespace _08_CompanyRoster
{
    class Employee
    {
        public Employee(string employeeName, decimal salary)
        {
            EmployeeName = employeeName;
            Salary = salary;
        }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
    }
    class Deparment
    {
        public Deparment (string deparmentName)
        {
            DepartmentName = deparmentName;
        }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public decimal TotalSalary => Employees.Sum(x => x.Salary);
    }

    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            List<Deparment> departments = new List<Deparment>();

            for (int i = 0; i < range; i++)
            {
                string[] data = Console.ReadLine()
                               .Split();
                string employeeName = data[0];
                decimal salary = decimal.Parse(data[1]);
                string departmentName = data[2];

                Deparment department = departments.FirstOrDefault(x => x.DepartmentName == departmentName);

                if(department == null)
                {
                    department = new Deparment(departmentName);
                    departments.Add(department);
                }

                department.Employees.Add(new Employee(employeeName, salary));
            }

            Deparment highestSalaryDepartment = departments.OrderByDescending(x=>x.TotalSalary).FirstOrDefault();

            if(highestSalaryDepartment != null)
            {

                Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment.DepartmentName}");
                foreach(Employee employee in highestSalaryDepartment.Employees.OrderByDescending(x=>x.Salary)) 
                {
                    
                    Console.WriteLine($"{employee.EmployeeName} {employee.Salary:f2}");
                }
            }


        }
    }
}