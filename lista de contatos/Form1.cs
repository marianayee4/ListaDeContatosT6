using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace lista_de_contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Contato[] listadeContatos = new Contato[1];

        private void Escrever(Contato contato)
        {
            StreamWriter escrever = new SreamWritterr("Contatos.txt");

            listaDeContatos = new Contato[Convert.ToInt32(Ler.ReadLine()];
 

          escrever.WriteLine(ListaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0) ; x < listaDeContatos.Lenght; x++)
          {
                escrever.WriteLine(listaDeContatos[x].Nome);
                escrever.WriteLine(listaDeContatos[
                escrever.W


                escrever.
              }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
