namespace pr22_3
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
                bool sc; string info, gender;
                try
                {
                    RadioButton rb = new RadioButton();
                    if (radioButton1.Checked) gender = radioButton1.Text;
                    else if (radioButton2.Checked) gender = radioButton2.Text;
                    else gender = "Не выбран";
                    SportLIFE sport = new SportLIFE();
                    sc = sport.Scan(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDateTime(textBox4.Text), short.Parse(textBox5.Text), short.Parse(textBox6.Text), textBox7.Text);
                    sport.IdealVes();
                    sport.IdealVes2(gender);
                    if (sc) { info = sport.Info(gender); MessageBox.Show(info, "Сообщение", MessageBoxButtons.OK); }
                }
                catch { MessageBox.Show("Найден некорректный ввод данных", "Дата", MessageBoxButtons.OK); }

            }
        
    }
}