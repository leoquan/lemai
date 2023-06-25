using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpproviderconfig
	{
		/// <summary>
		/// Lấy một DataTable GExpProviderConfig từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProviderConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProviderConfig từ Database
		/// </summary>
		List<GExpProviderConfig> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProviderConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProviderConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProviderConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProviderConfig từ Database
		/// </summary>
		GExpProviderConfig GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProviderConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProviderConfig GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProviderConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProviderConfig vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProviderConfig _GExpProviderConfig);
		/// <summary>
		/// Insert danh sách đối tượng GExpProviderConfig vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs);
		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProviderConfig _GExpProviderConfig, String Id);
		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProviderConfig _GExpProviderConfig);
		/// <summary>
		/// Cập nhật danh sách GExpProviderConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs);
		/// <summary>
		/// Cập nhật GExpProviderConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProviderConfig _GExpProviderConfig, string condition);
		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProviderConfig _GExpProviderConfig);
		/// <summary>
		/// Xóa GExpProviderConfig trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProviderConfig trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProviderConfig> _GExpProviderConfigs);
	}
}
