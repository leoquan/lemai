using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IDYnamicfieldtype
	{
		/// <summary>
		/// Lấy một DataTable DynamicFieldType từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable DynamicFieldType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách DynamicFieldType từ Database
		/// </summary>
		List<DynamicFieldType> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách DynamicFieldType từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<DynamicFieldType> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<DynamicFieldType> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một DynamicFieldType từ Database
		/// </summary>
		DynamicFieldType GetObject(string schema, Int32 Id);
		/// <summary>
		/// Lấy một DynamicFieldType đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		DynamicFieldType GetObjectCon(string schema, string condition, params Object[] parameters);
		DynamicFieldType GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới DynamicFieldType vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, DynamicFieldType _DynamicFieldType);
		/// <summary>
		/// Insert danh sách đối tượng DynamicFieldType vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes);
		/// <summary>
		/// Cập nhật DynamicFieldType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, DynamicFieldType _DynamicFieldType, Int32 Id);
		/// <summary>
		/// Cập nhật DynamicFieldType vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, DynamicFieldType _DynamicFieldType);
		/// <summary>
		/// Cập nhật danh sách DynamicFieldType vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes);
		/// <summary>
		/// Cập nhật DynamicFieldType vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, DynamicFieldType _DynamicFieldType, string condition);
		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 Id);
		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, DynamicFieldType _DynamicFieldType);
		/// <summary>
		/// Xóa DynamicFieldType trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa DynamicFieldType trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<DynamicFieldType> _DynamicFieldTypes);
	}
}
