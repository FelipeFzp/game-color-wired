using GameColor.Core.Enums;
using GameColor.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace GameColor.Core.Services
{
    public class UserPresetService : IUserPresetService
    {
        private readonly ICommunicationService _communicationService;

        private Action<byte> _onRedChange;
        private Action<byte> _onGreenChange;
        private Action<byte> _onBlueChange;

        private bool _isStopped;

        private byte _red;
        private byte _green;
        private byte _blue;

        public UserPresetService(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        #region Public Methods
        public byte Red() => _red;
        public byte Green() => _green;
        public byte Blue() => _blue;

        public void SetColor(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;

            if (_onRedChange != null)
                _onRedChange.Invoke(_red);

            if (_onGreenChange != null)
                _onGreenChange.Invoke(_green);

            if (_onBlueChange != null)
                _onBlueChange.Invoke(_blue);

            Send();
        }

        public void StopUserPreset()
        {
            _communicationService.ChangeColor(new byte[] { 0, 0, 0 });
            _isStopped = true;
        }

        public void SetRed(int value, bool mathOperation = false)
        {
            if (mathOperation)
            {
                if (_red + value > 255) _red = 255;
                else if (_red + value <= 0) _red = 0;
                else _red = Convert.ToByte(_red + value);
            }
            else _red = Convert.ToByte(value);


            if (_onRedChange != null)
                _onRedChange.Invoke(_red);

            Send();
        }

        public void SetGreen(int value, bool mathOperation = false)
        {
            if (mathOperation)
            {
                if (_green + value > 255) _green = 255;
                else if (_green + value <= 0) _green = 0;
                else _green = Convert.ToByte(_green + value);
            }
            else _green = Convert.ToByte(value);

            if (_onGreenChange != null)
                _onGreenChange.Invoke(_green);


            Send();
        }

        public void SetBlue(int value, bool mathOperation = false)
        {
            if (mathOperation)
            {
                if (_blue + value > 255) _blue = 255;
                else if (_blue + value <= 0) _blue = 0;
                else _blue = Convert.ToByte(_blue + value);
            }
            else _blue = Convert.ToByte(value);

            if (_onBlueChange != null)
                _onBlueChange.Invoke(_blue);

            Send();
        }

        public void OnRedChange(Action<byte> onRedChange) =>
            _onRedChange = onRedChange;

        public void OnGreenChange(Action<byte> onGreenChange) =>
            _onGreenChange = onGreenChange;

        public void OnBlueChange(Action<byte> onBoolChange) =>
            _onBlueChange = onBoolChange;
        #endregion

        #region Private Methods
        private void Send()
        {
            if (_isStopped)
                _isStopped = false;

            _communicationService.ChangeColor(new byte[] { _red, _green, _blue });
        }
        #endregion

        #region Static Methods
        public bool IsRunning()
            => !_isStopped;
        #endregion
    }
}
