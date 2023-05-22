using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public partial class WebsiteUserLogic : BaseLogic
    {
        public WebsiteUserLogic(BaseLogicConnectionData data) : base(data)
        {

        }
        public async Task<ExpCustomer> LoginCustomer(string customerCode, string passcode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.EXpcustomer.GetObjectCon(base.ConnectionData.Schema, "WHERE CustomerCode=@CustomerCode AND CustomerCodePass=@CustomerCodePass",
                    "@CustomerCode", customerCode,
                    "@CustomerCodePass", passcode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dc.Close();
            }
        }

        public async Task<string> ChangePassCustomer(string oldPass, string newPass, string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                ExpCustomer customer = dc.EXpcustomer.GetObject(base.ConnectionData.Schema, Id);
                if (customer != null)
                {
                    if (customer.CustomerCodePass != oldPass)
                    {
                        return "Mật khẩu hiện tại không đúng!";
                    }
                    customer.CustomerCodePass = newPass.Trim();
                    dc.EXpcustomer.Update(base.ConnectionData.Schema, customer);
                    dc.SubmitChanges();
                    return string.Empty;
                }
                else
                {
                    return "Lỗi đăng nhập";
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
        }
    }
}
