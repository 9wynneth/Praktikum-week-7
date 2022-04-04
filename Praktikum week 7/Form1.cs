using System;
using System.Windows.Forms;

namespace Praktikum_week_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Konversi_Click(object sender, EventArgs e)
        {
            var indexMenjadi = 0;
            var indexInputan = 0;
            int difference = 0;
            var kalimatInputan = "";
            char[] alphabet = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            if (txtBox_InputanHuruf.Text.Length > 1 || txtBoxMenjadiHuruf.Text.Length > 1)
            {
                MessageBox.Show("Inputan yang diminta merupakan huruf");
            }
            if (txtBox_InputanKalimat.Text.Length<=1)
            {
                if (txtBox_InputanKalimat.Text.ToLower().Contains(txtBox_InputanHuruf.Text.ToLower()))
                {
                    lbl_Output.Text = txtBox_InputanKalimat.Text.Replace(txtBox_InputanHuruf.Text, txtBoxMenjadiHuruf.Text).ToUpper();
                }
                else
                {
                    MessageBox.Show("Huruf tersebut tidak ada pada kalimat inputan!");
                }
            }
            else
            {
                if (txtBox_InputanKalimat.Text.ToLower().Contains(txtBox_InputanHuruf.Text.ToLower()))
                {
                    for (int i = 0; i <= alphabet.Length-1; i++)
                    {
                        if (txtBoxMenjadiHuruf.Text.ToLower() == alphabet[i].ToString())
                        {
                            indexMenjadi = i;
                        }
                    }
                    for (int j = 0; j <= alphabet.Length - 1; j++)
                    {
                        if (txtBox_InputanHuruf.Text.ToLower() == alphabet[j].ToString())
                        {
                            indexInputan = j;
                        }
                    }
                        difference = indexMenjadi - indexInputan;
                    
                     for (int k=0;k<=txtBox_InputanKalimat.Text.Length-1;k++)
                     {
                        char []inputKalimat = txtBox_InputanKalimat.Text.ToCharArray();
                        if (inputKalimat[k] == ' ')
                            kalimatInputan = kalimatInputan + inputKalimat[k];
                        for (int l=0;l<26;l++)
                        {
                            if (inputKalimat[k]==alphabet[l])
                            {
                                if (inputKalimat[k] > 26)
                                {
                                    l = 0;
                                }
                                kalimatInputan = kalimatInputan + alphabet[l + difference];
                            }
                        }
               

                     }
                    lbl_Output.Text = kalimatInputan.ToUpper();
                    /*if (alphabet[k]>26)
               {
                   k = 0;
               }
               string inputKalimat = txtBox_InputanKalimat.Text;
               if (inputKalimat[k]!=' ')
               {
                   var tiapKata = inputKalimat[k];
                    tiapKata= alphabet[k+difference];
                   kalimatInputan = kalimatInputan + tiapKata;
               }*/
                    //lbl_Output.Text = kalimatInputan.ToUpper();
                    /*foreach (char hurufInputan in txtBox_InputanKalimat.Text.ToCharArray())
                    {
                    lbl_Output.Text = txtBox_InputanKalimat.Text.ToCharArray()[index+difference].ToString();
                    index++;*/
                    //var kalimatInputan = hurufInputan{difference};
                    //lbl_Output.Text = kalimatInputan.ToString().ToUpper();
                    //lbl_Output.Text = hurufInputan;
                    //}
                    //lbl_Output.Text = alphabet[difference].ToString().ToUpper();
                }
                else
                {
                    MessageBox.Show("Huruf tersebut tidak ada pada kalimat inputan!");
                }
            }
          
        }
    }
}
