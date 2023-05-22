using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEddmten
	{
		/// <summary>
		/// Lấy một DataTable MedDmTen từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedDmTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedDmTen từ Database
		/// </summary>
		List<MedDmTen> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedDmTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedDmTen> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedDmTen> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedDmTen từ Database
		/// </summary>
		MedDmTen GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedDmTen đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedDmTen GetObjectCon(string schema, string condition, params Object[] parameters);
		MedDmTen GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedDmTen vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedDmTen _MedDmTen);
		/// <summary>
		/// Insert danh sách đối tượng MedDmTen vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedDmTen> _MedDmTens);
		/// <summary>
		/// Cập nhật MedDmTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedDmTen _MedDmTen, Int32 id);
		/// <summary>
		/// Cập nhật MedDmTen vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedDmTen _MedDmTen);
		/// <summary>
		/// Cập nhật danh sách MedDmTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedDmTen> _MedDmTens);
		/// <summary>
		/// Cập nhật MedDmTen vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedDmTen _MedDmTen, string condition);
		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedDmTen _MedDmTen);
		/// <summary>
		/// Xóa MedDmTen trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedDmTen trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedDmTen> _MedDmTens);
	}
}
