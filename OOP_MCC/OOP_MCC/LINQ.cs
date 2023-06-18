namespace OOP_MCC
{
    public class LINQ
    {
        public void employee()
        {
            Employee employee = new Employee();
            Department department = new Department();
            Region region = new Region();
            Location location = new Location();
            Country country = new Country();

            var employees = (from e in employee.GetAllEmployees()
                             join d in department.GetAllDepartments() on e.DepartmentId equals d.Id
                             join l in location.GetAllLocations() on d.LocarionId equals l.Id
                             join c in country.GetAllCountries() on l.CountryId equals c.Id
                             join r in region.GetAllRegion() on c.RegionId equals r.Id
                             select new
                             {
                                 Id = e.Id,
                                 FullName = e.FirstName + " " + e.LastName,
                                 Email = e.Email,
                                 Phone = e.PhoneNumber,
                                 Salary = e.Salary,
                                 DepartmentName = d.Name,
                                 StreetAddress = l.StreetAddress,
                                 CountryName = c.Name,
                                 RegionName = r.Name
                             }).Take(5).ToList();

            foreach (var emp in employees)
            {
                Console.WriteLine("Id : " + emp.Id + ", Name : " + emp.FullName + ", Email : " + emp.Email + ", Phone : " + emp.Phone + ", Salary : " + emp.Salary + ", Department : " + emp.DepartmentName + ", Street : " + emp.StreetAddress + ", Country : " + emp.CountryName + ", Region : " + emp.RegionName);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void department()
        {
            Employee employee = new Employee();
            Department department = new Department();

            var depatments = (from e in employee.GetAllEmployees()
                              join d in department.GetAllDepartments() on e.DepartmentId equals d.Id
                              group e by d.Name into g
                              where g.Count() >= 3
                              select new
                              {
                                  DepartmentName = g.Key,
                                  TotalEployee = g.Count(),
                                  MinSalary = g.Min(s => s.Salary),
                                  MaxSalary = g.Max(s => s.Salary),
                                  AvarageSalary = g.Average(s => s.Salary),
                              }).ToList();

            foreach (var item in depatments)
            {
                Console.WriteLine("Department : " + item.DepartmentName);
                Console.WriteLine("Total Employee : " + item.TotalEployee);
                Console.WriteLine("Min Salary : " + item.MinSalary);
                Console.WriteLine("Max Salary : " + item.MaxSalary);
                Console.WriteLine("Avarage Salary : " + item.AvarageSalary);
                Console.WriteLine();
            }
        }
    }
}
