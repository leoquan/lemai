using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdoisoatchitiet
	{
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTiet từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTiet từ Database
		/// </summary>
		List<GExpDoiSoatChiTiet> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDoiSoatChiTiet từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDoiSoatChiTiet> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDoiSoatChiTiet> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDoiSoatChiTiet từ Database
		/// </summary>
		GExpDoiSoatChiTiet GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDoiSoatChiTiet đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDoiSoatChiTiet GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDoiSoatChiTiet GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDoiSoatChiTiet vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet);
		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoatChiTiet vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet, String Id);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet);
		/// <summary>
		/// Cập nhật danh sách GExpDoiSoatChiTiet vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets);
		/// <summary>
		/// Cập nhật GExpDoiSoatChiTiet vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet, string condition);
		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDoiSoatChiTiet _GExpDoiSoatChiTiet);
		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDoiSoatChiTiet trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDoiSoatChiTiet> _GExpDoiSoatChiTiets);
	}
}
