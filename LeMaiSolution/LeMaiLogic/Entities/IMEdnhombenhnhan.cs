using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Data;
namespace LeMaiLogic
{
	public interface IMEdnhombenhnhan
	{
		/// <summary>
		/// Lấy một DataTable MedNhomBenhNhan từ Database
		/// </summary>
		DataTable GetDataTable(string schema);
		/// <summary>
		/// Lấy một DataTable MedNhomBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		DataTable GetDataTable(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Lấy danh sách MedNhomBenhNhan từ Database
		/// </summary>
		List<MedNhomBenhNhan> GetListObject(string schema);
		/// <summary>
		/// Lấy danh sách MedNhomBenhNhan từ Database có kèm theo điều kiện where, order by, group by
		/// </summary>
		List<MedNhomBenhNhan> GetListObjectCon(string schema, string condition,  params Object[] parameters);
		List<MedNhomBenhNhan> GetListObjectLimitCon(string schema, string columns, string condition, int take, int skip, params Object[] parameters);
		/// <summary>
		/// Lấy một MedNhomBenhNhan từ Database
		/// </summary>
		MedNhomBenhNhan GetObject(string schema, String id);
		/// <summary>
		/// Lấy một MedNhomBenhNhan đầu tiên từ Database thỏa điền kiện của condition
		/// </summary>
		MedNhomBenhNhan GetObjectCon(string schema, string condition, params Object[] parameters);
		MedNhomBenhNhan GetObjectLimitCon(string schema, string columns, string condition, params Object[] parameters);
		/// <summary>
		/// Thêm mới MedNhomBenhNhan vào Database
		/// </summary>
		bool InsertOnSubmit(string schema, MedNhomBenhNhan _MedNhomBenhNhan);
		/// <summary>
		/// Insert danh sách đối tượng MedNhomBenhNhan vào database
		/// </summary>
		/// <returns></returns>
		void InsertAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans);
		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		int Update(string schema, MedNhomBenhNhan _MedNhomBenhNhan, String id);
		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database với chính đối tượng được truyền vào. Không cho phép cập nhật khóa chính
		/// </summary>
		int Update(string schema, MedNhomBenhNhan _MedNhomBenhNhan);
		/// <summary>
		/// Cập nhật danh sách MedNhomBenhNhan vào Database. Cho phép cập nhật khóa chính.
		/// </summary>
		void UpdateAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans);
		/// <summary>
		/// Cập nhật MedNhomBenhNhan vào Database với điều kiện where truyền vào condition. Cho phép cập nhật khóa chính.
		/// </summary>
		int UpdateCon(string schema, MedNhomBenhNhan _MedNhomBenhNhan, string condition);
		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, String id);
		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		int DeleteOnSubmit(string schema, MedNhomBenhNhan _MedNhomBenhNhan);
		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database với điều kiện condition.
		/// </summary>
		int DeleteOnSubmitCon(string schema, string condition, params Object[] parameters);
		/// <summary>
		/// Xóa MedNhomBenhNhan trong Database
		/// </summary>
		void DeleteAllSubmit(string schema, List<MedNhomBenhNhan> _MedNhomBenhNhans);
	}
}
