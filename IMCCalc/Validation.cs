using System.Windows.Forms;

public static class Validation
{
    public static bool ValidateCPF(string cpf)
    {
        // Variaveis
        int caractere1 = 0, caractere2 = 0;

        // Formatar cpf
        cpf = cpf.Replace(".", "").Replace("-", "");
        char[] cpfChar = cpf.ToCharArray();

        // Verificar CPF valido
        if(cpfChar.Length != 11) return false;
        
        // Verificao 1
        else
        {
            // Multiplicar e somar
            for (int i = 0, j = 10; i < j; i++)
            {
                caractere1 = (cpfChar[i] * (j - i)) + caractere1;
                if (j <= 2) break;
            }
            MessageBox.Show($"{caractere1}");
            // Dividir
            caractere1 = caractere1 % 11;
            MessageBox.Show($"{caractere1}");

            // Validar caractere 1
            if (caractere1 < 2 && caractere1 > 0) return false;
            else
            {
                caractere1 = 11 - caractere1;
                if(caractere1 != cpfChar[9]) return false;
                
                // Verificacao 2
                else
                {
                    // Multiplicar e somar
                    for(int i = 0, j = 11; i < j; i++)
                    {
                        caractere2 = (cpfChar[i] * (j - i)) + caractere2;
                        if (j <= 2) break;
                    }
                    // Dividir
                    caractere2 = caractere2 % 11;

                    // Validar caractere 2
                    if (caractere2 < 2 && caractere2 > 0) return false;
                    else
                    {
                        caractere2 = 11 - caractere2;

                        // Validar caractere 2
                        if (caractere2 != cpfChar[10]) return false;
                        else return true;
                    }
                }
            }
        }
    }
}