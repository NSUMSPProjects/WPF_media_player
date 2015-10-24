using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMediaPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // for opening files
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog opnDialogue =
            new System.Windows.Forms.OpenFileDialog();
            opnDialogue.Filter = "Video Files(*.wmv)|*.wmv";
            if (opnDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.videoelement.Source = new Uri(opnDialogue.FileName);
            }
        }

        // play and pause function
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (this.button1.Content.ToString() == "Play")
            {
                this.videoelement.Play();
                this.button1.Content = "Pause";
            }
            else
            {
                this.videoelement.Pause();
                this.button1.Content = "Play";
            }
        }


        //stop function

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            // The Stop method stops and resets the media to be played from 
            // the beginning.
            this.videoelement.Stop();
            this.button1.Content = "Play";
        }


        // forward
        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            this.videoelement.Position = this.videoelement.Position + TimeSpan.FromSeconds(10);
        }


        // backward

        private void BackWard_Click(object sender, RoutedEventArgs e)
        {
            this.videoelement.Position = this.videoelement.Position - TimeSpan.FromSeconds(10);
        }


    }
}
