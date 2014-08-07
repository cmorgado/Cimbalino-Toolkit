using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class NavigationTarget : BaseVM
    {


        private string _Message;
        public string Message
        {
            get { return this._Message; }
            set
            {
                if (_Message != value)
                {
                    _Message = value;
                    NotifyPropertyChanged();
                }
            }
        }
        

        private RelayCommand _Load;
        public RelayCommand Load
        {
            get
            {
                return _Load ?? (_Load = new RelayCommand(
                  async () =>
                  {

                      try
                      {
                        
                     

                          //if (p != null)
                          //    Message = "you came here without parameters";
                          //else
                          //    Message = "you came here using a parameter";

                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }


        public NavigationTarget(
             INavigationService navigationService
            ,
             IStorageService storageService
           )
            : base(
            navigationService
            ,
            storageService


            )
        {




        }
    }
}
