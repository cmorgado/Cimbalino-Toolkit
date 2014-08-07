using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
   public class ApplicationProfile : BaseVM
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
                   () =>
                  {

                      try
                      {
                          switch (_applicationProfileService.Mode)
                          {
                              case ApplicationProfileServiceMode.Unknown:
                                  Message = "Unknown";
                                  break;
                              case ApplicationProfileServiceMode.Default:
                                  Message = "Default";
                                  break;
                              case ApplicationProfileServiceMode.KidsCorner:
                                  Message = "KidsCorner";
                                  break;
                              default:
                                  break;
                          }

                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }

        public readonly IApplicationProfileService _applicationProfileService;

        public ApplicationProfile(
            INavigationService navigationService
            ,
            IStorageService storageService
            , 
            IApplicationProfileService applicationProfileService
          )
            : base(
            navigationService
            ,
            storageService


            )
        {
            _applicationProfileService = applicationProfileService;



        }
    }
}
