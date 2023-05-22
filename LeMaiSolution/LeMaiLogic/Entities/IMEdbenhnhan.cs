using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdbenhnhan
	{
		/// <summary>
		/// Lấy một DataTable MedBenhNhan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedBenhNhan từ Database
		/// </summary>
		List<MedBenhNhan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedBenhNhan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedBenhNhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedBenhNhan từ Database
		/// </summary>
		MedBenhNhan GetObject(string schema, String mabn);
		/// <summary>
		/// Lấy một MedBenhNhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedBenhNhan GetObjectCon(string schema, string condition, params Object[] parameters);
		MedBenhNhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedBenhNhan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedBenhNhan _MedBenhNhan);
		/// <summary>
		/// Insert danh sách đối tượng MedBenhNhan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans);
		/// <summary>
		/// Cập nhật MedBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedBenhNhan _MedBenhNhan, String mabn);
		/// <summary>
		/// Cập nhật MedBenhNhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedBenhNhan _MedBenhNhan);
		/// <summary>
		/// Cập nhật danh sách MedBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans);
		/// <summary>
		/// Cập nhật MedBenhNhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedBenhNhan _MedBenhNhan, string condition);
		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String mabn);
		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedBenhNhan _MedBenhNhan);
		/// <summary>
		/// Xóa MedBenhNhan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedBenhNhan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedBenhNhan> _MedBenhNhans);
	}
}
