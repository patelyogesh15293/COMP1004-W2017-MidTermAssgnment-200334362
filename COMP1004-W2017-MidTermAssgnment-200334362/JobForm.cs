using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334362
{
    public partial class JobForm : Form
    {
        public RaceForm previousForm;

        private int _soldier = 30;
        private int _rogue = 28;
        private int _magicker = 15;
        private int _cultist = 24;
        private string _job;

        private int _DEX = Convert.ToInt32(Program.character.DEX);
        private int _END = Convert.ToInt32(Program.character.END);
        private int _INT = Convert.ToInt32(Program.character.INT);
        private int _CHA = Convert.ToInt32(Program.character.CHA);

        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;


            character.Health = HealthPointsLabel.Text;
            character.JOB = this._job;

            this.Hide();
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;
            finalForm.Show();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_soldier + _END).ToString();
            }
        }

        private void RougueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RougueRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_rogue + _DEX).ToString();
            }

        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MagickerRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_magicker + _INT).ToString();
            }
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CultistRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_cultist + _CHA).ToString();
            }
        }
    }
}
