using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LeMaiLogic
{
	public partial class dcDataContextM : IDataContext
	{
		protected SqlTransaction _transaction = null;
		private SqlConnection _connection = null;

		/// <summary>
		/// Đối tượng Connecion hiện tại của lớp dữ liệu.
		/// </summary>
		public SqlConnection Connection
		{
			get { return _connection; }
		}

		/// <summary>
		/// Khởi tạo mới một đối tượng dcDataContext không có tham số đầu vào. Sử dụng kết nối dữ liệu mặc định
		/// </summary>
		public dcDataContextM()
		{
			//Connection string mặc định sẽ lấy theo connection khi Gender ra file dcDataContext
			_connection = new SqlConnection("Server=miendongitc.com,8899;User Id=sa;Password=1@qweQAZ;Database=pmsat;");
			this.InitContext();
		}

		/// <summary>
		/// Khởi tạo mới một đối tượng dcDataContext với tham số đầu vào là chuỗi kết nối đến database.
		/// </summary>
		/// <param name="connectionString">Chuỗi kết nối đến cơ sở dữ liệu</param>
		public dcDataContextM(string connectionString)
		{
			_connection = new SqlConnection(connectionString);
			this.InitContext();
		}

		/// <summary>
		/// Khởi tạo mới một đối tượng dcDataContext với tham số đầu vào là một đối tượng Connection.
		/// </summary>
		/// <param name="connection"></param>
		public dcDataContextM(SqlConnection connection)
		{
			_connection = connection;
			this.InitContext();
		}

		/// <summary>
		/// Hoàn tất việc thay đổi dữ liệu xuống Database khi thực thi các câu lệnh inserted, updated, hoặc deleted.
		/// </summary>
		public void SubmitChanges()
		{
			try
			{
				_transaction.Commit();
				//Insert những câu sql để cho việc đồng bộ dữ liệu ở đây

			}
			catch (Exception ex)
			{
				_transaction.Rollback();
				throw ex;
			}

		}

		/// <summary>
		/// Đóng kết nối và giải phóng bộ nhớ được sử dụng.
		/// </summary>
		public void Close()
		{
			if (_connection != null)
			{
				if (_connection.State == ConnectionState.Open)
				{
					_connection.Close();
				}
			}
		}

		public void Open()
		{
			_connection.Open();
			_transaction = _connection.BeginTransaction();
		}

		/// <summary>
		/// Tiếp tục kết nối dữ liệu mà không cần phải Open lại connection
		/// </summary>
		public void RestartTransaction()
		{
			_transaction = _connection.BeginTransaction();
		}
		/// <summary>
		/// Kiểm tra xem schema có tồn tại trong database hay không?
		/// </summary>
		/// <param name="schema">Tên schema cần kiểm tra</param>
		/// <returns>True: Nếu như schema có tồn tại trong database, False: schema không tồn tại.</returns>
		public Boolean SchemaExist(String schema)
		{
			try
			{
				return true;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Lấy ngày giờ của Server
		/// </summary>
		/// <returns></returns>
		public DateTime CurrentTime()
		{
			try
			{
				string s = this.GetData("SELECT FORMAT(getdate(), 'dd/MM/yyyy HH:mm:ss') as date").Rows[0][0].ToString();
				return DateTime.ParseExact(s, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Lấy ngày giờ của Server UTC
		/// </summary>
		/// <returns></returns>
		public DateTime CurrentTimeUTC()
		{
			try
			{
				string s = this.GetData("SELECT FORMAT(getdate(), 'dd/MM/yyyy HH:mm:ss') as date").Rows[0][0].ToString();
				return DateTime.ParseExact(s, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Fill data từ Adapter vào trong một Datable
		/// </summary>
		/// <param name="table">Datable Cần fill dữ liệu</param>
		/// <param name="sql">Câu truy vấn dữ liệu</param>
		/// <param name="parameters">Tham số truy vấn dữ liệu</param>
		/// <returns>Datable dữ liệu kết quả</returns>
		private DataTable Fill(DataTable table, String sql, params Object[] parameters)
		{
			try
			{
				SqlCommand Ncommand = this.CreateCommand(sql, parameters);
				new SqlDataAdapter(Ncommand).Fill(table);
				return table;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Fill data từ Adapter vào trong một Datable
		/// </summary>
		/// <param name="table">Datable Cần fill dữ liệu</param>
		/// <param name="storeName">Tên Store</param>
		/// <param name="parameters">Tham số truy vấn dữ liệu</param>
		/// <returns>Datable dữ liệu kết quả</returns>
		private DataTable FillStore(DataTable table, String storeName, params Object[] parameters)
		{
			try
			{
				SqlCommand Ncommand = this.CreateCommand(storeName, parameters);
				Ncommand.CommandType = CommandType.StoredProcedure;
				new SqlDataAdapter(Ncommand).Fill(table);
				return table;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: select * from table where id=@id and name=@name</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		public DataTable GetData(String sql, params Object[] parameters)
		{
			return this.Fill(new DataTable(), sql, parameters);
		}

		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="storeName">Tên Store</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		public DataTable GetDataStore(String storeName, params Object[] parameters)
		{
			return this.FillStore(new DataTable(), storeName, parameters);
		}

		/// <summary>
		/// Nhận dữ liệu từ database, kiểu dữ liệu dạng Datable
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: select * from table where id=@id and name=@name</param>
		/// <param name="start_record">Dòng dữ liệu bắt đầu lấy ra</param>
		/// <param name="max_record">Số dòng cần lấy ra</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Dữ liệu có trong Database</returns>
		public DataTable GetDataRows(String sql, int start_record, int max_record, params Object[] parameters)
		{
			try
			{
				DataTable table = new DataTable();
				SqlCommand Mcmd = this.CreateCommand(sql, parameters);
				new SqlDataAdapter(Mcmd).Fill(start_record, max_record, table);
				return table;
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Truy vấn dữ liệu dạng Update, Delete, Insert
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu SQL. VD: delete table where id=@id and name=@name</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Số dòng dữ liệu thực hiện được</returns>
		public int ExecuteNonQuery(String sql, params Object[] parameters)
		{
			try
			{
				SqlCommand command = this.CreateCommand(sql, parameters);
				return command.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Truy vấn dữ liệu dạng Update, Delete, Insert sử dụng Store
		/// </summary>
		/// <param name="storeName">Tên của Store</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Số dòng dữ liệu thực hiện được</returns>
		public int ExecuteNonQueryStore(String storeName, params Object[] parameters)
		{
			try
			{
				SqlCommand command = this.CreateCommand(storeName, parameters);
				command.CommandType = CommandType.StoredProcedure;
				return command.ExecuteNonQuery();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Thực hiện truy vẫn dữ liệu thuộc dạng List Command
		/// </summary>
		/// <param name="commandtext">List command</param>
		public void ExcuteListCommand(List<string> commandtext)
		{
			SqlCommand command = null;
			try
			{
				command = new SqlCommand();
				command.Connection = _connection;
				command.Transaction = _transaction;
				foreach (string cmd in commandtext)
				{
					command.CommandText = cmd;
					command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Truy vấn trả về một đối tượng tùy thuộc vào câu truy vấn. Thường sử dụng cho các dạng câu select max, avg, sum, count...
		/// </summary>
		/// <param name="sql">Câu truy vấn</param>
		/// <param name="parameters">Các tham số đầu vào theo định dạng "@ten_tham_so","gia_tri_tham_so". VD: "@id", "1", "@name","name"</param>
		/// <returns>Một object kết quả, phụ thuộc vào câu truy vấn</returns>
		public object ExecuteScalar(String sql, params Object[] parameters)
		{
			try
			{
				SqlCommand command = this.CreateCommand(sql, parameters);
				return command.ExecuteScalar();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// Get Data with SP
		/// </summary>
		/// <param name="storeName"></param>
		/// <param name="parameters"></param>
		/// <returns>1 Datatable</returns>
		public DataTable ExecuteNonQueryStoreReturnValue(String storeName, params Object[] parameters)
		{
			try
			{
				DataTable dt = new DataTable();
				SqlCommand command = this.CreateCommand(storeName, parameters);
				command.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(command);
				da.Fill(dt);
				return dt;
			}
			catch
			{
				throw;
			}
		}

		/// Get Data with SP
		/// </summary>
		/// <param name="storeName"></param>
		/// <param name="parameters"></param>
		/// <returns>SqlCommand</returns>
		public SqlCommand ExecuteNonQueryStoreReturn_MutilValue(String storeName, params Object[] parameters)
		{
			try
			{
				SqlCommand command = this.CreateCommand(storeName, parameters);
				command.CommandType = CommandType.StoredProcedure;
				command.ExecuteNonQuery();
				return command;
			}
			catch
			{
				throw;
			}
		}


		/// <summary>
		/// Tạo ra NpgsqlCommand từ mảng parameters
		/// </summary>
		/// <param name="sql">Câu truy vấn dữ liệu</param>
		/// <param name="parameters">Parameters</param>
		/// <returns></returns>
		private SqlCommand CreateCommand(String sql, params Object[] parameters)
		{
			try
			{
				SqlCommand command = new SqlCommand(sql, _connection);
				for (int i = 0; i < parameters.Length; i += 2)
				{
					if (parameters[i + 1] == null)
					{
						command.Parameters.AddWithValue(parameters[i].ToString(), DBNull.Value);
					}
					else
					{
						if (parameters[i + 1].ToString() == "OUT")
						{
							var outParam = new SqlParameter(parameters[i].ToString(), SqlDbType.NVarChar, - 1);
							outParam.Direction = ParameterDirection.Output;
							command.Parameters.Add(outParam);
						}
						else
						{
							command.Parameters.AddWithValue(parameters[i].ToString(), parameters[i + 1]);
						}
					}
				}
				command.Transaction = _transaction;
				return command;
			}
			catch
			{
				throw;
			}
		}
		/// <summary>
		/// Convert Datetime to String
		/// </summary>
		/// <param name="datetime">Input Datetime</param>
		/// <returns></returns>
		public string ConvertDateString(DateTime? datetime)
		{
			if (datetime == null)
			{
				return null;
			}
			else
			{
				DateTime d = (DateTime)datetime;
				StringBuilder result = new StringBuilder();
				result.Append(d.Year.ToString().PadLeft(4, '0'));
				result.Append("-");
				result.Append(d.Month.ToString().PadLeft(2, '0'));
				result.Append("-");
				result.Append(d.Day.ToString().PadLeft(2, '0'));
				result.Append(" ");
				result.Append(d.Hour.ToString().PadLeft(2, '0'));
				result.Append(":");
				result.Append(d.Minute.ToString().PadLeft(2, '0'));
				result.Append(":");
				result.Append(d.Second.ToString().PadLeft(2, '0'));
				result.Append(".");
				result.Append(d.Millisecond.ToString().PadLeft(3, '0'));
				return result.ToString();
			}
		}
	}
}
