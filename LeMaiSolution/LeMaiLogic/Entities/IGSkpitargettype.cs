using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSkpitargettype
	{
		/// <summary>
		/// Lấy một DataTable GsKPITargetType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsKPITargetType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsKPITargetType từ Database
		/// </summary>
		List<GsKPITargetType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsKPITargetType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsKPITargetType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsKPITargetType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsKPITargetType từ Database
		/// </summary>
		GsKPITargetType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsKPITargetType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsKPITargetType GetObjectCon(string schema, string condition, params Object[] parameters);
		GsKPITargetType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsKPITargetType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsKPITargetType _GsKPITargetType);
		/// <summary>
		/// Insert danh sách đối tượng GsKPITargetType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes);
		/// <summary>
		/// Cập nhật GsKPITargetType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsKPITargetType _GsKPITargetType, String Id);
		/// <summary>
		/// Cập nhật GsKPITargetType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsKPITargetType _GsKPITargetType);
		/// <summary>
		/// Cập nhật danh sách GsKPITargetType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes);
		/// <summary>
		/// Cập nhật GsKPITargetType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsKPITargetType _GsKPITargetType, string condition);
		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsKPITargetType _GsKPITargetType);
		/// <summary>
		/// Xóa GsKPITargetType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsKPITargetType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsKPITargetType> _GsKPITargetTypes);
	}
}
