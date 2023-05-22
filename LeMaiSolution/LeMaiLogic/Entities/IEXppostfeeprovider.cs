using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXppostfeeprovider
	{
		/// <summary>
		/// Lấy một DataTable ExpPostFeeProvider từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpPostFeeProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpPostFeeProvider từ Database
		/// </summary>
		List<ExpPostFeeProvider> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpPostFeeProvider từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpPostFeeProvider> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpPostFeeProvider> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpPostFeeProvider từ Database
		/// </summary>
		ExpPostFeeProvider GetObject(string schema, String FK_ExpProvider, String FK_ExpPost);
		/// <summary>
		/// Lấy một ExpPostFeeProvider đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpPostFeeProvider GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpPostFeeProvider GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpPostFeeProvider vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpPostFeeProvider _ExpPostFeeProvider);
		/// <summary>
		/// Insert danh sách đối tượng ExpPostFeeProvider vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders);
		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpPostFeeProvider _ExpPostFeeProvider, String FK_ExpProvider, String FK_ExpPost);
		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpPostFeeProvider _ExpPostFeeProvider);
		/// <summary>
		/// Cập nhật danh sách ExpPostFeeProvider vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders);
		/// <summary>
		/// Cập nhật ExpPostFeeProvider vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpPostFeeProvider _ExpPostFeeProvider, string condition);
		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ExpProvider, String FK_ExpPost);
		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpPostFeeProvider _ExpPostFeeProvider);
		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpPostFeeProvider trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpPostFeeProvider> _ExpPostFeeProviders);
	}
}
