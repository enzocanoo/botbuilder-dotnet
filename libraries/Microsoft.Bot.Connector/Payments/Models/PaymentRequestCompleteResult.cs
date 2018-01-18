// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Payments
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    

    /// <summary>
    /// Result from a completed payment request
    /// </summary>
    public partial class PaymentRequestCompleteResult
    {
        /// <summary>
        /// Initializes a new instance of the PaymentRequestCompleteResult
        /// class.
        /// </summary>
        public PaymentRequestCompleteResult() { }

        /// <summary>
        /// Initializes a new instance of the PaymentRequestCompleteResult
        /// class.
        /// </summary>
        public PaymentRequestCompleteResult(string result = default(string))
        {
            Result = result;
        }

        /// <summary>
        /// Result of the payment request completion
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

    }
}