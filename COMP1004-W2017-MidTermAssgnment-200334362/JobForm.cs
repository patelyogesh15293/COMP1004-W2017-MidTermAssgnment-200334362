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

        private int _Soldier = 30;
        private int _Rogue = 28;
        private int _Magicker = 15;
        private int _Cultist = 24;
        private string _Job;

        public JobForm()
        {
            InitializeComponent();
        }
    }
}
