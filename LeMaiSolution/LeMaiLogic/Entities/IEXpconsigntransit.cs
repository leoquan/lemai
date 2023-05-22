using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsigntransit
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignTransit từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignTransit từ Database
		/// </summary>
		List<ExpConsignTransit> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignTransit từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignTransit> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignTransit> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignTransit từ Database
		/// </summary>
		ExpConsignTransit GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignTransit đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignTransit GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignTransit GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignTransit vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignTransit _ExpConsignTransit);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignTransit vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits);
		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignTransit _ExpConsignTransit, String Id);
		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignTransit _ExpConsignTransit);
		/// <summary>
		/// Cập nhật danh sách ExpConsignTransit vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits);
		/// <summary>
		/// Cập nhật ExpConsignTransit vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignTransit _ExpConsignTransit, string condition);
		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignTransit _ExpConsignTransit);
		/// <summary>
		/// Xóa ExpConsignTransit trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignTransit trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignTransit> _ExpConsignTransits);
	}
}
