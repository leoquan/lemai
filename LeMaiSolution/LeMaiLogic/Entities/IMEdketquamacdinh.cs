using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquamacdinh
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaMacDinh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaMacDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaMacDinh từ Database
		/// </summary>
		List<MedKetQuaMacDinh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaMacDinh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaMacDinh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaMacDinh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaMacDinh từ Database
		/// </summary>
		MedKetQuaMacDinh GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedKetQuaMacDinh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaMacDinh GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaMacDinh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaMacDinh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaMacDinh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs);
		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh, Int32 id);
		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaMacDinh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs);
		/// <summary>
		/// Cập nhật MedKetQuaMacDinh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh, string condition);
		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaMacDinh _MedKetQuaMacDinh);
		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaMacDinh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaMacDinh> _MedKetQuaMacDinhs);
	}
}
