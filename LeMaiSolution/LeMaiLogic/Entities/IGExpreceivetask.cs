using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpreceivetask
	{
		/// <summary>
		/// Lấy một DataTable GExpReceiveTask từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpReceiveTask từ Database
		/// </summary>
		List<GExpReceiveTask> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpReceiveTask từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpReceiveTask> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpReceiveTask> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpReceiveTask từ Database
		/// </summary>
		GExpReceiveTask GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpReceiveTask đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpReceiveTask GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpReceiveTask GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpReceiveTask vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpReceiveTask _GExpReceiveTask);
		/// <summary>
		/// Insert danh sách đối tượng GExpReceiveTask vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks);
		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpReceiveTask _GExpReceiveTask, String Id);
		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpReceiveTask _GExpReceiveTask);
		/// <summary>
		/// Cập nhật danh sách GExpReceiveTask vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks);
		/// <summary>
		/// Cập nhật GExpReceiveTask vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpReceiveTask _GExpReceiveTask, string condition);
		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpReceiveTask _GExpReceiveTask);
		/// <summary>
		/// Xóa GExpReceiveTask trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpReceiveTask trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpReceiveTask> _GExpReceiveTasks);
	}
}
