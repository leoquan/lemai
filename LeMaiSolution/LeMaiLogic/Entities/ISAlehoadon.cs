using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlehoadon
	{
		/// <summary>
		/// Lấy một DataTable SaleHoaDon từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleHoaDon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleHoaDon từ Database
		/// </summary>
		List<SaleHoaDon> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleHoaDon từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleHoaDon> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleHoaDon> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleHoaDon từ Database
		/// </summary>
		SaleHoaDon GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleHoaDon đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleHoaDon GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleHoaDon GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleHoaDon vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleHoaDon _SaleHoaDon);
		/// <summary>
		/// Insert danh sách đối tượng SaleHoaDon vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons);
		/// <summary>
		/// Cập nhật SaleHoaDon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleHoaDon _SaleHoaDon, String Id);
		/// <summary>
		/// Cập nhật SaleHoaDon vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleHoaDon _SaleHoaDon);
		/// <summary>
		/// Cập nhật danh sách SaleHoaDon vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons);
		/// <summary>
		/// Cập nhật SaleHoaDon vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleHoaDon _SaleHoaDon, string condition);
		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleHoaDon _SaleHoaDon);
		/// <summary>
		/// Xóa SaleHoaDon trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleHoaDon trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleHoaDon> _SaleHoaDons);
	}
}
