using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpautosign
	{
		/// <summary>
		/// Lấy một DataTable GExpAutoSign từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpAutoSign từ Database
		/// </summary>
		List<GExpAutoSign> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpAutoSign từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpAutoSign> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpAutoSign> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpAutoSign từ Database
		/// </summary>
		GExpAutoSign GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpAutoSign đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpAutoSign GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpAutoSign GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpAutoSign vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpAutoSign _GExpAutoSign);
		/// <summary>
		/// Insert danh sách đối tượng GExpAutoSign vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns);
		/// <summary>
		/// Cập nhật GExpAutoSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpAutoSign _GExpAutoSign, String Id);
		/// <summary>
		/// Cập nhật GExpAutoSign vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpAutoSign _GExpAutoSign);
		/// <summary>
		/// Cập nhật danh sách GExpAutoSign vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns);
		/// <summary>
		/// Cập nhật GExpAutoSign vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpAutoSign _GExpAutoSign, string condition);
		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpAutoSign _GExpAutoSign);
		/// <summary>
		/// Xóa GExpAutoSign trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpAutoSign trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpAutoSign> _GExpAutoSigns);
	}
}
