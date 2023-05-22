using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdxnten
	{
		/// <summary>
		/// Lấy một DataTable MedXNTen từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedXNTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedXNTen từ Database
		/// </summary>
		List<MedXNTen> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedXNTen từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedXNTen> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedXNTen> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedXNTen từ Database
		/// </summary>
		MedXNTen GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedXNTen đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedXNTen GetObjectCon(string schema, string condition, params Object[] parameters);
		MedXNTen GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedXNTen vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedXNTen _MedXNTen);
		/// <summary>
		/// Insert danh sách đối tượng MedXNTen vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedXNTen> _MedXNTens);
		/// <summary>
		/// Cập nhật MedXNTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedXNTen _MedXNTen, Int32 id);
		/// <summary>
		/// Cập nhật MedXNTen vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedXNTen _MedXNTen);
		/// <summary>
		/// Cập nhật danh sách MedXNTen vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedXNTen> _MedXNTens);
		/// <summary>
		/// Cập nhật MedXNTen vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedXNTen _MedXNTen, string condition);
		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedXNTen _MedXNTen);
		/// <summary>
		/// Xóa MedXNTen trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedXNTen trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedXNTen> _MedXNTens);
	}
}
