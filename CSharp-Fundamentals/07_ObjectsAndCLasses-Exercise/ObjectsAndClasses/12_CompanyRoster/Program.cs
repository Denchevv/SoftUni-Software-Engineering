using System.Linq;

namespace _12_CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public decimal HighestSalary => Employees.Sum(x => x.Salary);
    }
    public class Program
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            List<Department> departmentList = new List<Department>();

            for (int i = 0; i < range; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                decimal salary = decimal.Parse(data[1]);
                string departmentName = data[2];

                Department department = departmentList
                                        .FirstOrDefault(x => x.DepartmentName == departmentName);
                if (department == null)
                {
                    department = new Department();
                    departmentList.Add(department);
                }

                department.Employees.Add(new Employee(name, salary));
            }

            Department highestPaidDepartment = departmentList
                            .OrderByDescending(x => x.HighestSalary)
                            .FirstOrDefault();
                            
            if(highestPaidDepartment != null)
            {
                Console.WriteLine($"Highest Average Salary: {highestPaidDepartment.DepartmentName}");

                foreach (Employee employee in highestPaidDepartment.Employees.OrderByDescending(x=>x.Salary))
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }
}