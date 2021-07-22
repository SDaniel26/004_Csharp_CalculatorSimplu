namespace CalculatorTutorial
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
            this.mainBox = new System.Windows.Forms.TextBox();
            this.btnSapte = new System.Windows.Forms.Button();
            this.btnOpt = new System.Windows.Forms.Button();
            this.btnNoua = new System.Windows.Forms.Button();
            this.btnImpartire = new System.Windows.Forms.Button();
            this.btnInmultire = new System.Windows.Forms.Button();
            this.btnSase = new System.Windows.Forms.Button();
            this.btnCinci = new System.Windows.Forms.Button();
            this.btnPatru = new System.Windows.Forms.Button();
            this.btnScadere = new System.Windows.Forms.Button();
            this.btnTrei = new System.Windows.Forms.Button();
            this.btnDoi = new System.Windows.Forms.Button();
            this.btnUnu = new System.Windows.Forms.Button();
            this.btnAdunare = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBox.Location = new System.Drawing.Point(15, 12);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(418, 29);
            this.mainBox.TabIndex = 0;
            this.mainBox.Text = "0";
            this.mainBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSapte
            // 
            this.btnSapte.Location = new System.Drawing.Point(15, 110);
            this.btnSapte.Name = "btnSapte";
            this.btnSapte.Size = new System.Drawing.Size(100, 100);
            this.btnSapte.TabIndex = 1;
            this.btnSapte.Text = "7";
            this.btnSapte.UseVisualStyleBackColor = true;
            this.btnSapte.Click += new System.EventHandler(this.btnSapte_Click);
            // 
            // btnOpt
            // 
            this.btnOpt.Location = new System.Drawing.Point(121, 110);
            this.btnOpt.Name = "btnOpt";
            this.btnOpt.Size = new System.Drawing.Size(100, 100);
            this.btnOpt.TabIndex = 2;
            this.btnOpt.Text = "8";
            this.btnOpt.UseVisualStyleBackColor = true;
            this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
            // 
            // btnNoua
            // 
            this.btnNoua.Location = new System.Drawing.Point(227, 110);
            this.btnNoua.Name = "btnNoua";
            this.btnNoua.Size = new System.Drawing.Size(100, 100);
            this.btnNoua.TabIndex = 3;
            this.btnNoua.Text = "9";
            this.btnNoua.UseVisualStyleBackColor = true;
            this.btnNoua.Click += new System.EventHandler(this.btnNoua_Click);
            // 
            // btnImpartire
            // 
            this.btnImpartire.Location = new System.Drawing.Point(333, 110);
            this.btnImpartire.Name = "btnImpartire";
            this.btnImpartire.Size = new System.Drawing.Size(100, 100);
            this.btnImpartire.TabIndex = 4;
            this.btnImpartire.Text = "/";
            this.btnImpartire.UseVisualStyleBackColor = true;
            this.btnImpartire.Click += new System.EventHandler(this.btnImpartire_Click);
            // 
            // btnInmultire
            // 
            this.btnInmultire.Location = new System.Drawing.Point(333, 216);
            this.btnInmultire.Name = "btnInmultire";
            this.btnInmultire.Size = new System.Drawing.Size(100, 100);
            this.btnInmultire.TabIndex = 8;
            this.btnInmultire.Text = "X";
            this.btnInmultire.UseVisualStyleBackColor = true;
            this.btnInmultire.Click += new System.EventHandler(this.btnInmultire_Click);
            // 
            // btnSase
            // 
            this.btnSase.Location = new System.Drawing.Point(227, 216);
            this.btnSase.Name = "btnSase";
            this.btnSase.Size = new System.Drawing.Size(100, 100);
            this.btnSase.TabIndex = 7;
            this.btnSase.Text = "6";
            this.btnSase.UseVisualStyleBackColor = true;
            this.btnSase.Click += new System.EventHandler(this.btnSase_Click);
            // 
            // btnCinci
            // 
            this.btnCinci.Location = new System.Drawing.Point(121, 216);
            this.btnCinci.Name = "btnCinci";
            this.btnCinci.Size = new System.Drawing.Size(100, 100);
            this.btnCinci.TabIndex = 6;
            this.btnCinci.Text = "5";
            this.btnCinci.UseVisualStyleBackColor = true;
            this.btnCinci.Click += new System.EventHandler(this.btnCinci_Click);
            // 
            // btnPatru
            // 
            this.btnPatru.Location = new System.Drawing.Point(15, 216);
            this.btnPatru.Name = "btnPatru";
            this.btnPatru.Size = new System.Drawing.Size(100, 100);
            this.btnPatru.TabIndex = 5;
            this.btnPatru.Text = "4";
            this.btnPatru.UseVisualStyleBackColor = true;
            this.btnPatru.Click += new System.EventHandler(this.btnPatru_Click);
            // 
            // btnScadere
            // 
            this.btnScadere.Location = new System.Drawing.Point(333, 322);
            this.btnScadere.Name = "btnScadere";
            this.btnScadere.Size = new System.Drawing.Size(100, 100);
            this.btnScadere.TabIndex = 12;
            this.btnScadere.Text = "-";
            this.btnScadere.UseVisualStyleBackColor = true;
            this.btnScadere.Click += new System.EventHandler(this.btnScadere_Click);
            // 
            // btnTrei
            // 
            this.btnTrei.Location = new System.Drawing.Point(227, 322);
            this.btnTrei.Name = "btnTrei";
            this.btnTrei.Size = new System.Drawing.Size(100, 100);
            this.btnTrei.TabIndex = 11;
            this.btnTrei.Text = "3";
            this.btnTrei.UseVisualStyleBackColor = true;
            this.btnTrei.Click += new System.EventHandler(this.btnTrei_Click);
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(121, 322);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(100, 100);
            this.btnDoi.TabIndex = 10;
            this.btnDoi.Text = "2";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // btnUnu
            // 
            this.btnUnu.Location = new System.Drawing.Point(15, 322);
            this.btnUnu.Name = "btnUnu";
            this.btnUnu.Size = new System.Drawing.Size(100, 100);
            this.btnUnu.TabIndex = 9;
            this.btnUnu.Text = "1";
            this.btnUnu.UseVisualStyleBackColor = true;
            this.btnUnu.Click += new System.EventHandler(this.btnUnu_Click);
            // 
            // btnAdunare
            // 
            this.btnAdunare.Location = new System.Drawing.Point(333, 428);
            this.btnAdunare.Name = "btnAdunare";
            this.btnAdunare.Size = new System.Drawing.Size(100, 100);
            this.btnAdunare.TabIndex = 16;
            this.btnAdunare.Text = "+";
            this.btnAdunare.UseVisualStyleBackColor = true;
            this.btnAdunare.Click += new System.EventHandler(this.btnAdunare_Click);
            // 
            // btnEgal
            // 
            this.btnEgal.Location = new System.Drawing.Point(227, 428);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(100, 100);
            this.btnEgal.TabIndex = 15;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = true;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(121, 428);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(100, 100);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(15, 428);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(100, 100);
            this.btnVirgula.TabIndex = 13;
            this.btnVirgula.Text = ".";
            this.btnVirgula.UseVisualStyleBackColor = true;
            // 
            // rezultat
            // 
            this.rezultat.BackColor = System.Drawing.SystemColors.Control;
            this.rezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.Location = new System.Drawing.Point(316, 63);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(117, 31);
            this.rezultat.TabIndex = 17;
            this.rezultat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 538);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.btnAdunare);
            this.Controls.Add(this.btnEgal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnScadere);
            this.Controls.Add(this.btnTrei);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.btnUnu);
            this.Controls.Add(this.btnInmultire);
            this.Controls.Add(this.btnSase);
            this.Controls.Add(this.btnCinci);
            this.Controls.Add(this.btnPatru);
            this.Controls.Add(this.btnImpartire);
            this.Controls.Add(this.btnNoua);
            this.Controls.Add(this.btnOpt);
            this.Controls.Add(this.btnSapte);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Calculator Simplu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainBox;
        private System.Windows.Forms.Button btnSapte;
        private System.Windows.Forms.Button btnOpt;
        private System.Windows.Forms.Button btnNoua;
        private System.Windows.Forms.Button btnImpartire;
        private System.Windows.Forms.Button btnInmultire;
        private System.Windows.Forms.Button btnSase;
        private System.Windows.Forms.Button btnCinci;
        private System.Windows.Forms.Button btnPatru;
        private System.Windows.Forms.Button btnScadere;
        private System.Windows.Forms.Button btnTrei;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Button btnUnu;
        private System.Windows.Forms.Button btnAdunare;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Label rezultat;
    }
}

