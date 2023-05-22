using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpprovidertype
	{
		/// <summary>
		/// Lấy một DataTable GExpProviderType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpProviderType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpProviderType từ Database
		/// </summary>
		List<GExpProviderType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpProviderType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpProviderType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpProviderType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpProviderType từ Database
		/// </summary>
		GExpProviderType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpProviderType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpProviderType GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpProviderType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpProviderType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpProviderType _GExpProviderType);
		/// <summary>
		/// Insert danh sách đối tượng GExpProviderType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes);
		/// <summary>
		/// Cập nhật GExpProviderType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpProviderType _GExpProviderType, String Id);
		/// <summary>
		/// Cập nhật GExpProviderType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpProviderType _GExpProviderType);
		/// <summary>
		/// Cập nhật danh sách GExpProviderType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes);
		/// <summary>
		/// Cập nhật GExpProviderType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpProviderType _GExpProviderType, string condition);
		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpProviderType _GExpProviderType);
		/// <summary>
		/// Xóa GExpProviderType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpProviderType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpProviderType> _GExpProviderTypes);
	}
}
