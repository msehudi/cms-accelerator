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
    /// Collection of duplicaterecord
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.duplicaterecordCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMduplicaterecordCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterecordCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterecordCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterecordCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterecordCollection(IList<MicrosoftDynamicsCRMduplicaterecord> value = default(IList<MicrosoftDynamicsCRMduplicaterecord>))
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
        public IList<MicrosoftDynamicsCRMduplicaterecord> Value { get; set; }

    }
}