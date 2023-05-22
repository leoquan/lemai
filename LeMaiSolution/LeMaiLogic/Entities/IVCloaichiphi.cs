using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IVCloaichiphi
	{
		/// <summary>
		/// Lấy một DataTable VCLoaiChiPhi từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable VCLoaiChiPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách VCLoaiChiPhi từ Database
		/// </summary>
		List<VCLoaiChiPhi> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách VCLoaiChiPhi từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<VCLoaiChiPhi> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<VCLoaiChiPhi> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một VCLoaiChiPhi từ Database
		/// </summary>
		VCLoaiChiPhi GetObject(string schema, String Id);
		/// <summary>
		/// Lấy một VCLoaiChiPhi đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		VCLoaiChiPhi GetObjectCon(string schema, string condition, params Object[] parameters);
		VCLoaiChiPhi GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới VCLoaiChiPhi vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, VCLoaiChiPhi _VCLoaiChiPhi);
		/// <summary>
		/// Insert danh sách đối tượng VCLoaiChiPhi vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis);
		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, VCLoaiChiPhi _VCLoaiChiPhi, String Id);
		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, VCLoaiChiPhi _VCLoaiChiPhi);
		/// <summary>
		/// Cập nhật danh sách VCLoaiChiPhi vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis);
		/// <summary>
		/// Cập nhật VCLoaiChiPhi vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, VCLoaiChiPhi _VCLoaiChiPhi, string condition);
		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String Id);
		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, VCLoaiChiPhi _VCLoaiChiPhi);
		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa VCLoaiChiPhi trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<VCLoaiChiPhi> _VCLoaiChiPhis);
	}
}
