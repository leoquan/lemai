namespace LeMaiDomain
{
	public class RefreshDto : BaseDto
	{
		/// <summary>
		/// Access token cũ đã hết hạn
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// Refresh token đang lưu giữ
		/// </summary>
		public string RefreshToken { get; set; }
	}
}

