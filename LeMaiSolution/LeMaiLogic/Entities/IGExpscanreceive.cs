using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpscanreceive
	{
		/// <summary>
		/// Lấy một DataTable GExpScanReceive từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpScanReceive từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpScanReceive từ Database
		/// </summary>
		List<GExpScanReceive> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpScanReceive từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpScanReceive> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpScanReceive> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpScanReceive từ Database
		/// </summary>
		GExpScanReceive GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpScanReceive đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpScanReceive GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpScanReceive GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpScanReceive vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpScanReceive _GExpScanReceive);
		/// <summary>
		/// Insert danh sách đối tượng GExpScanReceive vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives);
		/// <summary>
		/// Cập nhật GExpScanReceive vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpScanReceive _GExpScanReceive, String Id);
		/// <summary>
		/// Cập nhật GExpScanReceive vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpScanReceive _GExpScanReceive);
		/// <summary>
		/// Cập nhật danh sách GExpScanReceive vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives);
		/// <summary>
		/// Cập nhật GExpScanReceive vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpScanReceive _GExpScanReceive, string condition);
		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpScanReceive _GExpScanReceive);
		/// <summary>
		/// Xóa GExpScanReceive trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpScanReceive trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpScanReceive> _GExpScanReceives);
	}
}
