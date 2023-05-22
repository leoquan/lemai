using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincevtp
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceVTP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceVTP từ Database
		/// </summary>
		List<GExpProvinceVTP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceVTP từ Database
		/// </summary>
		GExpProvinceVTP GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceVTP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceVTP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceVTP _GExpProvinceVTP);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceVTP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs);
		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceVTP _GExpProvinceVTP, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceVTP _GExpProvinceVTP);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs);
		/// <summary>
		/// Cập nhật GExpProvinceVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceVTP _GExpProvinceVTP, string condition);
		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceVTP _GExpProvinceVTP);
		/// <summary>
		/// Xóa GExpProvinceVTP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceVTP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceVTP> _GExpProvinceVTPs);
	}
}
