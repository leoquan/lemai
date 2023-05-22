using LeMaiDomain;
using LeMaiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMaiDesktop
{
    public class ApiNull : IConnectApi
    {
        public OutResultGHN CancelOrder(view_GExpBillGHNApi bill)
        {
            return new OutResultGHN { IsSuccess = false, Message = "API Chưa được khai báo" };
        }

        public OutResultGHN CreateOrder(view_GExpBillGHNApi bill)
        {
            return new OutResultGHN { IsSuccess = false, Message = "API Chưa được khai báo" };
        }

        public OutTrackingResultGHN Tracking(view_GExpBillGHNApi bill)
        {
            return new OutTrackingResultGHN { IsSuccess = false, Message = "API Chưa được khai báo" };
        }

        public OutResultGHN UpdateCOD(view_GExpBillGHNApi bill)
        {
            return new OutResultGHN { IsSuccess = false, Message = "API Chưa được khai báo" };
        }

        public OutResultGHN UpdateOrder(view_GExpBillGHNApi bill)
        {
            return new OutResultGHN { IsSuccess = false, Message = "API Chưa được khai báo" };
        }
    }
}
