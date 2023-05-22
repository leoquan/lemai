using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LeMaiLogic
{
	public partial interface IDataContext
	{
		/// <summary>
		/// Hoàn tất việc thay đổi dữ liệu xuống Database khi thực thi các câu lệnh inserted, updated, hoặc deleted.
		/// </summary>
		void SubmitChanges();
		/// <summary>
		/// Đóng kết nối và giải phóng bộ nhớ được sử dụng.
		/// </summary>
		void Close();
		/// <summary>
		/// Open kết nối database
		/// </summary>
		void Open();
		/// <summary>
		/// Tiếp tục kết nối dữ liệu mà không cần phải Open lại connection
		/// </summary>
		void RestartTransaction();
		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: select * from table where id=@id and name=@name</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		DataTable GetData(String sql, params Object[] parameters);
		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="storeName">Tên StoredProcedure</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		DataTable GetDataStore(String storeName, params Object[] parameters);
		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: select * from table where id=@id and name=@name</param>
		/// <param name="start_record">Dòng dữ liệu bắt đầu lấy ra</param>
		/// <param name="max_record">Số dòng cần lấy ra</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		DataTable GetDataRows(String sql, int start_record, int max_record, params Object[] parameters);
		/// <summary>
		/// Truy vấn dữ liệu dạng Update, Delete, Insert
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: delete table where id=@id and name=@name</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Số dòng dữ liệu thực hiện được</returns>
		int ExecuteNonQuery(String sql, params Object[] parameters);
		/// <summary>
		/// Truy vấn dữ liệu dạng Update, Delete, Insert
		/// </summary>
		/// <param name="storeName">Tên StoredProcedure</param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		int ExecuteNonQueryStore(String storeName, params Object[] parameters);
		/// <summary>
		/// Truy vấn dữ liệu dạng Update, Delete, Insert return MultiValue
		/// </summary>
		/// <param name="storeName">Tên StoredProcedure</param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		SqlCommand ExecuteNonQueryStoreReturn_MutilValue(String storeName, params Object[] parameters);
		/// <summary>
		/// Truy vấn dữ liệu dạng Store return DataTable
		/// </summary>
		/// <param name="storeName">Tên StoredProcedure</param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		DataTable ExecuteNonQueryStoreReturnValue(String storeName, params Object[] parameters);
		/// <summary>
		/// Thực hiện truy vẫn dữ liệu thuộc dạng List Command
		/// </summary>
		/// <param name="commandtext">List command</param>
		void ExcuteListCommand(List<string> commandtext);
		/// <summary>
		/// Lấy ngày giờ hiện tại trên server
		/// </summary>
		/// <returns></returns>
		DateTime CurrentTime();
		/// <summary>
		/// Lấy ngày giờ hiện tại trên server UTC
		/// </summary>
		/// <returns></returns>
		DateTime CurrentTimeUTC();
		/// <summary>
		/// Truy vấn trả về một đối tượng tùy thuộc vào câu truy vấn. Thường sử dụng cho các dạng câu select max, avg, sum, count...
		/// </summary>
		/// <param name="sql">Câu truy vấn</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Một object kết quả, phụ thuộc vào câu truy vấn</returns>
		object ExecuteScalar(String sql, params Object[] parameters);
		/// <summary>
		/// Convert Datetime to String
		/// </summary>
		/// <param name="datetime">Input Datetime</param>
		/// <returns></returns>
		string ConvertDateString(DateTime? datetime);
	}
}
