namespace RealStand
{
    partial class FormClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFiltarClientes = new System.Windows.Forms.Button();
            this.textBoxFiltrarClientes = new System.Windows.Forms.TextBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageInformacao = new System.Windows.Forms.TabPage();
            this.tabPageAdicionar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageAlterar = new System.Windows.Forms.TabPage();
            this.tabPageEliminar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabPageAdicionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonFiltarClientes);
            this.panel1.Controls.Add(this.textBoxFiltrarClientes);
            this.panel1.Controls.Add(this.dataGridViewClientes);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 382);
            this.panel1.TabIndex = 1;
            // 
            // buttonFiltarClientes
            // 
            this.buttonFiltarClientes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltarClientes.Location = new System.Drawing.Point(250, 23);
            this.buttonFiltarClientes.Name = "buttonFiltarClientes";
            this.buttonFiltarClientes.Size = new System.Drawing.Size(84, 28);
            this.buttonFiltarClientes.TabIndex = 2;
            this.buttonFiltarClientes.Text = "FILTRAR";
            this.buttonFiltarClientes.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltrarClientes
            // 
            this.textBoxFiltrarClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltrarClientes.Location = new System.Drawing.Point(17, 23);
            this.textBoxFiltrarClientes.Multiline = true;
            this.textBoxFiltrarClientes.Name = "textBoxFiltrarClientes";
            this.textBoxFiltrarClientes.Size = new System.Drawing.Size(226, 28);
            this.textBoxFiltrarClientes.TabIndex = 1;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NIF});
            this.dataGridViewClientes.Location = new System.Drawing.Point(17, 57);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(317, 310);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NIF
            // 
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lista De Clientes";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControlClientes);
            this.panel2.Location = new System.Drawing.Point(380, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 382);
            this.panel2.TabIndex = 3;
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPageInformacao);
            this.tabControlClientes.Controls.Add(this.tabPageAdicionar);
            this.tabControlClientes.Controls.Add(this.tabPageAlterar);
            this.tabControlClientes.Controls.Add(this.tabPageEliminar);
            this.tabControlClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlClientes.Location = new System.Drawing.Point(16, 23);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(353, 344);
            this.tabControlClientes.TabIndex = 0;
            // 
            // tabPageInformacao
            // 
            this.tabPageInformacao.Location = new System.Drawing.Point(4, 26);
            this.tabPageInformacao.Name = "tabPageInformacao";
            this.tabPageInformacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInformacao.Size = new System.Drawing.Size(345, 314);
            this.tabPageInformacao.TabIndex = 0;
            this.tabPageInformacao.Text = "Informação";
            this.tabPageInformacao.UseVisualStyleBackColor = true;
            // 
            // tabPageAdicionar
            // 
            this.tabPageAdicionar.Controls.Add(this.button1);
            this.tabPageAdicionar.Controls.Add(this.label14);
            this.tabPageAdicionar.Controls.Add(this.label13);
            this.tabPageAdicionar.Controls.Add(this.label7);
            this.tabPageAdicionar.Controls.Add(this.label6);
            this.tabPageAdicionar.Controls.Add(this.label12);
            this.tabPageAdicionar.Controls.Add(this.label10);
            this.tabPageAdicionar.Controls.Add(this.textBox5);
            this.tabPageAdicionar.Controls.Add(this.textBox4);
            this.tabPageAdicionar.Controls.Add(this.textBox3);
            this.tabPageAdicionar.Controls.Add(this.textBox2);
            this.tabPageAdicionar.Controls.Add(this.textBox1);
            this.tabPageAdicionar.Controls.Add(this.label5);
            this.tabPageAdicionar.Controls.Add(this.label8);
            this.tabPageAdicionar.Controls.Add(this.label3);
            this.tabPageAdicionar.Controls.Add(this.label1);
            this.tabPageAdicionar.Controls.Add(this.label9);
            this.tabPageAdicionar.Controls.Add(this.label11);
            this.tabPageAdicionar.Location = new System.Drawing.Point(4, 26);
            this.tabPageAdicionar.Name = "tabPageAdicionar";
            this.tabPageAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdicionar.Size = new System.Drawing.Size(345, 314);
            this.tabPageAdicionar.TabIndex = 1;
            this.tabPageAdicionar.Text = "Adicionar";
            this.tabPageAdicionar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 294);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Campo Obrigatório";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(10, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "NIF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Morada:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(69, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(37, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "*";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(114, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 23);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 186);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 23);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 23);
            this.textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 23);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contacto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telemóvel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADICIONAR CLIENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(48, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(23, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "*";
            // 
            // tabPageAlterar
            // 
            this.tabPageAlterar.Location = new System.Drawing.Point(4, 26);
            this.tabPageAlterar.Name = "tabPageAlterar";
            this.tabPageAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterar.Size = new System.Drawing.Size(345, 314);
            this.tabPageAlterar.TabIndex = 2;
            this.tabPageAlterar.Text = "Alterar";
            this.tabPageAlterar.UseVisualStyleBackColor = true;
            // 
            // tabPageEliminar
            // 
            this.tabPageEliminar.Location = new System.Drawing.Point(4, 26);
            this.tabPageEliminar.Name = "tabPageEliminar";
            this.tabPageEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEliminar.Size = new System.Drawing.Size(345, 314);
            this.tabPageEliminar.TabIndex = 3;
            this.tabPageEliminar.Text = "Eliminar";
            this.tabPageEliminar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ficha de Clientes";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageAdicionar.ResumeLayout(false);
            this.tabPageAdicionar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFiltarClientes;
        private System.Windows.Forms.TextBox textBoxFiltrarClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageInformacao;
        private System.Windows.Forms.TabPage tabPageAdicionar;
        private System.Windows.Forms.TabPage tabPageAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.TabPage tabPageEliminar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}