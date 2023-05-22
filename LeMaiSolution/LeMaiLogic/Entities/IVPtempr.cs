using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVPtempr
	{
		/// <summary>
		/// Lấy một DataTable VPTempR từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VPTempR từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VPTempR từ Database
		/// </summary>
		List<VPTempR> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VPTempR từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VPTempR> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VPTempR> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VPTempR từ Database
		/// </summary>
		VPTempR GetObject(string schema, String ID);
		/// <summary>
		/// Lấy một VPTempR đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VPTempR GetObjectCon(string schema, string condition, params Object[] parameters);
		VPTempR GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VPTempR vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VPTempR _VPTempR);
		/// <summary>
		/// Insert danh sách đối tượng VPTempR vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VPTempR> _VPTempRs);
		/// <summary>
		/// Cập nhật VPTempR vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VPTempR _VPTempR, String ID);
		/// <summary>
		/// Cập nhật VPTempR vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VPTempR _VPTempR);
		/// <summary>
		/// Cập nhật danh sách VPTempR vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VPTempR> _VPTempRs);
		/// <summary>
		/// Cập nhật VPTempR vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VPTempR _VPTempR, string condition);
		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ID);
		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VPTempR _VPTempR);
		/// <summary>
		/// Xóa VPTempR trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VPTempR trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VPTempR> _VPTempRs);
	}
}
