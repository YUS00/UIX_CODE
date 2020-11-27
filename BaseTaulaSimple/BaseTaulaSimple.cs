﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseTaulaSimple
{
    public partial class BaseTaulaSimple : Libreria_BaseForms.BaseForms
    {
        public BaseTaulaSimple()
        {
            InitializeComponent();
        }

        BaseDatos.DataBase dades = new BaseDatos.DataBase();
        DataSet dts = new DataSet();


        private String _Taula;

        public String Taula
        {
            get { return _Taula; }
            set { _Taula = value; }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dts = dades.PortarTaula(this.Taula);
            dtg.DataSource = dts.Tables[0];
            foreach (Control ctr in this.Controls)
            {
                if((ctr.GetType() == typeof(LibreriaClases.SWTextbox)))
                {
                    //Como me refiero al campo CampoBBDD del SWTextbox?, de momento lo asigno al tag
                    ctr.DataBindings.Add("Text", dtg.DataSource, ctr.Tag.ToString());
                }
            }
        }
    }
}
