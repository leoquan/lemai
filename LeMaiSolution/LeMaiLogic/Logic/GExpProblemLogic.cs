using LeMaiDomain;
using System;
using System.Collections.Generic;

namespace LeMaiLogic.Logic
{

    public partial class GExpProblemLogic : BaseLogic
    {
        public GExpProblemLogic(BaseLogicConnectionData data) : base(data)
        {
        }

        public List<view_GExpProblem> GetListProblem(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_Customer='" + customerId + "'";
                return dc.VIewgexpproblem.GetListObjectCon(base.ConnectionData.Schema, condition);
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

