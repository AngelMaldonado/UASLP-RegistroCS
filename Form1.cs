using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio2
{
    public partial class registroDePersonas : Form
    {
        List<string> info;
        public registroDePersonas()
        {
            info = new List<string>(8);
          
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guaradarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string datos = "";
            info.Add(tbNombre.Text);
            info.Add(tbApellidoP.Text);
            info.Add(tbApellidoM.Text);
            info.Add(cbPais.SelectedItem.ToString());
            info.Add(cbEstado.SelectedItem.ToString());
            if (rbMasc.Checked)
                info.Add(rbMasc.Text);
            else
                if (rbFem.Checked)
                info.Add(rbFem.Text);
            else
                info.Add(rbResp.Text);
            info.Add(chkAcepto.Enabled.ToString());
            info.Add(monthCalendar1.SelectionRange.Start.ToString());
            foreach (string elemento in info)
                datos += elemento;
            File.WriteAllText(@"C:\Users\DELL\Desktop\UNI MARIANA\INTERFACES\\info.txt", datos);

        }

    }
}
