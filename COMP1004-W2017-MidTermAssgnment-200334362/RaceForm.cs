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
    public partial class RaceForm : Form
    {
        // reference previous created form
        public AbilityForm previousForm;

        // Declare private variable
        private String _holdValue;

        private int _STR = Convert.ToInt32(Program.character.STR);
        private int _DEX = Convert.ToInt32(Program.character.DEX);
        private int _END = Convert.ToInt32(Program.character.END);
        private int _INT = Convert.ToInt32(Program.character.INT);
        private int _PER = Convert.ToInt32(Program.character.PER);
        private int _CHA = Convert.ToInt32(Program.character.CHA);


        public RaceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a method for chaange picture to pictubox when use select different radio button
        /// </summary>
        private void _pictureSelection()
        {
            if (HalflingRadioButton.Checked == true)
            {
                CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            }
            else if (HumanRadioButton.Checked == true)
            {
                CharacterPictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (ELFRadioButton.Checked == true)
            {
                CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (DwarfRadioButton.Checked == true)
            {
                CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else
            {
                CharacterPictureBox.Image = Properties.Resources.M_Human1;
            }
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();

            RacialBonusTextBox.Text = "Increase DEX and INT by 20 points, Decrease STR by 10 points";
            _DEX = _DEX + 20;
            _INT = _INT + 20;
            _STR = _STR - 10;

            this._holdValue = HalflingRadioButton.Text;
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();

            RacialBonusTextBox.Text = "Increase STR and PER by 20 points, Decrease CHA by 10 points";
            _STR = _STR + 20;
            _PER = _PER + 20;
            _CHA = _CHA - 10;

            this._holdValue = DwarfRadioButton.Text;

        }

        private void ELFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();

            RacialBonusTextBox.Text = "Increase the Character’s DEX and CHA by 15 points";
            _DEX = _DEX + 15;
            _CHA = _CHA + 15;

            this._holdValue = ELFRadioButton.Text;

        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            Character character = Program.character;

            character.Race = _holdValue;

            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        private void RaceForm_Load(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;

            RacialBonusTextBox.Text = "Increase all abilities by 5";
            _STR = _STR + 5;
            _DEX = _DEX + 5;
            _END = _END + 5;
            _INT = _INT + 5;
            _PER = _PER + 5;
            _CHA = _CHA + 5;

            this._holdValue = HumanRadioButton.Text;
        }
    }
}
