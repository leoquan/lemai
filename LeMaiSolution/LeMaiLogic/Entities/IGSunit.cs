using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSunit
	{
		/// <summary>
		/// Lấy một DataTable GsUnit từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsUnit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsUnit từ Database
		/// </summary>
		List<GsUnit> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsUnit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsUnit> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsUnit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsUnit từ Database
		/// </summary>
		GsUnit GetObject(string schema, String ID);
		/// <summary>
		/// Lấy một GsUnit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsUnit GetObjectCon(string schema, string condition, params Object[] parameters);
		GsUnit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsUnit vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsUnit _GsUnit);
		/// <summary>
		/// Insert danh sách đối tượng GsUnit vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsUnit> _GsUnits);
		/// <summary>
		/// Cập nhật GsUnit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsUnit _GsUnit, String ID);
		/// <summary>
		/// Cập nhật GsUnit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsUnit _GsUnit);
		/// <summary>
		/// Cập nhật danh sách GsUnit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsUnit> _GsUnits);
		/// <summary>
		/// Cập nhật GsUnit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsUnit _GsUnit, string condition);
		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String ID);
		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsUnit _GsUnit);
		/// <summary>
		/// Xóa GsUnit trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsUnit trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsUnit> _GsUnits);
	}
}
