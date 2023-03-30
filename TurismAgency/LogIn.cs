using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp3.domain;
using WindowsFormsApp3.srv;

namespace WindowsFormsApp3
{
    public partial class LogIn : Form
    {
        private readonly SRVAgent _a;
        IDictionary<string, string> props = new SortedList<string, string>();
        public LogIn(IDictionary<string, string> props)
        {
            this.props = props;
            _a = new SRVAgent(props);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agent user = _a.findByIdentity(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                Hide();
                var l = new Form1(props,user.Name);
                l.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var l = new Register(props);
            l.ShowDialog();
            Close();
        }
    }
}