using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class Navigation : BaseVM
    {
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
                         // var p =  _navigationService.QueryString;

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
                   () =>
                  {

                      try
                      {

                          _navigationService.Navigate<Home>();
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }

        private RelayCommand _GoWithoutParameter;
        public RelayCommand GoWithoutParameter
        {
            get
            {
                return _GoWithoutParameter ?? (_GoWithoutParameter = new RelayCommand(
                   () =>
                  {

                      try
                      {

                          _navigationService.Navigate<Views.NavigationTarget>();
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }

        private RelayCommand<string> _GoWithParam;
        public RelayCommand<string> GoWithParam
        {
            get
            {
                return _GoWithParam ?? (_GoWithParam = new RelayCommand<string>(
                   (param) =>
                  {

                      try
                      {

                          _navigationService.Navigate<Views.NavigationTarget>(param);
                      }
                      catch (Exception ex)
                      {

                          throw ex;
                      }

                  }));
            }

        }


        public Navigation(
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
