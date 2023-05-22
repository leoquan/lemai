using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdistrictjnt
	{
		/// <summary>
		/// Lấy một DataTable GExpDistrictJNT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDistrictJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDistrictJNT từ Database
		/// </summary>
		List<GExpDistrictJNT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDistrictJNT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDistrictJNT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDistrictJNT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDistrictJNT từ Database
		/// </summary>
		GExpDistrictJNT GetObject(string schema, String districtCode);
		/// <summary>
		/// Lấy một GExpDistrictJNT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDistrictJNT GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDistrictJNT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDistrictJNT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDistrictJNT _GExpDistrictJNT);
		/// <summary>
		/// Insert danh sách đối tượng GExpDistrictJNT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs);
		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDistrictJNT _GExpDistrictJNT, String districtCode);
		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDistrictJNT _GExpDistrictJNT);
		/// <summary>
		/// Cập nhật danh sách GExpDistrictJNT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs);
		/// <summary>
		/// Cập nhật GExpDistrictJNT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDistrictJNT _GExpDistrictJNT, string condition);
		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String districtCode);
		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDistrictJNT _GExpDistrictJNT);
		/// <summary>
		/// Xóa GExpDistrictJNT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDistrictJNT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDistrictJNT> _GExpDistrictJNTs);
	}
}
