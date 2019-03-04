using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zip_Yapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArchiveCreator ac = new IonicZipCreator(@"D:\Deneme\arsiv.zip");
            ArchiveObj ao = ac.GetArchieve();
            ao.AddFile(@"D:\Deneme\basvuru.xlsx");
            ao.AddFile(@"D:\Deneme\resim.png");
            ao.AddFile(@"D:\Deneme\metin.txt");
            ao.SaveArchive();
        }
    }
}
