namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int sayi = Convert.ToInt32(kullanýcý_veri.Text);
            int sayi_2 = Convert.ToInt32(kullanýcý_veri2.Text);
            string isaret = cocombo.Text;

            switch (isaret)
            {
                case "+":
                    lbl_sonuc.Text = "sayi" + "+" + "sayi_2" + "=" + Convert.ToString(sayi + sayi_2); 



                    break;

                case "-": lbl_sonuc.Text = "sayi" + "-" + "sayi_2" + "=" + Convert.ToString(sayi - sayi_2);


                    break;

                case "x":
                    lbl_sonuc.Text = "sayi" + "x" + "sayi_2" + "=" + Convert.ToString(sayi * sayi_2);


                    break;

                case "/":
                    lbl_sonuc.Text = "sayi" + "/" + "sayi_2" + "=" + Convert.ToString(sayi / sayi_2);


                    break;











            }


















        }


    }
}
