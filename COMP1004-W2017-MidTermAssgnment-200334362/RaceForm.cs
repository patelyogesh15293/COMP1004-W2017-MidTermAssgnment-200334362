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
        public Form previousForm;

        public RaceForm()
        {
            InitializeComponent();
        }

        public AbilityForm PreviousForm = new AbilityForm();

        /// <summary>
        /// Create a method for chaange picture to pictubox when use select different radio button
        /// </summary>
        private void _pictureSelection()
        {
            if (HalflingRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/yopat/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334362/COMP1004-W2017-MidTermAssgnment-200334362/Resources/M_Halfling2.png");
            }
            else if (HumanRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/yopat/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334362/COMP1004-W2017-MidTermAssgnment-200334362/Resources/M_Human1.png");
            }
            else if (ELFRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/yopat/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334362/COMP1004-W2017-MidTermAssgnment-200334362/Resources/M_Elf1.png");
            }
            else if (DwarfRadioButton.Checked == true)
            {
                CharacterPictureBox.Load("c:/users/yopat/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334362/COMP1004-W2017-MidTermAssgnment-200334362/Resources/M_Dwarf1.png");
            }
            else
            {
                CharacterPictureBox.Load("c:/users/yopat/documents/visual studio 2015/Projects/COMP1004-W2017-MidTermAssgnment-200334362/COMP1004-W2017-MidTermAssgnment-200334362/Resources/M_Halfling2.png");
            }
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();
        }

        private void ELFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _pictureSelection();
        }
    }
}
