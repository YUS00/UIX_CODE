﻿using System;
using System.Data;
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
            Mostrar_dades();
        }


        private void dtg_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is LibreriaClases.SWTextbox)
                {
                    LibreriaClases.SWTextbox SWctr = (LibreriaClases.SWTextbox)ctr;
                    SWctr.Text = dtg.SelectedRows[0].Cells[SWctr.CampoBBDD].Value.ToString();

                }
            }
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {


            //añadir_registro = ;

            //if (añadir_registro)
            //{
                dades.Actualizar();
            //}
            
        }

        private void btnAfegir_Click(object sender, EventArgs e)
        {
            Boolean añadir_registro = false;

            DataRow dr = dts.Tables[0].NewRow();

            foreach (Control ctr in this.Controls)
            {

                if (ctr is LibreriaClases.SWTextbox)
                {
                    LibreriaClases.SWTextbox SWctr = (LibreriaClases.SWTextbox)ctr;

                    dr[SWctr.CampoBBDD.ToString()] = SWctr.Text;

                   
                }

                

            }

            dts.Tables[0].Rows.Add(dr);

        }



        private void Mostrar_dades()
        {
            dts = dades.PortarTaula(this.Taula);
            dtg.DataSource = dts.Tables[0];
            foreach (Control ctr in this.Controls)
            {
                //    if((ctr.GetType() == typeof(LibreriaClases.SWTextbox)))
                //    {
                //        //Como me refiero al campo CampoBBDD del SWTextbox?, de momento lo asigno al tag
                //        ctr.DataBindings.Add("Text", dtg.DataSource, ctr.Tag.ToString());
                //    }
                //}
                if (ctr is LibreriaClases.SWTextbox)
                {
                    LibreriaClases.SWTextbox SWctr = (LibreriaClases.SWTextbox)ctr;
                    ctr.DataBindings.Add("Text", dts.Tables[0], SWctr.CampoBBDD);
                }
                else if (ctr is LibreriaControles.UIXCombobox)
                {
                    //Creada instancia de DataBase para que no se acumulen las tablas en el DataBase del DataGridView
                    BaseDatos.DataBase dadesCombobox = new BaseDatos.DataBase();
                    LibreriaControles.UIXCombobox SWctr = (LibreriaControles.UIXCombobox)ctr;
                    DataSet dtsForanea = new DataSet();
                    dtsForanea = dadesCombobox.PortarTaula(SWctr.TaulaForanea);

                    SWctr.DataBindings.Clear();
                    //Está cogiendo la tabla Agencies en index 0, Species en index 1
                    SWctr.DataSource = dtsForanea.Tables[0];
                    SWctr.DisplayMember = SWctr.CampMostrar;
                    SWctr.ValueMember = SWctr.CampID;

                    SWctr.DataBindings.Add("SelectedValue", dts.Tables[0], SWctr.CampoBBDD);
                }
            }
        }





    }
}
