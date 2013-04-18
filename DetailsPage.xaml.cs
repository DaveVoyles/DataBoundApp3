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
using Windows.Phone.Speech.Synthesis;
using Microsoft.Xna.Framework.Audio;

namespace DataBoundApp3
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        SpeechSynth speechSynthesizer;
        /**********************************************************************************
        * Constructor
        * Requires the capability ID_CAP_SPEECH_RECOGNITION & ID_CAP_MICROPHONE which has 
        * been enabled in the WMAppManifest.xml
        **********************************************************************************/
        public DetailsPage()
        {
            InitializeComponent();
            speechSynthesizer = new SpeechSynth();

            // Hides the animation particles until the correct word is entered by user
            this.AnimCanvas.Visibility = Visibility.Collapsed;
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                }
            }
        }


        /**********************************************************************************
        * Read out the content of the TextBox when the Play button is tapped
        **********************************************************************************/
        private async void ApplicationBarIconButton_TextToSpeech_Click(object sender, EventArgs e)
        {
            // Cancel any and all speaking from the synthesizer
            speechSynthesizer.synthesizer.CancelAll(); 

            // Readout the text
            try
            {
                await speechSynthesizer.synthesizer.SpeakTextAsync(this.readoutTextBox.Text.ToString());     // read the text

                // If the text the user enters matches the dictionary
                if (this.readoutTextBox.Text.ToLower() == this.AItemNameBlock.Text.ToLower())
                {
                    CorrectMatch();
                }
             }
            catch
            {
                // Ignore the exception which may be generated if the synthesizer is already in the middle of saying something
            }
        }

        /**********************************************************************************
        * Triggered when user correctly enters a string to match what is on screen
        **********************************************************************************/
        private void CorrectMatch()
        {
            SoundEffects.SFX_Yay.Play();        // Triggers celebration SFX
            this.AnimImageFade.Begin();         // Begins to fade out image
            this.Focus();                       // Hides keyboard

            // Hides the animation particles until the correct word is entered by user
            this.AnimCanvas.Visibility = Visibility.Visible;
            this.AnimFallingSprite.Begin();     // Begins falling celebration sprites    
        }


        /**********************************************************************************
        * Event handler for clearing the string when a user goes to first enter in text
        **********************************************************************************/
        private void readoutTextBox_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            readoutTextBox.Text = "";            // Clears the string text
            SoundEffects.SFX_ButtonClick.Play(); 
        }
    }
}