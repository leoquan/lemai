using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdcapmaso
	{
		/// <summary>
		/// Lấy một DataTable MedCapMaSo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedCapMaSo từ Database
		/// </summary>
		List<MedCapMaSo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedCapMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedCapMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedCapMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedCapMaSo từ Database
		/// </summary>
		MedCapMaSo GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedCapMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedCapMaSo GetObjectCon(string schema, string condition, params Object[] parameters);
		MedCapMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedCapMaSo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedCapMaSo _MedCapMaSo);
		/// <summary>
		/// Insert danh sách đối tượng MedCapMaSo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos);
		/// <summary>
		/// Cập nhật MedCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedCapMaSo _MedCapMaSo, String id);
		/// <summary>
		/// Cập nhật MedCapMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedCapMaSo _MedCapMaSo);
		/// <summary>
		/// Cập nhật danh sách MedCapMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos);
		/// <summary>
		/// Cập nhật MedCapMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedCapMaSo _MedCapMaSo, string condition);
		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedCapMaSo _MedCapMaSo);
		/// <summary>
		/// Xóa MedCapMaSo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedCapMaSo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedCapMaSo> _MedCapMaSos);
	}
}
