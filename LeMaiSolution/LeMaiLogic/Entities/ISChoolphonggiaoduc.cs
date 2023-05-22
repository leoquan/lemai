using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolphonggiaoduc
	{
		/// <summary>
		/// Lấy một DataTable SchoolPhongGiaoDuc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolPhongGiaoDuc từ Database
		/// </summary>
		List<SchoolPhongGiaoDuc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolPhongGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolPhongGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolPhongGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolPhongGiaoDuc từ Database
		/// </summary>
		SchoolPhongGiaoDuc GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolPhongGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolPhongGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolPhongGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolPhongGiaoDuc vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc);
		/// <summary>
		/// Insert danh sách đối tượng SchoolPhongGiaoDuc vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs);
		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc, String Id);
		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc);
		/// <summary>
		/// Cập nhật danh sách SchoolPhongGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs);
		/// <summary>
		/// Cập nhật SchoolPhongGiaoDuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc, string condition);
		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolPhongGiaoDuc _SchoolPhongGiaoDuc);
		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolPhongGiaoDuc trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolPhongGiaoDuc> _SchoolPhongGiaoDucs);
	}
}
