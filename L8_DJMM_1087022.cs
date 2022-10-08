namespace L8_DJMM_1087022
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
    }
}


int numero;

Console.Write("Ingrese un numero: ");
Console.WriteLine();
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
    Console.WriteLine("El numero ingresado es cero");
else if (numero < 0)
{
    Console.WriteLine("El numero ingresado es negativo");
}
else if (numero > 0)
{
    Console.WriteLine("El numero ingresado es posito");
}

Console.ReadKey();

