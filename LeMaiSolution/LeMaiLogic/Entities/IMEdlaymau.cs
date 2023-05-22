using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdlaymau
	{
		/// <summary>
		/// Lấy một DataTable MedLayMau từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedLayMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedLayMau từ Database
		/// </summary>
		List<MedLayMau> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedLayMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedLayMau> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedLayMau> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedLayMau từ Database
		/// </summary>
		MedLayMau GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedLayMau đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedLayMau GetObjectCon(string schema, string condition, params Object[] parameters);
		MedLayMau GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedLayMau vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedLayMau _MedLayMau);
		/// <summary>
		/// Insert danh sách đối tượng MedLayMau vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedLayMau> _MedLayMaus);
		/// <summary>
		/// Cập nhật MedLayMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedLayMau _MedLayMau, String id);
		/// <summary>
		/// Cập nhật MedLayMau vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedLayMau _MedLayMau);
		/// <summary>
		/// Cập nhật danh sách MedLayMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedLayMau> _MedLayMaus);
		/// <summary>
		/// Cập nhật MedLayMau vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedLayMau _MedLayMau, string condition);
		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedLayMau _MedLayMau);
		/// <summary>
		/// Xóa MedLayMau trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedLayMau trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedLayMau> _MedLayMaus);
	}
}
