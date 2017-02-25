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
    public partial class FinalForm : Form
    {
        // Jobform object for get and set all valyes
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler for form load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            HealthPointsTextBox.Text = Program.character.Health;
            JobTextBox.Text = Program.character.JOB;
            RaceTextBox.Text = Program.character.Race;
            STRTextBox.Text = Program.character.STR;
            ENDTextBox.Text = Program.character.END;
            DEXTextBox.Text = Program.character.DEX;
            INTTextBox.Text = Program.character.INT;
            PERTextBox.Text = Program.character.PER;
            CHATextBox.Text = Program.character.CHA;

            if (RaceTextBox.Text == "Human")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Human1;
            }
            else if (RaceTextBox.Text == "Elf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            }
            else if (RaceTextBox.Text == "Dwarf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            }
            else if (RaceTextBox.Text == "Halfling")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            }
        }

        /// <summary>
        /// Handler for print tool strip clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fina data of your process is send to printer....");
        }

        /// <summary>
        /// Handler for print About tool strip clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Handler for font tool strip clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();

            NameTextBox.Font = fontDialog.Font;
            HeightTextBox.Font = fontDialog.Font;
            WeightTextBox.Font = fontDialog.Font;

        }
    }
}
