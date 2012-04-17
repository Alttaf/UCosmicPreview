// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace UCosmic.Www.Mvc.Areas.My.Controllers {
    public partial class EmailAddressesController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected EmailAddressesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ChangeSpelling() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ChangeSpelling);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ValidateChangeSpelling() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ValidateChangeSpelling);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public EmailAddressesController Actions { get { return MVC.My.EmailAddresses; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "My";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "EmailAddresses";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "EmailAddresses";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string ChangeSpelling = "change-spelling";
            public readonly string ValidateChangeSpelling = "ValidateChangeSpelling";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string ChangeSpelling = "change-spelling";
            public const string ValidateChangeSpelling = "ValidateChangeSpelling";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string change_spelling_modal = "~/Areas/My/Views/EmailAddresses/change-spelling-modal.cshtml";
            public readonly string change_spelling = "~/Areas/My/Views/EmailAddresses/change-spelling.cshtml";
            static readonly _EditorTemplates s_EditorTemplates = new _EditorTemplates();
            public _EditorTemplates EditorTemplates { get { return s_EditorTemplates; } }
            public partial class _EditorTemplates{
                public readonly string ChangeSpellingForm = "ChangeSpellingForm";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_EmailAddressesController: UCosmic.Www.Mvc.Areas.My.Controllers.EmailAddressesController {
        public T4MVC_EmailAddressesController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult ChangeSpelling(int number) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangeSpelling);
            callInfo.RouteValueDictionary.Add("number", number);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangeSpelling(UCosmic.Www.Mvc.Areas.My.Models.EmailAddresses.ChangeSpellingForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangeSpelling);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ValidateChangeSpelling(UCosmic.Www.Mvc.Areas.My.Models.EmailAddresses.ChangeSpellingForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ValidateChangeSpelling);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591