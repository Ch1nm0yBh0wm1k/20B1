using CrudUsingDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CrudUsingDB.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;
        public StudentController(IConfiguration configuration) { 
            _configuration = configuration;
        }
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    var conString = _configuration.GetConnectionString("DefaultConnection");
        //    List<Student> std = new List<Student>();


        //    using (SqlConnection conn = new SqlConnection(conString))
        //    {
        //        string query = "select * from Student";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            std.Add(new Student
        //            {
        //                Id = (int)reader["Id"],
        //                Name = (string)reader["Name"],
        //                Address = (string)reader["Address"],
        //                Age = (int)reader["Age"],
        //            });
        //        }
        //    }
        //    return View(std);


        //}

        [HttpGet]
        public IActionResult Index()
        {
            var conString = _configuration.GetConnectionString("DefaultConnection");
            List<Student> std = new List<Student>();


            using (SqlConnection conn = new SqlConnection(conString))
            {
                
                SqlCommand cmd = new SqlCommand("sp_GetStudents", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    std.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Address = (string)reader["Address"],
                        Age = (int)reader["Age"],
                    });
                }
            }
            return View(std);


        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            var conString = "Server=localhost;Database=20B1;Trusted_Connection=True;MultipleActiveResultSets=true";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "INSERT INTO Student (Name, Address, Age) VALUES (@parameter1, @parameter2, @parameter3)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@parameter1", std.Name);
                cmd.Parameters.AddWithValue("@parameter2", std.Address);
                cmd.Parameters.AddWithValue("@parameter3", std.Age);
                
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");


        }

        [HttpPost]
        public IActionResult Update(Student std)
        {
            var conString = "Server=localhost;Database=20B1;Trusted_Connection=True;MultipleActiveResultSets=true";

            using (SqlConnection conn = new SqlConnection(conString))
            {
                string query = "UPDATE [dbo].[Student] set Age = @AgeParam where Name = @NameParam";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@AgeParam", std.Age);
                cmd.Parameters.AddWithValue("@NameParam", std.Name);
                

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");


        }
    }
}
