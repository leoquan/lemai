using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentqueuenumber
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentQueueNumber từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentQueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentQueueNumber từ Database
		/// </summary>
		List<ExpConsignmentQueueNumber> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentQueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentQueueNumber> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentQueueNumber> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentQueueNumber từ Database
		/// </summary>
		ExpConsignmentQueueNumber GetObject(string schema, String FK_ExpPost, String KeyValue);
		/// <summary>
		/// Lấy một ExpConsignmentQueueNumber đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentQueueNumber GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentQueueNumber GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentQueueNumber vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentQueueNumber vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers);
		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber, String FK_ExpPost, String KeyValue);
		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentQueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers);
		/// <summary>
		/// Cập nhật ExpConsignmentQueueNumber vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber, string condition);
		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ExpPost, String KeyValue);
		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentQueueNumber _ExpConsignmentQueueNumber);
		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentQueueNumber trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentQueueNumber> _ExpConsignmentQueueNumbers);
	}
}
