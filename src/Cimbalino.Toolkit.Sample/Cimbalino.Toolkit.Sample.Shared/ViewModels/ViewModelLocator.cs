using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Cimbalino.Toolkit.Services;




namespace Cimbalino.Toolkit.Sample.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                SimpleIoc.Default.Register<INavigationService, NavigationService>();
            }

            if (!SimpleIoc.Default.IsRegistered<IStorageService>())
            {
                SimpleIoc.Default.Register<IStorageService, StorageService>();
            }

            if (!SimpleIoc.Default.IsRegistered<IDisplayPropertiesService>())
            {
                SimpleIoc.Default.Register<IDisplayPropertiesService, DisplayPropertiesService>();
            }


#if WINDOWS_PHONE_APP
            if (!SimpleIoc.Default.IsRegistered<IApplicationProfileService>())
            {
                SimpleIoc.Default.Register<IApplicationProfileService, ApplicationProfileService>();
            }
            SimpleIoc.Default.Register<ApplicationProfile>();

            if (!SimpleIoc.Default.IsRegistered<IDeviceSettingsService>())
            {
                SimpleIoc.Default.Register<IDeviceSettingsService, DeviceSettingsService>();
            }
            SimpleIoc.Default.Register<DeviceSettings>();
#endif
            SimpleIoc.Default.Register<Home>();
            SimpleIoc.Default.Register<Navigation>();
            SimpleIoc.Default.Register<NavigationTarget>();
            SimpleIoc.Default.Register<Display>();
          

        }

        public Home Home
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Home>();
            }
        }


        public Navigation Navigation
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Navigation>();
            }
        }


        public NavigationTarget NavigationTarget
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NavigationTarget>();
            }
        }


        public Display Display
        {
            get
            {
                return ServiceLocator.Current.GetInstance<Display>();
            }
        }


#if WINDOWS_PHONE_APP
        public ApplicationProfile ApplicationProfile
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ApplicationProfile>();
            }
        }

        public DeviceSettings DeviceSettings
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DeviceSettings>();
            }
        }
#endif
        /// <summary>
        /// Cleanups this instance.
        /// </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}