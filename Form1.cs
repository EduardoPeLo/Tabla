namespace Tabla
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

        private void buttonVer_Click(object sender, EventArgs e)
        {
            
                int n = Convert.ToInt32(this.textBoxNum.Text);
                string tabla = "";
                for (int i = 1; i <= 10; i++)
                {
                    tabla = tabla + n + " x " + 1 + " = " + (n * i) + "\n";
                }
                this.richTextBoxResultados.AppendText(tabla);

            
    }

       
    }
}
