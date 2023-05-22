using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdsetting
	{
		/// <summary>
		/// Lấy một DataTable MedSetting từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedSetting từ Database
		/// </summary>
		List<MedSetting> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedSetting từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedSetting> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedSetting> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedSetting từ Database
		/// </summary>
		MedSetting GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedSetting đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedSetting GetObjectCon(string schema, string condition, params Object[] parameters);
		MedSetting GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedSetting vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedSetting _MedSetting);
		/// <summary>
		/// Insert danh sách đối tượng MedSetting vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedSetting> _MedSettings);
		/// <summary>
		/// Cập nhật MedSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedSetting _MedSetting, String id);
		/// <summary>
		/// Cập nhật MedSetting vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedSetting _MedSetting);
		/// <summary>
		/// Cập nhật danh sách MedSetting vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedSetting> _MedSettings);
		/// <summary>
		/// Cập nhật MedSetting vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedSetting _MedSetting, string condition);
		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedSetting _MedSetting);
		/// <summary>
		/// Xóa MedSetting trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedSetting trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedSetting> _MedSettings);
	}
}
