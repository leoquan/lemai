using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbnewscategory
	{
		/// <summary>
		/// Lấy một DataTable WebNewsCategory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebNewsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebNewsCategory từ Database
		/// </summary>
		List<WebNewsCategory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebNewsCategory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebNewsCategory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebNewsCategory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebNewsCategory từ Database
		/// </summary>
		WebNewsCategory GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebNewsCategory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebNewsCategory GetObjectCon(string schema, string condition, params Object[] parameters);
		WebNewsCategory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebNewsCategory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebNewsCategory _WebNewsCategory);
		/// <summary>
		/// Insert danh sách đối tượng WebNewsCategory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys);
		/// <summary>
		/// Cập nhật WebNewsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebNewsCategory _WebNewsCategory, String Id);
		/// <summary>
		/// Cập nhật WebNewsCategory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebNewsCategory _WebNewsCategory);
		/// <summary>
		/// Cập nhật danh sách WebNewsCategory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys);
		/// <summary>
		/// Cập nhật WebNewsCategory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebNewsCategory _WebNewsCategory, string condition);
		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebNewsCategory _WebNewsCategory);
		/// <summary>
		/// Xóa WebNewsCategory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebNewsCategory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebNewsCategory> _WebNewsCategorys);
	}
}
