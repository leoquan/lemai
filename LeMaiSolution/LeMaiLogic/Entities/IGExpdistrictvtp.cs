using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictvtp
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictVTP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictVTP từ Database
		/// </summary>
		List<GExpDistrictVTP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictVTP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictVTP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictVTP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictVTP từ Database
		/// </summary>
		GExpDistrictVTP GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictVTP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictVTP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictVTP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictVTP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictVTP _GExpDistrictVTP);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVTP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs);
		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictVTP _GExpDistrictVTP, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictVTP _GExpDistrictVTP);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictVTP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs);
		/// <summary>
		/// Cập nhật GExpDistrictVTP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictVTP _GExpDistrictVTP, string condition);
		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictVTP _GExpDistrictVTP);
		/// <summary>
		/// Xóa GExpDistrictVTP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictVTP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictVTP> _GExpDistrictVTPs);
	}
}
