using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbgallery
	{
		/// <summary>
		/// Lấy một DataTable WebGallery từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebGallery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebGallery từ Database
		/// </summary>
		List<WebGallery> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebGallery từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebGallery> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebGallery> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebGallery từ Database
		/// </summary>
		WebGallery GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebGallery đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebGallery GetObjectCon(string schema, string condition, params Object[] parameters);
		WebGallery GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebGallery vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebGallery _WebGallery);
		/// <summary>
		/// Insert danh sách đối tượng WebGallery vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebGallery> _WebGallerys);
		/// <summary>
		/// Cập nhật WebGallery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebGallery _WebGallery, String Id);
		/// <summary>
		/// Cập nhật WebGallery vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebGallery _WebGallery);
		/// <summary>
		/// Cập nhật danh sách WebGallery vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebGallery> _WebGallerys);
		/// <summary>
		/// Cập nhật WebGallery vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebGallery _WebGallery, string condition);
		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebGallery _WebGallery);
		/// <summary>
		/// Xóa WebGallery trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebGallery trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebGallery> _WebGallerys);
	}
}
