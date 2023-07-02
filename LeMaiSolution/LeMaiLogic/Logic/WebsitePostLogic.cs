using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class WebsitePostLogic: BaseLogic
    {
        public WebsitePostLogic(BaseLogicConnectionData data) : base(data)
        {

        }
        public async Task<AccountObject> LoginCustomer(string customerCode, string passcode)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                passcode = HasMethod.GetMD5(passcode);
                return dc.ACcountobject.GetObjectCon(base.ConnectionData.Schema, "WHERE UserName=@UserName AND PassWord=@PassWord",
                    "@UserName", customerCode,
                    "@PassWord", passcode);
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
