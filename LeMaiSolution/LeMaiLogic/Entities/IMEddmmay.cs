using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEddmmay
	{
		/// <summary>
		/// Lấy một DataTable MedDmMay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedDmMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedDmMay từ Database
		/// </summary>
		List<MedDmMay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedDmMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedDmMay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedDmMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedDmMay từ Database
		/// </summary>
		MedDmMay GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedDmMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedDmMay GetObjectCon(string schema, string condition, params Object[] parameters);
		MedDmMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedDmMay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedDmMay _MedDmMay);
		/// <summary>
		/// Insert danh sách đối tượng MedDmMay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedDmMay> _MedDmMays);
		/// <summary>
		/// Cập nhật MedDmMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedDmMay _MedDmMay, Int32 id);
		/// <summary>
		/// Cập nhật MedDmMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedDmMay _MedDmMay);
		/// <summary>
		/// Cập nhật danh sách MedDmMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedDmMay> _MedDmMays);
		/// <summary>
		/// Cập nhật MedDmMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedDmMay _MedDmMay, string condition);
		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedDmMay _MedDmMay);
		/// <summary>
		/// Xóa MedDmMay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedDmMay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedDmMay> _MedDmMays);
	}
}
