using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpfeemaster
	{
		/// <summary>
		/// Lấy một DataTable GExpFeeMaster từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpFeeMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpFeeMaster từ Database
		/// </summary>
		List<GExpFeeMaster> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpFeeMaster từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpFeeMaster> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpFeeMaster> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpFeeMaster từ Database
		/// </summary>
		GExpFeeMaster GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpFeeMaster đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpFeeMaster GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpFeeMaster GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpFeeMaster vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpFeeMaster _GExpFeeMaster);
		/// <summary>
		/// Insert danh sách đối tượng GExpFeeMaster vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters);
		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpFeeMaster _GExpFeeMaster, String Id);
		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpFeeMaster _GExpFeeMaster);
		/// <summary>
		/// Cập nhật danh sách GExpFeeMaster vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters);
		/// <summary>
		/// Cập nhật GExpFeeMaster vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpFeeMaster _GExpFeeMaster, string condition);
		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpFeeMaster _GExpFeeMaster);
		/// <summary>
		/// Xóa GExpFeeMaster trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpFeeMaster trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpFeeMaster> _GExpFeeMasters);
	}
}
