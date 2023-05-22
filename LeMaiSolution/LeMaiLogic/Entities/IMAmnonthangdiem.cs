using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonthangdiem
	{
		/// <summary>
		/// Lấy một DataTable MamNonThangDiem từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonThangDiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonThangDiem từ Database
		/// </summary>
		List<MamNonThangDiem> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonThangDiem từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonThangDiem> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonThangDiem> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonThangDiem từ Database
		/// </summary>
		MamNonThangDiem GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một MamNonThangDiem đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonThangDiem GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonThangDiem GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonThangDiem vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonThangDiem _MamNonThangDiem);
		/// <summary>
		/// Insert danh sách đối tượng MamNonThangDiem vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems);
		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonThangDiem _MamNonThangDiem, Int32 Id);
		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonThangDiem _MamNonThangDiem);
		/// <summary>
		/// Cập nhật danh sách MamNonThangDiem vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems);
		/// <summary>
		/// Cập nhật MamNonThangDiem vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonThangDiem _MamNonThangDiem, string condition);
		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonThangDiem _MamNonThangDiem);
		/// <summary>
		/// Xóa MamNonThangDiem trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonThangDiem trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonThangDiem> _MamNonThangDiems);
	}
}
