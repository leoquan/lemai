using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IQUeuenumber
	{
		/// <summary>
		/// Lấy một DataTable QueueNumber từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable QueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách QueueNumber từ Database
		/// </summary>
		List<QueueNumber> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách QueueNumber từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<QueueNumber> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<QueueNumber> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một QueueNumber từ Database
		/// </summary>
		QueueNumber GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một QueueNumber đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		QueueNumber GetObjectCon(string schema, string condition, params Object[] parameters);
		QueueNumber GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới QueueNumber vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, QueueNumber _QueueNumber);
		/// <summary>
		/// Insert danh sách đối tượng QueueNumber vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<QueueNumber> _QueueNumbers);
		/// <summary>
		/// Cập nhật QueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, QueueNumber _QueueNumber, String Id);
		/// <summary>
		/// Cập nhật QueueNumber vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, QueueNumber _QueueNumber);
		/// <summary>
		/// Cập nhật danh sách QueueNumber vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<QueueNumber> _QueueNumbers);
		/// <summary>
		/// Cập nhật QueueNumber vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, QueueNumber _QueueNumber, string condition);
		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, QueueNumber _QueueNumber);
		/// <summary>
		/// Xóa QueueNumber trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa QueueNumber trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<QueueNumber> _QueueNumbers);
	}
}
