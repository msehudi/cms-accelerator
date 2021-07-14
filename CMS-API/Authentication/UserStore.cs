using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk.Query;
using CMS_API.Models;
using Microsoft.Xrm.Sdk;

namespace CMS_API.Authentication
{
    public class UserStore : IUserPasswordStore<ApplicationUser>
    {
        private ServiceClient _serviceClient;

        public UserStore(ServiceClient serviceClient)
        {
            this._serviceClient = serviceClient;
        }

        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            //Use Entity class with entity logical name
            var contact = new Entity("contact");

            // set attribute values
            contact["firstname"] = user.FirstName;
            contact["lastname"] = user.LastName;
            contact["emailaddress1"] = user.UserName;
            // contact["name"] = user.Email;
            contact["rra_password"] = user.PasswordHash;


            //Create the account
            Guid contactId = this._serviceClient.Create(contact);
            user.Id = contactId.ToString();
            return Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(IdentityResult.Success);
        }

        public void Dispose()
        {
        }

        public async Task<ApplicationUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            //  Query using ConditionExpression and FilterExpression  
            ConditionExpression userIdEqContactId = new ConditionExpression();
            userIdEqContactId.AttributeName = "contactid";
            userIdEqContactId.Operator = ConditionOperator.Equal;
            userIdEqContactId.Values.Add(userId);

            FilterExpression filter1 = new FilterExpression();
            filter1.Conditions.Add(userIdEqContactId);

            ApplicationUser user = null;
            var query = new QueryExpression("contact");
            query.ColumnSet.AddColumns("contactid", "firstname", "lastname", "emailaddress1");
            query.Criteria.AddFilter(filter1);
            var contactsCollection = await _serviceClient.RetrieveMultipleAsync(query);
            return user;
        }

        public async Task<ApplicationUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            //  Query using ConditionExpression and FilterExpression  
            ConditionExpression userIdEqContactId = new ConditionExpression();
            userIdEqContactId.AttributeName = "emailaddress1";
            userIdEqContactId.Operator = ConditionOperator.Equal;
            userIdEqContactId.Values.Add(normalizedUserName);

            FilterExpression filter1 = new FilterExpression();
            filter1.Conditions.Add(userIdEqContactId);

            var query = new QueryExpression("contact");
            query.ColumnSet.AddColumns("contactid", "firstname", "lastname", "emailaddress1", "rra_password");
            query.Criteria.AddFilter(filter1);
            var contactsCollection = await _serviceClient.RetrieveMultipleAsync(query);
            var contact = contactsCollection.Entities
            .Select(entity =>
            {
                return new ApplicationUser()
                {
                    UserName = entity.Attributes["emailaddress1"].ToString(),
                    Id = entity.Attributes["contactid"].ToString(),
                    PasswordHash = entity.Attributes["rra_password"].ToString(),
                    FirstName = entity.Attributes["firstname"].ToString(),
                    LastName = entity.Attributes["lastname"].ToString(),
                };
            }).FirstOrDefault();
            return contact;
        }

        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.PasswordHash);
        }

        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id);
        }

        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserName);
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
            return Task.CompletedTask;
        }

        public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            return Task.CompletedTask;
        }

        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var contact = new Entity("contact");

            // set attribute values
            contact["firstname"] = user.FirstName;
            contact["lastname"] = user.LastName;
            contact["emailaddress1"] = user.UserName;
            contact["rra_password"] = user.PasswordHash;


            //Update the account
            this._serviceClient.Update(contact);
            return Task.FromResult(IdentityResult.Success);
        }
    }
}