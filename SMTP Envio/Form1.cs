using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SMTP_Envio
{

    public partial class Form1 : Form
    {
        bool req=false;
        bool html=false;
        bool ssl=false;
        
        public Form1()
        {
            InitializeComponent();          
        }
        void CheckBox2CheckedChanged(object sender, EventArgs e)
        {   
            if(checkBox2.Checked){
                textBox3.Enabled=true;
                textBox4.Enabled=true;
                req=true;
            }
            else{
                textBox3.Enabled=false;
                textBox4.Enabled=false;
                req=false;
            }
        }
        void Button1Click(object sender, EventArgs e)
        {
            string smtp=textBox1.Text;
            int port=Convert.ToInt32(textBox2.Text);
            string destino=textBox5.Text;
            string assunto=textBox6.Text;
            string mensagem=textBox7.Text;
            string anexo=textBox8.Text;
            string remetente=textBox9.Text;
            if(req==true){
                string login = textBox3.Text;
                string senha = textBox4.Text;
                try{
                    if(String.IsNullOrEmpty(anexo)){
                        new Enviar(remetente,smtp, port,login,senha,destino,assunto,mensagem,html, ssl);
                    }
                    else{
                        new Enviar(remetente,smtp,port,login,senha,destino,assunto,mensagem,anexo,html, ssl);
                    }
                }
                catch (Exception a){
                    MessageBox.Show(a.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);    
                }
            }
            if(req==false){
                try{
                    if(String.IsNullOrEmpty(anexo)){
                        new Enviar(remetente,smtp,port,destino,assunto,mensagem,html,ssl);
                    }
                    else{
                        new Enviar(remetente,smtp,port,destino,assunto,mensagem,anexo,html, ssl);
                    }
                }
                catch (Exception a){
                    MessageBox.Show(a.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);    
                }
            }
        }
        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked){
                html=true;
            }
            else{
                html=false;
            }
        }

        void Button2Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Button3Click(object sender, EventArgs e)
        {
            OpenFileDialog way = new OpenFileDialog();
            way.InitialDirectory = @"c:\";
            way.RestoreDirectory = true;
            if(way.ShowDialog()==DialogResult.OK)
                {
                textBox8.Text = way.FileName;
            }
        }

        void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ssl = true;
            }
            else
            {
                ssl = false;
            }
        }
    }
}
