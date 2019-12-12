using Plugin.Media;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FindMe.ViewModels
{
    public class AddImageViewModel : ViewModelBase
    {
        private DelegateCommand _takePhotoCommand;
        public DelegateCommand TakePhotoCommand =>
            _takePhotoCommand ?? (_takePhotoCommand = new DelegateCommand(ExecuteTakePhotoCommand));

        private ImageSource _cameraImage;

        public ImageSource CameraImage
        {
            get { return _cameraImage; }
            set { SetProperty(ref _cameraImage, value); }
        }


        private async void ExecuteTakePhotoCommand()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await _dialogService.DisplayAlertAsync("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await _dialogService.DisplayAlertAsync("File Location", file.Path, "OK");



            CameraImage = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

        }
        private IPageDialogService _dialogService;
        private DelegateCommand _addImageCommand;
        public DelegateCommand AddImageCommand =>
            _addImageCommand ?? (_addImageCommand = new DelegateCommand(ExecuteAddImageCommand));

        private ImageSource _pickImage;

        public ImageSource PickImage
        {
            get { return _pickImage; }
            set { SetProperty(ref _pickImage, value); }
        }


        private async void ExecuteAddImageCommand()
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {

            });


            if (file == null)
                return;

            await _dialogService.DisplayAlertAsync("File Location", file.Path, "OK");



            PickImage = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

        }

        public AddImageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            Title = "Pick Photo";
            _dialogService = pageDialogService;
        }

    
     
   

   /* public AddImageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
    {
        Title = "Take Photo";
        _dialogService = pageDialogService;
    }*/


}
}
    