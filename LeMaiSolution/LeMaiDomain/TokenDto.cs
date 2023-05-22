using System;
using System.ComponentModel.DataAnnotations;

namespace LeMaiDomain
{
	/// <summary>
	/// Kết quả token đăng nhập
	/// </summary>
	public class TokenDto : BaseDto
	{
		public string UserId { get; set; }

		/// <summary>
		/// Access token
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// Refresh token dùng để xin lại Access token mới khi cái củ hết hạn
		/// </summary>
		public string RefreshToken { get; set; }

		/// <summary>
		/// Thời gian hết hạn của Reresh token, tính bằng giờ UTC (ticks)
		/// </summary>
		public DateTime ExpiresRefreshToken { get; set; }

		public bool IsExpired()
		{
			return DateTime.UtcNow > ExpiresRefreshToken;
		}
	}
}


