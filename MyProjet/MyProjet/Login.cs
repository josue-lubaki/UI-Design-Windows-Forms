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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /**
         *  Methode qui permet d'effacer le texte dans le champs Username et Passsword.
         *  Et donne le Focus au champ Username
         */
        public void ClearAndFocus()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }


        /**
         * Lorsque L'Utilisateur clique sur le bouton "Log in"
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Equals("demo") && txtPassword.Text.Equals("1234"))
            {
                Home homepage = new Home();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Le nom d'Utilisateur ou mot de passe est incorrect, Réessayer");
                ClearAndFocus();
            }
        }


        /**
         * Si l'Utilisateur clique sur le label "EXIT"
         */
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /**
         * Si l'Utilisateur clique sur le label "Clear Fields"
         */
        private void label2_Click(object sender, EventArgs e)
        {
            ClearAndFocus();
        }
    }
}
