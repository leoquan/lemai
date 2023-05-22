using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeMaiLogic
{
	public class ServerOption
	{
		public string HOSPITAL_NAME { get; set; }
		public string HOSPITAL_ADDRESS { get; set; }
		public string HOSPITAL_PHONE { get; set; }
		public string HOSPITAL_SLOGAN { get; set; }
		public string LOGO_REPORT { get; set; }
		public string STARTUP_LOGO { get; set; }
		public string BACKGROUND_IMAGE { get; set; }
		public string FOOTER_COPYRIGHT { get; set; }
		public string SYSTEM_TITLE { get; set; }
		public string SIGNAL_HUB { get; set; }
		public string LOGOITEM { get; set; }
		public string CanhBaoBoQua { get; set; }
		public string CanhBaoBoQuaTitle { get; set; }
		public string CanhBaoHoanThanh { get; set; }
		public string CanhBaoHoanThanhTitle { get; set; }

		public static ServerOption ReadServerOption(string connection)
		{
			IDataContext dc = new dcDataContextM(connection);
			try
			{
				dc.Open();
				List<Setting> lsSetting = dc.SEtting.GetListObject("dbo");
				ServerOption serverSetting = new ServerOption();
				Setting setting;
				foreach (var prop in typeof(ServerOption).GetProperties())
				{
					switch (prop.PropertyType.Name)
					{
						case "Boolean":
							setting = lsSetting.FirstOrDefault(u => u.Id == prop.Name);
							if (setting != null)
							{
								bool value;
								if (!bool.TryParse(setting.Value, out value))
								{
									value = false;
								}
								prop.SetValue(serverSetting, value, null);
							}
							else
							{
								prop.SetValue(serverSetting, false, null);
							}
							break;
						case "Int32":
							setting = lsSetting.FirstOrDefault(u => u.Id == prop.Name);
							if (setting != null)
							{
								int value;
								if (!int.TryParse(setting.Value, out value))
								{
									value = 0;
								}
								prop.SetValue(serverSetting, value, null);
							}
							else
							{
								prop.SetValue(serverSetting, 0, null);
							}
							break;
						case "Decimal":
							setting = lsSetting.FirstOrDefault(u => u.Id == prop.Name);
							if (setting != null)
							{
								decimal value;
								if (!decimal.TryParse(setting.Value, out value))
								{
									value = 0;
								}
								prop.SetValue(serverSetting, value, null);
							}
							else
							{
								prop.SetValue(serverSetting, Convert.ToDecimal(0), null);
							}
							break;
						case "Double":
							setting = lsSetting.FirstOrDefault(u => u.Id == prop.Name);
							if (setting != null)
							{
								double value;
								if (!double.TryParse(setting.Value, out value))
								{
									value = 0;
								}
								prop.SetValue(serverSetting, value, null);
							}
							else
							{
								prop.SetValue(serverSetting, Convert.ToDouble(0), null);
							}
							break;
						case "String":
							setting = lsSetting.FirstOrDefault(u => u.Id == prop.Name);
							if (setting != null)
							{
								string value = setting.Value;
								prop.SetValue(serverSetting, value, null);
							}
							else
							{
								prop.SetValue(serverSetting, string.Empty, null);
							}
							break;
					}
				}
				return serverSetting;
			}
			catch
			{
				throw;
			}
			finally
			{
				dc.Close();
			}

		}
		public void SaveServerOption(string connection)
		{
			IDataContext dc = new dcDataContextM(connection);
			try
			{
				dc.Open();
				foreach (var prop in typeof(ServerOption).GetProperties())
				{
					Setting setting = dc.SEtting.GetObject("dbo", prop.Name);
					if (setting != null)
					{
						setting.Value = prop.GetValue(this, null).ToString();
						dc.SEtting.Update("dbo", setting);
					}
					else
					{
						setting = new Setting();
						setting.Id = prop.Name;
						setting.Value = prop.GetValue(this, null).ToString();
						dc.SEtting.InsertOnSubmit("dbo", setting);
					}
				}
				dc.SubmitChanges();
			}
			catch
			{
				throw;
			}
			finally
			{
				dc.Close();
			}
		}
	}
}

