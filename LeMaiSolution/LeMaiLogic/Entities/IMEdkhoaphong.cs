using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdkhoaphong
	{
		/// <summary>
		/// Lấy một DataTable MedKhoaPhong từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKhoaPhong từ Database
		/// </summary>
		List<MedKhoaPhong> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKhoaPhong> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKhoaPhong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKhoaPhong từ Database
		/// </summary>
		MedKhoaPhong GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKhoaPhong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKhoaPhong GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKhoaPhong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKhoaPhong vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKhoaPhong _MedKhoaPhong);
		/// <summary>
		/// Insert danh sách đối tượng MedKhoaPhong vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs);
		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKhoaPhong _MedKhoaPhong, String id);
		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKhoaPhong _MedKhoaPhong);
		/// <summary>
		/// Cập nhật danh sách MedKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs);
		/// <summary>
		/// Cập nhật MedKhoaPhong vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKhoaPhong _MedKhoaPhong, string condition);
		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKhoaPhong _MedKhoaPhong);
		/// <summary>
		/// Xóa MedKhoaPhong trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKhoaPhong trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKhoaPhong> _MedKhoaPhongs);
	}
}
