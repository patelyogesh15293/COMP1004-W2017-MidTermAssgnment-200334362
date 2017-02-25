using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200334362
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();
        private List<TextBox> _abilities;

        public AbilityForm()
        {
            InitializeComponent();

            // Initialize List (empty container)
            this._abilities = new List<TextBox>();
            this._intializeAbilities();
        }
        
        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void _intializeAbilities()
        {
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            // iterates through the textbox list
            for (int abilities = 0; abilities < this._abilities.Count; abilities++)
            {
                // roll 5d10 and assign the value
                int currentRoll = this.Roll3D10();

                // assign the current roll to the current abilities
                this._abilities[abilities].Text = currentRoll.ToString();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.STR = STRTextBox.Text;
            character.DEX = DEXTextBox.Text;
            character.END = ENDTextBox.Text;
            character.INT = INTTextBox.Text;
            character.PER = PERTextBox.Text;
            character.CHA = CHATextBox.Text;

            // Initialize the next form
            RaceForm raceForm = new RaceForm();

            // create a refernace to the parentform
            raceForm.previousForm = this;
            raceForm.Show();
            this.Hide();
        }
    }

}
