namespace TopYakalama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //topun hareket y�n�n� belirler
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
            // LblSag.Left - BtnTop.Width :BtnTop d��mesinin lblsag'�n sol kener�na do�ru hareket edebilece�i maksimum mesafeyi s�n�rlar
            BtnTop.Location = new Point(rnd.Next(50, LblSag.Left - BtnTop.Width), rnd.Next(50,this.Height/3));
        }
        int yeniY;
        int yeniX;
        DateTime baslangicZamani, bitisZamani;
        TimeSpan gecenSure;

        int toplamHak = 3;
        private void timer1_Tick(object sender, EventArgs e)

        {
            //topun sola �arpmas�n� kontrol eder
            if (BtnTop.Bounds.IntersectsWith(LblSol.Bounds))
            {
                yeniX = -yeniX;
                yeniY = yeniY;

            }
            //topun �ste �arpm�as�n� kontrol eder
            else if (BtnTop.Bounds.IntersectsWith(LblUst.Bounds))
            {
                yeniX = yeniX;
                yeniY = -yeniY;
            }
            //topun sa�a �arpmas�n� kontrol eder
            else if (BtnTop.Bounds.IntersectsWith(LblSag.Bounds))
            {
                yeniX = -yeniX;
                yeniY = yeniY;
            }
            //topun top kurtar�c�ya �arpmas�n� kontrol eder
            else if (BtnTopYakalama.Bounds.IntersectsWith(BtnTop.Bounds))
            {
                yeniX = yeniX;
                yeniY = -yeniY;
                carpmaSayisiArtir();
                //toplam hak 0 olursa �arpma say�s�n� 0 dan tekrardan ba�latmas�n� sa�l�yor
                if (toplamHak == 0)
                {
                    carpmaSayisi = 0;
                }
            }
            //e�er top hi�biryere �arpmazsa a�a��ya gider.
            if (BtnTop.Location.Y > this.Height)
            {
                //zaman� durdur ve gecen sureyi hesapla
                timer1.Stop();
                bitisZamani = DateTime.Now;
                gecenSure = bitisZamani - baslangicZamani;              
                LblSure.Text = gecenSure.Seconds.ToString();
                hakSayisi();
                //toplam hak 3 den farkl�ysa carpma say�s�n� 0 dan ba�lat 
                if (toplamHak != 3)
                {                   
                    carpmaSayisi = 0;
                    LblCarpmaSayisi.Text = "0";
                }
                //toplam hak 0'sa tekrar hakk� 3 den ba�lat
                if (toplamHak == 0)
                {
                    LblKalanHak.Text = "3";
                    toplamHak = 3;
                }
            }
            //topun gidece�i konumlar� belirler
            BtnTop.Location = new Point(BtnTop.Location.X + yeniX, BtnTop.Location.Y + yeniY);

        }
        int carpmaSayisi = 0;
        //kurtar�c�ya �arpt���nda carpma say�sn� artt�r
        private void carpmaSayisiArtir()
        {

            carpmaSayisi++;
            LblCarpmaSayisi.Text = carpmaSayisi.ToString();
        }
        //toplam hak 0'sa kullan�c�ya uyar� ver.
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
            //butona her bast���m�zda LblSure'yi temizledik.
            LblSure.Text = "";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //2'ye b�lmemizin nedeni farenin imlecini butonun ortas�na getirebilmektir.
            BtnTopYakalama.Location = new Point(e.Location.X - BtnTopYakalama.Width / 2, BtnTopYakalama.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
