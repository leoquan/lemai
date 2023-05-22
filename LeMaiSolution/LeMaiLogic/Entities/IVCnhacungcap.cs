using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCnhacungcap
	{
		/// <summary>
		/// Lấy một DataTable VCNhaCungCap từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCNhaCungCap từ Database
		/// </summary>
		List<VCNhaCungCap> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCNhaCungCap từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCNhaCungCap> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCNhaCungCap> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCNhaCungCap từ Database
		/// </summary>
		VCNhaCungCap GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCNhaCungCap đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCNhaCungCap GetObjectCon(string schema, string condition, params Object[] parameters);
		VCNhaCungCap GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCNhaCungCap vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCNhaCungCap _VCNhaCungCap);
		/// <summary>
		/// Insert danh sách đối tượng VCNhaCungCap vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps);
		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCNhaCungCap _VCNhaCungCap, String Id);
		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCNhaCungCap _VCNhaCungCap);
		/// <summary>
		/// Cập nhật danh sách VCNhaCungCap vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps);
		/// <summary>
		/// Cập nhật VCNhaCungCap vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCNhaCungCap _VCNhaCungCap, string condition);
		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCNhaCungCap _VCNhaCungCap);
		/// <summary>
		/// Xóa VCNhaCungCap trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCNhaCungCap trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCNhaCungCap> _VCNhaCungCaps);
	}
}
