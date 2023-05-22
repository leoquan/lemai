using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace LeMaiApi.Models
{
	/// <summary>
	/// Lỗi logic
	/// </summary>
	internal class LogicException : Exception
	{
		/// <summary>
		/// Lỗi logic
		/// </summary>
		/// <param name="errorCode"></param>
		public LogicException(ErrorCodeEnum errorCode) : base(errorCode.ToString())
		{
			ErrorCode = errorCode;
		}
		/// <summary>
		/// Lỗi logic
		/// </summary>
		/// <param name="errorCode"></param>
		/// <param name="innerException"></param>
		public LogicException(ErrorCodeEnum errorCode, Exception innerException) : base(errorCode.ToString(), innerException)
		{
			ErrorCode = errorCode;
		}

		/// <summary>
		/// Lỗi logic
		/// </summary>
		/// <param name="errorCode"></param>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LogicException(ErrorCodeEnum errorCode, SerializationInfo info, StreamingContext context) : base(info, context)
		{
			ErrorCode = errorCode;
		}

		/// <summary>
		/// Mã lỗi
		/// </summary>
		public ErrorCodeEnum ErrorCode { get; private set; }


	}
}

