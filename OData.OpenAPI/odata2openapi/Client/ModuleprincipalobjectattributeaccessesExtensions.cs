// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRM.Interface
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Moduleprincipalobjectattributeaccesses.
    /// </summary>
    public static partial class ModuleprincipalobjectattributeaccessesExtensions
    {
            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection Get(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(rraModuleid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetAsync(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(rraModuleid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetWithHttpMessages(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(rraModuleid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccess PrincipalObjectAttributeAccessesByKey(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.PrincipalObjectAttributeAccessesByKeyAsync(rraModuleid, principalobjectattributeaccessid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyAsync(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(rraModuleid, principalobjectattributeaccessid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get rra_module_PrincipalObjectAttributeAccesses from rra_modules
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraModuleid'>
            /// key: rra_moduleid of rra_module
            /// </param>
            /// <param name='principalobjectattributeaccessid'>
            /// key: principalobjectattributeaccessid of principalobjectattributeaccess
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyWithHttpMessages(this IModuleprincipalobjectattributeaccesses operations, string rraModuleid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(rraModuleid, principalobjectattributeaccessid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
