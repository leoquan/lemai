using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdnhomvp
	{
		/// <summary>
		/// Lấy một DataTable MedNhomVp từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedNhomVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedNhomVp từ Database
		/// </summary>
		List<MedNhomVp> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedNhomVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedNhomVp> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedNhomVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedNhomVp từ Database
		/// </summary>
		MedNhomVp GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedNhomVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedNhomVp GetObjectCon(string schema, string condition, params Object[] parameters);
		MedNhomVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedNhomVp vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedNhomVp _MedNhomVp);
		/// <summary>
		/// Insert danh sách đối tượng MedNhomVp vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedNhomVp> _MedNhomVps);
		/// <summary>
		/// Cập nhật MedNhomVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedNhomVp _MedNhomVp, Int32 id);
		/// <summary>
		/// Cập nhật MedNhomVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedNhomVp _MedNhomVp);
		/// <summary>
		/// Cập nhật danh sách MedNhomVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedNhomVp> _MedNhomVps);
		/// <summary>
		/// Cập nhật MedNhomVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedNhomVp _MedNhomVp, string condition);
		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedNhomVp _MedNhomVp);
		/// <summary>
		/// Xóa MedNhomVp trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedNhomVp trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedNhomVp> _MedNhomVps);
	}
}
