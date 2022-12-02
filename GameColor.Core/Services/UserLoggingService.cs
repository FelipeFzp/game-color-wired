using GameColor.Core.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace GameColor.Core.Services
{
    public class UserLoggingService : IUserLoggingService
    {
        #region Properties
        private ObservableCollection<string> _logs = new ObservableCollection<string>();
        private Action<string> _onLogChange;
        private bool _isStopped;
        #endregion

        #region Public Methods
        public void LogLine(string text)
        {
            if (!_isStopped)
                _logs.Add($"[{DateTime.Now.ToLongTimeString()}]: {text}");
        }
        public void OnLogChange(Action<string> onLogChange)
        {
            ConfigureLogsWatchers();
            _onLogChange = onLogChange;
        }
        public void StopLogging() =>
            _isStopped = true;
        #endregion

        #region Private Methods
        private void ConfigureLogsWatchers() =>
           _logs.CollectionChanged += OnCollectionChange;

        private void OnCollectionChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                _onLogChange.Invoke(_logs.Last());
        }
        #endregion
    }
}
