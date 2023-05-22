using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdlaymauct
	{
		/// <summary>
		/// Lấy một DataTable MedLayMauCT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedLayMauCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedLayMauCT từ Database
		/// </summary>
		List<MedLayMauCT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedLayMauCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedLayMauCT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedLayMauCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedLayMauCT từ Database
		/// </summary>
		MedLayMauCT GetObject(string schema, String id, Int32 stt);
		/// <summary>
		/// Lấy một MedLayMauCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedLayMauCT GetObjectCon(string schema, string condition, params Object[] parameters);
		MedLayMauCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedLayMauCT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedLayMauCT _MedLayMauCT);
		/// <summary>
		/// Insert danh sách đối tượng MedLayMauCT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs);
		/// <summary>
		/// Cập nhật MedLayMauCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedLayMauCT _MedLayMauCT, String id, Int32 stt);
		/// <summary>
		/// Cập nhật MedLayMauCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedLayMauCT _MedLayMauCT);
		/// <summary>
		/// Cập nhật danh sách MedLayMauCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs);
		/// <summary>
		/// Cập nhật MedLayMauCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedLayMauCT _MedLayMauCT, string condition);
		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id, Int32 stt);
		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedLayMauCT _MedLayMauCT);
		/// <summary>
		/// Xóa MedLayMauCT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedLayMauCT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedLayMauCT> _MedLayMauCTs);
	}
}
