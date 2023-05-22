using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdoisoatchitietct
	{
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTietCt từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTietCt từ Database
		/// </summary>
		List<GExpDoiSoatChiTietCt> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTietCt từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDoiSoatChiTietCt> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDoiSoatChiTietCt> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDoiSoatChiTietCt từ Database
		/// </summary>
		GExpDoiSoatChiTietCt GetObject(string schema, String BillCode);
		/// <summary>
		/// Lấy một GExpDoiSoatChiTietCt đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDoiSoatChiTietCt GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDoiSoatChiTietCt GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDoiSoatChiTietCt vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt);
		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatChiTietCt vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt, String BillCode);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt);
		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatChiTietCt vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTietCt vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt, string condition);
		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String BillCode);
		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDoiSoatChiTietCt _GExpDoiSoatChiTietCt);
		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDoiSoatChiTietCt trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDoiSoatChiTietCt> _GExpDoiSoatChiTietCts);
	}
}
