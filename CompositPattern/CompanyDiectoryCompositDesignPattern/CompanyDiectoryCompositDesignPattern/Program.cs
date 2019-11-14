using System;

namespace CompanyDiectoryCompositDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Department("Company");

            root.Add(new Employee("Boss"));
            root.Add(new Employee("Deputy boss "));
            //generate 1

            var financeDepartment = new Department("Finance Department");
            financeDepartment.Add(new Employee("Finance Person 1"));
            financeDepartment.Add(new Employee("Finance Person 2"));
            root.Add(financeDepartment);

            var softwareDepartment = new Department("Software Department");

            var backendDepartment = new Department("Backend Department");
            backendDepartment.Add(new Employee("Backend developer 1"));
            backendDepartment.Add(new Employee("Backend developer 2"));
            softwareDepartment.Add(backendDepartment);

            var frontendDepartment = new Department("Frontend Department");
            frontendDepartment.Add(new Employee("Frontend developer 1"));
            frontendDepartment.Add(new Employee("Frontend developer 2"));
            softwareDepartment.Add(frontendDepartment);
            root.Add(softwareDepartment);

            var iTDepartment = new Department("IT department");
            iTDepartment.Add(new Employee("IT helpdesk guy 1"));
            iTDepartment.Add(new Employee("IT helpdesk guy 2"));
            root.Add(iTDepartment);
            root.Display(1);
        }
    }
}
