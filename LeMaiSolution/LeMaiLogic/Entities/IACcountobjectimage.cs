using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectimage
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectImage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectImage từ Database
		/// </summary>
		List<AccountObjectImage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectImage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectImage từ Database
		/// </summary>
		AccountObjectImage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một AccountObjectImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectImage GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectImage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectImage _AccountObjectImage);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectImage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages);
		/// <summary>
		/// Cập nhật AccountObjectImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectImage _AccountObjectImage, String Id);
		/// <summary>
		/// Cập nhật AccountObjectImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectImage _AccountObjectImage);
		/// <summary>
		/// Cập nhật danh sách AccountObjectImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages);
		/// <summary>
		/// Cập nhật AccountObjectImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectImage _AccountObjectImage, string condition);
		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectImage _AccountObjectImage);
		/// <summary>
		/// Xóa AccountObjectImage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectImage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectImage> _AccountObjectImages);
	}
}
