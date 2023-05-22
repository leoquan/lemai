using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExprequestmoney
	{
		/// <summary>
		/// Lấy một DataTable GExpRequestMoney từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpRequestMoney từ Database
		/// </summary>
		List<GExpRequestMoney> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpRequestMoney từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpRequestMoney> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpRequestMoney> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpRequestMoney từ Database
		/// </summary>
		GExpRequestMoney GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpRequestMoney đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpRequestMoney GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpRequestMoney GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpRequestMoney vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpRequestMoney _GExpRequestMoney);
		/// <summary>
		/// Insert danh sách đối tượng GExpRequestMoney vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys);
		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpRequestMoney _GExpRequestMoney, String Id);
		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpRequestMoney _GExpRequestMoney);
		/// <summary>
		/// Cập nhật danh sách GExpRequestMoney vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys);
		/// <summary>
		/// Cập nhật GExpRequestMoney vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpRequestMoney _GExpRequestMoney, string condition);
		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpRequestMoney _GExpRequestMoney);
		/// <summary>
		/// Xóa GExpRequestMoney trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpRequestMoney trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpRequestMoney> _GExpRequestMoneys);
	}
}
