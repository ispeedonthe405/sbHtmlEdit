using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sbHtmlEdit.Core
{
    public class EmbeddedImage : INotifyPropertyChanged
    {
        ///////////////////////////////////////////////////////////
        #region INotifyPropertyChanged
        /////////////////////////////

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetField<TField>(ref TField field, TField value, string propertyName)
        {
            if (EqualityComparer<TField>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            OnPropertyChanged(propertyName);
        }

        /////////////////////////////
        #endregion INotifyPropertyChanged
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Fields
        /////////////////////////////

        private string _Source = string.Empty;
        private string _HTMLSource = string.Empty;
        private string _CIDSource = string.Empty;
        private string _Alt = string.Empty;
        private string _Base64String = string.Empty;
        private byte[] _Base64Bytes = [];

        /////////////////////////////
        #endregion Fields
        ///////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////
        #region Properties
        /////////////////////////////

        public string Source
        {
            get => _Source;
            set => SetField(ref _Source, value, nameof(Source));
        }
        
        public string HTMLSource
        {
            get => _HTMLSource;
            set => SetField(ref _HTMLSource, value, nameof(HTMLSource));
        }
        
        public string CIDSource
        {
            get => _CIDSource;
            set => SetField(ref _CIDSource, value, nameof(CIDSource));
        }
        
        public string Alt
        {
            get => _Alt;
            set => SetField(ref _Alt, value, nameof(Alt));
        }
        
        public string Base64String
        {
            get => _Base64String;
            set => SetField(ref _Base64String, value, nameof(Base64String));
        }
        
        public byte[] Base64Bytes
        {
            get => _Base64Bytes;
            set => SetField(ref _Base64Bytes, value, nameof(Base64Bytes));
        }

        /////////////////////////////
        #endregion Properties
        ///////////////////////////////////////////////////////////
    }
}
