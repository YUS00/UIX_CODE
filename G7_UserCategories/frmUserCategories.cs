using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G7_UserCategories
{
    public partial class frmUserCategories : Libreria_BaseForms.BaseForms
    {

        SecureCoreEntities db;

        List<UserCategories> userCategories;

        bool EsNou = false;


        public frmUserCategories()
        {
            InitializeComponent();
        }

        private void CarregarDades()
        {
            db = new SecureCoreEntities();
            userCategories = db.UserCategories.ToList();
            dataGridView1.DataSource = userCategories;
            FerBinding();
        }

        private void FerBinding()
        {
            
            foreach (Control ctr in this.Controls)
            {
               
                if (ctr is LibreriaClases.SWTextbox)
                {
                    LibreriaClases.SWTextbox SWctr = (LibreriaClases.SWTextbox)ctr;
                    SWctr.DataBindings.Clear();
                    ctr.DataBindings.Add("Text", userCategories, SWctr.CampoBBDD);
                }
                //else if (ctr is LibreriaControles.UIXCombobox)
                //{
                //    //Creada instancia de DataBase para que no se acumulen las tablas en el DataBase del DataGridView
                //    BaseDatos.DataBase dadesCombobox = new BaseDatos.DataBase();
                //    LibreriaControles.UIXCombobox SWctr = (LibreriaControles.UIXCombobox)ctr;
                //    SWctr.DataBindings.Clear();

                //    DataSet dtsForanea = new DataSet();
                //    dtsForanea = dadesCombobox.PortarTaula(SWctr.TaulaForanea);

                //    SWctr.DataBindings.Clear();
                //    //Está cogiendo la tabla Agencies en index 0, Species en index 1
                //    SWctr.DataSource = dtsForanea.Tables[0];
                //    SWctr.DisplayMember = SWctr.CampMostrar;
                //    SWctr.ValueMember = SWctr.CampID;

                //    SWctr.DataBindings.Add("SelectedValue", dts.Tables[0], SWctr.CampoBBDD);
                //}
            }
            

        }

        private void TreuBinding()
        {
            foreach (Control ctr in this.Controls)
            {

                if (ctr is LibreriaClases.SWTextbox)
                {
                    LibreriaClases.SWTextbox SWctr = (LibreriaClases.SWTextbox)ctr;
                    SWctr.DataBindings.Clear();
                    SWctr.Clear();
                }
                //else if (ctr is LibreriaControles.UIXCombobox)
                //{
                //    //Creada instancia de DataBase para que no se acumulen las tablas en el DataBase del DataGridView
                //    BaseDatos.DataBase dadesCombobox = new BaseDatos.DataBase();
                //    LibreriaControles.UIXCombobox SWctr = (LibreriaControles.UIXCombobox)ctr;
                //    SWctr.DataBindings.Clear();

                //    DataSet dtsForanea = new DataSet();
                //    dtsForanea = dadesCombobox.PortarTaula(SWctr.TaulaForanea);

                //    SWctr.DataBindings.Clear();
                //    //Está cogiendo la tabla Agencies en index 0, Species en index 1
                //    SWctr.DataSource = dtsForanea.Tables[0];
                //    SWctr.DisplayMember = SWctr.CampMostrar;
                //    SWctr.ValueMember = SWctr.CampID;

                //    SWctr.DataBindings.Add("SelectedValue", dts.Tables[0], SWctr.CampoBBDD);
                //}
            }

        }

        private void frmUserCategories_Load(object sender, EventArgs e)
        {
            CarregarDades();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreuBinding();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                UserCategories userCategories = new UserCategories
                {
                    CodeCategory = swtCodeCategory.Text,
                    DescCategory = swtDescCategory.Text,
                    AccessLevel = Int32.Parse(swtAccessLevel.Text)

                };
                db.UserCategories.Add(userCategories);
                EsNou = false;
                dataGridView1.Refresh();
                dataGridView1.Update();
                FerBinding();
            }
            //Actualizar
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int indexFila = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
