using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS_API.Models;
using System.Security.Claims;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace CMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/applications")]
    public class ApplicationsController : ControllerBase
    {
        private readonly ILogger<ApplicationsController> _logger;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ServiceClient serviceClient;

        public ApplicationsController(ILogger<ApplicationsController> logger,
                            ServiceClient serviceClient,
                            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
            this.serviceClient = serviceClient;
        }


        [HttpGet("application-types")]
        public async Task<IActionResult> GetApplicationTypes()
        {
            var programs = new QueryExpression("rra_program");
            programs.ColumnSet.AddColumns("rra_programid", "rra_name");

            var moduleLink = new LinkEntity("rra_program", "rra_module", "rra_programid", "rra_programid", JoinOperator.LeftOuter);
            programs.LinkEntities.Add(moduleLink);
            moduleLink.Columns.AddColumns("rra_moduleid", "rra_name");
            moduleLink.EntityAlias = "modules";

            var contactsCollection = await serviceClient.RetrieveMultipleAsync(programs);
            var appTypes = contactsCollection.Entities
            .Select(entity =>
            {
                return new Programs
                {
                    Id = entity.Attributes["rra_programid"].ToString(),
                    Name = entity.Attributes["rra_name"].ToString(),
                };
            }).ToList();
            return new JsonResult(appTypes);
        }

        [HttpGet("web-pages")]
        public async Task<IActionResult> GetWebPages(string moduleId)
        {
            var programs = new QueryExpression("rra_webpage");
            programs.ColumnSet.AddColumns("rra_webpageid", "rra_name", "rra_showloginbutton",
            "rra_pagefooter", "rra_pageheader", "rra_pageorder",
             "rra_showsavebutton", "rra_showbackbutton", "rra_shownextbutton");

            var contactsCollection = await serviceClient.RetrieveMultipleAsync(programs);
            var appTypes = contactsCollection.Entities
            .Select(async (entity) =>
            {
                return new PageControl
                {
                    Id = entity.Attributes["rra_webpageid"].ToString(),
                    Name = entity.Attributes["rra_name"].ToString(),
                    Header = entity.Attributes["rra_pageheader"]?.ToString(),
                    // Footer = entity.Attributes["rra_pagefooter"]?.ToString(),
                    Questions = await GetQuestions(entity.Attributes["rra_webpageid"].ToString())
                };
            }).ToList(); 
            return new JsonResult(appTypes);
        }

        private async Task<List<Question>> GetQuestions(string pageId)
        {
            //  Query using ConditionExpression and FilterExpression  
            ConditionExpression pageIdEqWebPageIdValue = new ConditionExpression();
            pageIdEqWebPageIdValue.AttributeName = "rra_webpageid";
            pageIdEqWebPageIdValue.Operator = ConditionOperator.Equal;
            pageIdEqWebPageIdValue.Values.Add(pageId);



            FilterExpression filter1 = new FilterExpression();
            filter1.Conditions.Add(pageIdEqWebPageIdValue);

            var query = new QueryExpression("rra_question");
            query.ColumnSet.AddColumns("rra_questionid", "rra_name", "rra_displayorder", "rra_rra_questiontype_rra_question_QuestionType");
            query.Criteria.AddFilter(filter1);


            var moduleLink = new LinkEntity("rra_question", "rra_questiontype", "_rra_questiontype_value", "rra_questiontypeid", JoinOperator.LeftOuter);
            query.LinkEntities.Add(moduleLink);
            moduleLink.Columns.AddColumns("rra_questiontypeid", "rra_name");
            moduleLink.EntityAlias = "questionType";

            var result = await serviceClient.RetrieveMultipleAsync(query);
            var questions = result.Entities.Select(entity =>
            {
                return new Question
                {
                    Id = entity.Attributes["rra_questionid"].ToString(),
                    Name = entity.Attributes["rra_name"].ToString(),
                };
            }).ToList();
            return questions;
        }
    }

    public class Programs
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Module> Modules { get; set; }
    }

    public class Module
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<PageControl> WebPages { get; set; }
    }

    public class PageControl
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Name { get; set; }
        public int PageOrder { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public int DisplayOrder { get; set; }
        public bool DisplayQuestionLabel { get; set; }
        public QuestionType Type { get; set; }

    }

    public class QuestionType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public int? Type { get; set; }
        public int? MaxCharacters { get; set; }
        public int? OptionSetControl { get; set; }
        public bool? displayListEntity { get; set; }
        public bool? displayListView { get; set; }
        public int? YesNo { get; set; }
        public int? YesNoNa { get; set; }
        public int? YesNoUnknown { get; set; }
    }
}
