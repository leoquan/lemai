using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolsogiaoduc
	{
		/// <summary>
		/// Lấy một DataTable SchoolSoGiaoDuc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolSoGiaoDuc từ Database
		/// </summary>
		List<SchoolSoGiaoDuc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolSoGiaoDuc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolSoGiaoDuc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolSoGiaoDuc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolSoGiaoDuc từ Database
		/// </summary>
		SchoolSoGiaoDuc GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolSoGiaoDuc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolSoGiaoDuc GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolSoGiaoDuc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolSoGiaoDuc vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc);
		/// <summary>
		/// Insert danh sách đối tượng SchoolSoGiaoDuc vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs);
		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc, String Id);
		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc);
		/// <summary>
		/// Cập nhật danh sách SchoolSoGiaoDuc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs);
		/// <summary>
		/// Cập nhật SchoolSoGiaoDuc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc, string condition);
		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolSoGiaoDuc _SchoolSoGiaoDuc);
		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolSoGiaoDuc trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolSoGiaoDuc> _SchoolSoGiaoDucs);
	}
}
