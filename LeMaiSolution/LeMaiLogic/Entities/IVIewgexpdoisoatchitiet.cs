using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewgexpdoisoatchitiet
	{
		/// <summary>
		/// Lấy một DataTable view_GExpDoiSoatChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_GExpDoiSoatChiTiet từ Database
		/// </summary>
		List<view_GExpDoiSoatChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_GExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_GExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_GExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_GExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		view_GExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
