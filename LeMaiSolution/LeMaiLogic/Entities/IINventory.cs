using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IINventory
	{
		/// <summary>
		/// Lấy một DataTable Inventory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Inventory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Inventory từ Database
		/// </summary>
		List<Inventory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Inventory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Inventory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Inventory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Inventory từ Database
		/// </summary>
		Inventory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Inventory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Inventory GetObjectCon(string schema, string condition, params Object[] parameters);
		Inventory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Inventory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Inventory _Inventory);
		/// <summary>
		/// Insert danh sách đối tượng Inventory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Inventory> _Inventorys);
		/// <summary>
		/// Cập nhật Inventory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Inventory _Inventory, String Id);
		/// <summary>
		/// Cập nhật Inventory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Inventory _Inventory);
		/// <summary>
		/// Cập nhật danh sách Inventory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Inventory> _Inventorys);
		/// <summary>
		/// Cập nhật Inventory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Inventory _Inventory, string condition);
		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Inventory _Inventory);
		/// <summary>
		/// Xóa Inventory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Inventory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Inventory> _Inventorys);
	}
}
