using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictghsv
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictGHSV từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictGHSV từ Database
		/// </summary>
		List<GExpDistrictGHSV> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictGHSV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictGHSV> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictGHSV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictGHSV từ Database
		/// </summary>
		GExpDistrictGHSV GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictGHSV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictGHSV GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictGHSV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictGHSV vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictGHSV _GExpDistrictGHSV);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictGHSV vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs);
		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictGHSV _GExpDistrictGHSV, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictGHSV _GExpDistrictGHSV);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictGHSV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs);
		/// <summary>
		/// Cập nhật GExpDistrictGHSV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictGHSV _GExpDistrictGHSV, string condition);
		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictGHSV _GExpDistrictGHSV);
		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictGHSV trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictGHSV> _GExpDistrictGHSVs);
	}
}
