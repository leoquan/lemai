using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISAlebanggia
	{
		/// <summary>
		/// Lấy một DataTable SaleBangGia từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SaleBangGia từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SaleBangGia từ Database
		/// </summary>
		List<SaleBangGia> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SaleBangGia từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SaleBangGia> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SaleBangGia> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SaleBangGia từ Database
		/// </summary>
		SaleBangGia GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SaleBangGia đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SaleBangGia GetObjectCon(string schema, string condition, params Object[] parameters);
		SaleBangGia GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SaleBangGia vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SaleBangGia _SaleBangGia);
		/// <summary>
		/// Insert danh sách đối tượng SaleBangGia vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SaleBangGia> _SaleBangGias);
		/// <summary>
		/// Cập nhật SaleBangGia vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SaleBangGia _SaleBangGia, String Id);
		/// <summary>
		/// Cập nhật SaleBangGia vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SaleBangGia _SaleBangGia);
		/// <summary>
		/// Cập nhật danh sách SaleBangGia vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SaleBangGia> _SaleBangGias);
		/// <summary>
		/// Cập nhật SaleBangGia vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SaleBangGia _SaleBangGia, string condition);
		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SaleBangGia _SaleBangGia);
		/// <summary>
		/// Xóa SaleBangGia trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SaleBangGia trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SaleBangGia> _SaleBangGias);
	}
}
