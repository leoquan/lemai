using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LeMaiDesktop
{
	public class PermissionExtension
	{
		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		/// <summary>
		/// Get Form with Name
		/// </summary>
		/// <param name="FormName"></param>
		/// <returns></returns>
		public static Form GetFormWithName(string FormName)
		{
			try
			{
				var _formName = (from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
								 where t.Name.Equals(FormName)
								 select t.FullName).Single();
				var _form = (Form)Activator.CreateInstance(Type.GetType(_formName));
				if (_form != null)
					return _form;
				else
					return null;
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return null;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static List<string> GetListForm()
		{
			List<string> lsForm = new List<string>();
			Type formType = typeof(Form);
			foreach (Type type in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
			{
				if (formType.IsAssignableFrom(type))
				{
					lsForm.Add(type.Name);
				}
			}
			return lsForm;
		}
	}
}

