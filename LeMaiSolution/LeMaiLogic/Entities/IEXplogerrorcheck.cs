using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXplogerrorcheck
	{
		/// <summary>
		/// Lấy một DataTable ExpLogErrorCheck từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpLogErrorCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpLogErrorCheck từ Database
		/// </summary>
		List<ExpLogErrorCheck> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpLogErrorCheck từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpLogErrorCheck> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpLogErrorCheck> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpLogErrorCheck từ Database
		/// </summary>
		ExpLogErrorCheck GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một ExpLogErrorCheck đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpLogErrorCheck GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpLogErrorCheck GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpLogErrorCheck vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpLogErrorCheck _ExpLogErrorCheck);
		/// <summary>
		/// Insert danh sách đối tượng ExpLogErrorCheck vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks);
		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpLogErrorCheck _ExpLogErrorCheck, String Id);
		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpLogErrorCheck _ExpLogErrorCheck);
		/// <summary>
		/// Cập nhật danh sách ExpLogErrorCheck vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks);
		/// <summary>
		/// Cập nhật ExpLogErrorCheck vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpLogErrorCheck _ExpLogErrorCheck, string condition);
		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpLogErrorCheck _ExpLogErrorCheck);
		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpLogErrorCheck trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpLogErrorCheck> _ExpLogErrorChecks);
	}
}
