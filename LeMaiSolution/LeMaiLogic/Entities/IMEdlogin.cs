using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdlogin
	{
		/// <summary>
		/// Lấy một DataTable MedLogin từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedLogin từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedLogin từ Database
		/// </summary>
		List<MedLogin> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedLogin từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedLogin> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedLogin> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedLogin từ Database
		/// </summary>
		MedLogin GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedLogin đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedLogin GetObjectCon(string schema, string condition, params Object[] parameters);
		MedLogin GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedLogin vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedLogin _MedLogin);
		/// <summary>
		/// Insert danh sách đối tượng MedLogin vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedLogin> _MedLogins);
		/// <summary>
		/// Cập nhật MedLogin vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedLogin _MedLogin, String id);
		/// <summary>
		/// Cập nhật MedLogin vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedLogin _MedLogin);
		/// <summary>
		/// Cập nhật danh sách MedLogin vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedLogin> _MedLogins);
		/// <summary>
		/// Cập nhật MedLogin vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedLogin _MedLogin, string condition);
		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedLogin _MedLogin);
		/// <summary>
		/// Xóa MedLogin trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedLogin trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedLogin> _MedLogins);
	}
}
