using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdsomauxetnghiem
	{
		/// <summary>
		/// Lấy một DataTable MedSoMauXetNghiem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedSoMauXetNghiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedSoMauXetNghiem từ Database
		/// </summary>
		List<MedSoMauXetNghiem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedSoMauXetNghiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedSoMauXetNghiem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedSoMauXetNghiem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedSoMauXetNghiem từ Database
		/// </summary>
		MedSoMauXetNghiem GetObject(string schema, String maql);
		/// <summary>
		/// Lấy một MedSoMauXetNghiem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedSoMauXetNghiem GetObjectCon(string schema, string condition, params Object[] parameters);
		MedSoMauXetNghiem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedSoMauXetNghiem vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem);
		/// <summary>
		/// Insert danh sách đối tượng MedSoMauXetNghiem vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems);
		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem, String maql);
		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem);
		/// <summary>
		/// Cập nhật danh sách MedSoMauXetNghiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems);
		/// <summary>
		/// Cập nhật MedSoMauXetNghiem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem, string condition);
		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String maql);
		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedSoMauXetNghiem _MedSoMauXetNghiem);
		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedSoMauXetNghiem trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedSoMauXetNghiem> _MedSoMauXetNghiems);
	}
}
