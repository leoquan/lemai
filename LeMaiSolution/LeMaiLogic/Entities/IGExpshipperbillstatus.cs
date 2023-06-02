using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpshipperbillstatus
	{
		/// <summary>
		/// Lấy một DataTable GExpShipperBillStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpShipperBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpShipperBillStatus từ Database
		/// </summary>
		List<GExpShipperBillStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpShipperBillStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpShipperBillStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpShipperBillStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpShipperBillStatus từ Database
		/// </summary>
		GExpShipperBillStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một GExpShipperBillStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpShipperBillStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpShipperBillStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpShipperBillStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpShipperBillStatus _GExpShipperBillStatus);
		/// <summary>
		/// Insert danh sách đối tượng GExpShipperBillStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss);
		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpShipperBillStatus _GExpShipperBillStatus, Int32 Id);
		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpShipperBillStatus _GExpShipperBillStatus);
		/// <summary>
		/// Cập nhật danh sách GExpShipperBillStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss);
		/// <summary>
		/// Cập nhật GExpShipperBillStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpShipperBillStatus _GExpShipperBillStatus, string condition);
		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpShipperBillStatus _GExpShipperBillStatus);
		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpShipperBillStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpShipperBillStatus> _GExpShipperBillStatuss);
	}
}
