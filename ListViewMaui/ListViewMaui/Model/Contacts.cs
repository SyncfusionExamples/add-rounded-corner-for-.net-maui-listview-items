﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region Contacts
    public class Contacts : INotifyPropertyChanged
    {
        #region Fields

        private string contactName;
        private string contactNumber;
        private string contactType;

        #endregion

        #region Constructor
        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
        }
        #endregion

        #region Properties
        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public string ContactType
        {
            get { return contactType; }
            set
            {
                this.contactType = value;
                this.RaisedOnPropertyChanged("ContactType");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
        #endregion
    }

    #endregion
}
