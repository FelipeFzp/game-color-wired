using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameColor.Core.Interfaces
{
    public interface IUserPresetService
    {
        void ToggleColor(bool red, bool green, bool blue);
        void ToggleRed();
        void ToggleGreen();
        void ToggleBlue();
        void OnRedChange(Action<bool> onRedChange);
        void OnGreenChange(Action<bool> onGreenChange);
        void OnBlueChange(Action<bool> onBoolChange);
        void StopUserPreset();
        bool IsRunning();
    }
}
