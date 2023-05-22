using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGScategory
	{
		/// <summary>
		/// Lấy một DataTable GsCategory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsCategory từ Database
		/// </summary>
		List<GsCategory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsCategory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsCategory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsCategory từ Database
		/// </summary>
		GsCategory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsCategory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsCategory GetObjectCon(string schema, string condition, params Object[] parameters);
		GsCategory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsCategory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsCategory _GsCategory);
		/// <summary>
		/// Insert danh sách đối tượng GsCategory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsCategory> _GsCategorys);
		/// <summary>
		/// Cập nhật GsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsCategory _GsCategory, String Id);
		/// <summary>
		/// Cập nhật GsCategory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsCategory _GsCategory);
		/// <summary>
		/// Cập nhật danh sách GsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsCategory> _GsCategorys);
		/// <summary>
		/// Cập nhật GsCategory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsCategory _GsCategory, string condition);
		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsCategory _GsCategory);
		/// <summary>
		/// Xóa GsCategory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsCategory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsCategory> _GsCategorys);
	}
}
