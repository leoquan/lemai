using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChoolgiaotrinhhocphan
	{
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		List<SchoolGiaoTrinhHocPhan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolGiaoTrinhHocPhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolGiaoTrinhHocPhan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolGiaoTrinhHocPhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolGiaoTrinhHocPhan từ Database
		/// </summary>
		SchoolGiaoTrinhHocPhan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolGiaoTrinhHocPhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolGiaoTrinhHocPhan GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolGiaoTrinhHocPhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolGiaoTrinhHocPhan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan);
		/// <summary>
		/// Insert danh sách đối tượng SchoolGiaoTrinhHocPhan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan, String Id);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan);
		/// <summary>
		/// Cập nhật danh sách SchoolGiaoTrinhHocPhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans);
		/// <summary>
		/// Cập nhật SchoolGiaoTrinhHocPhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan, string condition);
		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolGiaoTrinhHocPhan _SchoolGiaoTrinhHocPhan);
		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolGiaoTrinhHocPhan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolGiaoTrinhHocPhan> _SchoolGiaoTrinhHocPhans);
	}
}
