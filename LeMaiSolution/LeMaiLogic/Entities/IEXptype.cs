using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXptype
	{
		/// <summary>
		/// Lấy một DataTable ExpType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpType từ Database
		/// </summary>
		List<ExpType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpType từ Database
		/// </summary>
		ExpType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpType GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpType _ExpType);
		/// <summary>
		/// Insert danh sách đối tượng ExpType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpType> _ExpTypes);
		/// <summary>
		/// Cập nhật ExpType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpType _ExpType, String Id);
		/// <summary>
		/// Cập nhật ExpType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpType _ExpType);
		/// <summary>
		/// Cập nhật danh sách ExpType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpType> _ExpTypes);
		/// <summary>
		/// Cập nhật ExpType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpType _ExpType, string condition);
		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpType _ExpType);
		/// <summary>
		/// Xóa ExpType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpType> _ExpTypes);
	}
}
