namespace MercadoPago.DataStructures.Payment
{
    public struct Taxes
    {
        #region Properties

        private string _type;
        private int _value;

        #endregion Properties

        #region Accesors

        /// <summary>
        /// The name of the type of taxes
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// The amount of taxes
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion Accesors
    }
}