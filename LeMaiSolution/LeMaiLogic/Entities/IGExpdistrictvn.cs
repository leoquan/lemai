using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictvn
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictVN từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictVN từ Database
		/// </summary>
		List<GExpDistrictVN> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictVN từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictVN> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictVN> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictVN từ Database
		/// </summary>
		GExpDistrictVN GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictVN đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictVN GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictVN GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictVN vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictVN _GExpDistrictVN);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictVN vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs);
		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictVN _GExpDistrictVN, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictVN _GExpDistrictVN);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictVN vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs);
		/// <summary>
		/// Cập nhật GExpDistrictVN vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictVN _GExpDistrictVN, string condition);
		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictVN _GExpDistrictVN);
		/// <summary>
		/// Xóa GExpDistrictVN trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictVN trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictVN> _GExpDistrictVNs);
	}
}
