using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpconsignmentobject
	{
		/// <summary>
		/// Lấy một DataTable ExpConsignmentObject từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpConsignmentObject từ Database
		/// </summary>
		List<ExpConsignmentObject> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpConsignmentObject từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpConsignmentObject> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpConsignmentObject> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpConsignmentObject từ Database
		/// </summary>
		ExpConsignmentObject GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpConsignmentObject đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpConsignmentObject GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpConsignmentObject GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpConsignmentObject vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpConsignmentObject _ExpConsignmentObject);
		/// <summary>
		/// Insert danh sách đối tượng ExpConsignmentObject vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects);
		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpConsignmentObject _ExpConsignmentObject, String Id);
		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpConsignmentObject _ExpConsignmentObject);
		/// <summary>
		/// Cập nhật danh sách ExpConsignmentObject vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects);
		/// <summary>
		/// Cập nhật ExpConsignmentObject vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpConsignmentObject _ExpConsignmentObject, string condition);
		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpConsignmentObject _ExpConsignmentObject);
		/// <summary>
		/// Xóa ExpConsignmentObject trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpConsignmentObject trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpConsignmentObject> _ExpConsignmentObjects);
	}
}
