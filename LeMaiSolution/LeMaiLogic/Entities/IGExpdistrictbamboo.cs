using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictbamboo
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictBamboo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictBamboo từ Database
		/// </summary>
		List<GExpDistrictBamboo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictBamboo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictBamboo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictBamboo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictBamboo từ Database
		/// </summary>
		GExpDistrictBamboo GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictBamboo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictBamboo GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictBamboo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictBamboo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictBamboo _GExpDistrictBamboo);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictBamboo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictBamboo> _GExpDistrictBamboos);
		/// <summary>
		/// Cập nhật GExpDistrictBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictBamboo _GExpDistrictBamboo, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictBamboo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictBamboo _GExpDistrictBamboo);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictBamboo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictBamboo> _GExpDistrictBamboos);
		/// <summary>
		/// Cập nhật GExpDistrictBamboo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictBamboo _GExpDistrictBamboo, string condition);
		/// <summary>
		/// Xóa GExpDistrictBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictBamboo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictBamboo _GExpDistrictBamboo);
		/// <summary>
		/// Xóa GExpDistrictBamboo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictBamboo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictBamboo> _GExpDistrictBamboos);
	}
}
