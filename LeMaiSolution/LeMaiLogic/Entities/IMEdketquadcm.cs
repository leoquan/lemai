using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquadcm
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaDcm từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaDcm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaDcm từ Database
		/// </summary>
		List<MedKetQuaDcm> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaDcm từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaDcm> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaDcm> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaDcm từ Database
		/// </summary>
		MedKetQuaDcm GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaDcm đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaDcm GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaDcm GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaDcm vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaDcm _MedKetQuaDcm);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaDcm vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms);
		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaDcm _MedKetQuaDcm, String id);
		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaDcm _MedKetQuaDcm);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaDcm vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms);
		/// <summary>
		/// Cập nhật MedKetQuaDcm vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaDcm _MedKetQuaDcm, string condition);
		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaDcm _MedKetQuaDcm);
		/// <summary>
		/// Xóa MedKetQuaDcm trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaDcm trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaDcm> _MedKetQuaDcms);
	}
}
