using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpbillhoadondoisoat
	{
		/// <summary>
		/// Lấy một DataTable view_ExpBillHoaDonDoiSoat từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpBillHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpBillHoaDonDoiSoat từ Database
		/// </summary>
		List<view_ExpBillHoaDonDoiSoat> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpBillHoaDonDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpBillHoaDonDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpBillHoaDonDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpBillHoaDonDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpBillHoaDonDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpBillHoaDonDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
