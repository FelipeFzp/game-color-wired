using GameColor.Common.Enums;
using GameColor.Core.Interfaces;
using System;
using System.Threading;

namespace GameColor.Core.Services
{
    public class UserPresetService : IUserPresetService
    {
        private readonly ICommunicationService _communicationService;

        private Action<bool> _onRedChange;
        private Action<bool> _onGreenChange;
        private Action<bool> _onBlueChange;

        private bool _isStopped;
        private bool _red;
        private bool _green;
        private bool _blue;

        public UserPresetService(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }

        #region Public Methods
        public void ToggleColor(bool red, bool green, bool blue)
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
            _communicationService.TurnOffLights();
            _isStopped = true;
        }
        public void ToggleRed()
        {
            _red = !_red;

            if (_onRedChange != null)
                _onRedChange.Invoke(_red);

            Send();
        }
        public void ToggleGreen()
        {
            _green = !_green;

            if (_onGreenChange != null)
                _onGreenChange.Invoke(_green);

            Send();
        }
        public void ToggleBlue()
        {
            _blue = !_blue;

            if (_onBlueChange != null)
                _onBlueChange.Invoke(_blue);

            Send();
        }

        public void OnRedChange(Action<bool> onRedChange) => 
            _onRedChange = onRedChange;

        public void OnGreenChange(Action<bool> onGreenChange) =>
            _onGreenChange = onGreenChange;

        public void OnBlueChange(Action<bool> onBoolChange) =>
            _onBlueChange = onBoolChange;
        #endregion

        #region Private Methods
        private void Send()
        {
            if (_isStopped)
                _isStopped = false;

            var acceptedColor = default(AcceptedColor?);

            if (_red || _green || _blue)
            {
                if (_red && _green && _blue) acceptedColor = AcceptedColor.White;
                else if (_red && _green && !_blue) acceptedColor = AcceptedColor.Yellow;
                else if (_red && !_green && _blue) acceptedColor = AcceptedColor.Magenta;
                else if (!_red && _green && _blue) acceptedColor = AcceptedColor.LightBlue;
                else if (_red) acceptedColor = AcceptedColor.Red;
                else if (_green) acceptedColor = AcceptedColor.Green;
                else if (_blue) acceptedColor = AcceptedColor.Blue;

                _communicationService.ChangeColor(acceptedColor.Value);
            }
            else _communicationService.TurnOffLights();

        }
        #endregion

        #region Static Methods
        public bool IsRunning()
            => !_isStopped;
        #endregion
    }
}
