﻿using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Should;
using UCosmic.Domain.Identity;
using UCosmic.Domain.People;

namespace UCosmic.Www.Mvc.Areas.My.Models.EmailAddresses
{
    // ReSharper disable UnusedMember.Global
    public class ChangeSpellingFormMapperFacts
    // ReSharper restore UnusedMember.Global
    {
        [TestClass]
        public class TheEntityToViewModelProfile
        {
            [TestMethod]
            public void MapsValue_ToValue()
            {
                const string value = "user@domain.tld";
                var entity = new EmailAddress { Value = value };

                var model = Mapper.Map<ChangeSpellingForm>(entity);

                model.ShouldNotBeNull();
                model.Value.ShouldNotBeNull();
                model.Value.ShouldEqual(entity.Value);
            }

            [TestMethod]
            public void MapsValue_ToOldSpelling()
            {
                const string value = "user@domain.tld";
                var entity = new EmailAddress { Value = value };

                var model = Mapper.Map<ChangeSpellingForm>(entity);

                model.ShouldNotBeNull();
                model.OldSpelling.ShouldNotBeNull();
                model.OldSpelling.ShouldEqual(entity.Value);
            }

            [TestMethod]
            public void MapsPersonUserName_ToPersonUserName()
            {
                const string userName = "user@domain.tld";
                var entity = new EmailAddress
                {
                    Person = new Person
                    {
                        User = new User { Name = userName }
                    }
                };

                var model = Mapper.Map<ChangeSpellingForm>(entity);

                model.ShouldNotBeNull();
                model.PersonUserName.ShouldNotBeNull();
                model.PersonUserName.ShouldEqual(entity.Person.User.Name);
            }

            [TestMethod]
            public void MapsNumber_ToNumber()
            {
                const int number = 2;
                var entity = new EmailAddress { Number = number };

                var model = Mapper.Map<ChangeSpellingForm>(entity);

                model.ShouldNotBeNull();
                model.Number.ShouldEqual(entity.Number);
            }

            [TestMethod]
            public void IgnoresReturnUrl()
            {
                var entity = new EmailAddress();

                var model = Mapper.Map<ChangeSpellingForm>(entity);

                model.ShouldNotBeNull();
                model.ReturnUrl.ShouldBeNull();
            }
        }

        [TestClass]
        public class TheViewModelToCommandProfile
        {
            [TestMethod]
            public void MapsPersonUserName_ToUserName()
            {
                const string userName = "user@domain.tld";
                var model = new ChangeSpellingForm { PersonUserName = userName };

                var command = Mapper.Map<ChangeEmailAddressSpellingCommand>(model);

                command.ShouldNotBeNull();
                command.UserName.ShouldNotBeNull();
                command.UserName.ShouldEqual(model.PersonUserName);
            }

            [TestMethod]
            public void MapsValue_ToNewValue()
            {
                const string value = "user@domain.tld";
                var model = new ChangeSpellingForm { Value = value };

                var command = Mapper.Map<ChangeEmailAddressSpellingCommand>(model);

                command.ShouldNotBeNull();
                command.NewValue.ShouldNotBeNull();
                command.NewValue.ShouldEqual(model.Value);
            }

            [TestMethod]
            public void MapsNumber_ToNumber()
            {
                const int number = 2;
                var model = new ChangeSpellingForm { Number = number };

                var command = Mapper.Map<ChangeEmailAddressSpellingCommand>(model);

                command.ShouldNotBeNull();
                command.Number.ShouldEqual(model.Number);
            }

            [TestMethod]
            public void IgnoresChangedState()
            {
                var model = new ChangeSpellingForm();

                var command = Mapper.Map<ChangeEmailAddressSpellingCommand>(model);

                command.ShouldNotBeNull();
                command.ChangedState.ShouldBeFalse();
            }
        }
    }
}