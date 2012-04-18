﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using UCosmic.Www.Mvc.Models;

namespace UCosmic.Www.Mvc.Areas.My.Models
{
    public class ChangeEmailSpellingForm : IReturnUrl
    {
        public const string ValuePropertyName = "Value";

        [Display(Name = "New spelling")]
        [Remote("ValidateValue", "ChangeEmailSpelling", "My", HttpMethod = "POST", AdditionalFields = "PersonUserName,Number")]
        public string Value { get; set; }

        [Display(Name = "Current spelling")]
        public string OldSpelling { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string PersonUserName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string ReturnUrl { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Number { get; set; }
    }
}