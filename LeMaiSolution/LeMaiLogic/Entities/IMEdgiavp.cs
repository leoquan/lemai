using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdgiavp
	{
		/// <summary>
		/// Lấy một DataTable MedGiaVp từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedGiaVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedGiaVp từ Database
		/// </summary>
		List<MedGiaVp> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedGiaVp từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedGiaVp> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedGiaVp> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedGiaVp từ Database
		/// </summary>
		MedGiaVp GetObject(string schema, Int32 id);
		/// <summary>
		/// Lấy một MedGiaVp đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedGiaVp GetObjectCon(string schema, string condition, params Object[] parameters);
		MedGiaVp GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedGiaVp vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedGiaVp _MedGiaVp);
		/// <summary>
		/// Insert danh sách đối tượng MedGiaVp vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedGiaVp> _MedGiaVps);
		/// <summary>
		/// Cập nhật MedGiaVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedGiaVp _MedGiaVp, Int32 id);
		/// <summary>
		/// Cập nhật MedGiaVp vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedGiaVp _MedGiaVp);
		/// <summary>
		/// Cập nhật danh sách MedGiaVp vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedGiaVp> _MedGiaVps);
		/// <summary>
		/// Cập nhật MedGiaVp vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedGiaVp _MedGiaVp, string condition);
		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, Int32 id);
		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedGiaVp _MedGiaVp);
		/// <summary>
		/// Xóa MedGiaVp trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedGiaVp trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedGiaVp> _MedGiaVps);
	}
}
