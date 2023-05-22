
using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeMaiLogic
{
	public class WebOptionHelper
	{
        public static WebOption ReadWebOption(string connection, string schema, string branch)
		{
			IDataContext dc = new dcDataContextM(connection);
			try
			{
				dc.Open();
				List<WebConfig> lsSetting = dc.WEbconfig.GetListObjectCon(schema, "WHERE BranchCode=@BranchCode", "@BranchCode", branch);
                WebOption serverSetting = new WebOption();
				WebConfig setting;
				foreach (var prop in typeof(WebOption).GetProperties())
				{
					switch (prop.PropertyType.Name)
					{
						case "Boolean":
							setting = lsSetting.FirstOrDefault(u => u.KeyConfig == prop.Name);
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
							setting = lsSetting.FirstOrDefault(u => u.KeyConfig == prop.Name);
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
							setting = lsSetting.FirstOrDefault(u => u.KeyConfig == prop.Name);
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
							setting = lsSetting.FirstOrDefault(u => u.KeyConfig == prop.Name);
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
							setting = lsSetting.FirstOrDefault(u => u.KeyConfig == prop.Name);
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
		public void SaveWebOption(string connection)
		{
			IDataContext dc = new dcDataContextM(connection);
			try
			{
				dc.Open();
				foreach (var prop in typeof(WebOption).GetProperties())
				{
					WebConfig setting = dc.WEbconfig.GetObject("dbo", prop.Name);
					if (setting != null)
					{
						setting.Value = prop.GetValue(this, null).ToString();
						dc.WEbconfig.Update("dbo", setting);
					}
					else
					{
						setting = new WebConfig();
						setting.Id = prop.Name;
						setting.Value = prop.GetValue(this, null).ToString();
						setting.ConfigGroup = "system";
						dc.WEbconfig.InsertOnSubmit("dbo", setting);
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

