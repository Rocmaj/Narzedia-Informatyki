namespace MiniBiblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabelaGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KategoriaText = new System.Windows.Forms.RichTextBox();
            this.StronyText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TytulText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutorText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RokText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DodajButton = new System.Windows.Forms.Button();
            this.EdytujButton = new System.Windows.Forms.Button();
            this.UsunButton = new System.Windows.Forms.Button();
            this.WyjdzButton = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rokWydaniaSort = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TytulLookUp = new System.Windows.Forms.RadioButton();
            this.AutorLookUp = new System.Windows.Forms.RadioButton();
            this.PoleDoSzukania = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelaGridView
            // 
            this.TabelaGridView.AllowUserToAddRows = false;
            this.TabelaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaGridView.Location = new System.Drawing.Point(12, 12);
            this.TabelaGridView.Name = "TabelaGridView";
            this.TabelaGridView.ReadOnly = true;
            this.TabelaGridView.Size = new System.Drawing.Size(543, 360);
            this.TabelaGridView.TabIndex = 3;
            this.TabelaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KategoriaText);
            this.groupBox1.Controls.Add(this.StronyText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TytulText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AutorText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RokText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(570, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // KategoriaText
            // 
            this.KategoriaText.Location = new System.Drawing.Point(64, 104);
            this.KategoriaText.Name = "KategoriaText";
            this.KategoriaText.Size = new System.Drawing.Size(321, 16);
            this.KategoriaText.TabIndex = 11;
            this.KategoriaText.Text = "";
            // 
            // StronyText
            // 
            this.StronyText.Location = new System.Drawing.Point(81, 85);
            this.StronyText.Name = "StronyText";
            this.StronyText.Size = new System.Drawing.Size(304, 16);
            this.StronyText.TabIndex = 10;
            this.StronyText.Text = "";
            this.StronyText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StronyText_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Liczba stron";
            // 
            // TytulText
            // 
            this.TytulText.Location = new System.Drawing.Point(44, 19);
            this.TytulText.Name = "TytulText";
            this.TytulText.Size = new System.Drawing.Size(341, 16);
            this.TytulText.TabIndex = 5;
            this.TytulText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł";
            // 
            // AutorText
            // 
            this.AutorText.Location = new System.Drawing.Point(44, 41);
            this.AutorText.Name = "AutorText";
            this.AutorText.Size = new System.Drawing.Size(341, 16);
            this.AutorText.TabIndex = 9;
            this.AutorText.Text = "";
            this.AutorText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutorText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // RokText
            // 
            this.RokText.Location = new System.Drawing.Point(81, 63);
            this.RokText.Name = "RokText";
            this.RokText.Size = new System.Drawing.Size(304, 16);
            this.RokText.TabIndex = 8;
            this.RokText.Text = "";
            this.RokText.TextChanged += new System.EventHandler(this.RokText_TextChanged);
            this.RokText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RokText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok wydania";
            // 
            // DodajButton
            // 
            this.DodajButton.Location = new System.Drawing.Point(9, 19);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(122, 23);
            this.DodajButton.TabIndex = 5;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // EdytujButton
            // 
            this.EdytujButton.Location = new System.Drawing.Point(137, 19);
            this.EdytujButton.Name = "EdytujButton";
            this.EdytujButton.Size = new System.Drawing.Size(122, 23);
            this.EdytujButton.TabIndex = 6;
            this.EdytujButton.Text = "Edytuj";
            this.EdytujButton.UseVisualStyleBackColor = true;
            this.EdytujButton.Click += new System.EventHandler(this.EdytujButton_Click);
            // 
            // UsunButton
            // 
            this.UsunButton.Location = new System.Drawing.Point(265, 19);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(122, 23);
            this.UsunButton.TabIndex = 7;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // WyjdzButton
            // 
            this.WyjdzButton.Location = new System.Drawing.Point(893, 353);
            this.WyjdzButton.Name = "WyjdzButton";
            this.WyjdzButton.Size = new System.Drawing.Size(75, 23);
            this.WyjdzButton.TabIndex = 8;
            this.WyjdzButton.Text = "Wyjdz";
            this.WyjdzButton.UseVisualStyleBackColor = true;
            this.WyjdzButton.Click += new System.EventHandler(this.WyjdzButton_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(579, 353);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(308, 23);
            this.Zapisz.TabIndex = 1;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rokWydaniaSort);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TytulLookUp);
            this.groupBox3.Controls.Add(this.AutorLookUp);
            this.groupBox3.Controls.Add(this.PoleDoSzukania);
            this.groupBox3.Controls.Add(this.DodajButton);
            this.groupBox3.Controls.Add(this.EdytujButton);
            this.groupBox3.Controls.Add(this.UsunButton);
            this.groupBox3.Location = new System.Drawing.Point(570, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // rokWydaniaSort
            // 
            this.rokWydaniaSort.AutoSize = true;
            this.rokWydaniaSort.Location = new System.Drawing.Point(9, 172);
            this.rokWydaniaSort.Name = "rokWydaniaSort";
            this.rokWydaniaSort.Size = new System.Drawing.Size(90, 17);
            this.rokWydaniaSort.TabIndex = 14;
            this.rokWydaniaSort.TabStop = true;
            this.rokWydaniaSort.Text = "Rok Wydania";
            this.rokWydaniaSort.UseVisualStyleBackColor = true;
            this.rokWydaniaSort.CheckedChanged += new System.EventHandler(this.rokWydaniaSort_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 149);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tytuł";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sortuj po:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wyszukaj";
            // 
            // TytulLookUp
            // 
            this.TytulLookUp.AutoSize = true;
            this.TytulLookUp.Location = new System.Drawing.Point(199, 74);
            this.TytulLookUp.Name = "TytulLookUp";
            this.TytulLookUp.Size = new System.Drawing.Size(48, 17);
            this.TytulLookUp.TabIndex = 10;
            this.TytulLookUp.TabStop = true;
            this.TytulLookUp.Text = "Tytul";
            this.TytulLookUp.UseVisualStyleBackColor = true;
            this.TytulLookUp.CheckedChanged += new System.EventHandler(this.TytulLookUp_CheckedChanged);
            // 
            // AutorLookUp
            // 
            this.AutorLookUp.AutoSize = true;
            this.AutorLookUp.Location = new System.Drawing.Point(143, 74);
            this.AutorLookUp.Name = "AutorLookUp";
            this.AutorLookUp.Size = new System.Drawing.Size(50, 17);
            this.AutorLookUp.TabIndex = 9;
            this.AutorLookUp.TabStop = true;
            this.AutorLookUp.Text = "Autor";
            this.AutorLookUp.UseVisualStyleBackColor = true;
            this.AutorLookUp.CheckedChanged += new System.EventHandler(this.AutorLookUp_CheckedChanged);
            // 
            // PoleDoSzukania
            // 
            this.PoleDoSzukania.Location = new System.Drawing.Point(6, 97);
            this.PoleDoSzukania.Name = "PoleDoSzukania";
            this.PoleDoSzukania.Size = new System.Drawing.Size(376, 23);
            this.PoleDoSzukania.TabIndex = 8;
            this.PoleDoSzukania.Text = "";
            this.PoleDoSzukania.TextChanged += new System.EventHandler(this.PoleDoSzukania_TextChanged);
            this.PoleDoSzukania.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PoleDoSzukania_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 384);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.WyjdzButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TabelaGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView TabelaGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TytulText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AutorText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RokText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox KategoriaText;
        private System.Windows.Forms.RichTextBox StronyText;
        private System.Windows.Forms.Button DodajButton;
        private System.Windows.Forms.Button EdytujButton;
        private System.Windows.Forms.Button UsunButton;
        private System.Windows.Forms.Button WyjdzButton;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton TytulLookUp;
        private System.Windows.Forms.RadioButton AutorLookUp;
        private System.Windows.Forms.RichTextBox PoleDoSzukania;
        private System.Windows.Forms.RadioButton rokWydaniaSort;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

