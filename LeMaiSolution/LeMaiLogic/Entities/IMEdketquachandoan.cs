using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquachandoan
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaChanDoan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoan từ Database
		/// </summary>
		List<MedKetQuaChanDoan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaChanDoan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaChanDoan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaChanDoan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaChanDoan từ Database
		/// </summary>
		MedKetQuaChanDoan GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaChanDoan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaChanDoan GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaChanDoan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaChanDoan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaChanDoan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan, String id);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaChanDoan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans);
		/// <summary>
		/// Cập nhật MedKetQuaChanDoan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan, string condition);
		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaChanDoan _MedKetQuaChanDoan);
		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaChanDoan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaChanDoan> _MedKetQuaChanDoans);
	}
}
