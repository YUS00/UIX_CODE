using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Reflection;
using System.Data.Common;
using System.Dynamic;

namespace G7_Users
{
    public partial class Form1 : Libreria_BaseForms.BaseFormVentana
    {
        public Form1()
        {
            InitializeComponent();
        }


        UsersEntities db;
        

        List<Users> users;

        bool EsNou = false;

        private void CarregarDades()
        {
            db = new UsersEntities();
            users = db.Users.ToList();
            dataGridView1.DataSource = users;
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
                    ctr.DataBindings.Add("Text", dataGridView1.DataSource, SWctr.CampoBBDD);
                }
                else if (ctr is LibreriaControles.UIXCombobox)
                {
                    //Creada instancia de DataBase para que no se acumulen las tablas en el DataBase del DataGridView
                    
                    
                    
                    LibreriaControles.UIXCombobox SWctr = (LibreriaControles.UIXCombobox)ctr;
                    SWctr.DataBindings.Clear();
                    
                    string tableName = SWctr.TaulaForanea.ToString();
                    //Dictionary<string, Type> myDictionary = new Dictionary<string, Type>()
                    //{
                    //    {"UserRanks", typeof(List<UserRanks>) },
                    //    {"UserCategories", typeof(List<UserCategories>) },
                    //    {"Species", typeof(List<Species>) },
                    //    {"Planets", typeof(List<Planets>) },
                    //};

                    dynamic foreignTable;

                    switch (tableName)
                    {
                        case "UserRanks":
                            foreignTable = db.UserRanks.ToList();


                            SWctr.DataSource = foreignTable;
                            SWctr.DisplayMember = SWctr.CampMostrar;
                            SWctr.ValueMember = SWctr.CampID;

                            SWctr.DataBindings.Add("SelectedValue", dataGridView1.DataSource, SWctr.CampoBBDD);

                            break;
                        case "UserCategories":
                            foreignTable = db.UserCategories.ToList();

                            SWctr.DataSource = foreignTable;
                            SWctr.DisplayMember = SWctr.CampMostrar;
                            SWctr.ValueMember = SWctr.CampID;

                            SWctr.DataBindings.Add("SelectedValue", dataGridView1.DataSource, SWctr.CampoBBDD);
                            break;
                        case "Species":
                            foreignTable = db.Species.ToList();

                            SWctr.DataSource = foreignTable;
                            SWctr.DisplayMember = SWctr.CampMostrar;
                            SWctr.ValueMember = SWctr.CampID;

                            SWctr.DataBindings.Add("SelectedValue", dataGridView1.DataSource, SWctr.CampoBBDD);
                            break;
                        case "Planets":
                            foreignTable = db.Planets.ToList();

                            SWctr.DataSource = foreignTable;
                            SWctr.DisplayMember = SWctr.CampMostrar;
                            SWctr.ValueMember = SWctr.CampID;

                            SWctr.DataBindings.Add("SelectedValue", dataGridView1.DataSource, SWctr.CampoBBDD);
                            break;
                        default:
                            break;
                    }

                    
                }
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
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
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
            int id;
            if (EsNou)
            {
               
                Users user = new Users
                {
                    CodeUser = swtCodeUser.Text,
                    UserName = swtUsername.Text,
                    Login = swtLogin.Text,
                    Password = swtPassword.Text,
                    idUserRank = (int)cbxUserRank.SelectedValue,
                    idUserCategory = (int)cbxUserCategory.SelectedValue,
                    Photo = swtPhoto.Text,
                    idSpecie = (int) cbxSpecie.SelectedValue,
                    level = Convert.ToInt32(swtLevel.Text),
                    idPlanet = (int) cbxPlanet.SelectedValue


                };
                db.Users.Add(user);
                EsNou = false;
                dataGridView1.Refresh();
                dataGridView1.Update();
                id = user.idUser;
                FerBinding();
            }
            //Actualizar
            db.SaveChanges();
        }
    }
}
