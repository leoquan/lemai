using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquaecg
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaEcg từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaEcg từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaEcg từ Database
		/// </summary>
		List<MedKetQuaEcg> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaEcg từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaEcg> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaEcg> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaEcg từ Database
		/// </summary>
		MedKetQuaEcg GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaEcg đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaEcg GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaEcg GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaEcg vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaEcg _MedKetQuaEcg);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaEcg vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs);
		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaEcg _MedKetQuaEcg, String id);
		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaEcg _MedKetQuaEcg);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaEcg vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs);
		/// <summary>
		/// Cập nhật MedKetQuaEcg vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaEcg _MedKetQuaEcg, string condition);
		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaEcg _MedKetQuaEcg);
		/// <summary>
		/// Xóa MedKetQuaEcg trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaEcg trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaEcg> _MedKetQuaEcgs);
	}
}
