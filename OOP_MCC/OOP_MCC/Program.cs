using Microsoft.Data.SqlClient;
using System.Data;

namespace OOP_MCC;

public class Program
{

    static string connectionString = "Data Source=DESKTOP-2RVF447;Integrated Security=True;Connect Timeout=30;Database=db_hr;Encrypt=False;";

    static SqlConnection connection;
    public static void Main(string[] args)
    {
        // koneksi ke database
        /*connection = new SqlConnection(connectionString);*/

        /*try
        {
            connection.Open();
            Console.WriteLine("Connected!");
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection Failed!");
        }*/


        // GETALL : REGION
        /*List<Region> regions = GetAllRegion();
        foreach (var region in regions)
        {
            Console.WriteLine("Id : " + region.Id + ", Name : " + region.Name);
        }*/

        // Get by id Region
        /*Console.WriteLine("Get By Id");
        Console.Write("Masukkan id region : ");
        int id = int.Parse(Console.ReadLine());
        GetRegionById(id);*/


        // InsertRegion
        /*Console.WriteLine("Insert");
        Console.Write("Masukkan nama region : ");
        string nama = Console.ReadLine();
        int isInsertSuccessful = InsertRegion(nama);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil ditambahkan!");
        }
        else
        {
            Console.WriteLine("Data gagal ditambahkan!");
        }

        // UpdateRegion
        /*Console.WriteLine("Update");
        Console.Write("Masukkan id region : ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nama region : ");
        string nama = Console.ReadLine();
        int isInsertSuccessful = UpdateRegion(nama, id);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil diperbarui!");
        }
        else
        {
            Console.WriteLine("Data gagal diperbarui!");
        }*/

        // DeleteRegion
        /*Console.WriteLine("Delete");
        Console.Write("Masukkan id region : ");
        int id = int.Parse(Console.ReadLine());
        int isInsertSuccessful = DeleteRegion(id);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil dihapus!");
        }
        else
        {
            Console.WriteLine("Data gagal dihapus!");
        }*/


        // GetAll: Countries
        /*List<Country> countries = GetAllCountries();
        foreach (var country in countries)
        {
            Console.WriteLine("Id : " + country.Id + ", Name : " + country.Name + ", Region Id : " + country.RegionId);
        }*/

        // Insert country
        /*Console.WriteLine("Insert");
        Console.Write("Masukkan id country : ");
        string countryId = Console.ReadLine();
        Console.Write("Masukkan nama country : ");
        string name = Console.ReadLine();
        Console.Write("Masukkan id region : ");
        int regionId = int.Parse(Console.ReadLine());
        int isInsertSuccessful = InsertCountry(countryId, name, regionId);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil ditambahkan!");
        }
        else
        {
            Console.WriteLine("Data gagal ditambahkan!");
        }*/

        // Get By Id Country
        /*Console.WriteLine("Get By Id");
        Console.Write("Masukkan id country : ");
        string id = Console.ReadLine();
        GetCountryById(id);*/

        // Update Country
        /*Console.WriteLine("Update");
        Console.Write("Masukkan id country : ");
        string id = Console.ReadLine();
        Console.Write("Masukkan nama country : ");
        string name = Console.ReadLine();
        Console.Write("Masukkan id region : ");
        int regionId = int.Parse(Console.ReadLine());
        int isInsertSuccessful = UpdateCountry(id, name, regionId);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil diperbarui!");
        }
        else
        {
            Console.WriteLine("Data gagal diperbarui!");
        }*/

        // Delete Country
        /*Console.WriteLine("Delete");
        Console.Write("Masukkan id country : ");
        string id = Console.ReadLine();
        int isInsertSuccessful = DeleteCountry(id);
        if (isInsertSuccessful > 0)
        {
            Console.WriteLine("Data berhasil dihapus!");
        }
        else
        {
            Console.WriteLine("Data gagal dihapus!");
        }*/

        // GetAll: Departments
        /*List<Department> departments = GetAllDepartments();
        foreach (var department in departments)
        {
            Console.WriteLine("Id : " + department.Id + ", Name : " + department.Name + ", Location Id : " + department.LocarionId + ", Manager Id : " + department.ManagerId);
        }*/


        // GetAll: Employees
        /*List<Employee> employees = GetAllEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine("Id : " + employee.Id + ", Name : " + employee.FirstName + " " + employee.LastName + ", Email : " + employee.Email + ", Phone Number : " + employee.PhoneNumber + ", Hire Date : " + employee.HireDate + ", Salary : " + employee.Salary + ", Comission Pct : " + employee.ComissionPct + ", Manager Id : " + employee.ManagerId + ", Job Id : " + employee.JobId + ", Department Id : " + employee.DepartmentId);
        }*/


        // GetAll: Jobs
        /*List<Job> jobs = GetAllJobs();
        foreach (var job in jobs)
        {
            Console.WriteLine("Id : " + job.Id + ", Title : " + job.Title + ", Min Salary : " + job.MinSalary + ", Max Salary : " + job.MaxSalary);
        }*/


        // GetAll: Locations
        /*List<Location> locations = GetAllLocations();
        foreach (var location in locations)
        {
            Console.WriteLine("Id : " + location.Id + ", Street Address : " + location.StreetAddress + ", Postal Code : " + location.PostalCode + ", City : " + location.City + ", State Province : " + location.StateProvince + ", Country Id : " + location.CountryId);
        }*/


        // GetAll: Histories
        /*List<History> histories = GetAllHistories();
        foreach (var history in histories)
        {
            Console.WriteLine("Start Date : " + history.StartDate + ", Employee Id : " + history.EmployeeId + ", End Date : " + history.EndDate + ", Department Id : " + history.DepartmentId + ", Job Id : " + history.JobId);
        }*/

        LINQ lINQ = new LINQ();
        lINQ.employee();
        lINQ.department();



        // ------------------------------------------------------------------------------------------------------------------

        // get all region



        // koneksi

        /*Helloworld();
        *//*Program bum = new Program();
        bum.Helloworld();*//*

        Vehicle kapal = new Vehicle("yacht", "speed boat", "white");
        *//*car.name = "BMW Z4";
        car.type = "Sport";
        car.color = "Red";*//*
        kapal.Spesification();

        Wheel motorcycle = new Wheel(2, "Mio", "Scootic", "Blue");
        motorcycle.Spesification();

        Wheel car = new Wheel(4, "Avanza", "Family", "Silver");
        car.Spesification();
        ISound sound1 = new Implementsound();
        sound1.VehicleSoundCar(car.name);

        Pricelist price1 = new Pricelist(50000, "Revo", "Kurir", "Black");
        price1.Spesification();
        price1.PriceofVehicle(0.5);

        Wheel plane = new Wheel(6, "747-300", "Boeing", "White");
        plane.VehicleSoundPlane(plane.name);
        ISound sound2 = new Implementsound();
        sound2.VehicleSoundPlane(plane.name);*/
    }

