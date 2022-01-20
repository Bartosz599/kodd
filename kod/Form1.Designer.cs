namespace Zad1
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
            this.components = new System.ComponentModel.Container();
            this.tbSciezkaPlikuRepozytorium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWybierzPlik = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.cbMetodaWczytania = new System.Windows.Forms.ComboBox();
            this.nudMi = new System.Windows.Forms.NumericUpDown();
            this.nudMa = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbAtrybutyDoPominiecia = new System.Windows.Forms.CheckedListBox();
            this.cbMetryka = new System.Windows.Forms.ComboBox();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Dokladnosc = new System.Windows.Forms.Button();
            this.accuracy = new System.Windows.Forms.Label();
            this.btnKnn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbWiersz = new System.Windows.Forms.TextBox();
            this.metryki = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decyzja = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSciezkaPlikuRepozytorium
            // 
            this.tbSciezkaPlikuRepozytorium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSciezkaPlikuRepozytorium.Location = new System.Drawing.Point(12, 69);
            this.tbSciezkaPlikuRepozytorium.Margin = new System.Windows.Forms.Padding(4);
            this.tbSciezkaPlikuRepozytorium.Name = "tbSciezkaPlikuRepozytorium";
            this.tbSciezkaPlikuRepozytorium.ReadOnly = true;
            this.tbSciezkaPlikuRepozytorium.Size = new System.Drawing.Size(521, 22);
            this.tbSciezkaPlikuRepozytorium.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plik repozytorium";
            // 
            // btnWybierzPlik
            // 
            this.btnWybierzPlik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWybierzPlik.Location = new System.Drawing.Point(541, 66);
            this.btnWybierzPlik.Margin = new System.Windows.Forms.Padding(4);
            this.btnWybierzPlik.Name = "btnWybierzPlik";
            this.btnWybierzPlik.Size = new System.Drawing.Size(48, 28);
            this.btnWybierzPlik.TabIndex = 2;
            this.btnWybierzPlik.Text = "...";
            this.btnWybierzPlik.UseVisualStyleBackColor = true;
            this.btnWybierzPlik.Click += new System.EventHandler(this.btnWybierzPlik_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnaliza.Enabled = false;
            this.btnAnaliza.Location = new System.Drawing.Point(1106, 492);
            this.btnAnaliza.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(100, 28);
            this.btnAnaliza.TabIndex = 3;
            this.btnAnaliza.Text = "Analizuj plik";
            this.btnAnaliza.UseVisualStyleBackColor = true;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // cbMetodaWczytania
            // 
            this.cbMetodaWczytania.FormattingEnabled = true;
            this.cbMetodaWczytania.Location = new System.Drawing.Point(13, 13);
            this.cbMetodaWczytania.Margin = new System.Windows.Forms.Padding(4);
            this.cbMetodaWczytania.Name = "cbMetodaWczytania";
            this.cbMetodaWczytania.Size = new System.Drawing.Size(520, 24);
            this.cbMetodaWczytania.TabIndex = 4;
            // 
            // nudMi
            // 
            this.nudMi.DecimalPlaces = 4;
            this.nudMi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudMi.Location = new System.Drawing.Point(85, 34);
            this.nudMi.Margin = new System.Windows.Forms.Padding(4);
            this.nudMi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMi.Name = "nudMi";
            this.nudMi.Size = new System.Drawing.Size(160, 22);
            this.nudMi.TabIndex = 5;
            // 
            // nudMa
            // 
            this.nudMa.DecimalPlaces = 4;
            this.nudMa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nudMa.Location = new System.Drawing.Point(472, 34);
            this.nudMa.Margin = new System.Windows.Forms.Padding(4);
            this.nudMa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMa.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMa.Name = "nudMa";
            this.nudMa.Size = new System.Drawing.Size(160, 22);
            this.nudMa.TabIndex = 6;
            this.nudMa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maksimum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudMa);
            this.groupBox1.Location = new System.Drawing.Point(13, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(640, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Normalizacja";
            // 
            // clbAtrybutyDoPominiecia
            // 
            this.clbAtrybutyDoPominiecia.FormattingEnabled = true;
            this.clbAtrybutyDoPominiecia.Location = new System.Drawing.Point(597, 13);
            this.clbAtrybutyDoPominiecia.Margin = new System.Windows.Forms.Padding(4);
            this.clbAtrybutyDoPominiecia.Name = "clbAtrybutyDoPominiecia";
            this.clbAtrybutyDoPominiecia.Size = new System.Drawing.Size(608, 89);
            this.clbAtrybutyDoPominiecia.TabIndex = 10;
            this.clbAtrybutyDoPominiecia.SelectedIndexChanged += new System.EventHandler(this.clbAtrybutyDoPominiecia_SelectedIndexChanged);
            // 
            // cbMetryka
            // 
            this.cbMetryka.FormattingEnabled = true;
            this.cbMetryka.Items.AddRange(new object[] {
            "Euklidesowa",
            "Manhattana"});
            this.cbMetryka.Location = new System.Drawing.Point(12, 226);
            this.cbMetryka.Name = "cbMetryka";
            this.cbMetryka.Size = new System.Drawing.Size(409, 24);
            this.cbMetryka.TabIndex = 11;
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(660, 133);
            this.nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(120, 22);
            this.nUpDown.TabIndex = 12;
            this.nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDown.ValueChanged += new System.EventHandler(this.nUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "k";
            // 
            // Dokladnosc
            // 
            this.Dokladnosc.Enabled = false;
            this.Dokladnosc.Location = new System.Drawing.Point(999, 492);
            this.Dokladnosc.Name = "Dokladnosc";
            this.Dokladnosc.Size = new System.Drawing.Size(100, 28);
            this.Dokladnosc.TabIndex = 15;
            this.Dokladnosc.Text = "1 vs Reszta";
            this.Dokladnosc.UseVisualStyleBackColor = true;
            this.Dokladnosc.Click += new System.EventHandler(this.Dokladnosc_Click);
            // 
            // accuracy
            // 
            this.accuracy.AutoSize = true;
            this.accuracy.Location = new System.Drawing.Point(661, 158);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(0, 17);
            this.accuracy.TabIndex = 16;
            // 
            // btnKnn
            // 
            this.btnKnn.Location = new System.Drawing.Point(893, 492);
            this.btnKnn.Name = "btnKnn";
            this.btnKnn.Size = new System.Drawing.Size(100, 28);
            this.btnKnn.TabIndex = 17;
            this.btnKnn.Text = "nowy wiersz";
            this.btnKnn.UseVisualStyleBackColor = true;
            this.btnKnn.Click += new System.EventHandler(this.btnKnn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbWiersz
            // 
            this.tbWiersz.Location = new System.Drawing.Point(12, 289);
            this.tbWiersz.Name = "tbWiersz";
            this.tbWiersz.Size = new System.Drawing.Size(499, 22);
            this.tbWiersz.TabIndex = 19;
            // 
            // metryki
            // 
            this.metryki.AutoSize = true;
            this.metryki.Location = new System.Drawing.Point(12, 203);
            this.metryki.Name = "metryki";
            this.metryki.Size = new System.Drawing.Size(53, 17);
            this.metryki.TabIndex = 20;
            this.metryki.Text = "Metryki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Wypisz po separatorze wartosci wiersza do sprawdzenia ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Decyzja";
            // 
            // decyzja
            // 
            this.decyzja.AutoSize = true;
            this.decyzja.Location = new System.Drawing.Point(538, 292);
            this.decyzja.Name = "decyzja";
            this.decyzja.Size = new System.Drawing.Size(0, 17);
            this.decyzja.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "label7";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sposob 1",
            "sposób 2"});
            this.comboBox1.Location = new System.Drawing.Point(786, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "sposób klasyfikacji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 532);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.decyzja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.metryki);
            this.Controls.Add(this.tbWiersz);
            this.Controls.Add(this.btnKnn);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.Dokladnosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.cbMetryka);
            this.Controls.Add(this.clbAtrybutyDoPominiecia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbMetodaWczytania);
            this.Controls.Add(this.btnAnaliza);
            this.Controls.Add(this.btnWybierzPlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSciezkaPlikuRepozytorium);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(590, 329);
            this.Name = "Form1";
            this.Text = "Przygotwanie danych";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSciezkaPlikuRepozytorium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWybierzPlik;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnAnaliza;
        private System.Windows.Forms.ComboBox cbMetodaWczytania;
        private System.Windows.Forms.NumericUpDown nudMi;
        private System.Windows.Forms.NumericUpDown nudMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbAtrybutyDoPominiecia;
        private System.Windows.Forms.ComboBox cbMetryka;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Dokladnosc;
        private System.Windows.Forms.Label accuracy;
        private System.Windows.Forms.Button btnKnn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbWiersz;
        private System.Windows.Forms.Label metryki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label decyzja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
    }
}

