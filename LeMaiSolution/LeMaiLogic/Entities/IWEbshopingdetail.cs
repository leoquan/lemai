using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbshopingdetail
	{
		/// <summary>
		/// Lấy một DataTable WebShopingDetail từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebShopingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebShopingDetail từ Database
		/// </summary>
		List<WebShopingDetail> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebShopingDetail từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebShopingDetail> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebShopingDetail> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebShopingDetail từ Database
		/// </summary>
		WebShopingDetail GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebShopingDetail đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebShopingDetail GetObjectCon(string schema, string condition, params Object[] parameters);
		WebShopingDetail GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebShopingDetail vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebShopingDetail _WebShopingDetail);
		/// <summary>
		/// Insert danh sách đối tượng WebShopingDetail vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails);
		/// <summary>
		/// Cập nhật WebShopingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebShopingDetail _WebShopingDetail, String Id);
		/// <summary>
		/// Cập nhật WebShopingDetail vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebShopingDetail _WebShopingDetail);
		/// <summary>
		/// Cập nhật danh sách WebShopingDetail vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails);
		/// <summary>
		/// Cập nhật WebShopingDetail vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebShopingDetail _WebShopingDetail, string condition);
		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebShopingDetail _WebShopingDetail);
		/// <summary>
		/// Xóa WebShopingDetail trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebShopingDetail trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebShopingDetail> _WebShopingDetails);
	}
}
