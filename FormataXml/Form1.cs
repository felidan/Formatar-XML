using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FormataXml
{
    public partial class Form1 : Form
    {
        private string NomeArquivo;
        public Form1()
        {
            InitializeComponent();

            this.lblSalvaArqu.ForeColor = Color.DarkRed;
            this.lblSelArqu.ForeColor = Color.DarkRed;
            this.lblLog.Text = "";
            this.lblLog.ForeColor = Color.Red;
            this.ckInputTexto.Checked = true;
            this.ckInputTexto_CheckedChanged(this, null);
            
            // TODO - commit no git
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            ConfiguraDialogSelecionarArquivo();
            
            DialogResult dir = this.odf.ShowDialog();

            if(dir == DialogResult.OK)
            {
                this.txtArquivo.Text = this.odf.FileName;
                
                this.lblSelArqu.ForeColor = Color.Green;
                this.lblSelArqu.Text = "OK";
            }

            this.lblLog.Text = "";
        }
        
        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            ConfiguraDialogSalvarArquivo();
            
            DialogResult dir = this.sfd.ShowDialog();

            if(dir == DialogResult.OK)
            {
                this.txtDestino.Text = this.sfd.FileName;
                
                this.lblSalvaArqu.ForeColor = Color.Green;
                this.lblSalvaArqu.Text = "OK";
            }

            this.lblLog.Text = "";
        }

        private void ConfiguraDialogSalvarArquivo()
        {
            this.sfd.FileName = $"XML_Formatado_{DateTime.Now.ToString().Replace(":", "_").Replace(" ", "_").Replace("/", "-")}.xml";
            this.odf.Multiselect = false;
            this.odf.Title = "Selecionar Local";
            this.odf.InitialDirectory = @"C:\";
        }

        private void ConfiguraDialogSelecionarArquivo()
        {
            this.odf.Multiselect = false;
            this.odf.Title = "Selecionar Arquivo";
            this.odf.InitialDirectory = @"C:\";
            this.odf.Filter = "All files (*.*)|*.*";
            this.odf.CheckFileExists = true;
            this.odf.CheckPathExists = true;
            this.odf.RestoreDirectory = true;
            this.odf.ReadOnlyChecked = true;
            this.odf.ShowReadOnly = true;
        }

        private void btmFormatar_Click(object sender, EventArgs e)
        {
            this.lblLog.Text = "";
            
            if (!this.ckInputTexto.Checked && this.lblSelArqu.Text != "OK")
                this.lblLog.Text += " * Selecione um arquivo";

            if (this.ckInputTexto.Checked && this.txtArquivo.Text.Length == 0)
                this.lblLog.Text += " * Informe o XML a ser formatado";

            if (this.lblSalvaArqu.Text != "OK")
                this.lblLog.Text += " * Selecione o local de salvamento";

            if(this.lblLog.Text == "")
            {
                string arquivo = String.Empty;

                if (this.ckInputTexto.Checked)
                    arquivo = this.txtArquivo.Text;
                else
                    arquivo = LerArquivo(this.txtArquivo.Text);

                try
                {
                    var xml = System.Xml.Linq.XDocument.Parse(arquivo).ToString();

                    if (SalvarArquivo(xml, this.txtDestino.Text))
                    {
                        this.lblLog.ForeColor = Color.Blue;
                        this.lblLog.Text = $"XML Formatado! - {NomeArquivo}.";
                    }
                    else
                        this.lblLog.Text = "Erro ao processar.";

                }
                catch(Exception ex)
                {
                    this.lblLog.Text = "Erro: " + ex.Message;
                }
            }
        }

        private bool SalvarArquivo(string xml, string endereco)
        {
            try
            {
                using (var file = new StreamWriter(endereco))
                {
                    file.Write(xml);
                }

                this.NomeArquivo = endereco.Substring(endereco.LastIndexOf(@"\") + 1);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private string LerArquivo(string endereco)
        {
            string ret = String.Empty;

            using (var file = new StreamReader(endereco))
            {
                ret = file.ReadToEnd();
            }
            return ret;
        }

        private void ckInputTexto_CheckedChanged(object sender, EventArgs e)
        {
            this.txtArquivo.Text = "";

            if (this.ckInputTexto.Checked)
            {
                this.btnSelecionarArquivo.Visible = false;
                this.lblInfoSelecionar.Text = "Cole o XML";
                this.lblSelArqu.Text = "";
                this.txtArquivo.Width = 347;
            }
            else
            {
                this.btnSelecionarArquivo.Visible = true;
                this.lblInfoSelecionar.Text = "Selecionar arquivo a ser formatado";
                this.lblSelArqu.Text = "ER";
                this.txtArquivo.Width = 257;
            }
        }
    }
}
