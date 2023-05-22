using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISTock
	{
		/// <summary>
		/// Lấy một DataTable Stock từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Stock từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Stock từ Database
		/// </summary>
		List<Stock> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Stock từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Stock> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Stock> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Stock từ Database
		/// </summary>
		Stock GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Stock đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Stock GetObjectCon(string schema, string condition, params Object[] parameters);
		Stock GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Stock vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Stock _Stock);
		/// <summary>
		/// Insert danh sách đối tượng Stock vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Stock> _Stocks);
		/// <summary>
		/// Cập nhật Stock vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Stock _Stock, String Id);
		/// <summary>
		/// Cập nhật Stock vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Stock _Stock);
		/// <summary>
		/// Cập nhật danh sách Stock vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Stock> _Stocks);
		/// <summary>
		/// Cập nhật Stock vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Stock _Stock, string condition);
		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Stock _Stock);
		/// <summary>
		/// Xóa Stock trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Stock trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Stock> _Stocks);
	}
}
