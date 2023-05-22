using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdcotbaocao
	{
		/// <summary>
		/// Lấy một DataTable MedCotBaoCao từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedCotBaoCao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedCotBaoCao từ Database
		/// </summary>
		List<MedCotBaoCao> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedCotBaoCao từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedCotBaoCao> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedCotBaoCao> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedCotBaoCao từ Database
		/// </summary>
		MedCotBaoCao GetObject(string schema, String macot);
		/// <summary>
		/// Lấy một MedCotBaoCao đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedCotBaoCao GetObjectCon(string schema, string condition, params Object[] parameters);
		MedCotBaoCao GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedCotBaoCao vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedCotBaoCao _MedCotBaoCao);
		/// <summary>
		/// Insert danh sách đối tượng MedCotBaoCao vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos);
		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedCotBaoCao _MedCotBaoCao, String macot);
		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedCotBaoCao _MedCotBaoCao);
		/// <summary>
		/// Cập nhật danh sách MedCotBaoCao vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos);
		/// <summary>
		/// Cập nhật MedCotBaoCao vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedCotBaoCao _MedCotBaoCao, string condition);
		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String macot);
		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedCotBaoCao _MedCotBaoCao);
		/// <summary>
		/// Xóa MedCotBaoCao trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedCotBaoCao trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedCotBaoCao> _MedCotBaoCaos);
	}
}
