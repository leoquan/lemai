using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewwebbannerslider
	{
		/// <summary>
		/// Lấy một DataTable view_WebBannerSlider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_WebBannerSlider từ Database
		/// </summary>
		List<view_WebBannerSlider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_WebBannerSlider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_WebBannerSlider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_WebBannerSlider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_WebBannerSlider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_WebBannerSlider GetObjectCon(string schema, string condition, params Object[] parameters);
		view_WebBannerSlider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
