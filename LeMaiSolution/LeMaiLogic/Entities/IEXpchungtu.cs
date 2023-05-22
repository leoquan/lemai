using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpchungtu
	{
		/// <summary>
		/// Lấy một DataTable ExpChungTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpChungTu từ Database
		/// </summary>
		List<ExpChungTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpChungTu từ Database
		/// </summary>
		ExpChungTu GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpChungTu GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpChungTu vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpChungTu _ExpChungTu);
		/// <summary>
		/// Insert danh sách đối tượng ExpChungTu vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpChungTu> _ExpChungTus);
		/// <summary>
		/// Cập nhật ExpChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpChungTu _ExpChungTu, String Id);
		/// <summary>
		/// Cập nhật ExpChungTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpChungTu _ExpChungTu);
		/// <summary>
		/// Cập nhật danh sách ExpChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpChungTu> _ExpChungTus);
		/// <summary>
		/// Cập nhật ExpChungTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpChungTu _ExpChungTu, string condition);
		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpChungTu _ExpChungTu);
		/// <summary>
		/// Xóa ExpChungTu trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpChungTu trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpChungTu> _ExpChungTus);
	}
}
