#region Autor
//
// Autor: Mateusz Tomanek
//
// Uwagi: Plik zawierający moduł głównego formularza
//
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacja.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;

namespace Aplikacja
{
    public partial class MainForm : Form
    {
        #region Zmienne prywatne

        private Capture _capture;        
        private bool _captureInProgress; 

        #endregion

        #region Konstruktor
        public MainForm()
        {
            InitializeComponent();
            _capture = new Capture("http://192.168.1.3:8080/?x.mjpg");
            _capture.Start();
            _capture.ImageGrabbed += imageGrabbed;
        }

        #endregion

        #region Metody prywatne

        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form form = new CameraConfigForm())
            {
                form.ShowDialog();
            }
        }

        private void imageGrabbed(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            _capture.Retrieve(frame, 0);
            cameraBox.Image = frame;
        }

        #endregion
    }
}
