using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpshipper
	{
		/// <summary>
		/// Lấy một DataTable GExpShipper từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpShipper từ Database
		/// </summary>
		List<GExpShipper> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpShipper từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpShipper> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpShipper> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpShipper từ Database
		/// </summary>
		GExpShipper GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpShipper đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpShipper GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpShipper GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpShipper vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpShipper _GExpShipper);
		/// <summary>
		/// Insert danh sách đối tượng GExpShipper vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpShipper> _GExpShippers);
		/// <summary>
		/// Cập nhật GExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpShipper _GExpShipper, String Id);
		/// <summary>
		/// Cập nhật GExpShipper vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpShipper _GExpShipper);
		/// <summary>
		/// Cập nhật danh sách GExpShipper vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpShipper> _GExpShippers);
		/// <summary>
		/// Cập nhật GExpShipper vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpShipper _GExpShipper, string condition);
		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpShipper _GExpShipper);
		/// <summary>
		/// Xóa GExpShipper trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpShipper trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpShipper> _GExpShippers);
	}
}
