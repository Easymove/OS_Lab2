using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab2
{
    public partial class appForm : Form
    {
        CoinMachine machine = new CoinMachine();

        public appForm()
        {
            InitializeComponent();
            initNominals();
            initRest();
        }

        private void initNominals() {
            foreach (int i in machine.nominals)
            {
                nominalText.Items.Add(i.ToString());
            }
        }

        private void initRest()
        {
            restText.Text = "[1, 2, 5, 10, 25, 50, 100]  ::  " + String.Join("  ", machine.counts);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (inputText.Text != "" && nominalText.Text != "")
            {
                resText.Text = "";
                machine.run();
            }
        }
    }
}
