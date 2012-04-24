﻿using System;
using System.Threading;
using UCosmic.Domain.People;

namespace UCosmic.Domain.Email
{
    public class SendEmailMessageHandler : IHandleCommands<SendEmailMessageCommand>
    {
        private int _retryCount;
        private const int RetryLimit = 1000;
        private readonly IProcessQueries _queryProcessor;
        private readonly ICommandEntities _entities;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISendMail _mailSender;
        private readonly ILogExceptions _exceptionLogger;

        public SendEmailMessageHandler(IProcessQueries queryProcessor
            , ICommandEntities entities
            , IUnitOfWork unitOfWork
            , ISendMail mailSender
            , ILogExceptions exceptionLogger
        )
        {
            _queryProcessor = queryProcessor;
            _entities = entities;
            _unitOfWork = unitOfWork;
            _mailSender = mailSender;
            _exceptionLogger = exceptionLogger;
        }

        public void Handle(SendEmailMessageCommand command)
        {
            // get a fresh email address from the database
            EmailMessage emailMessage = null;
            while (emailMessage == null && ++_retryCount < RetryLimit)
            {
                if (_retryCount > 1) Thread.Sleep(100);

                emailMessage = _queryProcessor.Execute(
                    new GetEmailMessageByPersonIdAndNumberQuery
                    {
                        PersonId = command.PersonId,
                        Number = command.MessageNumber,
                        WithoutUnitOfWork = true,
                    }
                );
            }
            if (emailMessage == null)
            {
                var exception = new OperationCanceledException(string.Format(
                    "Unable to locate EmailMessage number '{0}' for person '{1}'. The message send operation was canceled after {2} retries.",
                    command.MessageNumber, command.PersonId, _retryCount));
                _exceptionLogger.LogException(exception);
                throw exception;
            }

            // convert email message to mail message
            var mail = _queryProcessor.Execute(
                new CreateMailMessageFromEmailMessageQuery(emailMessage)
            );

            // send the mail message
            _mailSender.Send(mail);

            // log when the message was sent
            emailMessage.SentOnUtc = DateTime.UtcNow;
            _entities.Update(emailMessage);
            _unitOfWork.SaveChanges();
        }
    }
}