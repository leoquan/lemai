using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIewroomgroup
	{
		/// <summary>
		/// Lấy một DataTable view_RoomGroup từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable view_RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách view_RoomGroup từ Database
		/// </summary>
		List<view_RoomGroup> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách view_RoomGroup từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<view_RoomGroup> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<view_RoomGroup> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một view_RoomGroup đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		view_RoomGroup GetObjectCon(string schema, string condition, params Object[] parameters);
		view_RoomGroup GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
	}
}
