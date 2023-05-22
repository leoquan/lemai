using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGSport
	{
		/// <summary>
		/// Lấy một DataTable GsPort từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GsPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GsPort từ Database
		/// </summary>
		List<GsPort> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GsPort từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GsPort> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GsPort> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GsPort từ Database
		/// </summary>
		GsPort GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GsPort đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GsPort GetObjectCon(string schema, string condition, params Object[] parameters);
		GsPort GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GsPort vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GsPort _GsPort);
		/// <summary>
		/// Insert danh sách đối tượng GsPort vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GsPort> _GsPorts);
		/// <summary>
		/// Cập nhật GsPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GsPort _GsPort, String Id);
		/// <summary>
		/// Cập nhật GsPort vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GsPort _GsPort);
		/// <summary>
		/// Cập nhật danh sách GsPort vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GsPort> _GsPorts);
		/// <summary>
		/// Cập nhật GsPort vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GsPort _GsPort, string condition);
		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GsPort _GsPort);
		/// <summary>
		/// Xóa GsPort trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GsPort trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GsPort> _GsPorts);
	}
}
