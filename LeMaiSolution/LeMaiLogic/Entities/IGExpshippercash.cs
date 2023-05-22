using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpshippercash
	{
		/// <summary>
		/// Lấy một DataTable GExpShipperCash từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpShipperCash từ Database
		/// </summary>
		List<GExpShipperCash> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpShipperCash từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpShipperCash> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpShipperCash> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpShipperCash từ Database
		/// </summary>
		GExpShipperCash GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpShipperCash đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpShipperCash GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpShipperCash GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpShipperCash vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpShipperCash _GExpShipperCash);
		/// <summary>
		/// Insert danh sách đối tượng GExpShipperCash vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs);
		/// <summary>
		/// Cập nhật GExpShipperCash vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpShipperCash _GExpShipperCash, String Id);
		/// <summary>
		/// Cập nhật GExpShipperCash vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpShipperCash _GExpShipperCash);
		/// <summary>
		/// Cập nhật danh sách GExpShipperCash vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs);
		/// <summary>
		/// Cập nhật GExpShipperCash vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpShipperCash _GExpShipperCash, string condition);
		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpShipperCash _GExpShipperCash);
		/// <summary>
		/// Xóa GExpShipperCash trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpShipperCash trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpShipperCash> _GExpShipperCashs);
	}
}
