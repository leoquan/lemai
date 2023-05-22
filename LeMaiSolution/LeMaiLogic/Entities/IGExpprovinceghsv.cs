using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovinceghsv
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceGHSV từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceGHSV từ Database
		/// </summary>
		List<GExpProvinceGHSV> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceGHSV từ Database
		/// </summary>
		GExpProvinceGHSV GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceGHSV GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceGHSV vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceGHSV _GExpProvinceGHSV);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceGHSV vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs);
		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceGHSV _GExpProvinceGHSV, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceGHSV _GExpProvinceGHSV);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs);
		/// <summary>
		/// Cập nhật GExpProvinceGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceGHSV _GExpProvinceGHSV, string condition);
		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceGHSV _GExpProvinceGHSV);
		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceGHSV trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceGHSV> _GExpProvinceGHSVs);
	}
}
