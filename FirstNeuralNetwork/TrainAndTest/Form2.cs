using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainAndTest
{
    public partial class Form2 : Form
    {
        private FolderBrowserDialog selectTrainDataBrowserDialog, selectTestDataBrowserDialog;

        public Form2()
        {
            InitializeComponent();
            selectTrainDataBrowserDialog = new FolderBrowserDialog();
            selectTestDataBrowserDialog = new FolderBrowserDialog();
        }

        private void selectTrainDataDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = selectTrainDataBrowserDialog.ShowDialog();
            if ( result == DialogResult.OK)
            {
                trainPathLabel.Text = selectTrainDataBrowserDialog.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = selectTestDataBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                testPathLabel.Text = selectTestDataBrowserDialog.SelectedPath;
            }
        }
    }
}
