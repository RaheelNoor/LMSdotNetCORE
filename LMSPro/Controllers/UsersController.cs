using LMSPro.Data;
using LMSPro.Model;
using LMSPro.Repository;
using LMSPro.Repository.InterFace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMSPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _userServices;
        public UsersController(IUsers userServices)
        {
            _userServices = userServices;
        }
        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            return _userServices.GetUsers();
        }
        [HttpPost]
        public ActionResult<Users> PostUser(Users user)
        {
            return _userServices.SignupUser(user);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, Users user)
        {
            var users = _userServices.UpdateUser(id, user);
            if (users == null) return NotFound();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _userServices.DeleteUser(id);
            if (!user) return NotFound();
            return NoContent();
        }
        // Loans Users Api 
        [HttpGet("loans")]
        public IEnumerable<Loans> GetLoans()
        {
            return _userServices.GetLoans();
        }
        [HttpPost("loan")]
        public ActionResult<Loans> PostUserLoan(Loans loan)
        {
            return _userServices.PostLoans(loan);
        }
        [HttpPut("loan{id}")]
        public IActionResult UpdateLoan(int id, Loans loan)
        {
            var loans = _userServices.PostLoans(loan);
            if (loans == null) return NotFound();
            return NoContent();
        }
        [HttpDelete("loan{id}")]
        public IActionResult DeleteLoans(int id)
        {
            var loan = _userServices.DeleteLoans(id);
            if (!loan) return NotFound();
            return NoContent();
        }
    }
}
