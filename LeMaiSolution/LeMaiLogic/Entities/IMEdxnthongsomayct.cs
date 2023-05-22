using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdxnthongsomayct
	{
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMayCT từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedXNThongSoMayCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedXNThongSoMayCT từ Database
		/// </summary>
		List<MedXNThongSoMayCT> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedXNThongSoMayCT từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedXNThongSoMayCT> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedXNThongSoMayCT> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedXNThongSoMayCT từ Database
		/// </summary>
		MedXNThongSoMayCT GetObject(string schema, Int32 id, Int32 stt);
		/// <summary>
		/// Lấy một MedXNThongSoMayCT đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedXNThongSoMayCT GetObjectCon(string schema, string condition, params Object[] parameters);
		MedXNThongSoMayCT GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedXNThongSoMayCT vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT);
		/// <summary>
		/// Insert danh sách đối tượng MedXNThongSoMayCT vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs);
		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT, Int32 id, Int32 stt);
		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT);
		/// <summary>
		/// Cập nhật danh sách MedXNThongSoMayCT vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs);
		/// <summary>
		/// Cập nhật MedXNThongSoMayCT vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT, string condition);
		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id, Int32 stt);
		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedXNThongSoMayCT _MedXNThongSoMayCT);
		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedXNThongSoMayCT trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedXNThongSoMayCT> _MedXNThongSoMayCTs);
	}
}
