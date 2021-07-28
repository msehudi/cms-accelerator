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
using CRM.Interface;

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
        private readonly IDynamicsClient dynamicsClient;

        public ApplicationsController(ILogger<ApplicationsController> logger,
                            ServiceClient serviceClient,
                            IDynamicsClient dynamicsClient,
                            UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
            this.serviceClient = serviceClient;
            this.dynamicsClient = dynamicsClient;
        }

        private ModuleData AppTypes()
        {
            // var questionExpand = new List<string>{"rra_webpage_rra_question"};
            var res = dynamicsClient.Webpages.Get().Value.ToList();
            var questions = dynamicsClient.Questions.Get().Value.ToList();
            var expand = new List<string> { "rra_rra_questiontype_rra_question_QuestionType" };
            var questionsTypes = dynamicsClient.Questiontypes.Get(expand: expand).Value
                .Select(qt =>
                {
                    List<OptionSet> optionSet = null;
                    var type = "text";
                    var controlType = "textbox";
                    if (qt.RraQuestiontype == (int)QuestionFieldType.DatePicker)
                    {
                        controlType = "datepicker";
                    }
                    else if (qt.RraQuestiontype == (int)QuestionFieldType.DropDown)
                    {
                        controlType = "dropdown";
                        if (qt.RraOptionsettype == (int)OptionSetType.YesNo)
                        {
                            optionSet = new List<OptionSet>{
                                new OptionSet {
                                    Label = "Yes",
                                    Value = "Yes"
                                },
                                new OptionSet {
                                    Label = "No",
                                    Value = "No"
                                },
                            };
                            controlType = "radio-group";
                        }
                        else if (qt.RraOptionsettype == (int)OptionSetType.YesNoNa)
                        {
                            optionSet = new List<OptionSet>{
                                new OptionSet {
                                    Label = "Yes",
                                    Value = "Yes"
                                },
                                new OptionSet {
                                    Label = "No",
                                    Value = "No"
                                },
                                new OptionSet {
                                    Label = "Na",
                                    Value = "Na"
                                },
                            };
                            controlType = "dropdown";
                        }
                        else if (qt.RraOptionsettype == (int)OptionSetType.YesNoUnknown)
                        {
                            optionSet = new List<OptionSet>{
                                new OptionSet {
                                    Label = "Yes",
                                    Value = "Yes"
                                },
                                new OptionSet {
                                    Label = "No",
                                    Value = "No"
                                },
                                new OptionSet {
                                    Label = "Unknown",
                                    Value = "Unknown"
                                },
                            };
                            controlType = "dropdown";
                        }
                    }

                    if (qt.RraName == "Text - Password")
                    {
                        type = "password";
                    }
                    else if (qt.RraName == "Text - Paragraph")
                    {
                        controlType = "textarea";
                    }

                    var questionType = new QuestionType
                    {
                        Id = qt.RraQuestiontypeid,
                        Name = qt.RraName,
                        DefaultValue = qt.RraDefaultvalue,
                        MaxCharacters = qt.RraMaxcharacters,
                        Type = type,
                        ControlType = controlType,
                        Options = optionSet
                    };
                    return questionType;
                })
            .ToList();
            var Modules = new List<Module> {
                new Module {
                    Id = "3d4ef3c0-79c9-eb11-bacc-0022486d9987",
                    Name = "Scholarship Grant Application",
                    WebPages = res.Where(page => page._rraModuleidValue == "3d4ef3c0-79c9-eb11-bacc-0022486d9987")
                        .Select(page =>
                            new WebPage{
                                Id = page.RraWebpageid,
                                Name = page.RraName,
                                Header= page.RraPageheader,
                                Order = page.RraPageorder,
                                Footer = page.RraPagefooter,
                                ShowBackButton = page.RraShowbackbutton == 166790000,
                                ShowSaveButton = page.RraShowsavebutton == 166790000,
                                ShowNextButton = page.RraShownextbutton == 166790000,
                                ShowSubmitButton = page.RraShowsubmitbutton == 166790000,
                                Questions = questions.Where(q => q._rraWebpageidValue == page.RraWebpageid)
                                    .Select(q => {
                                        var questionType = questionsTypes.Where(qt => qt.Id == q._rraQuestiontypeValue).FirstOrDefault();
                                        return new Question{
                                            Id = q.RraQuestionid,
                                            Label  = q.RraName,
                                            Value = questionType.DefaultValue,
                                            Order = q.RraDisplayorder == null ? 0 : (int)q.RraDisplayorder,
                                            Type = questionType?.Type,
                                            ControlType = questionType?.ControlType,
                                            QuestionTypeId = questionType.Id
                                        };
                                }).ToList()
                        }).ToList()
                },
                new Module
                {
                    Id = "a7aa66c8-79c9-eb11-bacc-0022486d9987",
                    Name = "General Inquiry",
                    WebPages = res.Where(page => page._rraModuleidValue == "a7aa66c8-79c9-eb11-bacc-0022486d9987")
                        .Select(page =>
                            new WebPage{
                                Id = page.RraWebpageid,
                                Name = page.RraName,
                                Header= page.RraPageheader,
                                Order = page.RraPageorder,
                                Footer = page.RraPagefooter,
                                ShowBackButton = page.RraShowbackbutton == 166790000,
                                ShowSaveButton = page.RraShowsavebutton == 166790000,
                                ShowNextButton = page.RraShownextbutton == 166790000,
                                ShowSubmitButton = page.RraShowsubmitbutton == 166790000,
                                Questions = questions.Where(q => q._rraWebpageidValue == page.RraWebpageid)
                                    .Select(q => {
                                        var questionType = questionsTypes.Where(qt => qt.Id == q._rraQuestiontypeValue).FirstOrDefault();
                                        return new Question{
                                            Id = q.RraQuestionid,
                                            Label  = q.RraName,
                                            Value = questionType.DefaultValue,
                                            Order = q.RraDisplayorder == null ? 0 : (int)q.RraDisplayorder,
                                            Type = questionType?.Type,
                                            ControlType = questionType?.ControlType,
                                            QuestionTypeId = questionType.Id
                                        };
                                })
                                .OrderBy(q => q.Order)
                                .ToList()
                        })
                        .OrderBy(page => page.Order)
                        .ToList()
                }
            };
            var result = new ModuleData
            {
                Modules = Modules,
                QuestionTypes = questionsTypes
            };
            return result;
        }


        [HttpGet("application-types")]
        public IActionResult GetApplicationTypes()
        {
            var appTypes = AppTypes();
            return new JsonResult(appTypes);
        }

    }

    public class ModuleData
    {
        public List<Module> Modules { get; set; }
        public List<QuestionType> QuestionTypes { get; set; }
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

        public List<WebPage> WebPages { get; set; }
    }

    public class WebPage
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string Name { get; set; }
        public int? Order { get; set; }
        public bool ShowNextButton { get; set; }
        public bool ShowBackButton { get; set; }
        public bool ShowSaveButton { get; set; }
        public bool ShowSubmitButton { get; set; }
        public List<Question> Questions { get; set; }
    }


    public class Question
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public string ControlType { get; set; }
        public string Type { get; set; }
        public string QuestionTypeId { get; set; }
    }

    public class OptionSet
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public enum QuestionFieldType
    {
        DatePicker = 166790003,
        List = 166790002,
        DropDown = 166790001,
        Text = 166790000
    }
    public enum OptionSetType
    {
        YesNo = 166790000,
        YesNoNa = 166790001,
        YesNoUnknown = 166790002,
        PreferredContactMethod = 166790003,
    }
    public enum OptionSetControl
    {
        DropDown = 166790000,
        RadioButton = 166790001,
        MultiSelect = 166790002,
    }

    public class QuestionType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public string ControlType { get; set; }
        public string Type { get; set; }
        public int? MaxCharacters { get; set; }
        public List<OptionSet> Options { get; set; }
    }
}
