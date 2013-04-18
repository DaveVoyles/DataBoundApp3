using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace DataBoundApp3.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _aItem;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        public string AItem
        {
            get
            {
                return _aItem;
            }
            set
            {
                if (value != _aItem)
                {
                    _aItem = value;
                    NotifyPropertyChanged("AItem");
                }
            }
        }

        private string _aItemName;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        public string AItemName
        {
            get
            {
                return _aItemName;
            }
            set
            {
                if (value != _aItemName)
                {
                    _aItemName = value;
                    NotifyPropertyChanged("AItemName");
                }
            }
        }

        private bool _isCompleted;
        /// <summary>
        /// Used to determine if an item has been successfully entered or not
        /// </summary>
        public bool IsCompleted
        {
            get
            {
                return _isCompleted;
            }
            set
            {
                if (value != _isCompleted)
                {
                    _isCompleted = value;
                    NotifyPropertyChanged("IsCompleted");
                }
            }
        }

        private string _imageURI;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        public string ImageURI
        {
            get
            {
                return _imageURI;
            }
            set
            {
                if (value != _imageURI)
                {
                    _imageURI = value;
                    NotifyPropertyChanged("ImageURI");
                }
            }
        }

        private string _description;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private string _id;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        /// <returns></returns>
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }
      

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}