using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpshipper
	{
		/// <summary>
		/// Lấy một DataTable ExpShipper từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpShipper từ Database
		/// </summary>
		List<ExpShipper> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpShipper từ Database
		/// </summary>
		ExpShipper GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpShipper GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpShipper vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpShipper _ExpShipper);
		/// <summary>
		/// Insert danh sách đối tượng ExpShipper vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpShipper> _ExpShippers);
		/// <summary>
		/// Cập nhật ExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpShipper _ExpShipper, String Id);
		/// <summary>
		/// Cập nhật ExpShipper vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpShipper _ExpShipper);
		/// <summary>
		/// Cập nhật danh sách ExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpShipper> _ExpShippers);
		/// <summary>
		/// Cập nhật ExpShipper vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpShipper _ExpShipper, string condition);
		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpShipper _ExpShipper);
		/// <summary>
		/// Xóa ExpShipper trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpShipper trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpShipper> _ExpShippers);
	}
}
