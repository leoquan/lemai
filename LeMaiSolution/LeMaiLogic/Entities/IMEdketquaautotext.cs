using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdketquaautotext
	{
		/// <summary>
		/// Lấy một DataTable MedKetQuaAutoText từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedKetQuaAutoText từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedKetQuaAutoText từ Database
		/// </summary>
		List<MedKetQuaAutoText> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedKetQuaAutoText từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedKetQuaAutoText> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedKetQuaAutoText> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedKetQuaAutoText từ Database
		/// </summary>
		MedKetQuaAutoText GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedKetQuaAutoText đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedKetQuaAutoText GetObjectCon(string schema, string condition, params Object[] parameters);
		MedKetQuaAutoText GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedKetQuaAutoText vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedKetQuaAutoText _MedKetQuaAutoText);
		/// <summary>
		/// Insert danh sách đối tượng MedKetQuaAutoText vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts);
		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedKetQuaAutoText _MedKetQuaAutoText, Int32 id);
		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedKetQuaAutoText _MedKetQuaAutoText);
		/// <summary>
		/// Cập nhật danh sách MedKetQuaAutoText vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts);
		/// <summary>
		/// Cập nhật MedKetQuaAutoText vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedKetQuaAutoText _MedKetQuaAutoText, string condition);
		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedKetQuaAutoText _MedKetQuaAutoText);
		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedKetQuaAutoText trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedKetQuaAutoText> _MedKetQuaAutoTexts);
	}
}
