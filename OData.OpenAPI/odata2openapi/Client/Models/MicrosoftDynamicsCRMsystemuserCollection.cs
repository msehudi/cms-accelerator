// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of systemuser
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.systemuserCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMsystemuserCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsystemuserCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMsystemuserCollection(IList<MicrosoftDynamicsCRMsystemuser> value = default(IList<MicrosoftDynamicsCRMsystemuser>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMsystemuser> Value { get; set; }

    }
}
