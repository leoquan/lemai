using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdticcapmaso
	{
		/// <summary>
		/// Lấy một DataTable MedTicCapMaSo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedTicCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedTicCapMaSo từ Database
		/// </summary>
		List<MedTicCapMaSo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedTicCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedTicCapMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedTicCapMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedTicCapMaSo từ Database
		/// </summary>
		MedTicCapMaSo GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedTicCapMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedTicCapMaSo GetObjectCon(string schema, string condition, params Object[] parameters);
		MedTicCapMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedTicCapMaSo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedTicCapMaSo _MedTicCapMaSo);
		/// <summary>
		/// Insert danh sách đối tượng MedTicCapMaSo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos);
		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedTicCapMaSo _MedTicCapMaSo, Int32 id);
		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedTicCapMaSo _MedTicCapMaSo);
		/// <summary>
		/// Cập nhật danh sách MedTicCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos);
		/// <summary>
		/// Cập nhật MedTicCapMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedTicCapMaSo _MedTicCapMaSo, string condition);
		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedTicCapMaSo _MedTicCapMaSo);
		/// <summary>
		/// Xóa MedTicCapMaSo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedTicCapMaSo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedTicCapMaSo> _MedTicCapMaSos);
	}
}
