using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12;
        int ipucu = 3;
        int süre = 7;

        private void btnInfo_Click(object sender, EventArgs e)
        {

            ipucu--;
            lblInfo.Text = ipucu.ToString();
            groupControl1.Visible = true;
            timer1.Start();
            if (ipucu == 0)
            {
                DialogResult dialog = XtraMessageBox.Show("Başka ipucu hakkınız kalmadı. Oyun bitti lütfen daha iyi bir hafıza ile deneyiniz :)", "GAME OVER", MessageBoxButtons.OK); ;
                if (dialog == DialogResult.OK)
                {
                    DialogResult dialog1 = XtraMessageBox.Show("Yeni oyuna başlamak ister misiniz ?", "NEW GAME", MessageBoxButtons.YesNo);
                    if (dialog1 == DialogResult.Yes)
                    {
                        clearGame();
                        groupControl1.Visible = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }

        }

        public void startGame()
        {
            ipucu = 3;
            lblInfo.Text = ipucu.ToString();
            sayi1 = random.Next(0, 200);
            sayi2 = random.Next(0, 200);
            sayi3 = random.Next(0, 200);
            sayi4 = random.Next(0, 200);
            sayi5 = random.Next(0, 200);
            sayi6 = random.Next(0, 200);
            sayi7 = random.Next(0, 200);
            sayi8 = random.Next(0, 200);
            sayi9 = random.Next(0, 200);
            sayi10 = random.Next(0, 200);
            sayi11 = random.Next(0, 200);
            sayi12 = random.Next(0, 200);

            labelControl1.Text = sayi1.ToString();
            labelControl2.Text = sayi2.ToString();
            labelControl3.Text = sayi3.ToString();
            labelControl4.Text = sayi4.ToString();
            labelControl5.Text = sayi5.ToString();
            labelControl6.Text = sayi6.ToString();
            labelControl7.Text = sayi7.ToString();
            labelControl8.Text = sayi8.ToString();
            labelControl9.Text = sayi9.ToString();
            labelControl10.Text = sayi10.ToString();
            labelControl11.Text = sayi11.ToString();
            labelControl12.Text = sayi12.ToString();
        }

        public void clearGame()
        {
            btnStart.Visible = true;
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";
            textEdit7.Text = "";
            textEdit8.Text = "";
            textEdit9.Text = "";
            textEdit10.Text = "";
            textEdit11.Text = "";
            textEdit12.Text = "";
            labelControl1.Text = "A";
            labelControl2.Text = "B";
            labelControl3.Text = "C";
            labelControl4.Text = "D";
            labelControl5.Text = "E";
            labelControl6.Text = "F";
            labelControl7.Text = "G";
            labelControl8.Text = "H";
            labelControl9.Text = "I";
            labelControl10.Text = "İ";
            labelControl11.Text = "J";
            labelControl12.Text = "K";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (labelControl1.Text == textEdit1.Text &&
                labelControl2.Text == textEdit2.Text &&
                labelControl3.Text == textEdit3.Text &&
                labelControl4.Text == textEdit4.Text &&
                labelControl5.Text == textEdit5.Text &&
                labelControl6.Text == textEdit6.Text &&
                labelControl7.Text == textEdit7.Text &&
                labelControl8.Text == textEdit8.Text &&
                labelControl9.Text == textEdit9.Text &&
                labelControl10.Text == textEdit10.Text &&
                labelControl11.Text == textEdit11.Text &&
                labelControl12.Text == textEdit12.Text)
            {
                XtraMessageBox.Show("Tebrikler oyunu kazandınız. :)", "WON", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Hatırlamkta güçlü çekiyorsunuz :)", "3 IQ", MessageBoxButtons.OK);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre--;
            lblSure.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Stop();
                groupControl1.Visible = false;
                btnStart.Visible = false;
                süre = 7;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            startGame();

            timer1.Start();
        }
    }

}
