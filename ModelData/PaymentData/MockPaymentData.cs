﻿using Point_of_Sale_Lab3.Models;

namespace Point_of_Sale_Lab3.ModelData.PaymentData
{
    public class MockPaymentData : IPaymentData
    {
        private List<Payment> payments = new List<Payment>()
        {
            new Payment()
            {
                id = Guid.NewGuid(),
                paymentMethod = "credit card"
            },
            new Payment()
            {
                id = Guid.NewGuid(),
                paymentMethod = "cash"
            }
        };

        public Payment AddPayment(Payment payment)
        {
            payment.id = Guid.NewGuid();
            payments.Add(payment);
            return payment;
        }

        public void DeletePayment(Guid id)
        {
            payments.Remove(GetPayment(id));
        }

        public Payment EditPayment(Payment payment)
        {
            var existing = GetPayment(payment.id);
            existing.employeeId = payment.employeeId;
            existing.paymentMethod = payment.paymentMethod;
            existing.customerId = payment.customerId;
            existing.paymentMethod = payment.paymentMethod;
            existing.tip = payment.tip;
            existing.totalAmount = payment.totalAmount;
            return existing;
        }

        public Payment GetPayment(Guid id)
        {
            return payments.SingleOrDefault(x => x.id == id);
        }

        public List<Payment> GetPayments()
        {
            return payments;
        }
    }
}