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

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] User user)
		{
			// Tìm người dùng dựa trên tên đăng nhập
			var userCheck = await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username);

			// Kiểm tra xem người dùng có tồn tại và mật khẩu có khớp không
			if (userCheck == null || user.Password != userCheck.Password) // Kiểm tra mật khẩu đã mã hóa
			{
				return Unauthorized(new { message = "Invalid username or password" });
			}

			// Trả về thông báo xác thực thành công
			return Ok(new 
			{ 
				message = "User authenticated successfully" ,
				role = userCheck.Role,
			});
		}

	}
}
