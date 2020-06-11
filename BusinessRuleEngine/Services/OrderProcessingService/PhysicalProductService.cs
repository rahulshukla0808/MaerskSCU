﻿using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Services.OrderProcessingService
{
    public class PhysicalProductService : OrderProcessing<PhysicalProductModel>
    {

        protected override PaymentStatus ProcessOrder(PhysicalProductModel model)
        {
            
            // Logic for packing slip
            if (model.Name != null)
            {
                return new PaymentStatus { 
                    isOrderProcessed = true, 
                    message = "Packing slip created for physical product",
                };
            }

            return new PaymentStatus { 
                isOrderProcessed = false, 
                message = ""
            }; ;
        }
    }
}