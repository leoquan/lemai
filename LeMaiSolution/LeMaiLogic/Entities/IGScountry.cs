using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGScountry
	{
		/// <summary>
		/// Lấy một DataTable GsCountry từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsCountry từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsCountry từ Database
		/// </summary>
		List<GsCountry> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsCountry từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsCountry> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsCountry> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsCountry từ Database
		/// </summary>
		GsCountry GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsCountry đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsCountry GetObjectCon(string schema, string condition, params Object[] parameters);
		GsCountry GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsCountry vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsCountry _GsCountry);
		/// <summary>
		/// Insert danh sách đối tượng GsCountry vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsCountry> _GsCountrys);
		/// <summary>
		/// Cập nhật GsCountry vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsCountry _GsCountry, String Id);
		/// <summary>
		/// Cập nhật GsCountry vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsCountry _GsCountry);
		/// <summary>
		/// Cập nhật danh sách GsCountry vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsCountry> _GsCountrys);
		/// <summary>
		/// Cập nhật GsCountry vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsCountry _GsCountry, string condition);
		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsCountry _GsCountry);
		/// <summary>
		/// Xóa GsCountry trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsCountry trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsCountry> _GsCountrys);
	}
}
