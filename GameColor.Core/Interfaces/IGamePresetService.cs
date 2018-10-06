using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameColor.Core.Interfaces
{
    public interface IGamePresetService
    {
        void SetPreset(string name);
        void StartApplicationWatcher();
        void StopApplicationWatcher();
        bool IsRunning();
    }
}
