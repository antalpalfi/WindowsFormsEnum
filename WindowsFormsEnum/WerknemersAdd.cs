using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEnum
{
    public partial class WerknemersAdd : Form
    {
        public Salaris newWerknemer = new Salaris();
        public WerknemersAdd()
        {
            InitializeComponent();
            cmbContract.Items.Add("maand");
            cmbContract.Items.Add("week");
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            newWerknemer.Naam = txtNaam.Text;
            newWerknemer.Salari = (double)numBrutto.Value;
            newWerknemer.Land = txtLand.Text;
            newWerknemer.Contract = cmbContract.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }
    }
}
