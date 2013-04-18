/**************************************************************************
 * SpeechSynth
 * Initializes synthesizer and loads dictionary
 * Dave Voyles 2/12/13
***************************************************************************/
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using Windows.Phone.Graphics;
using Microsoft.Phone.Controls;
using Windows.Phone.Speech.Synthesis;
using DataBoundApp3.Resources;
using Microsoft.Xna.Framework.Audio;

namespace DataBoundApp3
{

public class SpeechSynth
{
    public SpeechSynthesizer synthesizer;                           // Declare the synthesizer object
    public Dictionary<string, BitmapImage> ADictionary;       // Alphabet images that correspond to the words


    /**********************************************************************************
    * Constructor
    **********************************************************************************/
    public SpeechSynth()
    {
        this.initializeSpeechObjects();  // Speech synthesizer
        this.InitializeDictionary();     // Initializes Dictionary  
    }
    
    /**********************************************************************************
    * Initialize any speech objects
    **********************************************************************************/
    private void initializeSpeechObjects()
    {
        try
        {
            this.synthesizer = new SpeechSynthesizer();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Could not initialize the synthesizer: " + ex.Message);
        }
    }

    /**********************************************************************************
    * Taken from the Adding, loading, and preloading grammars for Windows Phone 8 page 
    * http://msdn.microsoft.com/en-us/library/windowsphone/develop/jj206964(v=vs.105).aspx 
    **********************************************************************************/
    public void InitializeDictionary()
    {
        /** Set up the dictionary of ADictionary objects. */
        if (ADictionary == null)
        {
            ADictionary = new Dictionary<string, BitmapImage>()
            {
                //ADictionary.Add("Apple", new BitmapImage(new Uri("/Assets/Apple.jpg", UriKind.Relative)));
                {"Apple", new BitmapImage(new Uri("/Assets/Images/Apple.jpg", UriKind.Relative))},
                {"Banana", new BitmapImage(new Uri("/Assets/Images/Banana.jpg", UriKind.Relative))},
                {"Carrot", new BitmapImage(new Uri("/Assets/Images/Carrot.jpg", UriKind.Relative))},
                {"Dog", new BitmapImage(new Uri("/Assets/Images/Dog.jpg", UriKind.Relative))}
             };
        }
    }
    

    /**********************************************************************************
    * Create images from recognized text (CURRENTLY NOT USED)
    **********************************************************************************/
    public BitmapImage getImage(string imageString)
    {
        // Default image
        BitmapImage newImage = new BitmapImage(new Uri("SplashScreenImage.jpg", UriKind.Relative));
        if (ADictionary.ContainsKey(imageString.ToLower()))
        {
            newImage = ADictionary[imageString];
        }
        return newImage;        // Returns default image
    }
}
}
