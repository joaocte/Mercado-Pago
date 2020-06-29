using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoPago.Core.Annotations
{
    public class Idempotent : Attribute
    {
        #region Variables
        public string GUID { get; set; }
        #endregion

        #region Constructors
        public Idempotent() {
            this.GUID = System.Guid.NewGuid().ToString();            
        }
        #endregion
    }
}
