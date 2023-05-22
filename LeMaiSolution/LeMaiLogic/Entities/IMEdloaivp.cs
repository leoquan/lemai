using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdloaivp
	{
		/// <summary>
		/// Lấy một DataTable MedLoaiVp từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedLoaiVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedLoaiVp từ Database
		/// </summary>
		List<MedLoaiVp> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedLoaiVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedLoaiVp> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedLoaiVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedLoaiVp từ Database
		/// </summary>
		MedLoaiVp GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedLoaiVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedLoaiVp GetObjectCon(string schema, string condition, params Object[] parameters);
		MedLoaiVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedLoaiVp vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedLoaiVp _MedLoaiVp);
		/// <summary>
		/// Insert danh sách đối tượng MedLoaiVp vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps);
		/// <summary>
		/// Cập nhật MedLoaiVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedLoaiVp _MedLoaiVp, Int32 id);
		/// <summary>
		/// Cập nhật MedLoaiVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedLoaiVp _MedLoaiVp);
		/// <summary>
		/// Cập nhật danh sách MedLoaiVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps);
		/// <summary>
		/// Cập nhật MedLoaiVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedLoaiVp _MedLoaiVp, string condition);
		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedLoaiVp _MedLoaiVp);
		/// <summary>
		/// Xóa MedLoaiVp trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedLoaiVp trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedLoaiVp> _MedLoaiVps);
	}
}
