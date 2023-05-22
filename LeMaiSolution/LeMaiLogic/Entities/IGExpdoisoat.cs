using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpdoisoat
	{
		/// <summary>
		/// Lấy một DataTable GExpDoiSoat từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpDoiSoat từ Database
		/// </summary>
		List<GExpDoiSoat> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpDoiSoat từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpDoiSoat> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpDoiSoat> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpDoiSoat từ Database
		/// </summary>
		GExpDoiSoat GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpDoiSoat đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpDoiSoat GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpDoiSoat GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpDoiSoat vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpDoiSoat _GExpDoiSoat);
		/// <summary>
		/// Insert danh sách đối tượng GExpDoiSoat vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats);
		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpDoiSoat _GExpDoiSoat, String Id);
		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpDoiSoat _GExpDoiSoat);
		/// <summary>
		/// Cập nhật danh sách GExpDoiSoat vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats);
		/// <summary>
		/// Cập nhật GExpDoiSoat vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpDoiSoat _GExpDoiSoat, string condition);
		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpDoiSoat _GExpDoiSoat);
		/// <summary>
		/// Xóa GExpDoiSoat trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpDoiSoat trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpDoiSoat> _GExpDoiSoats);
	}
}
