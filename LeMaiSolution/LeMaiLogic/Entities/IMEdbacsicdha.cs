using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdbacsicdha
	{
		/// <summary>
		/// Lấy một DataTable MedBacSiCDHA từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedBacSiCDHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedBacSiCDHA từ Database
		/// </summary>
		List<MedBacSiCDHA> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedBacSiCDHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedBacSiCDHA> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedBacSiCDHA> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedBacSiCDHA từ Database
		/// </summary>
		MedBacSiCDHA GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedBacSiCDHA đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedBacSiCDHA GetObjectCon(string schema, string condition, params Object[] parameters);
		MedBacSiCDHA GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedBacSiCDHA vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedBacSiCDHA _MedBacSiCDHA);
		/// <summary>
		/// Insert danh sách đối tượng MedBacSiCDHA vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs);
		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedBacSiCDHA _MedBacSiCDHA, Int32 id);
		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedBacSiCDHA _MedBacSiCDHA);
		/// <summary>
		/// Cập nhật danh sách MedBacSiCDHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs);
		/// <summary>
		/// Cập nhật MedBacSiCDHA vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedBacSiCDHA _MedBacSiCDHA, string condition);
		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedBacSiCDHA _MedBacSiCDHA);
		/// <summary>
		/// Xóa MedBacSiCDHA trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedBacSiCDHA trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedBacSiCDHA> _MedBacSiCDHAs);
	}
}
