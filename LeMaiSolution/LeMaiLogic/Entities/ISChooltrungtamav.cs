using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISChooltrungtamav
	{
		/// <summary>
		/// Lấy một DataTable SchoolTrungTamAV từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SchoolTrungTamAV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SchoolTrungTamAV từ Database
		/// </summary>
		List<SchoolTrungTamAV> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SchoolTrungTamAV từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SchoolTrungTamAV> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SchoolTrungTamAV> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SchoolTrungTamAV từ Database
		/// </summary>
		SchoolTrungTamAV GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SchoolTrungTamAV đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SchoolTrungTamAV GetObjectCon(string schema, string condition, params Object[] parameters);
		SchoolTrungTamAV GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SchoolTrungTamAV vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SchoolTrungTamAV _SchoolTrungTamAV);
		/// <summary>
		/// Insert danh sách đối tượng SchoolTrungTamAV vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs);
		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SchoolTrungTamAV _SchoolTrungTamAV, String Id);
		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SchoolTrungTamAV _SchoolTrungTamAV);
		/// <summary>
		/// Cập nhật danh sách SchoolTrungTamAV vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs);
		/// <summary>
		/// Cập nhật SchoolTrungTamAV vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SchoolTrungTamAV _SchoolTrungTamAV, string condition);
		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SchoolTrungTamAV _SchoolTrungTamAV);
		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SchoolTrungTamAV trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SchoolTrungTamAV> _SchoolTrungTamAVs);
	}
}
