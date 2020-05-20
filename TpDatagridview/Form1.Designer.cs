namespace TpDatagridview
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butt_Remplir = new System.Windows.Forms.Button();
            this.butt_Supp = new System.Windows.Forms.Button();
            this.butt_Vider = new System.Windows.Forms.Button();
            this.butt_Trier = new System.Windows.Forms.Button();
            this.butt_Modifier = new System.Windows.Forms.Button();
            this.buttQuitter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de Naissance ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(408, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 275);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // butt_Remplir
            // 
            this.butt_Remplir.Location = new System.Drawing.Point(42, 442);
            this.butt_Remplir.Name = "butt_Remplir";
            this.butt_Remplir.Size = new System.Drawing.Size(80, 31);
            this.butt_Remplir.TabIndex = 7;
            this.butt_Remplir.Text = "Remplir";
            this.butt_Remplir.UseVisualStyleBackColor = true;
            this.butt_Remplir.Click += new System.EventHandler(this.butt_Remplir_Click);
            // 
            // butt_Supp
            // 
            this.butt_Supp.Location = new System.Drawing.Point(174, 442);
            this.butt_Supp.Name = "butt_Supp";
            this.butt_Supp.Size = new System.Drawing.Size(95, 31);
            this.butt_Supp.TabIndex = 8;
            this.butt_Supp.Text = "Supprimer";
            this.butt_Supp.UseVisualStyleBackColor = true;
            this.butt_Supp.Click += new System.EventHandler(this.butt_Supp_Click);
            // 
            // butt_Vider
            // 
            this.butt_Vider.Location = new System.Drawing.Point(340, 442);
            this.butt_Vider.Name = "butt_Vider";
            this.butt_Vider.Size = new System.Drawing.Size(80, 31);
            this.butt_Vider.TabIndex = 9;
            this.butt_Vider.Text = "Vider";
            this.butt_Vider.UseVisualStyleBackColor = true;
            this.butt_Vider.Click += new System.EventHandler(this.butt_Vider_Click);
            // 
            // butt_Trier
            // 
            this.butt_Trier.Location = new System.Drawing.Point(505, 442);
            this.butt_Trier.Name = "butt_Trier";
            this.butt_Trier.Size = new System.Drawing.Size(80, 31);
            this.butt_Trier.TabIndex = 10;
            this.butt_Trier.Text = "Trier";
            this.butt_Trier.UseVisualStyleBackColor = true;
            this.butt_Trier.Click += new System.EventHandler(this.butt_Trier_Click);
            // 
            // butt_Modifier
            // 
            this.butt_Modifier.Location = new System.Drawing.Point(690, 442);
            this.butt_Modifier.Name = "butt_Modifier";
            this.butt_Modifier.Size = new System.Drawing.Size(80, 31);
            this.butt_Modifier.TabIndex = 11;
            this.butt_Modifier.Text = "Modifier";
            this.butt_Modifier.UseVisualStyleBackColor = true;
            this.butt_Modifier.Click += new System.EventHandler(this.butt_Modifier_Click);
            // 
            // buttQuitter
            // 
            this.buttQuitter.Location = new System.Drawing.Point(867, 442);
            this.buttQuitter.Name = "buttQuitter";
            this.buttQuitter.Size = new System.Drawing.Size(80, 31);
            this.buttQuitter.TabIndex = 12;
            this.buttQuitter.Text = "Quitter";
            this.buttQuitter.UseVisualStyleBackColor = true;
            this.buttQuitter.Click += new System.EventHandler(this.buttQuitter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(819, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 548);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttQuitter);
            this.Controls.Add(this.butt_Modifier);
            this.Controls.Add(this.butt_Trier);
            this.Controls.Add(this.butt_Vider);
            this.Controls.Add(this.butt_Supp);
            this.Controls.Add(this.butt_Remplir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "data grid view";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butt_Remplir;
        private System.Windows.Forms.Button butt_Supp;
        private System.Windows.Forms.Button butt_Vider;
        private System.Windows.Forms.Button butt_Trier;
        private System.Windows.Forms.Button butt_Modifier;
        private System.Windows.Forms.Button buttQuitter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

