using Cimbalino.Toolkit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class Email : BaseVM
    {



        private string _To;
        public string To
        {
            get { return this._To; }
            set
            {
                if (_To != value)
                {
                    _To = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _CC;
        public string CC
        {
            get { return this._CC; }
            set
            {
                if (_CC != value)
                {
                    _CC = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _BCC;
        public string BCC
        {
            get { return this._BCC; }
            set
            {
                if (_BCC != value)
                {
                    _BCC = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _Subject;
        public string Subject
        {
            get { return this._Subject; }
            set
            {
                if (_Subject != value)
                {
                    _Subject = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _Body;
        public string Body
        {
            get { return this._Body; }
            set
            {
                if (_Body != value)
                {
                    _Body = value;
                    NotifyPropertyChanged();
                }
            }
        }
        

        public readonly IEmailComposeService _emailComposeService;

        public Email(
          INavigationService navigationService
          ,
          IStorageService storageService
          ,
          IEmailComposeService emailComposeService
        )
            : base(
            navigationService
            ,
            storageService


            )
        {
            _emailComposeService = emailComposeService;



        }
    }
}
