using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeMaiApi.Models
{
	internal static class ExceptionHelpers
	{
		public static string NewErrorId()
		{
			return $"{DateTime.UtcNow.ToString("ddMMyy_HHmmss")}_{Guid.NewGuid().ToString().Substring(0, 8)}";
		}

		public static string GetMessage(in string errorId, in string message)
		{
			return $"Error Id: {errorId} | {message}";
		}
	}
}

