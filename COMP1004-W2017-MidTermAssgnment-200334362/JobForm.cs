﻿using System;
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
        // Reference previous form
        public RaceForm previousForm;

        // Declare some private variables
        private int _soldier = 30;
        private int _rogue = 28;
        private int _magicker = 15;
        private int _cultist = 24;
        private int _job;

        // Create private variables for hold character value
        private int _DEX = Convert.ToInt32(Program.character.DEX);
        private int _END = Convert.ToInt32(Program.character.END);
        private int _INT = Convert.ToInt32(Program.character.INT);
        private int _CHA = Convert.ToInt32(Program.character.CHA);

        public JobForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Habdler for next button event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Create character class object
            Character character = Program.character;
            
            // Assign value to local object
            character.Health = HealthPointsLabel.Text;
            character.JOB = (this._job).ToString();

            this.Hide(); // hide this form

            // create a final form object to display final form
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;
            finalForm.Show();
        }

        /// <summary>
        /// Radio button event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_soldier + _END).ToString();
            }
        }

        /// <summary>
        /// Habdler for radio button chacked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RougueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RougueRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_rogue + _DEX).ToString();
            }

        }

        /// <summary>
        /// Handler for radiobutton clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MagickerRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_magicker + _INT).ToString();
            }
        }

        /// <summary>
        /// Handler for radio button clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CultistRadioButton.Checked == true)
            {
                HealthPointsLabel.Text = (_cultist + _CHA).ToString();
            }
        }
    }
}
