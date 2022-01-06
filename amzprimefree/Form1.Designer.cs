            
namespace botmap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_publicoAlvo = new System.Windows.Forms.Label();
            this.txt_nome2 = new System.Windows.Forms.TextBox();
            this.lbl_regiao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.btn_iniciar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iniciar.Location = new System.Drawing.Point(452, 336);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(134, 42);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Criar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.txt_nome.Location = new System.Drawing.Point(36, 194);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PlaceholderText = "Ex: joao (sem caracteres especias)";
            this.txt_nome.Size = new System.Drawing.Size(254, 27);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_publicoAlvo_TextChanged);
            // 
            // lbl_publicoAlvo
            // 
            this.lbl_publicoAlvo.AutoSize = true;
            this.lbl_publicoAlvo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_publicoAlvo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_publicoAlvo.Location = new System.Drawing.Point(121, 166);
            this.lbl_publicoAlvo.Name = "lbl_publicoAlvo";
            this.lbl_publicoAlvo.Size = new System.Drawing.Size(57, 23);
            this.lbl_publicoAlvo.TabIndex = 2;
            this.lbl_publicoAlvo.Text = "Nome:";
            this.lbl_publicoAlvo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome2
            // 
            this.txt_nome2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.txt_nome2.Location = new System.Drawing.Point(332, 194);
            this.txt_nome2.Name = "txt_nome2";
            this.txt_nome2.PlaceholderText = "Ex: silva (sem caracteres especiais)";
            this.txt_nome2.Size = new System.Drawing.Size(254, 27);
            this.txt_nome2.TabIndex = 3;
            this.txt_nome2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_regiao
            // 
            this.lbl_regiao.AutoSize = true;
            this.lbl_regiao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_regiao.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_regiao.Location = new System.Drawing.Point(411, 169);
            this.lbl_regiao.Name = "lbl_regiao";
            this.lbl_regiao.Size = new System.Drawing.Size(99, 23);
            this.lbl_regiao.TabIndex = 4;
            this.lbl_regiao.Text = "Sobrenome:";
            this.lbl_regiao.Click += new System.EventHandler(this.lbl_regiao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Crie uma conta grátis por 1 mês do Amazon Prime,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(129, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "faça isso todo mês!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(222, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Celular (que funcione):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_cel
            // 
            this.txt_cel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(188)))), ((int)(((byte)(207)))));
            this.txt_cel.Location = new System.Drawing.Point(180, 265);
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.PlaceholderText = "Ex: 12900000000";
            this.txt_cel.Size = new System.Drawing.Size(254, 27);
            this.txt_cel.TabIndex = 9;
            this.txt_cel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_regiao);
            this.Controls.Add(this.txt_nome2);
            this.Controls.Add(this.lbl_publicoAlvo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_iniciar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amz Prime Free";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_publicoAlvo;
        private System.Windows.Forms.TextBox txt_nome2;
        private System.Windows.Forms.Label lbl_regiao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cel;
    }
}

