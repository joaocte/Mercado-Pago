using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
    public struct Order
    {
        #region Properties

        private long? _id;
        private OrderType? _type;

        #endregion Properties

        #region Accessors

        /// <summary>
        /// Id of the associated purchase order
        /// </summary>
        public long? Id1
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Type of order
        /// </summary>
        public OrderType? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion Accessors
    }
}