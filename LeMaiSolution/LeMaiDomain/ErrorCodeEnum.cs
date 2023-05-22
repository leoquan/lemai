namespace LeMaiDomain
{
	/// <summary>
	/// Mã lỗi API
	/// </summary>
	public enum ErrorCodeEnum
	{
		/// <summary>
		/// Không có lỗi
		/// </summary>
		None,

		/// <summary>
		/// Lỗi dữ liệu đầu vào
		/// </summary>
		ValidationFail,

		/// <summary>
		/// Lỗi nghiệp vụ máy chủ
		/// </summary>
		UnknowLogic,

		/// <summary>
		/// Lỗi xử lý máy chủ
		/// </summary>
		UnknowApi,

		/// <summary>
		/// Lỗi đăng nhập thất bại
		/// </summary>
		LoginFail,

		/// <summary>
		/// Tên đăng nhập người dùng đã tồn tại
		/// </summary>
		Exists,
		/// <summary>
		/// Điều kiện query không tồn tại
		/// </summary>
		QueryNotFound
	}
}

