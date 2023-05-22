using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdworkspace
	{
		/// <summary>
		/// Lấy một DataTable MedWorkSpace từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedWorkSpace từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedWorkSpace từ Database
		/// </summary>
		List<MedWorkSpace> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedWorkSpace từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedWorkSpace> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedWorkSpace> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedWorkSpace từ Database
		/// </summary>
		MedWorkSpace GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MedWorkSpace đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedWorkSpace GetObjectCon(string schema, string condition, params Object[] parameters);
		MedWorkSpace GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedWorkSpace vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedWorkSpace _MedWorkSpace);
		/// <summary>
		/// Insert danh sách đối tượng MedWorkSpace vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces);
		/// <summary>
		/// Cập nhật MedWorkSpace vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedWorkSpace _MedWorkSpace, String Id);
		/// <summary>
		/// Cập nhật MedWorkSpace vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedWorkSpace _MedWorkSpace);
		/// <summary>
		/// Cập nhật danh sách MedWorkSpace vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces);
		/// <summary>
		/// Cập nhật MedWorkSpace vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedWorkSpace _MedWorkSpace, string condition);
		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedWorkSpace _MedWorkSpace);
		/// <summary>
		/// Xóa MedWorkSpace trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedWorkSpace trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedWorkSpace> _MedWorkSpaces);
	}
}
