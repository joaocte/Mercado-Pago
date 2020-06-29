using MercadoPago.Common;

namespace MercadoPago.DataStructures.Payment
{
    public struct Barcode
    {
        #region Properties

        private string _content;
        private EncodingType? _encoding_type;
        private int? height;
        private int? width;

        #endregion Properties

        #region Accessors

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        public EncodingType? Encoding_type
        {
            get
            {
                return _encoding_type;
            }

            set
            {
                _encoding_type = value;
            }
        }

        public int? Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public int? Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        #endregion Accessors
    }
}