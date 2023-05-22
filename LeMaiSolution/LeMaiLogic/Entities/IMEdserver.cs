using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdserver
	{
		/// <summary>
		/// Lấy một DataTable MedServer từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedServer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedServer từ Database
		/// </summary>
		List<MedServer> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedServer từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedServer> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedServer> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedServer từ Database
		/// </summary>
		MedServer GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedServer đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedServer GetObjectCon(string schema, string condition, params Object[] parameters);
		MedServer GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedServer vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedServer _MedServer);
		/// <summary>
		/// Insert danh sách đối tượng MedServer vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedServer> _MedServers);
		/// <summary>
		/// Cập nhật MedServer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedServer _MedServer, String id);
		/// <summary>
		/// Cập nhật MedServer vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedServer _MedServer);
		/// <summary>
		/// Cập nhật danh sách MedServer vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedServer> _MedServers);
		/// <summary>
		/// Cập nhật MedServer vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedServer _MedServer, string condition);
		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedServer _MedServer);
		/// <summary>
		/// Xóa MedServer trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedServer trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedServer> _MedServers);
	}
}
