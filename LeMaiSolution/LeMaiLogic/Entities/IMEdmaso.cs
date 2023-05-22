using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdmaso
	{
		/// <summary>
		/// Lấy một DataTable MedMaSo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedMaSo từ Database
		/// </summary>
		List<MedMaSo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedMaSo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedMaSo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedMaSo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedMaSo từ Database
		/// </summary>
		MedMaSo GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedMaSo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedMaSo GetObjectCon(string schema, string condition, params Object[] parameters);
		MedMaSo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedMaSo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedMaSo _MedMaSo);
		/// <summary>
		/// Insert danh sách đối tượng MedMaSo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedMaSo> _MedMaSos);
		/// <summary>
		/// Cập nhật MedMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedMaSo _MedMaSo, String id);
		/// <summary>
		/// Cập nhật MedMaSo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedMaSo _MedMaSo);
		/// <summary>
		/// Cập nhật danh sách MedMaSo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedMaSo> _MedMaSos);
		/// <summary>
		/// Cập nhật MedMaSo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedMaSo _MedMaSo, string condition);
		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedMaSo _MedMaSo);
		/// <summary>
		/// Xóa MedMaSo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedMaSo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedMaSo> _MedMaSos);
	}
}
