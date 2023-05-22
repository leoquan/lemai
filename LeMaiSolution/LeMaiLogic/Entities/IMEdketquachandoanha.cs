using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquachandoanha
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoanHA từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoanHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoanHA từ Database
		/// </summary>
		List<MedKetQuaChanDoanHA> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoanHA từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaChanDoanHA> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaChanDoanHA> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaChanDoanHA từ Database
		/// </summary>
		MedKetQuaChanDoanHA GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaChanDoanHA đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaChanDoanHA GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaChanDoanHA GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaChanDoanHA vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaChanDoanHA vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA, String id);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaChanDoanHA vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoanHA vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA, string condition);
		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaChanDoanHA _MedKetQuaChanDoanHA);
		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaChanDoanHA trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaChanDoanHA> _MedKetQuaChanDoanHAs);
	}
}
