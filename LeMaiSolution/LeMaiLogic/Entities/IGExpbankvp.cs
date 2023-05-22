using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpbankvp
	{
		/// <summary>
		/// Lấy một DataTable GExpBankVP từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpBankVP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpBankVP từ Database
		/// </summary>
		List<GExpBankVP> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpBankVP từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpBankVP> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpBankVP> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpBankVP từ Database
		/// </summary>
		GExpBankVP GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpBankVP đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpBankVP GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpBankVP GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpBankVP vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpBankVP _GExpBankVP);
		/// <summary>
		/// Insert danh sách đối tượng GExpBankVP vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs);
		/// <summary>
		/// Cập nhật GExpBankVP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpBankVP _GExpBankVP, String Id);
		/// <summary>
		/// Cập nhật GExpBankVP vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpBankVP _GExpBankVP);
		/// <summary>
		/// Cập nhật danh sách GExpBankVP vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs);
		/// <summary>
		/// Cập nhật GExpBankVP vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpBankVP _GExpBankVP, string condition);
		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpBankVP _GExpBankVP);
		/// <summary>
		/// Xóa GExpBankVP trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpBankVP trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpBankVP> _GExpBankVPs);
	}
}
