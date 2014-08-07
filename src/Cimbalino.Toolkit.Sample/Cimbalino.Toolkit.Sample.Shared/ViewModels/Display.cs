using Cimbalino.Toolkit.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimbalino.Toolkit.Sample.ViewModels
{
    public class Display : BaseVM
    {



        private string _Bounds;
        public string Bounds
        {
            get { return this._Bounds; }
            set
            {
                if (_Bounds != value)
                {
                    _Bounds = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _LogicalDPI;
        public string LogicalDPI
        {
            get { return this._LogicalDPI; }
            set
            {
                if (_LogicalDPI != value)
                {
                    _LogicalDPI = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _RawDPIX;
        public string RawDPIX
        {
            get { return this._RawDPIX; }
            set
            {
                if (_RawDPIX != value)
                {
                    _RawDPIX = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _RawDPIY;
        public string RawDPIY
        {
            get { return this._RawDPIY; }
            set
            {
                if (_RawDPIY != value)
                {
                    _RawDPIY = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _RawPixelPerViewPixel;
        public string RawPixelPerViewPixel
        {
            get { return this._RawPixelPerViewPixel; }
            set
            {
                if (_RawPixelPerViewPixel != value)
                {
                    _RawPixelPerViewPixel = value;
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
                           Bounds = string.Format(@"
Bottom: {0} 
Bottom Left: 
  x:{1} 
  y:{2}
Bottom Right: 
  x:{3} 
  y:{4}
Height: {5}
Left: {6}
Right: {7}
Size: h:{8} 
      w:{9}
Top: {10}
Top Left: 
  x:{11} 
  y:{12}
Top Right: 
  x:{13} 
  y:{14}
Width: {15}
X: {16}
Y: {17}"
                             , _displayPropertiesService.Bounds.Bottom
                               , _displayPropertiesService.Bounds.BottomLeft.X
                               , _displayPropertiesService.Bounds.BottomLeft.Y
                               , _displayPropertiesService.Bounds.BottomRight.X
                               , _displayPropertiesService.Bounds.BottomRight.Y
                               , _displayPropertiesService.Bounds.Height
                               , _displayPropertiesService.Bounds.Left
                               , _displayPropertiesService.Bounds.Right
                               , _displayPropertiesService.Bounds.Size.Height
                               , _displayPropertiesService.Bounds.Size.Width
                               , _displayPropertiesService.Bounds.Top
                               , _displayPropertiesService.Bounds.TopLeft.X
                               , _displayPropertiesService.Bounds.TopLeft.Y
                               , _displayPropertiesService.Bounds.TopRight.X
                               , _displayPropertiesService.Bounds.TopRight.Y
                               , _displayPropertiesService.Bounds.Width
                               , _displayPropertiesService.Bounds.X
                               , _displayPropertiesService.Bounds.Y);
                           LogicalDPI = _displayPropertiesService.LogicalDpi.ToString("0.000");
                           RawDPIX = _displayPropertiesService.RawDpiX.ToString("0.000");
                           RawDPIY = _displayPropertiesService.RawDpiY.ToString("0.000");
                           RawPixelPerViewPixel = _displayPropertiesService.RawPixelsPerViewPixel.ToString("0.00");

                       }
                       catch (Exception ex)
                       {

                           throw ex;
                       }

                   }));
            }

        }


        public readonly IDisplayPropertiesService _displayPropertiesService;

        public Display(
          INavigationService navigationService
          ,
          IStorageService storageService
          ,
          IDisplayPropertiesService displayPropertiesService
        )
            : base(
            navigationService
            ,
            storageService


            )
        {
            _displayPropertiesService = displayPropertiesService;



        }
    }
}
