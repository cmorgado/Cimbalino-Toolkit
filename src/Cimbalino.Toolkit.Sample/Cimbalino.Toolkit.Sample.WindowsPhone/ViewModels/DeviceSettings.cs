using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class DeviceSettings : BaseVM
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


                       }
                       catch (Exception ex)
                       {

                           throw ex;
                       }

                   }));
            }

        }

        private RelayCommand<string> _Show;
        public RelayCommand<string> Show
        {
            get
            {
                return _Show ?? (_Show = new RelayCommand<string>(
                   async (p) =>
                   {

                       try
                       {
                           var param = int.Parse(p);
                           switch (param)
                           {
                               case 0:
                                   await _deviceSettingsService.ShowAirplaneModeSettingsAsync();
                                   break;

                               case 1:
                                   await _deviceSettingsService.ShowBluetoothSettingsAsync();
                                   break;

                               case 2:
                                   await _deviceSettingsService.ShowCameraSettingsAsync();
                                   break;

                               case 3:
                                   await _deviceSettingsService.ShowCellularSettingsAsync();

                                   break;

                               case 4:
                                   await _deviceSettingsService.ShowEmailAndAccountsSettingsAsync();
                                   break;

                               case 5:
                                   await _deviceSettingsService.ShowLocationSettingsAsync();
                                   break;
                               case 6:
                                   await _deviceSettingsService.ShowLockScreenSettingsAsync();
                                   break;
                               case 7:
                                   await _deviceSettingsService.ShowNotificationSettingsAsync();
                                   break;
                               case 8:
                                   await _deviceSettingsService.ShowPowerSettingsAsync();
                                   break;
                               case 9:
                                   await _deviceSettingsService.ShowProximitySettingsAsync();
                                   break;
                               case 10:
                                   await _deviceSettingsService.ShowScreenRotationSettingsAsync();
                                   break;
                               case 11:
                                   await _deviceSettingsService.ShowWiFiSettingsAsync();
                                   break;
                               case 12:
                                   await _deviceSettingsService.ShowWorkplaceSettingsAsync();
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

        

        public readonly IDeviceSettingsService _deviceSettingsService;

        public DeviceSettings(
            INavigationService navigationService
            ,
            IStorageService storageService
            ,
            IDeviceSettingsService deviceSettingsService
          )
            : base(
            navigationService
            ,
            storageService


            )
        {
            _deviceSettingsService = deviceSettingsService;



        }
    }
}
