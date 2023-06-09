using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace LeMaiLogic
{
	public static class MapperExtensionClass
	{
		/// <summary>
		/// Chuyển đổi List Generic sang Datatable
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="data"></param>
		/// <returns>Example: DataTable data = MapperExtensionClass.ToDataTable(lsData);</returns>
		public static DataTable ToDataTable<TSource>(IList<TSource> data)
		{
			DataTable dataTable = new DataTable(typeof(TSource).Name);
			PropertyInfo[] props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (PropertyInfo prop in props)
			{
				dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			}

			foreach (TSource item in data)
			{
				var values = new object[props.Length];
				for (int i = 0; i < props.Length; i++)
				{
					values[i] = props[i].GetValue(item, null);
				}
				dataTable.Rows.Add(values);
			}
			return dataTable;
		}
		/// <summary>
		/// Chuyển đổi Datatable sang Generic List
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="dataTable"></param>
		/// <returns>Example: List<abc> lsData = MapperExtensionClass.ToList<abc>(lsData); Với abc là tên class cần chuyển.</returns>
		public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
		{
			var dataList = new List<TSource>();

			const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
			var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
								 select new
								 {
									 Name = aProp.Name,
									 Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
						 aProp.PropertyType
								 }).ToList();
			var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
									 select new
									 {
										 Name = aHeader.ColumnName,
										 Type = aHeader.DataType
									 }).ToList();
			var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

			foreach (DataRow dataRow in dataTable.Rows)
			{
				var aTSource = new TSource();
				foreach (var aField in commonFields)
				{
					PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
					var value = (dataRow[aField.Name] == DBNull.Value) ?
					null : dataRow[aField.Name]; //if database field is nullable
					propertyInfos.SetValue(aTSource, value, null);
				}
				dataList.Add(aTSource);
			}
			return dataList;
		}
		/// <summary>
		/// Chuyển đổi DataTable sang Object
		/// </summary>
		/// <typeparam name="TSource">Đối tượng cần được chuyển đổi.</typeparam>
		/// <param name="dataTable">DataTable cần chuyển đổi</param>
		/// <returns>Trả về đối tượng được chuyển đổi, throw exception nếu có nhiều hơn 1 dòng dữ liệu. Sử dụng tương tự như ToList</returns>
		public static TSource ToObject<TSource>(this DataTable dataTable) where TSource : new()
		{
			var tSource = new TSource();
			if (dataTable.Rows.Count > 1)
			{
				throw new Exception("Có nhiều hơn 1 dòng dữ liệu! Vui lòng kiểm tra lại điều kiện!");
			}
			const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
			var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
								 select new
								 {
									 Name = aProp.Name,
									 Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
						 aProp.PropertyType
								 }).ToList();
			var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
									 select new
									 {
										 Name = aHeader.ColumnName,
										 Type = aHeader.DataType
									 }).ToList();
			var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

			foreach (DataRow dataRow in dataTable.Rows)
			{
				var aTSource = new TSource();
				foreach (var aField in commonFields)
				{
					PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
					var value = (dataRow[aField.Name] == DBNull.Value) ?
					null : dataRow[aField.Name]; //if database field is nullable
					propertyInfos.SetValue(aTSource, value, null);
				}
				return aTSource;
			}
			return tSource;
		}
	}
}

