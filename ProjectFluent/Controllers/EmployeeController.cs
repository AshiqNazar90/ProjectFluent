using Microsoft.AspNetCore.Mvc;
using ProjectFluent.DB;
using ProjectFluent.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectFluent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        ProjectFluentApiDbContext dbcontext;
        public EmployeeController(ProjectFluentApiDbContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public void GetAllDeatils()
        {

            dbcontext.Employees.ToList();
        }

      

        // POST api/<EmployeeController>
        [HttpPost]
      public void PutDeatils(Employee employee)
        {
            dbcontext.Employees.Add(employee);
            dbcontext.SaveChanges();    

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
