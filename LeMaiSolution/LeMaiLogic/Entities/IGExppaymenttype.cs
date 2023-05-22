using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExppaymenttype
	{
		/// <summary>
		/// Lấy một DataTable GExpPaymentType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpPaymentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpPaymentType từ Database
		/// </summary>
		List<GExpPaymentType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpPaymentType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpPaymentType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpPaymentType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpPaymentType từ Database
		/// </summary>
		GExpPaymentType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpPaymentType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpPaymentType GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpPaymentType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpPaymentType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpPaymentType _GExpPaymentType);
		/// <summary>
		/// Insert danh sách đối tượng GExpPaymentType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes);
		/// <summary>
		/// Cập nhật GExpPaymentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpPaymentType _GExpPaymentType, String Id);
		/// <summary>
		/// Cập nhật GExpPaymentType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpPaymentType _GExpPaymentType);
		/// <summary>
		/// Cập nhật danh sách GExpPaymentType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes);
		/// <summary>
		/// Cập nhật GExpPaymentType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpPaymentType _GExpPaymentType, string condition);
		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpPaymentType _GExpPaymentType);
		/// <summary>
		/// Xóa GExpPaymentType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpPaymentType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpPaymentType> _GExpPaymentTypes);
	}
}
