using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolcapbac
	{
		/// <summary>
		/// Lấy một DataTable SchoolCapBac từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolCapBac từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolCapBac từ Database
		/// </summary>
		List<SchoolCapBac> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolCapBac từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolCapBac> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolCapBac> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolCapBac từ Database
		/// </summary>
		SchoolCapBac GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolCapBac đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolCapBac GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolCapBac GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolCapBac vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolCapBac _SchoolCapBac);
		/// <summary>
		/// Insert danh sách đối tượng SchoolCapBac vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs);
		/// <summary>
		/// Cập nhật SchoolCapBac vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolCapBac _SchoolCapBac, String Id);
		/// <summary>
		/// Cập nhật SchoolCapBac vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolCapBac _SchoolCapBac);
		/// <summary>
		/// Cập nhật danh sách SchoolCapBac vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs);
		/// <summary>
		/// Cập nhật SchoolCapBac vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolCapBac _SchoolCapBac, string condition);
		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolCapBac _SchoolCapBac);
		/// <summary>
		/// Xóa SchoolCapBac trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolCapBac trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolCapBac> _SchoolCapBacs);
	}
}
