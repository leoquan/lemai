using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSbank
	{
		/// <summary>
		/// Lấy một DataTable GsBank từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsBank từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsBank từ Database
		/// </summary>
		List<GsBank> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsBank từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsBank> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsBank> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsBank từ Database
		/// </summary>
		GsBank GetObject(string schema, String BankID);
		/// <summary>
		/// Lấy một GsBank đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsBank GetObjectCon(string schema, string condition, params Object[] parameters);
		GsBank GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsBank vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsBank _GsBank);
		/// <summary>
		/// Insert danh sách đối tượng GsBank vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsBank> _GsBanks);
		/// <summary>
		/// Cập nhật GsBank vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsBank _GsBank, String BankID);
		/// <summary>
		/// Cập nhật GsBank vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsBank _GsBank);
		/// <summary>
		/// Cập nhật danh sách GsBank vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsBank> _GsBanks);
		/// <summary>
		/// Cập nhật GsBank vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsBank _GsBank, string condition);
		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BankID);
		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsBank _GsBank);
		/// <summary>
		/// Xóa GsBank trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsBank trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsBank> _GsBanks);
	}
}
