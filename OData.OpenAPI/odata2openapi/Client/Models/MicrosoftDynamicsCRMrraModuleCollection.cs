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
    /// Collection of rra_module
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.rra_moduleCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMrraModuleCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrraModuleCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMrraModuleCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrraModuleCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMrraModuleCollection(IList<MicrosoftDynamicsCRMrraModule> value = default(IList<MicrosoftDynamicsCRMrraModule>))
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
        public IList<MicrosoftDynamicsCRMrraModule> Value { get; set; }

    }
}
