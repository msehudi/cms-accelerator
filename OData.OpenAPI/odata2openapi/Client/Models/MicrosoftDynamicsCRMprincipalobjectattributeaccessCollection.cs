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
    /// Collection of principalobjectattributeaccess
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.principalobjectattributeaccessCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> value = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
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
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> Value { get; set; }

    }
}