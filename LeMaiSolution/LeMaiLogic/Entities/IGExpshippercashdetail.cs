using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpshippercashdetail
	{
		/// <summary>
		/// Lấy một DataTable GExpShipperCashDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpShipperCashDetail từ Database
		/// </summary>
		List<GExpShipperCashDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpShipperCashDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpShipperCashDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpShipperCashDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpShipperCashDetail từ Database
		/// </summary>
		GExpShipperCashDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpShipperCashDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpShipperCashDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpShipperCashDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpShipperCashDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpShipperCashDetail _GExpShipperCashDetail);
		/// <summary>
		/// Insert danh sách đối tượng GExpShipperCashDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails);
		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpShipperCashDetail _GExpShipperCashDetail, String Id);
		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpShipperCashDetail _GExpShipperCashDetail);
		/// <summary>
		/// Cập nhật danh sách GExpShipperCashDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails);
		/// <summary>
		/// Cập nhật GExpShipperCashDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpShipperCashDetail _GExpShipperCashDetail, string condition);
		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpShipperCashDetail _GExpShipperCashDetail);
		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpShipperCashDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpShipperCashDetail> _GExpShipperCashDetails);
	}
}
