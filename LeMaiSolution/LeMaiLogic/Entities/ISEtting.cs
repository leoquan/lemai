using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISEtting
	{
		/// <summary>
		/// Lấy một DataTable Setting từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable Setting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách Setting từ Database
		/// </summary>
		List<Setting> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách Setting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<Setting> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<Setting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một Setting từ Database
		/// </summary>
		Setting GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một Setting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		Setting GetObjectCon(string schema, string condition, params Object[] parameters);
		Setting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới Setting vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, Setting _Setting);
		/// <summary>
		/// Insert danh sách đối tượng Setting vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<Setting> _Settings);
		/// <summary>
		/// Cập nhật Setting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, Setting _Setting, String Id);
		/// <summary>
		/// Cập nhật Setting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, Setting _Setting);
		/// <summary>
		/// Cập nhật danh sách Setting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<Setting> _Settings);
		/// <summary>
		/// Cập nhật Setting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, Setting _Setting, string condition);
		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Setting _Setting);
		/// <summary>
		/// Xóa Setting trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa Setting trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<Setting> _Settings);
	}
}
