using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
    public struct Payer
    {
        #region Properties

        private Address? _address;
        private string _email;
        private EntityType? _entity_type;
        private string _first_name;
        private string _id;
        private Identification? _identification;
        private string _last_name;
        private Phone? _phone;
        private PayerType? _type;

        #endregion Properties

        #region Accesors

        public Address? Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Email of the payer
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// Find a payment trought an unique identifier
        /// </summary>
        public EntityType? Entity_type
        {
            get { return _entity_type; }
            set { _entity_type = value; }
        }

        /// <summary>
        /// First name of the associated payer
        /// </summary>
        public string FirstName
        {
            get { return _first_name; }
            set { _first_name = value; }
        }

        /// <summary>
        /// Identification of the associated payer
        /// </summary>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Personal identification
        /// </summary>
        public Identification? Identification
        {
            get { return _identification; }
            set { _identification = value; }
        }

        /// <summary>
        /// Last name of the associated payer
        /// </summary>
        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }

        /// <summary>
        /// Phone of the associated payer
        /// </summary>
        public Phone? Phone
        {
            get { return _phone; }
            private set { _phone = value; }
        }

        /// <summary>
        /// Identification type of the associated payer
        /// (mandatory if the Payer is a Customer)
        /// </summary>
        public PayerType? Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion Accesors
    }
}