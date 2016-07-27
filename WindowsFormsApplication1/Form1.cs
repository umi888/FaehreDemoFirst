using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Faehre faehre = null;
        public Form1()
        {

            InitializeComponent();            
        }

        private void buttonFaehreErzeugen_Click(object sender, EventArgs e)
        {
            faehre = new Faehre();
            faehre.Baujahr = Convert.ToInt32(textBoxBaujahr.Text);
            faehre.Laenge = Convert.ToDecimal(textBoxLänge.Text);
            faehre.Name = textBoxName.Text;
            toolStripStatusLabelMeldung.Text = "Faehre " + faehre.Name + " wurde angelegt";
        }
    }
}
