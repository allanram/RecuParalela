namespace RecuperacaoParalela.View
{
    partial class ContatoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTelefone = new MaskedTextBox();
            label4 = new Label();
            dtpnascimento = new DateTimePicker();
            label5 = new Label();
            btnNovoContato = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(112, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(162, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(162, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(112, 204);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(162, 23);
            txtEndereco.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 149);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 207);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Endereco";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(415, 149);
            txtTelefone.Mask = "(00)000000000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 152);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefone";
            // 
            // dtpnascimento
            // 
            dtpnascimento.Format = DateTimePickerFormat.Short;
            dtpnascimento.Location = new Point(477, 191);
            dtpnascimento.Name = "dtpnascimento";
            dtpnascimento.Size = new Size(97, 23);
            dtpnascimento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 197);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 9;
            label5.Text = "Data de Nascimento";
            // 
            // btnNovoContato
            // 
            btnNovoContato.Location = new Point(383, 262);
            btnNovoContato.Name = "btnNovoContato";
            btnNovoContato.Size = new Size(132, 23);
            btnNovoContato.TabIndex = 10;
            btnNovoContato.Text = "Adicionar Novo";
            btnNovoContato.UseVisualStyleBackColor = true;
            btnNovoContato.Click += btnNovoContato_Click;
            // 
            // ContatoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoContato);
            Controls.Add(label5);
            Controls.Add(dtpnascimento);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "ContatoView";
            Text = "ContatoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtTelefone;
        private Label label4;
        private DateTimePicker dtpnascimento;
        private Label label5;
        private Button btnNovoContato;
    }
}