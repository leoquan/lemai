using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscantype
	{
		/// <summary>
		/// Lấy một DataTable GExpScanType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanType từ Database
		/// </summary>
		List<GExpScanType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanType từ Database
		/// </summary>
		GExpScanType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanType GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanType _GExpScanType);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanType> _GExpScanTypes);
		/// <summary>
		/// Cập nhật GExpScanType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanType _GExpScanType, String Id);
		/// <summary>
		/// Cập nhật GExpScanType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanType _GExpScanType);
		/// <summary>
		/// Cập nhật danh sách GExpScanType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanType> _GExpScanTypes);
		/// <summary>
		/// Cập nhật GExpScanType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanType _GExpScanType, string condition);
		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanType _GExpScanType);
		/// <summary>
		/// Xóa GExpScanType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanType> _GExpScanTypes);
	}
}
