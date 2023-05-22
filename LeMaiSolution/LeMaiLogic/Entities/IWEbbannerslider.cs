using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IWEbbannerslider
	{
		/// <summary>
		/// Lấy một DataTable WebBannerSlider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách WebBannerSlider từ Database
		/// </summary>
		List<WebBannerSlider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<WebBannerSlider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<WebBannerSlider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một WebBannerSlider từ Database
		/// </summary>
		WebBannerSlider GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một WebBannerSlider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		WebBannerSlider GetObjectCon(string schema, string condition, params Object[] parameters);
		WebBannerSlider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới WebBannerSlider vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, WebBannerSlider _WebBannerSlider);
		/// <summary>
		/// Insert danh sách đối tượng WebBannerSlider vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders);
		/// <summary>
		/// Cập nhật WebBannerSlider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, WebBannerSlider _WebBannerSlider, String Id);
		/// <summary>
		/// Cập nhật WebBannerSlider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, WebBannerSlider _WebBannerSlider);
		/// <summary>
		/// Cập nhật danh sách WebBannerSlider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders);
		/// <summary>
		/// Cập nhật WebBannerSlider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, WebBannerSlider _WebBannerSlider, string condition);
		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, WebBannerSlider _WebBannerSlider);
		/// <summary>
		/// Xóa WebBannerSlider trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa WebBannerSlider trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<WebBannerSlider> _WebBannerSliders);
	}
}
