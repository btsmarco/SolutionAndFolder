using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace Coptic_Agpeya
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

   MediaPlayerLauncher objMediaPlayerLauncher = new MediaPlayerLauncher(); 


 objMediaPlayerLauncher.Media = new Uri("095-Psalm95.mp3", UriKind.Relative); 


 objMediaPlayerLauncher.Location = MediaLocationType.Install; 


 objMediaPlayerLauncher.Controls = MediaPlaybackControls.Pause | MediaPlaybackControls.Stop | MediaPlaybackControls.All; 


 objMediaPlayerLauncher.Orientation = MediaPlayerOrientation.Landscape; 


 objMediaPlayerLauncher.Show(); 

        }

    }
}