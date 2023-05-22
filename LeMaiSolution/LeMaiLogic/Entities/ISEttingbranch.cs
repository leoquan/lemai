using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface ISEttingbranch
	{
		/// <summary>
		/// Lấy một DataTable SettingBranch từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable SettingBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách SettingBranch từ Database
		/// </summary>
		List<SettingBranch> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách SettingBranch từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<SettingBranch> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<SettingBranch> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một SettingBranch từ Database
		/// </summary>
		SettingBranch GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một SettingBranch đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		SettingBranch GetObjectCon(string schema, string condition, params Object[] parameters);
		SettingBranch GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới SettingBranch vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, SettingBranch _SettingBranch);
		/// <summary>
		/// Insert danh sách đối tượng SettingBranch vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<SettingBranch> _SettingBranchs);
		/// <summary>
		/// Cập nhật SettingBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, SettingBranch _SettingBranch, String Id);
		/// <summary>
		/// Cập nhật SettingBranch vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, SettingBranch _SettingBranch);
		/// <summary>
		/// Cập nhật danh sách SettingBranch vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<SettingBranch> _SettingBranchs);
		/// <summary>
		/// Cập nhật SettingBranch vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, SettingBranch _SettingBranch, string condition);
		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, SettingBranch _SettingBranch);
		/// <summary>
		/// Xóa SettingBranch trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa SettingBranch trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<SettingBranch> _SettingBranchs);
	}
}
