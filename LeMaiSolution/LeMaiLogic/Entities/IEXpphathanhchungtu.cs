using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IEXpphathanhchungtu
	{
		/// <summary>
		/// Lấy một DataTable ExpPhatHanhChungTu từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable ExpPhatHanhChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách ExpPhatHanhChungTu từ Database
		/// </summary>
		List<ExpPhatHanhChungTu> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách ExpPhatHanhChungTu từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<ExpPhatHanhChungTu> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<ExpPhatHanhChungTu> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một ExpPhatHanhChungTu từ Database
		/// </summary>
		ExpPhatHanhChungTu GetObject(string schema, String BILL_CODE);
		/// <summary>
		/// Lấy một ExpPhatHanhChungTu đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		ExpPhatHanhChungTu GetObjectCon(string schema, string condition, params Object[] parameters);
		ExpPhatHanhChungTu GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới ExpPhatHanhChungTu vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu);
		/// <summary>
		/// Insert danh sách đối tượng ExpPhatHanhChungTu vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus);
		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu, String BILL_CODE);
		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu);
		/// <summary>
		/// Cập nhật danh sách ExpPhatHanhChungTu vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus);
		/// <summary>
		/// Cập nhật ExpPhatHanhChungTu vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu, string condition);
		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BILL_CODE);
		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, ExpPhatHanhChungTu _ExpPhatHanhChungTu);
		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa ExpPhatHanhChungTu trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<ExpPhatHanhChungTu> _ExpPhatHanhChungTus);
	}
}
