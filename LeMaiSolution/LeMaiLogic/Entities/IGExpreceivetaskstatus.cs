using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpreceivetaskstatus
	{
		/// <summary>
		/// Lấy một DataTable GExpReceiveTaskStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpReceiveTaskStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpReceiveTaskStatus từ Database
		/// </summary>
		List<GExpReceiveTaskStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpReceiveTaskStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpReceiveTaskStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpReceiveTaskStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpReceiveTaskStatus từ Database
		/// </summary>
		GExpReceiveTaskStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một GExpReceiveTaskStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpReceiveTaskStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpReceiveTaskStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpReceiveTaskStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus);
		/// <summary>
		/// Insert danh sách đối tượng GExpReceiveTaskStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss);
		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus, Int32 Id);
		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus);
		/// <summary>
		/// Cập nhật danh sách GExpReceiveTaskStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss);
		/// <summary>
		/// Cập nhật GExpReceiveTaskStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus, string condition);
		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpReceiveTaskStatus _GExpReceiveTaskStatus);
		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpReceiveTaskStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpReceiveTaskStatus> _GExpReceiveTaskStatuss);
	}
}
