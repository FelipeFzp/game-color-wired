using System;
using System.Collections.Generic;

namespace GameColor.Core.Interfaces
{
    public interface IUserLoggingService
    {
        void LogLine(string text);
        void OnLogChange(Action<string> onLogChange);
        void StopLogging();
    }
}
