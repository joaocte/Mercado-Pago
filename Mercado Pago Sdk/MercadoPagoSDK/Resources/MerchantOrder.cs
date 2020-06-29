using MercadoPago.Core;
using MercadoPago.DataStructures.MerchantOrder;
using MercadoPago.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MercadoPago.Resources
{
    public class MerchantOrder : MPBase
    {
        #region Actions

        public MerchantOrder Load(string id)
        {
            return Load(id, WITHOUT_CACHE, null);
        }

        [GETEndpoint("/merchant_orders/:id")]
        public MerchantOrder Load(string id, bool useCache, MPRequestOptions requestOptions)
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>(typeof(MerchantOrder), "Load", id, useCache, requestOptions);
        }

        public MerchantOrder Save()
        {
            return Save(null);
        }

        [POSTEndpoint("/merchant_orders")]
        public MerchantOrder Save(MPRequestOptions requestOptions)
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>("Save", WITHOUT_CACHE, requestOptions);
        }

        public MerchantOrder Update()
        {
            return Update(null);
        }

        [PUTEndpoint("/merchant_orders/:id")]
        public MerchantOrder Update(MPRequestOptions requestOptions)
        {
            return (MerchantOrder)ProcessMethod<MerchantOrder>("Update", WITHOUT_CACHE, requestOptions);
        }

        #endregion Actions

        #region Properties

        [StringLength(600)]
        private string additionalInfo;

        private string applicationId;
        private bool? cancelled;
        private Collector collector;
        private DateTime? dateCreated;

        [StringLength(256)]
        private string externalReference;

        private string id;
        private List<Item> items;
        private DateTime? lastUpdate;

        [StringLength(256)]
        private string marketplace;

        [StringLength(500)]
        private string notificationUrl;

        private float? paidAmount;
        private Payer payer;
        private List<MerchantOrderPayment> payments;
        private string preferenceId;
        private float? refundedAmount;
        private List<Shipment> shipments;
        private float? shippingCost;
        private string siteId;
        private long? sponsorId;
        private string status;
        private float? totalAmount;

        #endregion Properties

        #region Accessors

        public string AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }

        public string ApplicationId
        {
            get { return applicationId; }
            set { applicationId = value; }
        }

        public bool? Cancelled
        {
            get { return cancelled; }
            set { cancelled = value; }
        }

        public Collector Collector
        {
            get { return collector; }
            set { collector = value; }
        }

        public DateTime? DateCreated
        {
            get { return dateCreated; }
        }

        public string ExternalReference
        {
            get { return externalReference; }
            set { externalReference = value; }
        }

        public string ID
        {
            get { return id; }
            set { this.id = value; } //This Accessor must be removed after testing approvement.
        }

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public DateTime? LastUpdate
        {
            get { return lastUpdate; }
        }

        public string Marketplace
        {
            get { return marketplace; }
            set { marketplace = value; }
        }

        public string NotificationUrl
        {
            get { return notificationUrl; }
            set { notificationUrl = value; }
        }

        public float? PaidAmount
        {
            get { return paidAmount; }
        }

        public Payer Payer
        {
            get { return payer; }
            set { payer = value; }
        }

        public List<MerchantOrderPayment> Payments
        {
            get { return payments; }
        }

        public string PreferenceId
        {
            get { return preferenceId; }
            set { preferenceId = value; }
        }

        public float? RefundedAmount
        {
            get { return refundedAmount; }
        }

        public List<Shipment> Shipments
        {
            get { return shipments; }
            set { shipments = value; }
        }

        public float? ShippingCost
        {
            get { return shippingCost; }
        }

        public string SiteId
        {
            get { return siteId; }
            set { siteId = value; }
        }

        public long? SponsorId
        {
            get { return sponsorId; }
            set { sponsorId = value; }
        }

        public string Status
        {
            get { return status; }
        }

        public float? TotalAmount
        {
            get { return totalAmount; }
        }

        public void AppendItem(Item item)
        {
            if (items == null)
            {
                items = new List<Item>();
            }
            items.Add(item);
        }

        public void AppendShipment(Shipment shipment)
        {
            if (shipments == null)
            {
                shipments = new List<Shipment>();
            }
            shipments.Add(shipment);
        }

        #endregion Accessors
    }
}