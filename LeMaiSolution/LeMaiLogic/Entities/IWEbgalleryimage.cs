using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbgalleryimage
	{
		/// <summary>
		/// Lấy một DataTable WebGalleryImage từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebGalleryImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebGalleryImage từ Database
		/// </summary>
		List<WebGalleryImage> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebGalleryImage từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebGalleryImage> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebGalleryImage> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebGalleryImage từ Database
		/// </summary>
		WebGalleryImage GetObject(string schema, String FK_WebGallery, String FK_WebImage);
		/// <summary>
		/// Lấy một WebGalleryImage đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebGalleryImage GetObjectCon(string schema, string condition, params Object[] parameters);
		WebGalleryImage GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebGalleryImage vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebGalleryImage _WebGalleryImage);
		/// <summary>
		/// Insert danh sách đối tượng WebGalleryImage vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages);
		/// <summary>
		/// Cập nhật WebGalleryImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebGalleryImage _WebGalleryImage, String FK_WebGallery, String FK_WebImage);
		/// <summary>
		/// Cập nhật WebGalleryImage vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebGalleryImage _WebGalleryImage);
		/// <summary>
		/// Cập nhật danh sách WebGalleryImage vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages);
		/// <summary>
		/// Cập nhật WebGalleryImage vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebGalleryImage _WebGalleryImage, string condition);
		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_WebGallery, String FK_WebImage);
		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebGalleryImage _WebGalleryImage);
		/// <summary>
		/// Xóa WebGalleryImage trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebGalleryImage trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebGalleryImage> _WebGalleryImages);
	}
}
