using System;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTP_Envio
{
	public class Enviar
	{
		public Enviar(string remetente, string smt, int port, string destino, string assunto, string mensagem, bool html){
			MailMessage Email = new MailMessage();
			Stopwatch Stop = new Stopwatch();
			SmtpClient smtp = new SmtpClient();
			smtp.Host = smt;
			smtp.Port = port;
			smtp.EnableSsl = false;
			smtp.UseDefaultCredentials = true;
			Email.From = new System.Net.Mail.MailAddress(remetente);
			Email.To.Add(new System.Net.Mail.MailAddress(destino));
			Email.Priority = MailPriority.High;
			Email.Subject = assunto;
			Email.SubjectEncoding = System.Text.Encoding.UTF8;
			Email.Body = mensagem;
			Email.BodyEncoding = System.Text.Encoding.UTF8;
			Email.IsBodyHtml = html;
			smtp.Send(Email);
			MessageBox.Show("Mensagem enviada","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);			
		}
		public Enviar(string remetente, string smt, int port, string destino, string assunto, string mensagem, string anexo, bool html){
			MailMessage Email = new MailMessage();
			Stopwatch Stop = new Stopwatch();
			SmtpClient smtp = new SmtpClient();
			smtp.Host = smt;
			smtp.Port = port;
			smtp.EnableSsl = false;
			smtp.UseDefaultCredentials = true;
			Email.From = new System.Net.Mail.MailAddress(remetente);
			Email.To.Add(new System.Net.Mail.MailAddress(destino));
			Email.Priority = MailPriority.High;
			Email.Subject = assunto;
			Email.SubjectEncoding = System.Text.Encoding.UTF8;
			Email.Body = mensagem;
			Email.BodyEncoding = System.Text.Encoding.UTF8;
			Email.IsBodyHtml = html;
			Attachment arquivo = new Attachment(anexo);
			Email.Attachments.Add(arquivo);
			smtp.Send(Email);
			MessageBox.Show("Mensagem enviada","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);			
		}
		public Enviar(string remetente, string smt, int port, string login, string senha, string destino, string assunto, string mensagem, bool html){
			MailMessage Email = new MailMessage();
			Stopwatch Stop = new Stopwatch();
			SmtpClient smtp = new SmtpClient();
			smtp.Host = smt;
			smtp.Port = port;
			smtp.EnableSsl = false;
			smtp.UseDefaultCredentials = false;
			smtp.Credentials = new System.Net.NetworkCredential(login,senha);
			Email.From = new System.Net.Mail.MailAddress(remetente);
			Email.To.Add(new System.Net.Mail.MailAddress(destino));
			Email.Priority = MailPriority.High;
			Email.Subject = assunto;
			Email.SubjectEncoding = System.Text.Encoding.UTF8;
			Email.Body = mensagem;
			Email.BodyEncoding = System.Text.Encoding.UTF8;
			Email.IsBodyHtml = html;
			smtp.Send(Email);
			MessageBox.Show("Mensagem enviada","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);					
		}
		public Enviar(string remetente, string smt, int port, string login, string senha, string destino, string assunto, string mensagem, string anexo, bool html){
			MailMessage Email = new MailMessage();
			Stopwatch Stop = new Stopwatch();
			SmtpClient smtp = new SmtpClient();
			smtp.Host = smt;
			smtp.Port = port;
			smtp.EnableSsl = false;
			smtp.UseDefaultCredentials = false;
			smtp.Credentials = new System.Net.NetworkCredential(login,senha);
			Email.From = new System.Net.Mail.MailAddress(remetente);
			Email.To.Add(new System.Net.Mail.MailAddress(destino));
			Email.Priority = MailPriority.High;
			Email.Subject = assunto;
			Email.SubjectEncoding = System.Text.Encoding.UTF8;
			Email.Body = mensagem;
			Email.BodyEncoding = System.Text.Encoding.UTF8;
			Email.IsBodyHtml = html;
			Attachment arquivo = new Attachment(anexo);
			Email.Attachments.Add(arquivo);
			smtp.Send(Email);
			MessageBox.Show("Mensagem enviada","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);					
		}
	}
}
