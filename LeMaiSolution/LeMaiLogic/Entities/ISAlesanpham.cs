using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlesanpham
	{
		/// <summary>
		/// Lấy một DataTable SaleSanPham từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleSanPham từ Database
		/// </summary>
		List<SaleSanPham> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleSanPham từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleSanPham> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleSanPham> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleSanPham từ Database
		/// </summary>
		SaleSanPham GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleSanPham đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleSanPham GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleSanPham GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleSanPham vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleSanPham _SaleSanPham);
		/// <summary>
		/// Insert danh sách đối tượng SaleSanPham vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams);
		/// <summary>
		/// Cập nhật SaleSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleSanPham _SaleSanPham, String Id);
		/// <summary>
		/// Cập nhật SaleSanPham vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleSanPham _SaleSanPham);
		/// <summary>
		/// Cập nhật danh sách SaleSanPham vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams);
		/// <summary>
		/// Cập nhật SaleSanPham vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleSanPham _SaleSanPham, string condition);
		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleSanPham _SaleSanPham);
		/// <summary>
		/// Xóa SaleSanPham trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleSanPham trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleSanPham> _SaleSanPhams);
	}
}
