using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewexpconsignmenthistorymater
	{
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistoryMater từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_ExpConsignmentHistoryMater từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentHistoryMater từ Database
		/// </summary>
		List<view_ExpConsignmentHistoryMater> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_ExpConsignmentHistoryMater từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_ExpConsignmentHistoryMater> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_ExpConsignmentHistoryMater> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_ExpConsignmentHistoryMater đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_ExpConsignmentHistoryMater GetObjectCon(string schema, string condition, params Object[] parameters);
		view_ExpConsignmentHistoryMater GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
