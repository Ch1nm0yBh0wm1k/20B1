using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emp = new();

            string con = "Server=localhost;Database=20B1;Trusted_Connection=True;MultipleActiveResultSets=true";

            using (SqlConnection conn = new SqlConnection(con))
            {
                string query = "select * from Employee";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    emp.Add(new Employee
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }


            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            

            string con = "Server=localhost;Database=20B1;Trusted_Connection=True;MultipleActiveResultSets=true";

            


            return Ok();
        }
    }
}
