using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using WissingLocal.Annotations;

namespace WissingLocal
{
    public class MainVM : INotifyPropertyChanged
    {
        private bool _localEnabled;
        private string _buttonText;

        public bool LocalEnabled
        {
            get => _localEnabled;
            set
            {
                if (value == _localEnabled) return;
                _localEnabled = value;
                OnPropertyChanged();
            }
        }


        public string ButtonText
        {
            get => _buttonText;
            set
            {
                if (value == _buttonText) return;
                _buttonText = value;
                OnPropertyChanged();
            }
        }

        public MainVM()
        {
            ReadFile();
        }

        private void ReadFile()
        {
            // Work related stuff removed
            LocalEnabled = IsEnabled();
            ButtonText = LocalEnabled ? "Disable Local" : "Enable Local";
        }

        private bool IsEnabled()
        {
            bool starter = false;
            return !LocalEnabled;
        }

        private IEnumerable<string> Without()
        {
            // Work related stuff removed
            yield break;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void EnableDisable()
        {
            // Work related stuff removed
            ReadFile();
        }
    }
}