using MercadoPago.Core;
using MercadoPago.Net;
using System;

namespace MercadoPago.Resources
{
    public class CardToken : MPBase
    {
        #region Actions

        public static CardToken FindById(string id)
        {
            return FindById(id, WITHOUT_CACHE, null);
        }

        [GETEndpoint("/v1/card_tokens/:id")]
        public static CardToken FindById(string id, bool useCache, MPRequestOptions requestOptions)
        {
            return (CardToken)ProcessMethod<CardToken>(typeof(CardToken), "FindById", id, useCache, requestOptions);
        }

        public CardToken Save()
        {
            return Save(null);
        }

        [POSTEndpoint("/v1/card_tokens")]
        public CardToken Save(MPRequestOptions requestOptions)
        {
            return (CardToken)ProcessMethod<CardToken>("Save", WITHOUT_CACHE, requestOptions);
        }

        #endregion Actions

        private string cardId;
        private string customerId;
        private DateTime? dateCreated;
        private DateTime? dateDue;
        private DateTime? dateLastUpdate;
        private string id;
        private bool? lineMode;
        private bool? luhnValidation;
        private string publicKey;
        private bool? requireEsc;
        private string securityCode;
        private string status;

        public string CardId
        {
            get { return cardId; }
            set { cardId = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public DateTime? DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public DateTime? DateDue
        {
            get { return dateDue; }
            set { dateDue = value; }
        }

        public DateTime? DateLastUpdate
        {
            get { return dateLastUpdate; }
            set { dateLastUpdate = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool? LineMode
        {
            get { return lineMode; }
            set { lineMode = value; }
        }

        public bool? LuhnValidation
        {
            get { return luhnValidation; }
            set { luhnValidation = value; }
        }

        public string PublicKey
        {
            get { return publicKey; }
            set { publicKey = value; }
        }

        public bool? RequireEsc
        {
            get { return requireEsc; }
            set { requireEsc = value; }
        }

        public string SecurityCode
        {
            get { return securityCode; }
            set { securityCode = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}