using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMAmnonsodaubai
	{
		/// <summary>
		/// Lấy một DataTable MamNonSoDauBai từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MamNonSoDauBai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MamNonSoDauBai từ Database
		/// </summary>
		List<MamNonSoDauBai> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MamNonSoDauBai từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MamNonSoDauBai> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MamNonSoDauBai> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MamNonSoDauBai từ Database
		/// </summary>
		MamNonSoDauBai GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một MamNonSoDauBai đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MamNonSoDauBai GetObjectCon(string schema, string condition, params Object[] parameters);
		MamNonSoDauBai GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MamNonSoDauBai vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MamNonSoDauBai _MamNonSoDauBai);
		/// <summary>
		/// Insert danh sách đối tượng MamNonSoDauBai vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais);
		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MamNonSoDauBai _MamNonSoDauBai, String Id);
		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MamNonSoDauBai _MamNonSoDauBai);
		/// <summary>
		/// Cập nhật danh sách MamNonSoDauBai vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais);
		/// <summary>
		/// Cập nhật MamNonSoDauBai vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MamNonSoDauBai _MamNonSoDauBai, string condition);
		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MamNonSoDauBai _MamNonSoDauBai);
		/// <summary>
		/// Xóa MamNonSoDauBai trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MamNonSoDauBai trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MamNonSoDauBai> _MamNonSoDauBais);
	}
}
