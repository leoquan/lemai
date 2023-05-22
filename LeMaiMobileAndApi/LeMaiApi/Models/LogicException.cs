using LeMaiDto;
using System.Runtime.Serialization;

namespace LeMaiApi.Models
{
    internal class LogicException : Exception
    {
		public List<ApiError> ListErrors { get; }
        public ApiStatus Status { get; set; } = ApiStatus.LogicError;

        public LogicException(string message) : base(message)
        {
        }

        public LogicException(List<ApiError> errors)
        {
            ListErrors = errors;
        }
    }
}
