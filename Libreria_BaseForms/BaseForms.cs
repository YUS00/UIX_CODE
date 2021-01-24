using System;
using System.Windows.Forms;

namespace Libreria_BaseForms
{
    public partial class BaseForms : Form
    {
        public BaseForms()
        {
            InitializeComponent();
        }

        int locationX, locationY;
        int formWidth, formHeight;



        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The application will be closed, do you agree?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        //private const int gridSize = 10;
        //private const int areamouse = 132;
        //private const int botonizquierdo = 17;
        //private Rectangle rectangulogrid;



        //protected override void WndProc(ref Message sms)
        //{

        //    switch (sms.Msg)
        //    {
        //        case areamouse:
        //            base.WndProc(ref sms);

        //            var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
        //            if (!rectangulogrid.Contains(RefPoint))
        //            {
        //                break;
        //            }

        //            sms.Result = new IntPtr(botonizquierdo);
        //            break;
        //        default:
        //            base.WndProc(ref sms);
        //            break;
        //    }
        //}

    }
}
