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
    /// Collection of rra_questiontype
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.rra_questiontypeCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMrraQuestiontypeCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrraQuestiontypeCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMrraQuestiontypeCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrraQuestiontypeCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMrraQuestiontypeCollection(IList<MicrosoftDynamicsCRMrraQuestiontype> value = default(IList<MicrosoftDynamicsCRMrraQuestiontype>))
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
        public IList<MicrosoftDynamicsCRMrraQuestiontype> Value { get; set; }

    }
}