using BaiTap1___NET.DataAccessLayer;
using BaiTap1___NET.DataAccessLayer.DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1___NET
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AnimalDAL animal = new AnimalDAL();
            animal.GetAllAnimals();
        }

    }
}
