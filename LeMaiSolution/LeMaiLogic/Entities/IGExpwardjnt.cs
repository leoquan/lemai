using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpwardjnt
	{
		/// <summary>
		/// Lấy một DataTable GExpWardJNT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpWardJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpWardJNT từ Database
		/// </summary>
		List<GExpWardJNT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpWardJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpWardJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpWardJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpWardJNT từ Database
		/// </summary>
		GExpWardJNT GetObject(string schema, String communeCode);
		/// <summary>
		/// Lấy một GExpWardJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpWardJNT GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpWardJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpWardJNT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpWardJNT _GExpWardJNT);
		/// <summary>
		/// Insert danh sách đối tượng GExpWardJNT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs);
		/// <summary>
		/// Cập nhật GExpWardJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpWardJNT _GExpWardJNT, String communeCode);
		/// <summary>
		/// Cập nhật GExpWardJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpWardJNT _GExpWardJNT);
		/// <summary>
		/// Cập nhật danh sách GExpWardJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs);
		/// <summary>
		/// Cập nhật GExpWardJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpWardJNT _GExpWardJNT, string condition);
		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String communeCode);
		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpWardJNT _GExpWardJNT);
		/// <summary>
		/// Xóa GExpWardJNT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpWardJNT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpWardJNT> _GExpWardJNTs);
	}
}
