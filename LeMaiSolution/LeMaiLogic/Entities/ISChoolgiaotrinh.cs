using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolgiaotrinh
	{
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinh từ Database
		/// </summary>
		List<SchoolGiaoTrinh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolGiaoTrinh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolGiaoTrinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolGiaoTrinh từ Database
		/// </summary>
		SchoolGiaoTrinh GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolGiaoTrinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolGiaoTrinh GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolGiaoTrinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolGiaoTrinh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh);
		/// <summary>
		/// Insert danh sách đối tượng SchoolGiaoTrinh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh, String Id);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh);
		/// <summary>
		/// Cập nhật danh sách SchoolGiaoTrinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh, string condition);
		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolGiaoTrinh _SchoolGiaoTrinh);
		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolGiaoTrinh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolGiaoTrinh> _SchoolGiaoTrinhs);
	}
}
