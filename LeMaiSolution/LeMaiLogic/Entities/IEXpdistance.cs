using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpdistance
	{
		/// <summary>
		/// Lấy một DataTable ExpDistance từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpDistance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpDistance từ Database
		/// </summary>
		List<ExpDistance> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpDistance từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpDistance> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpDistance> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpDistance từ Database
		/// </summary>
		ExpDistance GetObject(string schema, String Id, String Target);
		/// <summary>
		/// Lấy một ExpDistance đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpDistance GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpDistance GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpDistance vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpDistance _ExpDistance);
		/// <summary>
		/// Insert danh sách đối tượng ExpDistance vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpDistance> _ExpDistances);
		/// <summary>
		/// Cập nhật ExpDistance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpDistance _ExpDistance, String Id, String Target);
		/// <summary>
		/// Cập nhật ExpDistance vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpDistance _ExpDistance);
		/// <summary>
		/// Cập nhật danh sách ExpDistance vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpDistance> _ExpDistances);
		/// <summary>
		/// Cập nhật ExpDistance vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpDistance _ExpDistance, string condition);
		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id, String Target);
		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpDistance _ExpDistance);
		/// <summary>
		/// Xóa ExpDistance trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpDistance trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpDistance> _ExpDistances);
	}
}
