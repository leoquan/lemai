using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketluanmau
	{
		/// <summary>
		/// Lấy một DataTable MedKetLuanMau từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetLuanMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetLuanMau từ Database
		/// </summary>
		List<MedKetLuanMau> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetLuanMau từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetLuanMau> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetLuanMau> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetLuanMau từ Database
		/// </summary>
		MedKetLuanMau GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetLuanMau đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetLuanMau GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetLuanMau GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetLuanMau vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetLuanMau _MedKetLuanMau);
		/// <summary>
		/// Insert danh sách đối tượng MedKetLuanMau vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus);
		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetLuanMau _MedKetLuanMau, String id);
		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetLuanMau _MedKetLuanMau);
		/// <summary>
		/// Cập nhật danh sách MedKetLuanMau vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus);
		/// <summary>
		/// Cập nhật MedKetLuanMau vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetLuanMau _MedKetLuanMau, string condition);
		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetLuanMau _MedKetLuanMau);
		/// <summary>
		/// Xóa MedKetLuanMau trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetLuanMau trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetLuanMau> _MedKetLuanMaus);
	}
}
