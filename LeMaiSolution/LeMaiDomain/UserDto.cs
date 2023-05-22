using System.Collections.Generic;

namespace LeMaiDomain
{
	public class UserDto : BaseDto
	{
		public string Id { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public string Phone { get; set; }
		public string Avatar { get; set; }
		public List<RoleDto> ListRole { get; set; }
	}
	public class UpdateProfileInput
	{
		public string AtLastModifiedBy { get; set; }
		public string FullName { get; set; }
		public string Phone { get; set; }
		public string AtRowVersion { get; set; }
		public string Id { get; set; }
		public string Email { get; set; }
	}
}
