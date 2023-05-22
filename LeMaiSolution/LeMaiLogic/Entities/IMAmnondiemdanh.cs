using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnondiemdanh
	{
		/// <summary>
		/// Lấy một DataTable MamNonDiemDanh từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonDiemDanh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonDiemDanh từ Database
		/// </summary>
		List<MamNonDiemDanh> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonDiemDanh từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonDiemDanh> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonDiemDanh> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonDiemDanh từ Database
		/// </summary>
		MamNonDiemDanh GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonDiemDanh đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonDiemDanh GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonDiemDanh GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonDiemDanh vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonDiemDanh _MamNonDiemDanh);
		/// <summary>
		/// Insert danh sách đối tượng MamNonDiemDanh vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs);
		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonDiemDanh _MamNonDiemDanh, String Id);
		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonDiemDanh _MamNonDiemDanh);
		/// <summary>
		/// Cập nhật danh sách MamNonDiemDanh vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs);
		/// <summary>
		/// Cập nhật MamNonDiemDanh vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonDiemDanh _MamNonDiemDanh, string condition);
		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonDiemDanh _MamNonDiemDanh);
		/// <summary>
		/// Xóa MamNonDiemDanh trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonDiemDanh trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonDiemDanh> _MamNonDiemDanhs);
	}
}
