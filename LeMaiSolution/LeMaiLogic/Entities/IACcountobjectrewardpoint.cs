using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IACcountobjectrewardpoint
	{
		/// <summary>
		/// Lấy một DataTable AccountObjectRewardPoint từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable AccountObjectRewardPoint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách AccountObjectRewardPoint từ Database
		/// </summary>
		List<AccountObjectRewardPoint> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách AccountObjectRewardPoint từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<AccountObjectRewardPoint> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<AccountObjectRewardPoint> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một AccountObjectRewardPoint từ Database
		/// </summary>
		AccountObjectRewardPoint GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một AccountObjectRewardPoint đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		AccountObjectRewardPoint GetObjectCon(string schema, string condition, params Object[] parameters);
		AccountObjectRewardPoint GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới AccountObjectRewardPoint vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint);
		/// <summary>
		/// Insert danh sách đối tượng AccountObjectRewardPoint vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints);
		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint, String Id);
		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint);
		/// <summary>
		/// Cập nhật danh sách AccountObjectRewardPoint vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints);
		/// <summary>
		/// Cập nhật AccountObjectRewardPoint vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint, string condition);
		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, AccountObjectRewardPoint _AccountObjectRewardPoint);
		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa AccountObjectRewardPoint trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<AccountObjectRewardPoint> _AccountObjectRewardPoints);
	}
}
