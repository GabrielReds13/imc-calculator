using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Limpar itens
            Txt_result.Text = "";
        }

        private void Btn_calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Validation.ValidateCPF(Txt_cpf.Text)}");
            // Verificar inputs vazios
            if (Txt_name.Text == "" || Txt_cpf.Text == "" || Select_sex.Text == "" || Txt_weight.Text == "" || Txt_height.Text == "" || Txt_age.Text == "")
            {
                // Mensagem de erro
                Txt_result.Text = "ERROR: There are empty fields."; 
                Txt_result.ForeColor = Color.Red;
            }
            // Calcular IMC
            else
            {
                // Instaciamentos e variaveis
                Person user = new Person(
                    Txt_name.Text, 
                    Txt_cpf.Text, 
                    Select_sex.Text, 
                    Convert.ToInt32(Txt_age.Text), 
                    Convert.ToDouble(Txt_height.Text), 
                    Convert.ToDouble(Txt_weight.Text)
                );

                (double imc, string classification, int degree) = user.CalcIMC();

                // Mensagem de erro
                Txt_result.Text = $"Your IMC is '{imc.ToString("0.0")}' and your classification is '{classification} {degree}'."; 
                Txt_result.ForeColor = Color.Black; 
                
            }
        }
    }
}
