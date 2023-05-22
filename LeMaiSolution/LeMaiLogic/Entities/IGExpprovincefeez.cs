using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincefeez
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceFeeZ từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceFeeZ từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceFeeZ từ Database
		/// </summary>
		List<GExpProvinceFeeZ> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceFeeZ từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceFeeZ> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceFeeZ> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceFeeZ từ Database
		/// </summary>
		GExpProvinceFeeZ GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProvinceFeeZ đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceFeeZ GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceFeeZ GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceFeeZ vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceFeeZ vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs);
		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ, String Id);
		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceFeeZ vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs);
		/// <summary>
		/// Cập nhật GExpProvinceFeeZ vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ, string condition);
		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceFeeZ _GExpProvinceFeeZ);
		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceFeeZ trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceFeeZ> _GExpProvinceFeeZs);
	}
}
