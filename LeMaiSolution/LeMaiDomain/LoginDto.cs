using System;
using System.Collections.Generic;
using System.Text;

namespace LeMaiDomain
{
	/// <summary>
	/// Thông tin đăng nhập lấy token
	/// </summary>
	public class LoginDto : BaseDto
	{
		/// <summary>
		/// Tên đăng nhập
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// Mật khẩu
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Thông tin đăng nhập từ thiết bị nào
		/// </summary>
		public string Device { get; set; }
	}

	public class LoginDtoOutput:BaseDto
	{
		public UserDto userDto { get; set; }
		public TokenDto tokken { get; set; }
	}
}


