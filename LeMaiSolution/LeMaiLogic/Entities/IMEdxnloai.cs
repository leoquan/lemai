using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdxnloai
	{
		/// <summary>
		/// Lấy một DataTable MedXNLoai từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedXNLoai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedXNLoai từ Database
		/// </summary>
		List<MedXNLoai> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedXNLoai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedXNLoai> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedXNLoai> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedXNLoai từ Database
		/// </summary>
		MedXNLoai GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedXNLoai đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedXNLoai GetObjectCon(string schema, string condition, params Object[] parameters);
		MedXNLoai GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedXNLoai vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedXNLoai _MedXNLoai);
		/// <summary>
		/// Insert danh sách đối tượng MedXNLoai vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedXNLoai> _MedXNLoais);
		/// <summary>
		/// Cập nhật MedXNLoai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedXNLoai _MedXNLoai, Int32 id);
		/// <summary>
		/// Cập nhật MedXNLoai vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedXNLoai _MedXNLoai);
		/// <summary>
		/// Cập nhật danh sách MedXNLoai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedXNLoai> _MedXNLoais);
		/// <summary>
		/// Cập nhật MedXNLoai vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedXNLoai _MedXNLoai, string condition);
		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedXNLoai _MedXNLoai);
		/// <summary>
		/// Xóa MedXNLoai trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedXNLoai trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedXNLoai> _MedXNLoais);
	}
}
