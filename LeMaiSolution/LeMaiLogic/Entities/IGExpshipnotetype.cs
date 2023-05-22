using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IGExpshipnotetype
	{
		/// <summary>
		/// Lấy một DataTable GExpShipNoteType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable GExpShipNoteType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách GExpShipNoteType từ Database
		/// </summary>
		List<GExpShipNoteType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách GExpShipNoteType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<GExpShipNoteType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<GExpShipNoteType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một GExpShipNoteType từ Database
		/// </summary>
		GExpShipNoteType GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một GExpShipNoteType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		GExpShipNoteType GetObjectCon(string schema, string condition, params Object[] parameters);
		GExpShipNoteType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới GExpShipNoteType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, GExpShipNoteType _GExpShipNoteType);
		/// <summary>
		/// Insert danh sách đối tượng GExpShipNoteType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes);
		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, GExpShipNoteType _GExpShipNoteType, String Id);
		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, GExpShipNoteType _GExpShipNoteType);
		/// <summary>
		/// Cập nhật danh sách GExpShipNoteType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes);
		/// <summary>
		/// Cập nhật GExpShipNoteType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, GExpShipNoteType _GExpShipNoteType, string condition);
		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, GExpShipNoteType _GExpShipNoteType);
		/// <summary>
		/// Xóa GExpShipNoteType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa GExpShipNoteType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<GExpShipNoteType> _GExpShipNoteTypes);
	}
}
