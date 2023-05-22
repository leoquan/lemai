using System.Collections.Generic;

namespace LeMaiDomain
{
	public class ApiResultDto<T> : BaseDto
	{
		public ApiResultDto()
		{
		}
		public ApiResultDto(T data)
		{
			IsOk = true;
			Payload = data;
		}


		public bool IsOk { get; set; }
		/// <summary>
		/// Id lỗi dùng để trace ở server API
		/// </summary>
		public string ErrorId { get; set; }

		/// <summary>
		/// Mã lỗi trả về nếu có. Ngược lại ErrorCode = string.Empty khi kết quả thực hiện thành công.
		/// </summary>
		public ErrorCodeEnum ErrorCode { get; set; }

		/// <summary>
		/// Dữ liệu thực sự của API
		/// </summary>
		public T Payload { get; set; }

		/// <summary>
		/// Nội dung lỗi, empty nếu không có lỗi.
		/// </summary>
        public string ErrorMessage { get; set; }
		public List<AtApiError> ListError { get; set; }
	}

	public class AtApiError
	{
		public string Key { get; set; }
		public ErrorCodeEnum Error { get; set; }
		public string Message { get; set; }
	}
    public class ApiExecuteResult
    {
		public bool Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
}


