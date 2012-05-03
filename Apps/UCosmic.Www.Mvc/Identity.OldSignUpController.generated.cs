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
namespace UCosmic.Www.Mvc.Areas.Identity.Controllers {
    public partial class OldSignUpController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected OldSignUpController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ValidateSendEmail() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ValidateSendEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.JsonResult ValidateConfirmEmail() {
            return new T4MVC_JsonResult(Area, Name, ActionNames.ValidateConfirmEmail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ConfirmEmail() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ConfirmEmail);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public OldSignUpController Actions { get { return MVC.Identity.OldSignUp; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Identity";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "OldSignUp";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "OldSignUp";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string ValidateSendEmail = "ValidateSendEmail";
            public readonly string SendEmail = "send-email";
            public readonly string ValidateConfirmEmail = "ValidateConfirmEmail";
            public readonly string ConfirmEmail = "confirm-email";
            public readonly string CreatePassword = "create-password";
            public readonly string SignIn = "sign-in";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants {
            public const string ValidateSendEmail = "ValidateSendEmail";
            public const string SendEmail = "send-email";
            public const string ValidateConfirmEmail = "ValidateConfirmEmail";
            public const string ConfirmEmail = "confirm-email";
            public const string CreatePassword = "create-password";
            public const string SignIn = "sign-in";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string confirm_denied = "~/Areas/Identity/Views/OldSignUp/confirm-denied.cshtml";
            public readonly string confirm_email = "~/Areas/Identity/Views/OldSignUp/confirm-email.cshtml";
            public readonly string create_denied = "~/Areas/Identity/Views/OldSignUp/create-denied.cshtml";
            public readonly string create_password = "~/Areas/Identity/Views/OldSignUp/create-password.cshtml";
            public readonly string send_email = "~/Areas/Identity/Views/OldSignUp/send-email.cshtml";
            public readonly string sign_in = "~/Areas/Identity/Views/OldSignUp/sign-in.cshtml";
            static readonly _EditorTemplates s_EditorTemplates = new _EditorTemplates();
            public _EditorTemplates EditorTemplates { get { return s_EditorTemplates; } }
            public partial class _EditorTemplates{
                public readonly string ConfirmEmailForm = "ConfirmEmailForm";
                public readonly string EmailAddress = "EmailAddress";
                public readonly string OldCreatePasswordForm = "OldCreatePasswordForm";
                public readonly string OldSendEmailForm = "OldSendEmailForm";
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_OldSignUpController: UCosmic.Www.Mvc.Areas.Identity.Controllers.OldSignUpController {
        public T4MVC_OldSignUpController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.JsonResult ValidateSendEmail(string emailAddress) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ValidateSendEmail);
            callInfo.RouteValueDictionary.Add("emailAddress", emailAddress);
            return callInfo;
        }

        public override System.Web.Mvc.ViewResult SendEmail() {
            var callInfo = new T4MVC_ViewResult(Area, Name, ActionNames.SendEmail);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult SendEmail(UCosmic.Www.Mvc.Areas.Identity.Models.SignUp.OldSendEmailForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.SendEmail);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.JsonResult ValidateConfirmEmail(System.Guid token, string secretCode) {
            var callInfo = new T4MVC_JsonResult(Area, Name, ActionNames.ValidateConfirmEmail);
            callInfo.RouteValueDictionary.Add("token", token);
            callInfo.RouteValueDictionary.Add("secretCode", secretCode);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ConfirmEmail(System.Guid token, string secretCode) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ConfirmEmail);
            callInfo.RouteValueDictionary.Add("token", token);
            callInfo.RouteValueDictionary.Add("secretCode", secretCode);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ConfirmEmail(UCosmic.Www.Mvc.Areas.Identity.Models.SignUp.OldConfirmEmailForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ConfirmEmail);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreatePassword() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreatePassword);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult CreatePassword(UCosmic.Www.Mvc.Areas.Identity.Models.SignUp.OldCreatePasswordForm model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.CreatePassword);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult SignIn() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.SignIn);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591