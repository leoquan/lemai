using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscandelivery
	{
		/// <summary>
		/// Lấy một DataTable GExpScanDelivery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanDelivery từ Database
		/// </summary>
		List<GExpScanDelivery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanDelivery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanDelivery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanDelivery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanDelivery từ Database
		/// </summary>
		GExpScanDelivery GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanDelivery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanDelivery GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanDelivery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanDelivery vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanDelivery _GExpScanDelivery);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanDelivery vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys);
		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanDelivery _GExpScanDelivery, String Id);
		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanDelivery _GExpScanDelivery);
		/// <summary>
		/// Cập nhật danh sách GExpScanDelivery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys);
		/// <summary>
		/// Cập nhật GExpScanDelivery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanDelivery _GExpScanDelivery, string condition);
		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanDelivery _GExpScanDelivery);
		/// <summary>
		/// Xóa GExpScanDelivery trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanDelivery trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanDelivery> _GExpScanDeliverys);
	}
}
