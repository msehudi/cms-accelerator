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
    /// Collection of sharepointsite
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.sharepointsiteCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMsharepointsiteCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointsiteCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointsiteCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsharepointsiteCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMsharepointsiteCollection(IList<MicrosoftDynamicsCRMsharepointsite> value = default(IList<MicrosoftDynamicsCRMsharepointsite>))
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
        public IList<MicrosoftDynamicsCRMsharepointsite> Value { get; set; }

    }
}
