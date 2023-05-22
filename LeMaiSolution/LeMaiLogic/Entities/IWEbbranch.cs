using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbbranch
	{
		/// <summary>
		/// Lấy một DataTable WebBranch từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebBranch từ Database
		/// </summary>
		List<WebBranch> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebBranch từ Database
		/// </summary>
		WebBranch GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebBranch GetObjectCon(string schema, string condition, params Object[] parameters);
		WebBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebBranch vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebBranch _WebBranch);
		/// <summary>
		/// Insert danh sách đối tượng WebBranch vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebBranch> _WebBranchs);
		/// <summary>
		/// Cập nhật WebBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebBranch _WebBranch, String Id);
		/// <summary>
		/// Cập nhật WebBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebBranch _WebBranch);
		/// <summary>
		/// Cập nhật danh sách WebBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebBranch> _WebBranchs);
		/// <summary>
		/// Cập nhật WebBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebBranch _WebBranch, string condition);
		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebBranch _WebBranch);
		/// <summary>
		/// Xóa WebBranch trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebBranch trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebBranch> _WebBranchs);
	}
}
