/**************************************************************************
 * DataBoundApp3
 * This app allows users to view an image, enter matching text, and then have 
 * the app confirm or deny whether or not the text matches the image
 * Dave Voyles 1/7/13
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DataBoundApp3.Resources;
using DataBoundApp3.ViewModels;
using Windows.Phone.Speech.Synthesis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;
using System.Windows.Resources;

namespace DataBoundApp3
{
    public partial class MainPage : PhoneApplicationPage
    {

        /*********************************************************
         * Constructor
        *********************************************************/
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the LongListSelector control to the sample data
            DataContext = App.ViewModel;

            // Prompt to make user aware that permissions must be granted to use voice recognition
            if (Microsoft.Devices.Environment.DeviceType == Microsoft.Devices.DeviceType.Emulator)
            {
                MessageBox.Show(AppResources.Warn_EmulatorMode, AppResources.Warn_EmulatorModeTitle, MessageBoxButton.OK);
            }

            // Initializes SoundEffects class
            SoundEffects.Initialize();
        }

        /*********************************************************
        * Loads data for ViewModel
        *********************************************************/
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
                App.ViewModel.LoadData();

            // Plays the click sound 
            SoundEffects.SFX_ButtonClick.Play();
        }


        /*********************************************************
        * Handle selection changed on LongListSelector
        *********************************************************/
        private void MainLongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected item is null (no selection) do nothing
            if (MainLongListSelector.SelectedItem == null)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?selectedItem=" + (MainLongListSelector.SelectedItem as ItemViewModel).ID, UriKind.Relative));

            // Reset selected item to null (no selection)
            MainLongListSelector.SelectedItem = null;

            // Plays the click sound 
            SoundEffects.SFX_ButtonClick.Play();
        }    
    }
}