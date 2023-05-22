using LeMaiDomain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeMaiLogic.Logic
{

    public partial class GExpOrderLogic : BaseLogic
    {
        public GExpOrderLogic(BaseLogicConnectionData data) : base(data)
        {
        }

        public List<view_GExpOrder> GetListDatDon(string customerId)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                string condition = "WHERE FK_CustomerId='" + customerId + "'";
                return dc.VIewgexporder.GetListObjectCon(base.ConnectionData.Schema, condition);
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


        public GExpOrder GetDetails(String IdOrder)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                return dc.GExporder.GetObjectCon(base.ConnectionData.Schema, " WHERE Id=@IdOrder ", "@IdOrder", IdOrder);
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

        public GExpOrder CreateOrder(GExpOrder input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpOrder item = new GExpOrder();
                DateTime currentDate = dc.CurrentTime();
                item.Id = Guid.NewGuid().ToString();
                item.OrderCode = string.Format("{0:yyMMddHHmmss}", DateTime.Now);
                item.AcceptName = input.AcceptName;
                item.AcceptAddress = input.AcceptAddress;
                item.AcceptPhone = input.AcceptPhone;
                item.GoodsName = input.GoodsName;
                item.COD = input.COD;
                item.IsShopPay = input.IsShopPay;
                item.Note = input.Note;
                item.CreateDate = currentDate;
                item.FK_CustomerId = input.FK_CustomerId;
                dc.GExporder.InsertOnSubmit(base.ConnectionData.Schema, item);
                dc.SubmitChanges();
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dc.Close();
            }
        }


        public GExpOrder UpdateOrder(GExpOrder input)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();

                GExpOrder item = dc.GExporder.GetObject(base.ConnectionData.Schema, input.Id);
                if (item != null)
                {
                    item.AcceptName = input.AcceptName;
                    item.AcceptAddress = input.AcceptAddress;
                    item.AcceptPhone = input.AcceptPhone;
                    item.GoodsName = input.GoodsName;
                    item.COD = input.COD;
                    item.IsShopPay = input.IsShopPay;
                    item.Note = input.Note;
                    dc.GExporder.Update(base.ConnectionData.Schema, item);
                    dc.SubmitChanges();
                    return item;
                }
                return null;
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

        public async Task<bool> Delete(string Id)
        {
            IDataContext dc = new dcDataContextM(base.ConnectionData.ConnectionString);
            try
            {
                dc.Open();
                GExpOrder item = dc.GExporder.GetObject(base.ConnectionData.Schema, Id);
                if (item != null)
                {
                    //Delete master
                    dc.GExporder.DeleteOnSubmit(base.ConnectionData.Schema, Id);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
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

