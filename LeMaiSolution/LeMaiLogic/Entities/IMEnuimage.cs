using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEnuimage
	{
		/// <summary>
		/// Lấy một DataTable MenuImage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MenuImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MenuImage từ Database
		/// </summary>
		List<MenuImage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MenuImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MenuImage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MenuImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MenuImage từ Database
		/// </summary>
		MenuImage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MenuImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MenuImage GetObjectCon(string schema, string condition, params Object[] parameters);
		MenuImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MenuImage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MenuImage _MenuImage);
		/// <summary>
		/// Insert danh sách đối tượng MenuImage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MenuImage> _MenuImages);
		/// <summary>
		/// Cập nhật MenuImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MenuImage _MenuImage, String Id);
		/// <summary>
		/// Cập nhật MenuImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MenuImage _MenuImage);
		/// <summary>
		/// Cập nhật danh sách MenuImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MenuImage> _MenuImages);
		/// <summary>
		/// Cập nhật MenuImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MenuImage _MenuImage, string condition);
		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MenuImage _MenuImage);
		/// <summary>
		/// Xóa MenuImage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MenuImage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MenuImage> _MenuImages);
	}
}
