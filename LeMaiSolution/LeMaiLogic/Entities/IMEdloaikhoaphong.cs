using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdloaikhoaphong
	{
		/// <summary>
		/// Lấy một DataTable MedLoaiKhoaPhong từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedLoaiKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedLoaiKhoaPhong từ Database
		/// </summary>
		List<MedLoaiKhoaPhong> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedLoaiKhoaPhong từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedLoaiKhoaPhong> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedLoaiKhoaPhong> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedLoaiKhoaPhong từ Database
		/// </summary>
		MedLoaiKhoaPhong GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedLoaiKhoaPhong đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedLoaiKhoaPhong GetObjectCon(string schema, string condition, params Object[] parameters);
		MedLoaiKhoaPhong GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedLoaiKhoaPhong vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong);
		/// <summary>
		/// Insert danh sách đối tượng MedLoaiKhoaPhong vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs);
		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong, String id);
		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong);
		/// <summary>
		/// Cập nhật danh sách MedLoaiKhoaPhong vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs);
		/// <summary>
		/// Cập nhật MedLoaiKhoaPhong vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong, string condition);
		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedLoaiKhoaPhong _MedLoaiKhoaPhong);
		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedLoaiKhoaPhong trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedLoaiKhoaPhong> _MedLoaiKhoaPhongs);
	}
}
