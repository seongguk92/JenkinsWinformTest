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

namespace JenkinsWinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("업데이트를 하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Update();
            }
        }

        /// <summary>
        /// 업데이트
        /// </summary>
        /// <param name="p"></param>
        private new void Update()
        {
            string updateAppPath = string.Format(@"{0}\UpdateManager.exe", Application.StartupPath);
            Process.Start(updateAppPath);

            this.Dispose();
        }
    }
}
