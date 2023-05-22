using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSccy
	{
		/// <summary>
		/// Lấy một DataTable GsCCY từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsCCY từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsCCY từ Database
		/// </summary>
		List<GsCCY> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsCCY từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsCCY> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsCCY> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsCCY từ Database
		/// </summary>
		GsCCY GetObject(string schema, String Code);
		/// <summary>
		/// Lấy một GsCCY đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsCCY GetObjectCon(string schema, string condition, params Object[] parameters);
		GsCCY GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsCCY vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsCCY _GsCCY);
		/// <summary>
		/// Insert danh sách đối tượng GsCCY vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsCCY> _GsCCYs);
		/// <summary>
		/// Cập nhật GsCCY vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsCCY _GsCCY, String Code);
		/// <summary>
		/// Cập nhật GsCCY vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsCCY _GsCCY);
		/// <summary>
		/// Cập nhật danh sách GsCCY vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsCCY> _GsCCYs);
		/// <summary>
		/// Cập nhật GsCCY vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsCCY _GsCCY, string condition);
		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Code);
		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsCCY _GsCCY);
		/// <summary>
		/// Xóa GsCCY trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsCCY trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsCCY> _GsCCYs);
	}
}
