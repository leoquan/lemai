using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbpartner
	{
		/// <summary>
		/// Lấy một DataTable WebPartner từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebPartner từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebPartner từ Database
		/// </summary>
		List<WebPartner> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebPartner từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebPartner> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebPartner> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebPartner từ Database
		/// </summary>
		WebPartner GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebPartner đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebPartner GetObjectCon(string schema, string condition, params Object[] parameters);
		WebPartner GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebPartner vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebPartner _WebPartner);
		/// <summary>
		/// Insert danh sách đối tượng WebPartner vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebPartner> _WebPartners);
		/// <summary>
		/// Cập nhật WebPartner vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebPartner _WebPartner, String Id);
		/// <summary>
		/// Cập nhật WebPartner vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebPartner _WebPartner);
		/// <summary>
		/// Cập nhật danh sách WebPartner vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebPartner> _WebPartners);
		/// <summary>
		/// Cập nhật WebPartner vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebPartner _WebPartner, string condition);
		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebPartner _WebPartner);
		/// <summary>
		/// Xóa WebPartner trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebPartner trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebPartner> _WebPartners);
	}
}
