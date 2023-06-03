using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIhcleservice
	{
		/// <summary>
		/// Lấy một DataTable VihcleService từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VihcleService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VihcleService từ Database
		/// </summary>
		List<VihcleService> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VihcleService từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VihcleService> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VihcleService> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VihcleService từ Database
		/// </summary>
		VihcleService GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VihcleService đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VihcleService GetObjectCon(string schema, string condition, params Object[] parameters);
		VihcleService GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VihcleService vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VihcleService _VihcleService);
		/// <summary>
		/// Insert danh sách đối tượng VihcleService vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VihcleService> _VihcleServices);
		/// <summary>
		/// Cập nhật VihcleService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VihcleService _VihcleService, String Id);
		/// <summary>
		/// Cập nhật VihcleService vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VihcleService _VihcleService);
		/// <summary>
		/// Cập nhật danh sách VihcleService vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VihcleService> _VihcleServices);
		/// <summary>
		/// Cập nhật VihcleService vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VihcleService _VihcleService, string condition);
		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VihcleService _VihcleService);
		/// <summary>
		/// Xóa VihcleService trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VihcleService trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VihcleService> _VihcleServices);
	}
}
