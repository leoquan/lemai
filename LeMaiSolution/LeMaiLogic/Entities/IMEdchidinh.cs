using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdchidinh
	{
		/// <summary>
		/// Lấy một DataTable MedChiDinh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedChiDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedChiDinh từ Database
		/// </summary>
		List<MedChiDinh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedChiDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedChiDinh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedChiDinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedChiDinh từ Database
		/// </summary>
		MedChiDinh GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedChiDinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedChiDinh GetObjectCon(string schema, string condition, params Object[] parameters);
		MedChiDinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedChiDinh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedChiDinh _MedChiDinh);
		/// <summary>
		/// Insert danh sách đối tượng MedChiDinh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs);
		/// <summary>
		/// Cập nhật MedChiDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedChiDinh _MedChiDinh, String id);
		/// <summary>
		/// Cập nhật MedChiDinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedChiDinh _MedChiDinh);
		/// <summary>
		/// Cập nhật danh sách MedChiDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs);
		/// <summary>
		/// Cập nhật MedChiDinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedChiDinh _MedChiDinh, string condition);
		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedChiDinh _MedChiDinh);
		/// <summary>
		/// Xóa MedChiDinh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedChiDinh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedChiDinh> _MedChiDinhs);
	}
}
