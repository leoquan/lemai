using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIhcle
	{
		/// <summary>
		/// Lấy một DataTable Vihcle từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Vihcle từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Vihcle từ Database
		/// </summary>
		List<Vihcle> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Vihcle từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Vihcle> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Vihcle> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Vihcle từ Database
		/// </summary>
		Vihcle GetObject(string schema, String BienSo);
		/// <summary>
		/// Lấy một Vihcle đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Vihcle GetObjectCon(string schema, string condition, params Object[] parameters);
		Vihcle GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Vihcle vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Vihcle _Vihcle);
		/// <summary>
		/// Insert danh sách đối tượng Vihcle vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Vihcle> _Vihcles);
		/// <summary>
		/// Cập nhật Vihcle vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Vihcle _Vihcle, String BienSo);
		/// <summary>
		/// Cập nhật Vihcle vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Vihcle _Vihcle);
		/// <summary>
		/// Cập nhật danh sách Vihcle vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Vihcle> _Vihcles);
		/// <summary>
		/// Cập nhật Vihcle vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Vihcle _Vihcle, string condition);
		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BienSo);
		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Vihcle _Vihcle);
		/// <summary>
		/// Xóa Vihcle trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Vihcle trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Vihcle> _Vihcles);
	}
}
