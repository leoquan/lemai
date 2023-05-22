using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISErvicecombo
	{
		/// <summary>
		/// Lấy một DataTable ServiceCombo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ServiceCombo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ServiceCombo từ Database
		/// </summary>
		List<ServiceCombo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ServiceCombo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ServiceCombo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ServiceCombo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ServiceCombo từ Database
		/// </summary>
		ServiceCombo GetObject(string schema, String FK_ComboService, String FK_ServiceBelong);
		/// <summary>
		/// Lấy một ServiceCombo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ServiceCombo GetObjectCon(string schema, string condition, params Object[] parameters);
		ServiceCombo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ServiceCombo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ServiceCombo _ServiceCombo);
		/// <summary>
		/// Insert danh sách đối tượng ServiceCombo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ServiceCombo> _ServiceCombos);
		/// <summary>
		/// Cập nhật ServiceCombo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ServiceCombo _ServiceCombo, String FK_ComboService, String FK_ServiceBelong);
		/// <summary>
		/// Cập nhật ServiceCombo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ServiceCombo _ServiceCombo);
		/// <summary>
		/// Cập nhật danh sách ServiceCombo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ServiceCombo> _ServiceCombos);
		/// <summary>
		/// Cập nhật ServiceCombo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ServiceCombo _ServiceCombo, string condition);
		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ComboService, String FK_ServiceBelong);
		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ServiceCombo _ServiceCombo);
		/// <summary>
		/// Xóa ServiceCombo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ServiceCombo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ServiceCombo> _ServiceCombos);
	}
}