    public static void Helloworld()
    {
        Console.WriteLine("Hello World!");
    }

    public static void GetRegionById(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM tb_m_regions WHERE id = @region_id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlParameter pId = new SqlParameter("@region_id", SqlDbType.Int);
                pId.Value = id;
                command.Parameters.Add(pId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string regionName = reader["name"].ToString();
                        int regionId = (int)reader["id"];

                        // Tampilkan nilai kolom
                        Console.WriteLine("Id : " + regionId + " Name : " + regionName);
                    }
                    else
                    {
                        Console.WriteLine("Region not found");
                    }
                }
            }
        }
    }

    public static int InsertRegion(string nama)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Insert Into tb_m_regions (name) VALUES (@region_name)";
            command.Transaction = transaction;

            // Membuat parameter
            SqlParameter pName = new SqlParameter();
            pName.ParameterName = "@region_name";
            pName.Value = nama;
            pName.SqlDbType = SqlDbType.VarChar;

            // Menambahkan parameter ke command
            command.Parameters.Add(pName);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }

    public static int UpdateRegion(string nama, int id)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE tb_m_regions SET name = @region_name WHERE id = @region_id";
            command.Transaction = transaction;

            // Membuat array
            SqlParameter[] parameters =
            {
                new SqlParameter("@region_name",SqlDbType.VarChar){Value = nama},
                new SqlParameter("@region_id",SqlDbType.Int){Value=id}
            };

            // Menambahkan parameter ke command
            command.Parameters.AddRange(parameters);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }

    public static int DeleteRegion(int id)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM tb_m_regions WHERE (id) = (@region_id)";
            command.Transaction = transaction;

            // Membuat parameter
            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@region_id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.VarChar;

            // Menambahkan parameter ke command
            command.Parameters.Add(pId);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }



    public static int InsertCountry(string countryId, string nama, int regionId)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO tb_m_countries (id, name, region_id) VALUES (@country_id, @country_name, @region_id)";
            command.Transaction = transaction;

            // Membuat array
            SqlParameter[] parameters =
            {
                new SqlParameter("@country_id",SqlDbType.VarChar){Value = countryId},
                new SqlParameter("@country_name",SqlDbType.VarChar){Value=nama},
                new SqlParameter("@region_id",SqlDbType.Int){Value=regionId}
            };

            // Menambahkan parameter ke command
            command.Parameters.AddRange(parameters);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }

    public static void GetCountryById(string id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM tb_m_countries WHERE id = @country_id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlParameter pId = new SqlParameter("@country_id", SqlDbType.VarChar);
                pId.Value = id;
                command.Parameters.Add(pId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string countryId = reader["id"].ToString();
                        string countryName = reader["name"].ToString();
                        int regionId = (int)reader["region_id"];

                        // Tampilkan nilai kolom
                        Console.WriteLine("Id : " + countryId + ", Name : " + countryName + ", Region Id : " + regionId);
                    }
                    else
                    {
                        Console.WriteLine("Country not found");
                    }
                }
            }
        }
    }

    public static int UpdateCountry(string countryId, string name, int regionId)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE tb_m_countries SET name = @country_name, region_id = @region_id  WHERE id = @country_id";
            command.Transaction = transaction;

            // Membuat array
            SqlParameter[] parameters =
            {
                new SqlParameter("@country_name",SqlDbType.VarChar){Value = name},
                new SqlParameter("@country_id",SqlDbType.VarChar){Value = countryId},
                new SqlParameter("@region_id",SqlDbType.Int){Value=regionId}
            };

            // Menambahkan parameter ke command
            command.Parameters.AddRange(parameters);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }

    public static int DeleteCountry(string id)
    {
        int result = 0;
        connection = new SqlConnection(connectionString);

        connection.Open();
        SqlTransaction transaction = connection.BeginTransaction();
        try
        {
            // Membuat Instance untuk command
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE FROM tb_m_countries WHERE (id) = (@country_id)";
            command.Transaction = transaction;

            // Membuat parameter
            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@country_id";
            pId.Value = id;
            pId.SqlDbType = SqlDbType.VarChar;

            // Menambahkan parameter ke command
            command.Parameters.Add(pId);

            // Menjalankan command
            result = command.ExecuteNonQuery();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollback)
            {
                Console.WriteLine(rollback.Message);
            }
        }
        connection.Close();
        return result;
    }



    static List<Job> GetAllJobs()
    {
        List<Job> jobs = new List<Job>();

        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            string sql = "SELECT * FROM tb_m_jobs";
            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Job job = new Job();
                        job.Id = reader["id"].ToString();
                        job.Title = reader["title"].ToString();
                        if (Convert.IsDBNull(reader["min_salary"]))
                        {
                            job.MinSalary = 0;
                        }
                        else
                        {
                            job.MinSalary = (int)reader["min_salary"];
                        }
                        if (Convert.IsDBNull(reader["max_salary"]))
                        {
                            job.MaxSalary = 0;
                        }
                        else
                        {

                            job.MaxSalary = (int)reader["max_salary"];
                        }

                        jobs.Add(job);
                    }
                }
            }

            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollbackEx)
            {
                Console.WriteLine(rollbackEx.Message);
            }
        }

        return jobs;

    }



    static List<History> GetAllHistories()
    {
        List<History> histories = new List<History>();

        SqlConnection connection = new SqlConnection(connectionString);

        connection.Open();

        SqlTransaction transaction = connection.BeginTransaction();

        try
        {
            string sql = "SELECT * FROM tb_tr_histories";
            using (SqlCommand command = new SqlCommand(sql, connection, transaction))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        History history = new History();
                        history.StartDate = (DateTime)reader["start_date"];
                        history.EmployeeId = (int)reader["employee_id"];
                        if (Convert.IsDBNull(reader["end_date"]))
                        {
                            history.EndDate = null;
                        }
                        else
                        {
                            history.EndDate = (DateTime)reader["end_date"];
                        }
                        history.DepartmentId = (int)reader["department_id"];
                        history.JobId = reader["job_id"].ToString();

                        histories.Add(history);
                    }
                }
            }

            transaction.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            try
            {
                transaction.Rollback();
            }
            catch (Exception rollbackEx)
            {
                Console.WriteLine(rollbackEx.Message);
            }
        }

        return histories;

    }
}



class Job
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
}



class History
{
    public DateTime StartDate { get; set; }
    public int EmployeeId { get; set; }
    public DateTime? EndDate { get; set; }
    public int DepartmentId { get; set; }
    public string JobId { get; set; }
}