using LeMaiDomain;
using System;

namespace LeMaiLogic
{
	public class BaseLogic
	{
		public BaseLogicConnectionData ConnectionData { get;  set; }
		public BaseLogic(BaseLogicConnectionData data)
		{
			ConnectionData = data;
	   
		}

		/// <summary>
		/// Get Value
		/// </summary>
		/// <param name="arrParam"></param>
		/// <returns></returns>
		public static object[] getParams(params object[] arrParam)
		{
			object[] retValue = new object[arrParam.Length];
			int i = 0;
			for (i = 0; i <= arrParam.Length - 1; i++)
			{
				retValue[i] = arrParam[i];
			}
			return retValue;
		}
		public static string UnSigns(string text)
		{
			string result = text.ToLower();
			string sign = "ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý";
			string unsign = "aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyy";
			for (int i = 0; i < sign.Length; i++)
			{
				result = result.Replace(sign.Substring(i, 1), unsign.Substring(i, 1));
			}
			return result;
		}
        public string MakeNotForScan(string TrackId, params Object[] parameters)
        {
            string Note = string.Empty;
            IDataContext dc = new dcDataContextM(ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpScanType stype = dc.GExpscantype.GetObject(ConnectionData.Schema, TrackId);
                if (stype != null)
                {
                    Note = string.Format(stype.FormatRegexString, parameters);
                }
                else
                {
                    foreach (var para in parameters)
                    {
                        Note = Note + para.ToString() + " ";
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
            return Note;
        }
    }
}


