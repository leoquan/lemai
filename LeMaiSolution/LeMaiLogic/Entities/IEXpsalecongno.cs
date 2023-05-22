using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpsalecongno
	{
		/// <summary>
		/// Lấy một DataTable ExpSaleCongNo từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpSaleCongNo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpSaleCongNo từ Database
		/// </summary>
		List<ExpSaleCongNo> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpSaleCongNo từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpSaleCongNo> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpSaleCongNo> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpSaleCongNo từ Database
		/// </summary>
		ExpSaleCongNo GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpSaleCongNo đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpSaleCongNo GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpSaleCongNo GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpSaleCongNo vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpSaleCongNo _ExpSaleCongNo);
		/// <summary>
		/// Insert danh sách đối tượng ExpSaleCongNo vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos);
		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpSaleCongNo _ExpSaleCongNo, String Id);
		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpSaleCongNo _ExpSaleCongNo);
		/// <summary>
		/// Cập nhật danh sách ExpSaleCongNo vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos);
		/// <summary>
		/// Cập nhật ExpSaleCongNo vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpSaleCongNo _ExpSaleCongNo, string condition);
		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpSaleCongNo _ExpSaleCongNo);
		/// <summary>
		/// Xóa ExpSaleCongNo trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpSaleCongNo trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpSaleCongNo> _ExpSaleCongNos);
	}
}
