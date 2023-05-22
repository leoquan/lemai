using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCkettoan
	{
		/// <summary>
		/// Lấy một DataTable VCKetToan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCKetToan từ Database
		/// </summary>
		List<VCKetToan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCKetToan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCKetToan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCKetToan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCKetToan từ Database
		/// </summary>
		VCKetToan GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCKetToan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCKetToan GetObjectCon(string schema, string condition, params Object[] parameters);
		VCKetToan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCKetToan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCKetToan _VCKetToan);
		/// <summary>
		/// Insert danh sách đối tượng VCKetToan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCKetToan> _VCKetToans);
		/// <summary>
		/// Cập nhật VCKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCKetToan _VCKetToan, String Id);
		/// <summary>
		/// Cập nhật VCKetToan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCKetToan _VCKetToan);
		/// <summary>
		/// Cập nhật danh sách VCKetToan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCKetToan> _VCKetToans);
		/// <summary>
		/// Cập nhật VCKetToan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCKetToan _VCKetToan, string condition);
		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCKetToan _VCKetToan);
		/// <summary>
		/// Xóa VCKetToan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCKetToan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCKetToan> _VCKetToans);
	}
}
