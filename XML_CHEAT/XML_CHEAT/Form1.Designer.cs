namespace XML_CHEAT
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_process = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.bnt_loading_ct = new System.Windows.Forms.Button();
            this.bnt_read_all = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bnt_write_all = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.TexCod = new System.Windows.Forms.TextBox();
            this.bnt_gr_cpp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bnt_clr_gr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carregar Arquivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "->";
            // 
            // bnt_process
            // 
            this.bnt_process.Location = new System.Drawing.Point(281, 86);
            this.bnt_process.Name = "bnt_process";
            this.bnt_process.Size = new System.Drawing.Size(217, 23);
            this.bnt_process.TabIndex = 6;
            this.bnt_process.Text = "selecionar processo";
            this.bnt_process.UseVisualStyleBackColor = true;
            this.bnt_process.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Process ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "->";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 290);
            this.listBox2.TabIndex = 14;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // bnt_loading_ct
            // 
            this.bnt_loading_ct.Enabled = false;
            this.bnt_loading_ct.Location = new System.Drawing.Point(15, 311);
            this.bnt_loading_ct.Name = "bnt_loading_ct";
            this.bnt_loading_ct.Size = new System.Drawing.Size(445, 23);
            this.bnt_loading_ct.TabIndex = 15;
            this.bnt_loading_ct.Text = "Carregar CT";
            this.bnt_loading_ct.UseVisualStyleBackColor = true;
            this.bnt_loading_ct.Click += new System.EventHandler(this.button6_Click);
            // 
            // bnt_read_all
            // 
            this.bnt_read_all.Location = new System.Drawing.Point(391, 57);
            this.bnt_read_all.Name = "bnt_read_all";
            this.bnt_read_all.Size = new System.Drawing.Size(107, 23);
            this.bnt_read_all.TabIndex = 17;
            this.bnt_read_all.Text = "Read";
            this.bnt_read_all.UseVisualStyleBackColor = true;
            this.bnt_read_all.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "=";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 333);
            this.textBox2.TabIndex = 16;
            // 
            // bnt_write_all
            // 
            this.bnt_write_all.Location = new System.Drawing.Point(278, 57);
            this.bnt_write_all.Name = "bnt_write_all";
            this.bnt_write_all.Size = new System.Drawing.Size(111, 23);
            this.bnt_write_all.TabIndex = 19;
            this.bnt_write_all.Text = "Write";
            this.bnt_write_all.UseVisualStyleBackColor = true;
            this.bnt_write_all.Click += new System.EventHandler(this.bnt_write_all_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Log :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(408, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // TexCod
            // 
            this.TexCod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TexCod.Location = new System.Drawing.Point(0, 418);
            this.TexCod.Multiline = true;
            this.TexCod.Name = "TexCod";
            this.TexCod.Size = new System.Drawing.Size(795, 214);
            this.TexCod.TabIndex = 22;
            // 
            // bnt_gr_cpp
            // 
            this.bnt_gr_cpp.Location = new System.Drawing.Point(12, 389);
            this.bnt_gr_cpp.Name = "bnt_gr_cpp";
            this.bnt_gr_cpp.Size = new System.Drawing.Size(132, 23);
            this.bnt_gr_cpp.TabIndex = 23;
            this.bnt_gr_cpp.Text = "CPP EXTERNAL";
            this.bnt_gr_cpp.UseVisualStyleBackColor = true;
            this.bnt_gr_cpp.Click += new System.EventHandler(this.bnt_gr_cpp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "CPP INTERNAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_clr_gr
            // 
            this.bnt_clr_gr.Location = new System.Drawing.Point(731, 389);
            this.bnt_clr_gr.Name = "bnt_clr_gr";
            this.bnt_clr_gr.Size = new System.Drawing.Size(52, 23);
            this.bnt_clr_gr.TabIndex = 25;
            this.bnt_clr_gr.Text = "Clear";
            this.bnt_clr_gr.UseVisualStyleBackColor = true;
            this.bnt_clr_gr.Click += new System.EventHandler(this.bnt_clr_gr_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 632);
            this.Controls.Add(this.bnt_clr_gr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_gr_cpp);
            this.Controls.Add(this.TexCod);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bnt_write_all);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bnt_read_all);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bnt_loading_ct);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnt_process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "CT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_process;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button bnt_loading_ct;
        private System.Windows.Forms.Button bnt_read_all;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bnt_write_all;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexCod;
        private System.Windows.Forms.Button bnt_gr_cpp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bnt_clr_gr;
    }
}

