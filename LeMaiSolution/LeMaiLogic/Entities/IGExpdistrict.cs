using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrict
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrict từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrict từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrict từ Database
		/// </summary>
		List<GExpDistrict> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrict từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrict> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrict> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrict từ Database
		/// </summary>
		GExpDistrict GetObject(string schema, Int32 DistrictID);
		/// <summary>
		/// Lấy một GExpDistrict đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrict GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrict GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrict vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrict _GExpDistrict);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrict vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrict> _GExpDistricts);
		/// <summary>
		/// Cập nhật GExpDistrict vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrict _GExpDistrict, Int32 DistrictID);
		/// <summary>
		/// Cập nhật GExpDistrict vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrict _GExpDistrict);
		/// <summary>
		/// Cập nhật danh sách GExpDistrict vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrict> _GExpDistricts);
		/// <summary>
		/// Cập nhật GExpDistrict vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrict _GExpDistrict, string condition);
		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 DistrictID);
		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrict _GExpDistrict);
		/// <summary>
		/// Xóa GExpDistrict trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrict trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrict> _GExpDistricts);
	}
}
