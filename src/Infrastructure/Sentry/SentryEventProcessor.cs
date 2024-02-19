using Microsoft.AspNetCore.Http;
using Sentry.Extensibility;


namespace Infrastructure.Sentry
{
    public class SentryEventProcessor : ISentryEventProcessor
    {
        private readonly IHttpContextAccessor _httpContext;

        public SentryEventProcessor(IHttpContextAccessor httpContext) => _httpContext = httpContext;

        public SentryEvent Process(SentryEvent @event)
        {
            // Here I can modify the event, while taking dependencies via DI

            @event.SetExtra("Response:HasStarted", _httpContext.HttpContext?.Response.HasStarted);
            return @event;
        }
    }
}
