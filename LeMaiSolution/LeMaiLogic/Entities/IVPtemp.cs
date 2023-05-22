using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVPtemp
	{
		/// <summary>
		/// Lấy một DataTable VPTemp từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VPTemp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VPTemp từ Database
		/// </summary>
		List<VPTemp> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VPTemp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VPTemp> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VPTemp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VPTemp từ Database
		/// </summary>
		VPTemp GetObject(string schema, String ID);
		/// <summary>
		/// Lấy một VPTemp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VPTemp GetObjectCon(string schema, string condition, params Object[] parameters);
		VPTemp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VPTemp vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VPTemp _VPTemp);
		/// <summary>
		/// Insert danh sách đối tượng VPTemp vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VPTemp> _VPTemps);
		/// <summary>
		/// Cập nhật VPTemp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VPTemp _VPTemp, String ID);
		/// <summary>
		/// Cập nhật VPTemp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VPTemp _VPTemp);
		/// <summary>
		/// Cập nhật danh sách VPTemp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VPTemp> _VPTemps);
		/// <summary>
		/// Cập nhật VPTemp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VPTemp _VPTemp, string condition);
		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ID);
		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VPTemp _VPTemp);
		/// <summary>
		/// Xóa VPTemp trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VPTemp trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VPTemp> _VPTemps);
	}
}
