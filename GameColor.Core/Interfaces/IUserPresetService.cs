using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameColor.Core.Interfaces
{
    public interface IUserPresetService
    {
        byte Red();
        byte Green();
        byte Blue();
        void SetRed(int value, bool mathOperation = false);
        void SetGreen(int value, bool mathOperation = false);
        void SetBlue(int value, bool mathOperation = false);
        void OnRedChange(Action<byte> onRedChange);
        void OnGreenChange(Action<byte> onGreenChange);
        void OnBlueChange(Action<byte> onBoolChange);
        bool IsRunning();
        void StopUserPreset();
        void SetColor(byte red, byte green, byte blue);
    }
}
