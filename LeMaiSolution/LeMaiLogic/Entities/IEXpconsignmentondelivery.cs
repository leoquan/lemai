using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentondelivery
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentOnDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentOnDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentOnDelivery từ Database
		/// </summary>
		List<ExpConsignmentOnDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentOnDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentOnDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentOnDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentOnDelivery từ Database
		/// </summary>
		ExpConsignmentOnDelivery GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentOnDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentOnDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentOnDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentOnDelivery vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentOnDelivery vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys);
		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentOnDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys);
		/// <summary>
		/// Cập nhật ExpConsignmentOnDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery, string condition);
		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentOnDelivery _ExpConsignmentOnDelivery);
		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentOnDelivery trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentOnDelivery> _ExpConsignmentOnDeliverys);
	}
}
