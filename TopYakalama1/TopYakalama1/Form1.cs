namespace TopYakalama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //topun hareket yönünü belirler
            yeniX = rnd.Next(-4, 5) * 3;
            yeniY = rnd.Next(-4, 5) * 3;
            if (yeniX == 0 || yeniY == 0)
            {
                yeniX = rnd.Next(-3, 5) * 5;
                yeniY = rnd.Next(-3, 5) * 5;
            }
            LblKalanHak.Text = "3";

        }
        Random rnd = new Random();
        private void TopBasla()
        {
            //topun ilk konumu
            // LblSag.Left - BtnTop.Width :BtnTop düðmesinin lblsag'ýn sol kenerýna doðru hareket edebileceði maksimum mesafeyi sýnýrlar
            BtnTop.Location = new Point(rnd.Next(50, LblSag.Left - BtnTop.Width), rnd.Next(50,this.Height/3));
        }
        int yeniY;
        int yeniX;
        DateTime baslangicZamani, bitisZamani;
        TimeSpan gecenSure;

        int toplamHak = 3;
        private void timer1_Tick(object sender, EventArgs e)

        {
            //topun sola çarpmasýný kontrol eder
            if (BtnTop.Bounds.IntersectsWith(LblSol.Bounds))
            {
                yeniX = -yeniX;
                yeniY = yeniY;

            }
            //topun üste çarpmýasýný kontrol eder
            else if (BtnTop.Bounds.IntersectsWith(LblUst.Bounds))
            {
                yeniX = yeniX;
                yeniY = -yeniY;
            }
            //topun saða çarpmasýný kontrol eder
            else if (BtnTop.Bounds.IntersectsWith(LblSag.Bounds))
            {
                yeniX = -yeniX;
                yeniY = yeniY;
            }
            //topun top kurtarýcýya çarpmasýný kontrol eder
            else if (BtnTopYakalama.Bounds.IntersectsWith(BtnTop.Bounds))
            {
                yeniX = yeniX;
                yeniY = -yeniY;
                carpmaSayisiArtir();
                //toplam hak 0 olursa çarpma sayýsýný 0 dan tekrardan baþlatmasýný saðlýyor
                if (toplamHak == 0)
                {
                    carpmaSayisi = 0;
                }
            }
            //eðer top hiçbiryere çarpmazsa aþaðýya gider.
            if (BtnTop.Location.Y > this.Height)
            {
                //zamaný durdur ve gecen sureyi hesapla
                timer1.Stop();
                bitisZamani = DateTime.Now;
                gecenSure = bitisZamani - baslangicZamani;              
                LblSure.Text = gecenSure.Seconds.ToString();
                hakSayisi();
                //toplam hak 3 den farklýysa carpma sayýsýný 0 dan baþlat 
                if (toplamHak != 3)
                {                   
                    carpmaSayisi = 0;
                    LblCarpmaSayisi.Text = "0";
                }
                //toplam hak 0'sa tekrar hakký 3 den baþlat
                if (toplamHak == 0)
                {
                    LblKalanHak.Text = "3";
                    toplamHak = 3;
                }
            }
            //topun gideceði konumlarý belirler
            BtnTop.Location = new Point(BtnTop.Location.X + yeniX, BtnTop.Location.Y + yeniY);

        }
        int carpmaSayisi = 0;
        //kurtarýcýya çarptýðýnda carpma sayýsný arttýr
        private void carpmaSayisiArtir()
        {

            carpmaSayisi++;
            LblCarpmaSayisi.Text = carpmaSayisi.ToString();
        }
        //toplam hak 0'sa kullanýcýya uyarý ver.
        private void hakSayisi()
        {
            toplamHak--;
            TopBasla();         
            LblKalanHak.Text = toplamHak.ToString();

            if (toplamHak == 0)
            {
                MessageBox.Show("Tekrar deneyin");
            }
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            baslangicZamani = DateTime.Now;
            timer1.Start();
            //butona her bastýðýmýzda LblSure'yi temizledik.
            LblSure.Text = "";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //2'ye bölmemizin nedeni farenin imlecini butonun ortasýna getirebilmektir.
            BtnTopYakalama.Location = new Point(e.Location.X - BtnTopYakalama.Width / 2, BtnTopYakalama.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
