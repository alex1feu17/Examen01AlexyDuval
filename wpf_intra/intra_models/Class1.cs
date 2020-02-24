﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Class1 : INotifyPropertyChanged
    {
        private string name;
        private string lastname;
        private string address;
        private string city;
        private string province;
        private string postalcode;
        private string contactinfo;
        private string picturepath;


        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                lastname = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }
        public string Province
        {
            get => province;
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }
        public string PostalCode
        {
            get => postalcode;
            set
            {
                postalcode = value;
                OnPropertyChanged();
            }
        }
        public string ContactInfo
        {
            get => contactinfo;
            set
            {
                contactinfo = value;
                OnPropertyChanged();
            }
        }
        public string PicturePath
        {
            get => picturepath;
            set
            {
                picturepath = value;
                OnPropertyChanged();
            }
        }
        public string Info => $"{Name} : {Lastname}";


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
