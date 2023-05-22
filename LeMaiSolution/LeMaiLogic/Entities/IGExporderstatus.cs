using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExporderstatus
	{
		/// <summary>
		/// Lấy một DataTable GExpOrderStatus từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpOrderStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpOrderStatus từ Database
		/// </summary>
		List<GExpOrderStatus> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpOrderStatus từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpOrderStatus> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpOrderStatus> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpOrderStatus từ Database
		/// </summary>
		GExpOrderStatus GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một GExpOrderStatus đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpOrderStatus GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpOrderStatus GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpOrderStatus vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpOrderStatus _GExpOrderStatus);
		/// <summary>
		/// Insert danh sách đối tượng GExpOrderStatus vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss);
		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpOrderStatus _GExpOrderStatus, Int32 Id);
		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpOrderStatus _GExpOrderStatus);
		/// <summary>
		/// Cập nhật danh sách GExpOrderStatus vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss);
		/// <summary>
		/// Cập nhật GExpOrderStatus vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpOrderStatus _GExpOrderStatus, string condition);
		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpOrderStatus _GExpOrderStatus);
		/// <summary>
		/// Xóa GExpOrderStatus trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpOrderStatus trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpOrderStatus> _GExpOrderStatuss);
	}
}
