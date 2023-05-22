using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquact
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaCT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaCT từ Database
		/// </summary>
		List<MedKetQuaCT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaCT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaCT từ Database
		/// </summary>
		MedKetQuaCT GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedKetQuaCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaCT GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaCT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaCT _MedKetQuaCT);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaCT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs);
		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaCT _MedKetQuaCT, String id);
		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaCT _MedKetQuaCT);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs);
		/// <summary>
		/// Cập nhật MedKetQuaCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaCT _MedKetQuaCT, string condition);
		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaCT _MedKetQuaCT);
		/// <summary>
		/// Xóa MedKetQuaCT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaCT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaCT> _MedKetQuaCTs);
	}
}
