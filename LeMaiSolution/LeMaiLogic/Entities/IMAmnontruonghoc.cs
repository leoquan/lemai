using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnontruonghoc
	{
		/// <summary>
		/// Lấy một DataTable MamNonTruongHoc từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonTruongHoc từ Database
		/// </summary>
		List<MamNonTruongHoc> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonTruongHoc từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonTruongHoc> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonTruongHoc> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonTruongHoc từ Database
		/// </summary>
		MamNonTruongHoc GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonTruongHoc đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonTruongHoc GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonTruongHoc GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonTruongHoc vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonTruongHoc _MamNonTruongHoc);
		/// <summary>
		/// Insert danh sách đối tượng MamNonTruongHoc vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs);
		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonTruongHoc _MamNonTruongHoc, String Id);
		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonTruongHoc _MamNonTruongHoc);
		/// <summary>
		/// Cập nhật danh sách MamNonTruongHoc vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs);
		/// <summary>
		/// Cập nhật MamNonTruongHoc vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonTruongHoc _MamNonTruongHoc, string condition);
		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonTruongHoc _MamNonTruongHoc);
		/// <summary>
		/// Xóa MamNonTruongHoc trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonTruongHoc trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonTruongHoc> _MamNonTruongHocs);
	}
}
