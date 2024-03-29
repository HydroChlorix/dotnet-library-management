﻿using Sentry.Extensibility;


namespace Infrastructure.Sentry
{
    public class SpecialExceptionProcessor : SentryEventExceptionProcessor<SpecialException>
    {
        protected override void ProcessException(
            SpecialException exception,
            SentryEvent sentryEvent)
        {
            sentryEvent.AddBreadcrumb("Processor running on special exception.");

            sentryEvent.SetTag("IsSpecial", exception.IsSpecial.ToString());
        }
    }
}
