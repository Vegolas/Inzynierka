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
            //IntPtr image = CvInvoke.cvCreateImage(new System.Drawing.Size(400, 300), Emgu.CV.CvEnum.IplDepth.IplDepth_8U, 1);
            //Image<Bgr, Byte> image = new Image<Bgr, byte>(100,100);
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

        #endregion
    }
}
