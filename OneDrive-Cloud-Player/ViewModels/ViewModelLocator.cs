﻿using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace OneDrive_Cloud_Player.ViewModels
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
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
            }
            else
            {
                // Create run time view services and models
            }

            //Register your services used here
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            //SimpleIoc.Default.Register<StartPageViewModel>();
            SimpleIoc.Default.Register<VideoPlayerPageViewModel>();
            SimpleIoc.Default.Register<LoginPageViewModel>();

        }


        // <summary>
        // Gets the StartPage view model.
        // </summary>
        // <value>
        // The StartPage view model.
        // </value>
        //public StartPageViewModel StartPageInstance
        //{
        //    get
        //    {
        //        return ServiceLocator.Current.GetInstance<StartPageViewModel>();
        //    }
        //}


        // <summary>
        // Gets the VideoPlayer view model.
        // </summary>
        // <value>
        // The StartPage view model.
        // </value>
        public VideoPlayerPageViewModel VideoPlayerPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<VideoPlayerPageViewModel>();
            }
        }

        // <summary>
        // Gets the LoginPage view model.
        // </summary>
        // <value>
        // The StartPage view model.
        // </value>
        public LoginPageViewModel LoginPageInstance
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginPageViewModel>();
            }
        }

        // <summary>
        // The cleanup.
        // </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }

}