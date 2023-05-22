using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictvnp
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictVNP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictVNP từ Database
		/// </summary>
		List<GExpDistrictVNP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictVNP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictVNP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictVNP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictVNP từ Database
		/// </summary>
		GExpDistrictVNP GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictVNP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictVNP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictVNP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictVNP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictVNP _GExpDistrictVNP);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVNP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs);
		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictVNP _GExpDistrictVNP, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictVNP _GExpDistrictVNP);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictVNP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs);
		/// <summary>
		/// Cập nhật GExpDistrictVNP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictVNP _GExpDistrictVNP, string condition);
		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictVNP _GExpDistrictVNP);
		/// <summary>
		/// Xóa GExpDistrictVNP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictVNP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictVNP> _GExpDistrictVNPs);
	}
}
