using MercadoPago.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.MerchantOrder
{
    public struct MerchantOrderPayment
    {
        #region Properties

        private float amountRefunded;

        [StringLength(3)]
        private CurrencyId currencyId;

        private DateTime dateApproved;
        private DateTime dateCreated;
        private string id;
        private DateTime lastModified;
        private OperationType operationType;
        private float shippingCost;
        private string status;
        private string statusDetail;
        private float totalPaidAmount;
        private float transactionAmount;

        public enum OperationType
        {
            RegularPayment,
            PaymentAddition
        }

        #endregion Properties

        #region Accessors

        public float AmountRefunded
        {
            get { return amountRefunded; }
        }

        public DateTime DateApproved
        {
            get { return dateApproved; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public string ID
        {
            get { return id; }
        }

        public DateTime LastModified
        {
            get { return lastModified; }
        }

        public CurrencyId PaymentCurrencyId
        {
            get { return currencyId; }
        }

        public OperationType PaymentOperationType
        {
            get { return operationType; }
        }

        public float ShippingCost
        {
            get { return shippingCost; }
        }

        public string Status
        {
            get { return status; }
        }

        public string StatusDetail
        {
            get { return statusDetail; }
        }

        public float TotalPaidAmount
        {
            get { return totalPaidAmount; }
        }

        public float TransactionAmount
        {
            get { return transactionAmount; }
        }

        #endregion Accessors
    }
}