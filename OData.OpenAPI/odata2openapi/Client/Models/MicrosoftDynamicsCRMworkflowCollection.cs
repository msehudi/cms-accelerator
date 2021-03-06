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
    /// Collection of workflow
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.workflowCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMworkflowCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMworkflowCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMworkflowCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMworkflowCollection(IList<MicrosoftDynamicsCRMworkflow> value = default(IList<MicrosoftDynamicsCRMworkflow>))
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
        public IList<MicrosoftDynamicsCRMworkflow> Value { get; set; }

    }
}
