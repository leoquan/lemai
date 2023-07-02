using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ReportUtilFormat
    {
        public string ControlName { get; set; }
        public string Format { get; set; }
    }
    public class ReportUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rpt"></param>
        /// <param name="data"></param>
        public static void BindingData(XtraReport rpt, Object data, List<ReportUtilFormat> formats)
        {
            var listControl = rpt.AllControls<XRControl>();
            Type myType = data.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(data, null);
                if (propValue != null)
                {
                    var controls = listControl.Where(u => u.Name.StartsWith("xr" + prop.Name) || u.Name.EndsWith("_" + prop.Name)).ToList();
                    foreach (var con in controls)
                    {
                        var format = formats.FirstOrDefault(u => u.ControlName == con.Name);
                        if (format != null)
                        {
                            con.Text = string.Format(format.Format, propValue);
                        }
                        else
                        {
                            con.Text = propValue.ToString();
                        }
                    }
                }

            }
        }
    }
}
