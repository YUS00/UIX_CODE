using System;
using System.Drawing;
using System.Windows.Forms;

namespace Libreria_BaseForms
{
    public partial class BaseForms : Form
    {
        public BaseForms()
        {
            InitializeComponent();
            this.labelUsername.Text = Modelos.User.getUserName();
        }

        private const int gridSize = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            rectangulogrid = new Rectangle(ClientRectangle.Width - gridSize, ClientRectangle.Height - gridSize, gridSize, gridSize);
            region.Exclude(rectangulogrid);

            pnlMain.Region = region;
            Invalidate();
        }

        protected override void WndProc(ref Message sms)
        {
            
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);

                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32()&0xffff, sms.LParam.ToInt32() >> 16));
                    if(!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }

                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

    }
}
