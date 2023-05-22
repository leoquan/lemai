using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsigndelivery
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignDelivery từ Database
		/// </summary>
		List<ExpConsignDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignDelivery từ Database
		/// </summary>
		ExpConsignDelivery GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignDelivery vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignDelivery _ExpConsignDelivery);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignDelivery vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys);
		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignDelivery _ExpConsignDelivery, String Id);
		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignDelivery _ExpConsignDelivery);
		/// <summary>
		/// Cập nhật danh sách ExpConsignDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys);
		/// <summary>
		/// Cập nhật ExpConsignDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignDelivery _ExpConsignDelivery, string condition);
		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignDelivery _ExpConsignDelivery);
		/// <summary>
		/// Xóa ExpConsignDelivery trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignDelivery trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignDelivery> _ExpConsignDeliverys);
	}
}
