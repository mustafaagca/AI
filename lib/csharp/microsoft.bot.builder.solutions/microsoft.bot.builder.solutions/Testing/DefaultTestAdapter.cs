﻿using Microsoft.Bot.Builder.Adapters;
using Microsoft.Bot.Builder.Solutions.Middleware;

namespace Microsoft.Bot.Builder.Solutions.Testing
{
    public class DefaultTestAdapter : TestAdapter
    {
        public DefaultTestAdapter(BotStateSet botStateSet)
        {
            Use(new EventDebuggerMiddleware());
            Use(new AutoSaveStateMiddleware(botStateSet));
        }
    }
}
