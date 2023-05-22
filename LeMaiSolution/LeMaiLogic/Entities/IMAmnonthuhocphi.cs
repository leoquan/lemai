using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonthuhocphi
	{
		/// <summary>
		/// Lấy một DataTable MamNonThuHocPhi từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonThuHocPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonThuHocPhi từ Database
		/// </summary>
		List<MamNonThuHocPhi> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonThuHocPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonThuHocPhi> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonThuHocPhi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonThuHocPhi từ Database
		/// </summary>
		MamNonThuHocPhi GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonThuHocPhi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonThuHocPhi GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonThuHocPhi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonThuHocPhi vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonThuHocPhi _MamNonThuHocPhi);
		/// <summary>
		/// Insert danh sách đối tượng MamNonThuHocPhi vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis);
		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonThuHocPhi _MamNonThuHocPhi, String Id);
		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonThuHocPhi _MamNonThuHocPhi);
		/// <summary>
		/// Cập nhật danh sách MamNonThuHocPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis);
		/// <summary>
		/// Cập nhật MamNonThuHocPhi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonThuHocPhi _MamNonThuHocPhi, string condition);
		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonThuHocPhi _MamNonThuHocPhi);
		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonThuHocPhi trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonThuHocPhi> _MamNonThuHocPhis);
	}
}
