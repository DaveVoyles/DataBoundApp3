/****************************************************************
 * Audio manager for Windows Phone 8. Currently juse handles SFX
 * Dave Voyles 2/16/2013
 ***************************************************************/
using System;
using System.Windows.Media;
using System.Windows.Resources;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;
using System.IO;

namespace DataBoundApp3
{
public static class SoundEffects
{
    private static bool initialized = false;
    private static SoundEffect sfx_ButtonClick;
    private static SoundEffect sfx_yay;


    /****************************************************************
    * Must be called before using static methods
    ****************************************************************/
    public static void Initialize()
    {
        if (SoundEffects.initialized)
            return;

        // Adds an Update delegate, to simulate the XNA update method.
        FrameworkDispatcher.Update();
        initialized = true;
    }


    /****************************************************************
    * Plays the click sound when user enters/exits a menu
    ****************************************************************/
    public static SoundEffect SFX_ButtonClick
    {
        get
        {
            // If not initialized, returns null.
            if (!SoundEffects.initialized)
                return null;

            // Holds informations about a file stream.
            StreamResourceInfo info = App.GetResourceStream(new Uri(@"Assets\Audio\Button_Enter.wav", UriKind.Relative));

            // Create the SoundEffect from the Stream
            sfx_ButtonClick = SoundEffect.FromStream(info.Stream);
            return sfx_ButtonClick;
        }
    }

    /****************************************************************
   * Plays the click sound when user enters/exits a menu
   ****************************************************************/
    public static SoundEffect SFX_Yay
    {
        get
        {
            // If not initialized, returns null.
            if (!SoundEffects.initialized)
                return null;

            // Holds informations about a file stream.
            StreamResourceInfo info = App.GetResourceStream(new Uri(@"Assets\Audio\Yay.wav", UriKind.Relative));

            // Create the SoundEffect from the Stream
            sfx_yay = SoundEffect.FromStream(info.Stream);
            return sfx_yay;
        }
    }
}
}
