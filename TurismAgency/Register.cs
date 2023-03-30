using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.repo;
using WindowsFormsApp3.srv;

namespace WindowsFormsApp3
{
    public partial class Register : Form
    {
        private readonly SRVAgent _a;
        IDictionary<string, string> props;
        
        public Register(IDictionary<string, string> props)
        {
            this.props = props;
            _a = new SRVAgent(props);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var l = new LogIn(props);
            l.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox4.Text == textBox5.Text)
            {
                try
                {
                    _a.addAgent(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);
                    MessageBox.Show("You have been registered!");
                    button2_Click(sender, e);
                }
                catch (ValidationException exception)
                {
                    MessageBox.Show(exception.Message);
                }
                catch (RepoException repoException)
                {
                    MessageBox.Show((repoException.Message));
                }

            }
            else
            {
                MessageBox.Show("Unmatching Passwords");
            }
           

        }
    }
}