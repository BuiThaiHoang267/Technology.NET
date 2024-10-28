using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SHOPTEST.Models;

namespace SHOPTEST.Controllers
{
	[Route("api/user")]
	[ApiController]
	public class UserController : Controller
	{
		private readonly ShoptestContext _context;

		public UserController(ShoptestContext context) {
			_context = context;
		}
		// Check User
		[HttpGet("checkuser")]
		public async Task<ActionResult<User>> CheckUser([FromBody] User user)
		{
			var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
			if (userCheck == null)
				return Unauthorized();
			return Ok(userCheck);
		}
	}
}
