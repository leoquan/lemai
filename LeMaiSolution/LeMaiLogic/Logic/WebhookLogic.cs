using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{
    public class WebhookLogic : BaseLogic
    {
        public WebhookLogic(BaseLogicConnectionData data) : base(data)
        {
        }
        public async Task<bool> addWebhook(string content, string provider)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpWebhook webhook = new GExpWebhook();
                webhook.Id = Guid.NewGuid().ToString();
                webhook.Provider = provider;
                webhook.JsonContent = content;
                webhook.CreateDate = DateTime.Now;
                webhook.IsProcess = false;
                dc.GExpwebhook.InsertOnSubmit(base.ConnectionData.Schema, webhook);
                dc.SubmitChanges();
                return true;
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
