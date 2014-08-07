using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class Home : BaseVM
    {


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
                          //var p =  _navigationService.QueryString;

                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }

        private RelayCommand _GoHome;
        public RelayCommand GoHome
        {
            get
            {
                return _GoHome ?? (_GoHome = new RelayCommand(
                  async () =>
                  {

                      try
                      {

                          _navigationService.Navigate<Views.MainPage>();
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }

        private RelayCommand _GoNavigation;
        public RelayCommand GoNavigation
        {
            get
            {
                return _GoNavigation ?? (_GoNavigation = new RelayCommand(
                   () =>
                   {

                       try
                       {

                           _navigationService.Navigate<Views.Navigation>();


                       }
                       catch (Exception ex)
                       {

                           throw ex;
                       }

                   }));
            }

        }
        private RelayCommand _GoDisplay;
        public RelayCommand GoDisplay
        {
            get
            {
                return _GoDisplay ?? (_GoDisplay = new RelayCommand(
                   () =>
                   {

                       try
                       {

                           _navigationService.Navigate<Views.Display>();


                       }
                       catch (Exception ex)
                       {

                           throw ex;
                       }

                   }));
            }

        }



#if WINDOWS_PHONE_APP
        private RelayCommand _GoDeviceSettings;
        public RelayCommand GoDeviceSettings
        {
            get
            {
                return _GoDeviceSettings ?? (_GoDeviceSettings = new RelayCommand(
                  async () =>
                  {

                      try
                      {

                          _navigationService.Navigate<Views.DeviceSettings>();
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }


        private RelayCommand _ApplicationProfile;
        public RelayCommand ApplicationProfile
        {
            get
            {
                return _ApplicationProfile ?? (_ApplicationProfile = new RelayCommand(
                  async () =>
                  {

                      try
                      {

                          _navigationService.Navigate<Views.ApplicationProfile>();
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }
#endif
     
        public Home(
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
