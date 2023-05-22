using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdhistory
	{
		/// <summary>
		/// Lấy một DataTable MedHiStory từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedHiStory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedHiStory từ Database
		/// </summary>
		List<MedHiStory> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedHiStory từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedHiStory> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedHiStory> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedHiStory từ Database
		/// </summary>
		MedHiStory GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedHiStory đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedHiStory GetObjectCon(string schema, string condition, params Object[] parameters);
		MedHiStory GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedHiStory vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedHiStory _MedHiStory);
		/// <summary>
		/// Insert danh sách đối tượng MedHiStory vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedHiStory> _MedHiStorys);
		/// <summary>
		/// Cập nhật MedHiStory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedHiStory _MedHiStory, String id);
		/// <summary>
		/// Cập nhật MedHiStory vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedHiStory _MedHiStory);
		/// <summary>
		/// Cập nhật danh sách MedHiStory vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedHiStory> _MedHiStorys);
		/// <summary>
		/// Cập nhật MedHiStory vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedHiStory _MedHiStory, string condition);
		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedHiStory _MedHiStory);
		/// <summary>
		/// Xóa MedHiStory trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedHiStory trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedHiStory> _MedHiStorys);
	}
}
