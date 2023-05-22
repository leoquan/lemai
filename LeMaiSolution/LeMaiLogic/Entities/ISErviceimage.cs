using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISErviceimage
	{
		/// <summary>
		/// Lấy một DataTable ServiceImage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ServiceImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ServiceImage từ Database
		/// </summary>
		List<ServiceImage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ServiceImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ServiceImage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ServiceImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ServiceImage từ Database
		/// </summary>
		ServiceImage GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ServiceImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ServiceImage GetObjectCon(string schema, string condition, params Object[] parameters);
		ServiceImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ServiceImage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ServiceImage _ServiceImage);
		/// <summary>
		/// Insert danh sách đối tượng ServiceImage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ServiceImage> _ServiceImages);
		/// <summary>
		/// Cập nhật ServiceImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ServiceImage _ServiceImage, String Id);
		/// <summary>
		/// Cập nhật ServiceImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ServiceImage _ServiceImage);
		/// <summary>
		/// Cập nhật danh sách ServiceImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ServiceImage> _ServiceImages);
		/// <summary>
		/// Cập nhật ServiceImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ServiceImage _ServiceImage, string condition);
		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ServiceImage _ServiceImage);
		/// <summary>
		/// Xóa ServiceImage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ServiceImage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ServiceImage> _ServiceImages);
	}
}
