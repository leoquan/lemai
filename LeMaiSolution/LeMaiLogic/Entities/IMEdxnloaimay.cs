using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdxnloaimay
	{
		/// <summary>
		/// Lấy một DataTable MedXNLoaiMay từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedXNLoaiMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedXNLoaiMay từ Database
		/// </summary>
		List<MedXNLoaiMay> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedXNLoaiMay từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedXNLoaiMay> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedXNLoaiMay> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedXNLoaiMay từ Database
		/// </summary>
		MedXNLoaiMay GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedXNLoaiMay đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedXNLoaiMay GetObjectCon(string schema, string condition, params Object[] parameters);
		MedXNLoaiMay GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedXNLoaiMay vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedXNLoaiMay _MedXNLoaiMay);
		/// <summary>
		/// Insert danh sách đối tượng MedXNLoaiMay vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays);
		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedXNLoaiMay _MedXNLoaiMay, Int32 id);
		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedXNLoaiMay _MedXNLoaiMay);
		/// <summary>
		/// Cập nhật danh sách MedXNLoaiMay vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays);
		/// <summary>
		/// Cập nhật MedXNLoaiMay vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedXNLoaiMay _MedXNLoaiMay, string condition);
		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedXNLoaiMay _MedXNLoaiMay);
		/// <summary>
		/// Xóa MedXNLoaiMay trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedXNLoaiMay trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedXNLoaiMay> _MedXNLoaiMays);
	}
}
