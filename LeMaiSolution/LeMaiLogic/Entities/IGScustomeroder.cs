using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGScustomeroder
	{
		/// <summary>
		/// Lấy một DataTable GsCustomerOder từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsCustomerOder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsCustomerOder từ Database
		/// </summary>
		List<GsCustomerOder> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsCustomerOder từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsCustomerOder> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsCustomerOder> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsCustomerOder từ Database
		/// </summary>
		GsCustomerOder GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsCustomerOder đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsCustomerOder GetObjectCon(string schema, string condition, params Object[] parameters);
		GsCustomerOder GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsCustomerOder vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsCustomerOder _GsCustomerOder);
		/// <summary>
		/// Insert danh sách đối tượng GsCustomerOder vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders);
		/// <summary>
		/// Cập nhật GsCustomerOder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsCustomerOder _GsCustomerOder, String Id);
		/// <summary>
		/// Cập nhật GsCustomerOder vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsCustomerOder _GsCustomerOder);
		/// <summary>
		/// Cập nhật danh sách GsCustomerOder vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders);
		/// <summary>
		/// Cập nhật GsCustomerOder vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsCustomerOder _GsCustomerOder, string condition);
		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsCustomerOder _GsCustomerOder);
		/// <summary>
		/// Xóa GsCustomerOder trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsCustomerOder trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsCustomerOder> _GsCustomerOders);
	}
}
