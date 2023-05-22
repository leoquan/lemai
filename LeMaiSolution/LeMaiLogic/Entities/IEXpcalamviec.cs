using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpcalamviec
	{
		/// <summary>
		/// Lấy một DataTable ExpCaLamViec từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpCaLamViec từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpCaLamViec từ Database
		/// </summary>
		List<ExpCaLamViec> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpCaLamViec từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpCaLamViec> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpCaLamViec> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpCaLamViec từ Database
		/// </summary>
		ExpCaLamViec GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpCaLamViec đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpCaLamViec GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpCaLamViec GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpCaLamViec vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpCaLamViec _ExpCaLamViec);
		/// <summary>
		/// Insert danh sách đối tượng ExpCaLamViec vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs);
		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpCaLamViec _ExpCaLamViec, String Id);
		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpCaLamViec _ExpCaLamViec);
		/// <summary>
		/// Cập nhật danh sách ExpCaLamViec vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs);
		/// <summary>
		/// Cập nhật ExpCaLamViec vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpCaLamViec _ExpCaLamViec, string condition);
		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpCaLamViec _ExpCaLamViec);
		/// <summary>
		/// Xóa ExpCaLamViec trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpCaLamViec trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpCaLamViec> _ExpCaLamViecs);
	}
}
