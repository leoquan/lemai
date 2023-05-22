using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovincejnt
	{
		/// <summary>
		/// Lấy một DataTable GExpProvinceJNT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProvinceJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProvinceJNT từ Database
		/// </summary>
		List<GExpProvinceJNT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProvinceJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProvinceJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProvinceJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProvinceJNT từ Database
		/// </summary>
		GExpProvinceJNT GetObject(string schema, String provinceCode);
		/// <summary>
		/// Lấy một GExpProvinceJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProvinceJNT GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProvinceJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProvinceJNT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProvinceJNT _GExpProvinceJNT);
		/// <summary>
		/// Insert danh sách đối tượng GExpProvinceJNT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs);
		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProvinceJNT _GExpProvinceJNT, String provinceCode);
		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProvinceJNT _GExpProvinceJNT);
		/// <summary>
		/// Cập nhật danh sách GExpProvinceJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs);
		/// <summary>
		/// Cập nhật GExpProvinceJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProvinceJNT _GExpProvinceJNT, string condition);
		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String provinceCode);
		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProvinceJNT _GExpProvinceJNT);
		/// <summary>
		/// Xóa GExpProvinceJNT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProvinceJNT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProvinceJNT> _GExpProvinceJNTs);
	}
}
