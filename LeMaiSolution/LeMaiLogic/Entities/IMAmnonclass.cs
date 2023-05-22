using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonclass
	{
		/// <summary>
		/// Lấy một DataTable MamNonClass từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonClass từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonClass từ Database
		/// </summary>
		List<MamNonClass> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonClass từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonClass> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonClass> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonClass từ Database
		/// </summary>
		MamNonClass GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonClass đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonClass GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonClass GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonClass vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonClass _MamNonClass);
		/// <summary>
		/// Insert danh sách đối tượng MamNonClass vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonClass> _MamNonClasss);
		/// <summary>
		/// Cập nhật MamNonClass vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonClass _MamNonClass, String Id);
		/// <summary>
		/// Cập nhật MamNonClass vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonClass _MamNonClass);
		/// <summary>
		/// Cập nhật danh sách MamNonClass vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonClass> _MamNonClasss);
		/// <summary>
		/// Cập nhật MamNonClass vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonClass _MamNonClass, string condition);
		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonClass _MamNonClass);
		/// <summary>
		/// Xóa MamNonClass trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonClass trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonClass> _MamNonClasss);
	}
}
