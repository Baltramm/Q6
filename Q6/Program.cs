using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
           
           
        }

        static Department GetCurrentDepartment()
        {
            Department department1 = new Department();
            department1.Company = new Company();
            department1.City = new City();
            Console.WriteLine("Введите тип компании:");
            department1.Company.Type = Console.ReadLine();
            Console.WriteLine("Введите название компании:");
            department1.Company.Name = Console.ReadLine();
            if (department1.Company.Name == "")
            {
                department1.Company.Name = null;
            }
            Console.WriteLine("Введите город компании:");
            department1.City.Name = Console.ReadLine();
            
            if ((department1.City.Name=="Питер")&&(department1.Company.Type =="Банк"))
            {
                string name = department1.Company.Name ?? "Неизвестная компания";
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", name);

            }
            return department1;
        }
    }
    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

}
