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
    /// Extension methods for Questionprincipalobjectattributeaccesses.
    /// </summary>
    public static partial class QuestionprincipalobjectattributeaccessesExtensions
    {
            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection Get(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(rraQuestionid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetAsync(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(rraQuestionid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccessCollection> GetWithHttpMessages(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(rraQuestionid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static MicrosoftDynamicsCRMprincipalobjectattributeaccess PrincipalObjectAttributeAccessesByKey(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.PrincipalObjectAttributeAccessesByKeyAsync(rraQuestionid, principalobjectattributeaccessid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static async Task<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyAsync(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(rraQuestionid, principalobjectattributeaccessid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get rra_question_PrincipalObjectAttributeAccesses from rra_questions
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rraQuestionid'>
            /// key: rra_questionid of rra_question
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMprincipalobjectattributeaccess> PrincipalObjectAttributeAccessesByKeyWithHttpMessages(this IQuestionprincipalobjectattributeaccesses operations, string rraQuestionid, string principalobjectattributeaccessid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.PrincipalObjectAttributeAccessesByKeyWithHttpMessagesAsync(rraQuestionid, principalobjectattributeaccessid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
