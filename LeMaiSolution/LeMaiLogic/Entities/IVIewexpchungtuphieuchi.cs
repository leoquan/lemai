using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpchungtuphieuchi
	{
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuPhieuChi từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpChungTuPhieuChi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuPhieuChi từ Database
		/// </summary>
		List<view_ExpChungTuPhieuChi> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpChungTuPhieuChi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpChungTuPhieuChi> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpChungTuPhieuChi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpChungTuPhieuChi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpChungTuPhieuChi GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpChungTuPhieuChi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
