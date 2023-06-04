using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVIhcleserviceconfig
	{
		/// <summary>
		/// Lấy một DataTable VihcleServiceConfig từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VihcleServiceConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VihcleServiceConfig từ Database
		/// </summary>
		List<VihcleServiceConfig> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VihcleServiceConfig từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VihcleServiceConfig> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VihcleServiceConfig> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VihcleServiceConfig từ Database
		/// </summary>
		VihcleServiceConfig GetObject(string schema, String FK_ServiceId, String FK_Vihcle);
		/// <summary>
		/// Lấy một VihcleServiceConfig đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VihcleServiceConfig GetObjectCon(string schema, string condition, params Object[] parameters);
		VihcleServiceConfig GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VihcleServiceConfig vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VihcleServiceConfig _VihcleServiceConfig);
		/// <summary>
		/// Insert danh sách đối tượng VihcleServiceConfig vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs);
		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VihcleServiceConfig _VihcleServiceConfig, String FK_ServiceId, String FK_Vihcle);
		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VihcleServiceConfig _VihcleServiceConfig);
		/// <summary>
		/// Cập nhật danh sách VihcleServiceConfig vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs);
		/// <summary>
		/// Cập nhật VihcleServiceConfig vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VihcleServiceConfig _VihcleServiceConfig, string condition);
		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String FK_ServiceId, String FK_Vihcle);
		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VihcleServiceConfig _VihcleServiceConfig);
		/// <summary>
		/// Xóa VihcleServiceConfig trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VihcleServiceConfig trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VihcleServiceConfig> _VihcleServiceConfigs);
	}
}
