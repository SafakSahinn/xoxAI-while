using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xoxAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public void gorunurYap() //butonları aktif hale getiren fonksiyon
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        public void gorunmezYap() // butonları pasif hale getiren fonksiyon
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        public void kilitle() // butonun içine x yada y değeri girildiğinde tekrar kullanılmaması için pasif hale getiren fonksiyon
        {
            if (btn1.Text != "")
            {
                btn1.Enabled = false;
            }
            if (btn2.Text != "")
            {
                btn2.Enabled = false;
            }
            if (btn3.Text != "")
            {
                btn3.Enabled = false;
            }
            if (btn4.Text != "")
            {
                btn4.Enabled = false;
            }
            if (btn5.Text != "")
            {
                btn5.Enabled = false;
            }
            if (btn6.Text != "")
            {
                btn6.Enabled = false;
            }
            if (btn7.Text != "")
            {
                btn7.Enabled = false;
            }
            if (btn8.Text != "")
            {
                btn8.Enabled = false;
            }
            if (btn9.Text != "")
            {
                btn9.Enabled = false;
            }
        }

        public void temizle() // butonları temizleme fonksiyonu
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            lblX.Text = "0";
            lblY.Text = "0";
        }

        public void yeniOyun() //Skor fonksiyonun içinde, kimin hesapladıktan sonra çalışan fonksiyon. Başlat butonunu aktif edip diğerlerini kilitliyor
        {
            btnStart.Enabled = true;
            btnX.Enabled = false;
            btnY.Enabled = false;
            rdoInsan.Enabled = true;
            rdoYapayZeka.Enabled = true;
            sayiDizisi.Clear(); //diziyi temizliyor
        }

        public void skor()   // Skor hesaplama fonksiyonu.
        {
            int xSkor = 0;
            int ySkor = 0;
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                xSkor += 1;
            }
            if (btn1.Text == "Y" && btn2.Text == "Y" && btn3.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                xSkor += 1;
            }
            if (btn1.Text == "Y" && btn4.Text == "Y" && btn7.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                xSkor += 1;
            }
            if (btn1.Text == "Y" && btn5.Text == "Y" && btn9.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                xSkor += 1;
            }
            if (btn2.Text == "Y" && btn5.Text == "Y" && btn8.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                xSkor += 1;
            }
            if (btn3.Text == "Y" && btn6.Text == "Y" && btn9.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                xSkor += 1;
            }
            if (btn3.Text == "Y" && btn5.Text == "Y" && btn7.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                xSkor += 1;
            }
            if (btn4.Text == "Y" && btn5.Text == "Y" && btn6.Text == "Y")
            {
                ySkor += 1;
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                xSkor += 1;
            }
            if (btn7.Text == "Y" && btn8.Text == "Y" && btn9.Text == "Y")
            {
                ySkor += 1;
            }
            lblX.Text = xSkor.ToString();
            lblY.Text = ySkor.ToString();

            //kimink kazandığını hesaplayan kısım
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                if (xSkor > ySkor)
                {
                    MessageBox.Show("X kazandı!");
                    yeniOyun();
                    btnStart.Text = ("Yeni Oyun");
                }
                else if (xSkor == ySkor)
                {
                    MessageBox.Show("Berabere bitt!");
                    yeniOyun();
                    btnStart.Text = ("Yeni Oyun");
                }
                else if (xSkor < ySkor)
                {
                    MessageBox.Show("Y kazandı!");
                    yeniOyun();
                    btnStart.Text = ("Yeni Oyun");
                }
            }
        }

        public void yazdir(int a)  //9 butonun içinde bu fonksiyon var. Hepsine butonun sayı numarasına göre int değer giriyoruz ve fonksiyon hangi butona tıklandığını otomatik algılayıp yazdırma işlemi yapıyor. Kod tekrarını engellemek için
        {
            string btnNumara = "btn" + a;
           
            if (btnX.Enabled == true) //x aktifse x yazdıran kısım
            {
                switch (btnNumara)
                {
                    case "btn1":
                        btn1.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn2":
                        btn2.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn3":
                        btn3.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn4":
                        btn4.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn5":
                        btn5.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn6":
                        btn6.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn7":
                        btn7.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn8":
                        btn8.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                    case "btn9":
                        btn9.Text = "X";
                        gorunmezYap();
                        btnY.Enabled = true;
                        btnX.Enabled = false;
                        break;
                }
            }
            else if (btnY.Enabled == true) //y aktifse y yazdıran kısım
            {
                switch (btnNumara)
                {
                    case "btn1":
                        btn1.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn2":
                        btn2.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn3":
                        btn3.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn4":
                        btn4.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn5":
                        btn5.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn6":
                        btn6.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn7":
                        btn7.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn8":
                        btn8.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                    case "btn9":
                        btn9.Text = "Y";
                        gorunmezYap();
                        btnY.Enabled = false;
                        btnX.Enabled = true;
                        break;
                }
            }
        }

        public void yapayZeka() //yapay zeka fonksiyonu
        {
            if (rdoYapayZeka.Checked == true) //yapay zeka seçiliyse çalışmasını sağlıyor
            {
                Random random = new Random();
                int sayi = random.Next(1, 10);
                if (sayiDizisi.Contains(sayi) == false) //sayı, sayı dizisi içerisinde yoksa direk çalıştır
                {
                    yazdir(sayi);
                    sayiDizisi.Add(sayi);
                }
                else //sayı varsa
                {
                    while (sayiDizisi.Contains(sayi) == true) //sayı, sayı dizisinde var olduğu sürece döngü çalışır
                    {
                        sayi = random.Next(1, 10); //döngü sayı dizisinde olmayan bir eleman bulana kadar çalışır                  
                    }
                    yazdir(sayi); //dizide olmayan eleman bulduğunda da yazdırır
                    sayiDizisi.Add(sayi);
                }
            }    
        }

        ArrayList sayiDizisi = new ArrayList(); //diziyi oluşturan kod
        //dizi oluşturmamın sebebi, yapay zeka ile oynandığı zaman hangi butonların kullanıldığını hesaplamak için. Her butona tıklandığında buton numarasını diziye ekliyoruz.
        //yapay zekanın kodları içerisinde de rastgele oluşturulan sayı dizide var mı yok mu diye kontrol ediyoruz.

        private void button1_Click(object sender, EventArgs e) //9. butonun kodları
        {
            yazdir(9);
            sayiDizisi.Add(9);    
            skor();
            yapayZeka();
        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e) //başlat butonunun kodları
        {
            btnStart.Enabled= false;
            btnX.Enabled = true;
            btnY.Enabled = true;
            rdoInsan.Enabled = false;
            rdoYapayZeka.Enabled = false;
            if (rdoYapayZeka.Checked == true)
            {
                btnY.Enabled = false;
            }
            temizle();

        }

        private void btnX_Click(object sender, EventArgs e) //x butonunun kodları
        {
            gorunurYap();
            btnY.Enabled = false;
            kilitle();
        }

        private void btnY_Click(object sender, EventArgs e) //y butonun kodları
        {
            gorunurYap();
            btnX.Enabled = false;
            kilitle();
        }

        private void btn1_Click(object sender, EventArgs e) // 1. butonun kodları
        {
            yazdir(1);
            sayiDizisi.Add(1); //diziye 1 sayısını ekliyor
            skor();
            yapayZeka();
        }

        private void btn2_Click(object sender, EventArgs e) //2. butonun kodları
        {
            yazdir(2);
            sayiDizisi.Add(2); //diziye 2 sayısını ekliyor
            skor();
            yapayZeka();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            yazdir(3);
            sayiDizisi.Add(3);
            skor();
            yapayZeka();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            yazdir(4);
            sayiDizisi.Add(4);
            skor();
            yapayZeka();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            yazdir(5);
            sayiDizisi.Add(5);
            skor();
            yapayZeka();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            yazdir(6);
            sayiDizisi.Add(6);
            skor();
            yapayZeka();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            yazdir(7);
            sayiDizisi.Add(7);
            skor();
            yapayZeka();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            yazdir(8);
            sayiDizisi.Add(8);
            skor();
            yapayZeka();
        }
    }
}
