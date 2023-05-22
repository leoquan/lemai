using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincevnp
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceVNP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceVNP từ Database
		/// </summary>
		List<GExpProvinceVNP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceVNP từ Database
		/// </summary>
		GExpProvinceVNP GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceVNP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceVNP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceVNP _GExpProvinceVNP);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVNP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs);
		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceVNP _GExpProvinceVNP, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceVNP _GExpProvinceVNP);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs);
		/// <summary>
		/// Cập nhật GExpProvinceVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceVNP _GExpProvinceVNP, string condition);
		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceVNP _GExpProvinceVNP);
		/// <summary>
		/// Xóa GExpProvinceVNP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceVNP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceVNP> _GExpProvinceVNPs);
	}
}
