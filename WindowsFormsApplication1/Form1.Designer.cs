namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x1label = new System.Windows.Forms.Label();
            this.x3t = new System.Windows.Forms.Label();
            this.blabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.calc = new System.Windows.Forms.Button();
            this.p1label = new System.Windows.Forms.Label();
            this.p2label = new System.Windows.Forms.Label();
            this.doc = new System.Windows.Forms.PictureBox();
            this.xtext = new System.Windows.Forms.Label();
            this.x2label = new System.Windows.Forms.Label();
            this.x3TB = new System.Windows.Forms.TextBox();
            this.tableOfValues = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество членов разложения в ряд функции cos: ";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(289, 32);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(39, 20);
            this.N.TabIndex = 1;
            this.N.Click += new System.EventHandler(this.N_Click);
            this.N.TextChanged += new System.EventHandler(this.N_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cos(x) = ";
            // 
            // x1label
            // 
            this.x1label.AutoSize = true;
            this.x1label.Location = new System.Drawing.Point(12, 60);
            this.x1label.Name = "x1label";
            this.x1label.Size = new System.Drawing.Size(36, 13);
            this.x1label.TabIndex = 3;
            this.x1label.Text = "x1 = 0";
            // 
            // x3t
            // 
            this.x3t.AutoSize = true;
            this.x3t.Location = new System.Drawing.Point(96, 60);
            this.x3t.Name = "x3t";
            this.x3t.Size = new System.Drawing.Size(24, 13);
            this.x3t.TabIndex = 5;
            this.x3t.Text = "x3=";
            // 
            // blabel
            // 
            this.blabel.AutoSize = true;
            this.blabel.Location = new System.Drawing.Point(154, 60);
            this.blabel.Name = "blabel";
            this.blabel.Size = new System.Drawing.Size(43, 13);
            this.blabel.TabIndex = 6;
            this.blabel.Text = "b = -2.9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 191);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(15, 283);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(312, 57);
            this.calc.TabIndex = 8;
            this.calc.Text = "Вычислить";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // p1label
            // 
            this.p1label.AutoSize = true;
            this.p1label.Location = new System.Drawing.Point(203, 60);
            this.p1label.Name = "p1label";
            this.p1label.Size = new System.Drawing.Size(37, 13);
            this.p1label.TabIndex = 10;
            this.p1label.Text = "p1 = 1";
            // 
            // p2label
            // 
            this.p2label.AutoSize = true;
            this.p2label.Location = new System.Drawing.Point(244, 60);
            this.p2label.Name = "p2label";
            this.p2label.Size = new System.Drawing.Size(46, 13);
            this.p2label.TabIndex = 11;
            this.p2label.Text = "p2 = 1.3";
            // 
            // doc
            // 
            this.doc.Location = new System.Drawing.Point(334, 32);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(599, 308);
            this.doc.TabIndex = 12;
            this.doc.TabStop = false;
            // 
            // xtext
            // 
            this.xtext.AutoSize = true;
            this.xtext.Location = new System.Drawing.Point(328, 60);
            this.xtext.Name = "xtext";
            this.xtext.Size = new System.Drawing.Size(0, 13);
            this.xtext.TabIndex = 13;
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Location = new System.Drawing.Point(54, 60);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(36, 13);
            this.x2label.TabIndex = 4;
            this.x2label.Text = "x2 = 2";
            // 
            // x3TB
            // 
            this.x3TB.Location = new System.Drawing.Point(120, 57);
            this.x3TB.Name = "x3TB";
            this.x3TB.Size = new System.Drawing.Size(28, 20);
            this.x3TB.TabIndex = 14;
            this.x3TB.Text = "0,";
            this.x3TB.Click += new System.EventHandler(this.x3TB_Click);
            this.x3TB.TextChanged += new System.EventHandler(this.x3TB_TextChanged);
            // 
            // tableOfValues
            // 
            this.tableOfValues.Location = new System.Drawing.Point(939, 29);
            this.tableOfValues.Multiline = true;
            this.tableOfValues.Name = "tableOfValues";
            this.tableOfValues.ReadOnly = true;
            this.tableOfValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tableOfValues.Size = new System.Drawing.Size(139, 311);
            this.tableOfValues.TabIndex = 15;
            this.tableOfValues.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1015, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableOfValues);
            this.Controls.Add(this.x3TB);
            this.Controls.Add(this.xtext);
            this.Controls.Add(this.doc);
            this.Controls.Add(this.p2label);
            this.Controls.Add(this.p1label);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.blabel);
            this.Controls.Add(this.x3t);
            this.Controls.Add(this.x2label);
            this.Controls.Add(this.x1label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x1label;
        private System.Windows.Forms.Label x3t;
        private System.Windows.Forms.Label blabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label p1label;
        private System.Windows.Forms.Label p2label;
        private System.Windows.Forms.PictureBox doc;
        private System.Windows.Forms.Label xtext;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.TextBox x3TB;
        private System.Windows.Forms.TextBox tableOfValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

