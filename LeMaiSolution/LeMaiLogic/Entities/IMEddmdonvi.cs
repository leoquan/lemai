using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEddmdonvi
	{
		/// <summary>
		/// Lấy một DataTable MedDmDonVi từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedDmDonVi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedDmDonVi từ Database
		/// </summary>
		List<MedDmDonVi> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedDmDonVi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedDmDonVi> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedDmDonVi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedDmDonVi từ Database
		/// </summary>
		MedDmDonVi GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedDmDonVi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedDmDonVi GetObjectCon(string schema, string condition, params Object[] parameters);
		MedDmDonVi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedDmDonVi vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedDmDonVi _MedDmDonVi);
		/// <summary>
		/// Insert danh sách đối tượng MedDmDonVi vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis);
		/// <summary>
		/// Cập nhật MedDmDonVi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedDmDonVi _MedDmDonVi, Int32 id);
		/// <summary>
		/// Cập nhật MedDmDonVi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedDmDonVi _MedDmDonVi);
		/// <summary>
		/// Cập nhật danh sách MedDmDonVi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis);
		/// <summary>
		/// Cập nhật MedDmDonVi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedDmDonVi _MedDmDonVi, string condition);
		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedDmDonVi _MedDmDonVi);
		/// <summary>
		/// Xóa MedDmDonVi trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedDmDonVi trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedDmDonVi> _MedDmDonVis);
	}
}
