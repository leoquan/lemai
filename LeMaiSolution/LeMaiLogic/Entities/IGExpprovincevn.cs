using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincevn
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceVN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceVN từ Database
		/// </summary>
		List<GExpProvinceVN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceVN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceVN từ Database
		/// </summary>
		GExpProvinceVN GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceVN GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceVN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceVN _GExpProvinceVN);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs);
		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceVN _GExpProvinceVN, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceVN _GExpProvinceVN);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs);
		/// <summary>
		/// Cập nhật GExpProvinceVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceVN _GExpProvinceVN, string condition);
		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceVN _GExpProvinceVN);
		/// <summary>
		/// Xóa GExpProvinceVN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceVN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceVN> _GExpProvinceVNs);
	}
}
