using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovince
	{
		/// <summary>
		/// Lấy một DataTable GExpProvince từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvince từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvince từ Database
		/// </summary>
		List<GExpProvince> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvince từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvince> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvince> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvince từ Database
		/// </summary>
		GExpProvince GetObject(string schema, Int32 ProvinceID);
		/// <summary>
		/// Lấy một GExpProvince đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvince GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvince GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvince vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvince _GExpProvince);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvince vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvince> _GExpProvinces);
		/// <summary>
		/// Cập nhật GExpProvince vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvince _GExpProvince, Int32 ProvinceID);
		/// <summary>
		/// Cập nhật GExpProvince vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvince _GExpProvince);
		/// <summary>
		/// Cập nhật danh sách GExpProvince vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvince> _GExpProvinces);
		/// <summary>
		/// Cập nhật GExpProvince vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvince _GExpProvince, string condition);
		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 ProvinceID);
		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvince _GExpProvince);
		/// <summary>
		/// Xóa GExpProvince trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvince trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvince> _GExpProvinces);
	}
}
