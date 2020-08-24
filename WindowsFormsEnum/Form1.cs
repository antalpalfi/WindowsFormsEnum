using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsEnum
{
    public partial class Form1 : Form
    {
        
        public List<Werknemer> WerkNemList = new List<Werknemer>();
        public List<Bedrijf> BedrijList = new List<Bedrijf>();
        public List<Werknemer> MercedesList = new List<Werknemer>();
        public List<Werknemer> BmwList = new List<Werknemer>();
        public List<Werknemer> AudiList = new List<Werknemer>();
        public Form1()
        {
            InitializeComponent();
            Werknemer werknemer = new Salaris("Geert",contract: "week");
            Werknemer werknemer2 = new Salaris("Frank", salari : 2200.00);
            Werknemer werknemer3 = new Salaris("Daniel", land : "Nederland",contract: "week");
            Werknemer werknemer4 = new Salaris("Sofia", salari :3110.00, land :"Nederland");
            MercedesList.Add(werknemer);
            BmwList.Add(werknemer2);
            BmwList.Add(werknemer3);
            AudiList.Add(werknemer4);
            LoadListCmbNaam();
            Bedrijf bedrifj1 = new Bedrijf("Mercedes", BtwNummerRandom());
            Thread.Sleep(50);
            Bedrijf bedrifj2 = new Bedrijf("BMW", BtwNummerRandom());
            Thread.Sleep(50);
            Bedrijf bedrifj3= new Bedrijf("Audi", BtwNummerRandom());
            BedrijList.Add(bedrifj1);
            BedrijList.Add(bedrifj2);
            BedrijList.Add(bedrifj3);
            LoadCmbBedrijf();




        }
        public string BtwNummerRandom()
        {
            Random rng = new Random();
            string rekeningnr = "BE";
            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(999);
                rekeningnr += " " + randomnr.ToString().PadLeft(3, '0');
            }
            return rekeningnr;

        }


        private void cmbNaam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNaam.DataSource != null)
            {
                lblInfo.Text = (cmbNaam.SelectedItem as Salaris).Beschrijft();
            }
            else
            {
                lblInfo.Text = "";
            }
        }
        private void LoadListCmbNaam()
        {
            cmbNaam.DataSource = null;
            cmbNaam.DataSource = WerkNemList;
        }
        private void LoadCmbBedrijf()
        {
            cmbBedrijf.DataSource = null;
            cmbBedrijf.DataSource = BedrijList;
        }

        private void cmbBedrijf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBedrijf.Text == "Mercedes")
            {
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = MercedesList;
                if (cmbBedrijf.DataSource != null)
                {
                    lblBedrifjInfo.Text = (cmbBedrijf.SelectedItem as Bedrijf).BedrijfInfo();

                }
             
                else
                {
                    lblBedrifjInfo.Text = "";
                }
            }
            else if (cmbBedrijf.Text == "BMW")
            {
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = BmwList;
                if (cmbBedrijf.DataSource != null)
                {
                    lblBedrifjInfo.Text = (cmbBedrijf.SelectedItem as Bedrijf).BedrijfInfo();

                }

                else
                {
                    lblBedrifjInfo.Text = "";
                }

            }
            else if (cmbBedrijf.Text == "Audi")
            {
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = AudiList;
                if (cmbBedrijf.DataSource != null)
                {
                    lblBedrifjInfo.Text = (cmbBedrijf.SelectedItem as Bedrijf).BedrijfInfo();

                }

                else
                {
                    lblBedrifjInfo.Text = "";
                }

            }

        }
        private  void Verwijderen()
        {
            if (cmbBedrijf.Text == "Mercedes")
            {
                MercedesList.RemoveAt(cmbNaam.SelectedIndex);
                cmbNaam.Items.Remove(cmbNaam.SelectedIndex);
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = MercedesList;
            }
            else if (cmbBedrijf.Text == "BMW")
            {
                BmwList.RemoveAt(cmbNaam.SelectedIndex);
                cmbNaam.Items.Remove(cmbNaam.SelectedIndex);
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = BmwList;

            }
            else if (cmbBedrijf.Text == "Audi")
            {
                AudiList.RemoveAt(cmbNaam.SelectedIndex);
                cmbNaam.Items.Remove(cmbNaam.SelectedIndex);
                cmbNaam.DataSource = null;
                cmbNaam.DataSource = AudiList;

            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Verwijderen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            WerknemersAdd werknemersAdd = new WerknemersAdd();
            if (werknemersAdd.ShowDialog() == DialogResult.OK)
            {
                if (cmbBedrijf.Text == "Mercedes")
                {
                    MercedesList.Add(werknemersAdd.newWerknemer);
                    cmbNaam.DataSource = null;
                    cmbNaam.DataSource = MercedesList;
                }
                else if (cmbBedrijf.Text == "BMW")
                {
                    BmwList.Add(werknemersAdd.newWerknemer);
                    cmbNaam.DataSource = null;
                    cmbNaam.DataSource = BmwList;

                }
                else if (cmbBedrijf.Text == "Audi")
                {
                    AudiList.Add(werknemersAdd.newWerknemer);
                    cmbNaam.DataSource = null;
                    cmbNaam.DataSource = AudiList;
                }
            }
        }
    }
}
