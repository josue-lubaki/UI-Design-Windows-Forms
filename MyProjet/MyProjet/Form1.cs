using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjet
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Démarrer Timer
            progressBar1.Increment(2); // Incrementer à une vitesse de 2

            if(progressBar1.Value == 100)
            {
                timer1.Enabled = false; // Arrêter Timer
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }
    }
}
