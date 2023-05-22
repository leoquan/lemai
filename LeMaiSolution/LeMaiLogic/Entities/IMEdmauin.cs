using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdmauin
	{
		/// <summary>
		/// Lấy một DataTable MedMauIn từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedMauIn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedMauIn từ Database
		/// </summary>
		List<MedMauIn> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedMauIn từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedMauIn> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedMauIn> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedMauIn từ Database
		/// </summary>
		MedMauIn GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MedMauIn đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedMauIn GetObjectCon(string schema, string condition, params Object[] parameters);
		MedMauIn GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedMauIn vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedMauIn _MedMauIn);
		/// <summary>
		/// Insert danh sách đối tượng MedMauIn vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedMauIn> _MedMauIns);
		/// <summary>
		/// Cập nhật MedMauIn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedMauIn _MedMauIn, String Id);
		/// <summary>
		/// Cập nhật MedMauIn vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedMauIn _MedMauIn);
		/// <summary>
		/// Cập nhật danh sách MedMauIn vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedMauIn> _MedMauIns);
		/// <summary>
		/// Cập nhật MedMauIn vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedMauIn _MedMauIn, string condition);
		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedMauIn _MedMauIn);
		/// <summary>
		/// Xóa MedMauIn trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedMauIn trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedMauIn> _MedMauIns);
	}
}
