using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace unix_code


{
    public partial class Menu : Form
    {
        public Menu(String user)
        {
            InitializeComponent();
            username = user;
            labelUsername.Text = username;
            Modelos.User.setUserName(username);
        }

        String username;

        private const int gridSize = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);

        //    var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
        //    rectangulogrid = new Rectangle(ClientRectangle.Width - gridSize, ClientRectangle.Height - gridSize, gridSize, gridSize);
        //    region.Exclude(rectangulogrid);
        //    pnlPrincipal.Region = region;
        //    Invalidate();
        //}

        //protected override void WndProc(ref Message sms)
        //{
        //    base.WndProc(ref sms);
        //    switch (sms.Msg)
        //    {
        //        case areamouse:
        //            base.WndProc(ref sms);

        //            var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
        //            if (rectangulogrid.Contains(RefPoint))
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

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
        //    e.Graphics.FillRectangle(solidBrush, rectangulogrid);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Muestra Muestra = new Muestra(labelUsername.Text);
        //    Muestra.Show();
        //}
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    Acces_bbdd basebbdd = new Acces_bbdd();
        //    basebbdd.Show();
        //    this.Hide();
        //}
        private void cerrarsesion_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.Show();
        }
        DataSet dts, dtsLevel;
        String form, classe, descripcio, color, level;

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            locationX = Location.X;
            locationY = Location.Y;

            formWidth = Size.Width;
            formHeight = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The application will be closed, do you agree?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(formWidth, formHeight);
            Location = new Point(locationX, locationY);

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Application.StartupPath + @"\ConsolaServidorFTP.exe";
            Process.Start(startInfo);

            //Console.WriteLine(Application.StartupPath);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            BaseDatos.DataBase bd = new BaseDatos.DataBase();
            String query = "select * from menu";

            String query2 = "SELECT * from USERS WHERE CodeUser = '" + labelUsername.Text + "';";
            dtsLevel = bd.PortarPerConsulta(query2);
            level = dtsLevel.Tables[0].Rows[0]["level"].ToString();
            //MessageBox.Show(level);
            dts = bd.CarregarMenu(level);
            //Cargar nombre en pantalla
            lblUser.Text = username;




            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                form = dr["classe"].ToString();
                classe = dr["ensamblat"].ToString();
                descripcio = dr["descOpcio"].ToString();
                color = dr["backgroundColor"].ToString();

                LibreriaUserControls.ControlLlencaApplicacions btn = new LibreriaUserControls.ControlLlencaApplicacions();
                btn.LabelText = descripcio;
                btn.ClasseObrir = classe;
                btn.FormObrir = form;
                btn.BackgroundColor = Color.FromName(color);

                tbl.Controls.Add(btn);

            }
        }

        private void class11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int locationX, locationY;
        int formWidth, formHeight;

    }
}
