using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdhosonhanbenh
	{
		/// <summary>
		/// Lấy một DataTable MedHoSoNhanBenh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedHoSoNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedHoSoNhanBenh từ Database
		/// </summary>
		List<MedHoSoNhanBenh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedHoSoNhanBenh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedHoSoNhanBenh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedHoSoNhanBenh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedHoSoNhanBenh từ Database
		/// </summary>
		MedHoSoNhanBenh GetObject(string schema, String mavv);
		/// <summary>
		/// Lấy một MedHoSoNhanBenh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedHoSoNhanBenh GetObjectCon(string schema, string condition, params Object[] parameters);
		MedHoSoNhanBenh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedHoSoNhanBenh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh);
		/// <summary>
		/// Insert danh sách đối tượng MedHoSoNhanBenh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs);
		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh, String mavv);
		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh);
		/// <summary>
		/// Cập nhật danh sách MedHoSoNhanBenh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs);
		/// <summary>
		/// Cập nhật MedHoSoNhanBenh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh, string condition);
		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String mavv);
		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedHoSoNhanBenh _MedHoSoNhanBenh);
		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedHoSoNhanBenh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedHoSoNhanBenh> _MedHoSoNhanBenhs);
	}
}
