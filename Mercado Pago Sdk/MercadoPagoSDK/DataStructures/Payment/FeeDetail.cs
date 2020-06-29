using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
    public struct FeeDetail
    {
        #region Properties

        private float? _amount;
        private FeePayerType? _fee_payer;
        private FeeType? _type;

        #endregion Properties

        #region Accessors

        /// <summary> Fee amount </summary>
        public float? Amount
        {
            get { return _amount; }
            private set { _amount = value; }
        }

        /// <summary> Who absorbs the cost </summary>
        public FeePayerType? FeePayer
        {
            get { return _fee_payer; }
            private set { _fee_payer = value; }
        }

        /// <summary> Fee detail </summary>
        public FeeType? Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        #endregion Accessors
    }
}