namespace DrinkMachine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.colaGroup = new System.Windows.Forms.GroupBox();
            this.colaDisplayLabel = new System.Windows.Forms.Label();
            this.drinksLeftLabelCola = new System.Windows.Forms.Label();
            this.colaPriceLabel = new System.Windows.Forms.Label();
            this.colaImage = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lemonLimeDisplayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lLPriceLabel = new System.Windows.Forms.Label();
            this.lemonLimeImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.creamSodaDisplayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creamSodaPriceLabel = new System.Windows.Forms.Label();
            this.creamSodaImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rootBeerDisplayLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBPriceLabel = new System.Windows.Forms.Label();
            this.rootBeerImage = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grapeDisplayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grapePriceLabel = new System.Windows.Forms.Label();
            this.grapeSodaImage = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.salesDisplayLabel = new System.Windows.Forms.Label();
            this.totalSalesTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.colaGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimeImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaImage)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(158, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Select a Drink";
            // 
            // colaGroup
            // 
            this.colaGroup.Controls.Add(this.colaDisplayLabel);
            this.colaGroup.Controls.Add(this.drinksLeftLabelCola);
            this.colaGroup.Controls.Add(this.colaPriceLabel);
            this.colaGroup.Controls.Add(this.colaImage);
            this.colaGroup.Location = new System.Drawing.Point(31, 54);
            this.colaGroup.Name = "colaGroup";
            this.colaGroup.Size = new System.Drawing.Size(178, 82);
            this.colaGroup.TabIndex = 1;
            this.colaGroup.TabStop = false;
            // 
            // colaDisplayLabel
            // 
            this.colaDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaDisplayLabel.Location = new System.Drawing.Point(101, 55);
            this.colaDisplayLabel.Name = "colaDisplayLabel";
            this.colaDisplayLabel.Size = new System.Drawing.Size(58, 19);
            this.colaDisplayLabel.TabIndex = 3;
            this.colaDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLabelCola
            // 
            this.drinksLeftLabelCola.AutoSize = true;
            this.drinksLeftLabelCola.Location = new System.Drawing.Point(98, 38);
            this.drinksLeftLabelCola.Name = "drinksLeftLabelCola";
            this.drinksLeftLabelCola.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLabelCola.TabIndex = 2;
            this.drinksLeftLabelCola.Text = "Drinks Left:";
            // 
            // colaPriceLabel
            // 
            this.colaPriceLabel.AutoSize = true;
            this.colaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colaPriceLabel.Location = new System.Drawing.Point(107, 16);
            this.colaPriceLabel.Name = "colaPriceLabel";
            this.colaPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.colaPriceLabel.TabIndex = 1;
            this.colaPriceLabel.Text = "$1.00";
            // 
            // colaImage
            // 
            this.colaImage.Image = ((System.Drawing.Image)(resources.GetObject("colaImage.Image")));
            this.colaImage.Location = new System.Drawing.Point(6, 10);
            this.colaImage.Name = "colaImage";
            this.colaImage.Size = new System.Drawing.Size(64, 64);
            this.colaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colaImage.TabIndex = 0;
            this.colaImage.TabStop = false;
            this.colaImage.Click += new System.EventHandler(this.colaImage_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lemonLimeDisplayLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lLPriceLabel);
            this.groupBox1.Controls.Add(this.lemonLimeImage);
            this.groupBox1.Location = new System.Drawing.Point(31, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lemonLimeDisplayLabel
            // 
            this.lemonLimeDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lemonLimeDisplayLabel.Location = new System.Drawing.Point(101, 55);
            this.lemonLimeDisplayLabel.Name = "lemonLimeDisplayLabel";
            this.lemonLimeDisplayLabel.Size = new System.Drawing.Size(58, 19);
            this.lemonLimeDisplayLabel.TabIndex = 3;
            this.lemonLimeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drinks Left:";
            // 
            // lLPriceLabel
            // 
            this.lLPriceLabel.AutoSize = true;
            this.lLPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLPriceLabel.Location = new System.Drawing.Point(107, 16);
            this.lLPriceLabel.Name = "lLPriceLabel";
            this.lLPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.lLPriceLabel.TabIndex = 1;
            this.lLPriceLabel.Text = "$1.00";
            // 
            // lemonLimeImage
            // 
            this.lemonLimeImage.Image = ((System.Drawing.Image)(resources.GetObject("lemonLimeImage.Image")));
            this.lemonLimeImage.Location = new System.Drawing.Point(6, 10);
            this.lemonLimeImage.Name = "lemonLimeImage";
            this.lemonLimeImage.Size = new System.Drawing.Size(62, 64);
            this.lemonLimeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lemonLimeImage.TabIndex = 0;
            this.lemonLimeImage.TabStop = false;
            this.lemonLimeImage.Click += new System.EventHandler(this.lemonLimeImage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.creamSodaDisplayLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.creamSodaPriceLabel);
            this.groupBox2.Controls.Add(this.creamSodaImage);
            this.groupBox2.Location = new System.Drawing.Point(121, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // creamSodaDisplayLabel
            // 
            this.creamSodaDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creamSodaDisplayLabel.Location = new System.Drawing.Point(101, 55);
            this.creamSodaDisplayLabel.Name = "creamSodaDisplayLabel";
            this.creamSodaDisplayLabel.Size = new System.Drawing.Size(58, 19);
            this.creamSodaDisplayLabel.TabIndex = 3;
            this.creamSodaDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drinks Left:";
            // 
            // creamSodaPriceLabel
            // 
            this.creamSodaPriceLabel.AutoSize = true;
            this.creamSodaPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creamSodaPriceLabel.Location = new System.Drawing.Point(107, 16);
            this.creamSodaPriceLabel.Name = "creamSodaPriceLabel";
            this.creamSodaPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.creamSodaPriceLabel.TabIndex = 1;
            this.creamSodaPriceLabel.Text = "$1.50";
            // 
            // creamSodaImage
            // 
            this.creamSodaImage.Image = ((System.Drawing.Image)(resources.GetObject("creamSodaImage.Image")));
            this.creamSodaImage.Location = new System.Drawing.Point(6, 10);
            this.creamSodaImage.Name = "creamSodaImage";
            this.creamSodaImage.Size = new System.Drawing.Size(62, 64);
            this.creamSodaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.creamSodaImage.TabIndex = 0;
            this.creamSodaImage.TabStop = false;
            this.creamSodaImage.Click += new System.EventHandler(this.creamSodaImage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rootBeerDisplayLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rBPriceLabel);
            this.groupBox3.Controls.Add(this.rootBeerImage);
            this.groupBox3.Location = new System.Drawing.Point(229, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // rootBeerDisplayLabel
            // 
            this.rootBeerDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rootBeerDisplayLabel.Location = new System.Drawing.Point(101, 55);
            this.rootBeerDisplayLabel.Name = "rootBeerDisplayLabel";
            this.rootBeerDisplayLabel.Size = new System.Drawing.Size(58, 19);
            this.rootBeerDisplayLabel.TabIndex = 3;
            this.rootBeerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Drinks Left:";
            // 
            // rBPriceLabel
            // 
            this.rBPriceLabel.AutoSize = true;
            this.rBPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPriceLabel.Location = new System.Drawing.Point(107, 16);
            this.rBPriceLabel.Name = "rBPriceLabel";
            this.rBPriceLabel.Size = new System.Drawing.Size(39, 13);
            this.rBPriceLabel.TabIndex = 1;
            this.rBPriceLabel.Text = "$1.00";
            // 
            // rootBeerImage
            // 
            this.rootBeerImage.Image = ((System.Drawing.Image)(resources.GetObject("rootBeerImage.Image")));
            this.rootBeerImage.Location = new System.Drawing.Point(6, 10);
            this.rootBeerImage.Name = "rootBeerImage";
            this.rootBeerImage.Size = new System.Drawing.Size(64, 64);
            this.rootBeerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rootBeerImage.TabIndex = 0;
            this.rootBeerImage.TabStop = false;
            this.rootBeerImage.Click += new System.EventHandler(this.rootBeerImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grapeDisplayLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.grapePriceLabel);
            this.groupBox4.Controls.Add(this.grapeSodaImage);
            this.groupBox4.Location = new System.Drawing.Point(229, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 82);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // grapeDisplayLabel
            // 
            this.grapeDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grapeDisplayLabel.Location = new System.Drawing.Point(101, 55);
            this.grapeDisplayLabel.Name = "grapeDisplayLabel";
            this.grapeDisplayLabel.Size = new System.Drawing.Size(58, 19);
            this.grapeDisplayLabel.TabIndex = 3;
            this.grapeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Drinks Left:";
            // 
            // grapePriceLabel
            // 
            this.grapePriceLabel.AutoSize = true;
            this.grapePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grapePriceLabel.Location = new System.Drawing.Point(107, 16);
            this.grapePriceLabel.Name = "grapePriceLabel";
            this.grapePriceLabel.Size = new System.Drawing.Size(39, 13);
            this.grapePriceLabel.TabIndex = 1;
            this.grapePriceLabel.Text = "$1.50";
            // 
            // grapeSodaImage
            // 
            this.grapeSodaImage.Image = ((System.Drawing.Image)(resources.GetObject("grapeSodaImage.Image")));
            this.grapeSodaImage.Location = new System.Drawing.Point(6, 10);
            this.grapeSodaImage.Name = "grapeSodaImage";
            this.grapeSodaImage.Size = new System.Drawing.Size(62, 64);
            this.grapeSodaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.grapeSodaImage.TabIndex = 0;
            this.grapeSodaImage.TabStop = false;
            this.grapeSodaImage.Click += new System.EventHandler(this.grapeSodaImage_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.salesDisplayLabel);
            this.groupBox5.Controls.Add(this.totalSalesTitleLabel);
            this.groupBox5.Location = new System.Drawing.Point(132, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 82);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // salesDisplayLabel
            // 
            this.salesDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salesDisplayLabel.Location = new System.Drawing.Point(48, 38);
            this.salesDisplayLabel.Name = "salesDisplayLabel";
            this.salesDisplayLabel.Size = new System.Drawing.Size(82, 24);
            this.salesDisplayLabel.TabIndex = 3;
            this.salesDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSalesTitleLabel
            // 
            this.totalSalesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesTitleLabel.Location = new System.Drawing.Point(48, 10);
            this.totalSalesTitleLabel.Name = "totalSalesTitleLabel";
            this.totalSalesTitleLabel.Size = new System.Drawing.Size(82, 22);
            this.totalSalesTitleLabel.TabIndex = 1;
            this.totalSalesTitleLabel.Text = "Total Sales";
            this.totalSalesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(187, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 495);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.colaGroup);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Henze Vending v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colaGroup.ResumeLayout(false);
            this.colaGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimeImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaImage)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox colaGroup;
        private System.Windows.Forms.Label colaDisplayLabel;
        private System.Windows.Forms.Label drinksLeftLabelCola;
        private System.Windows.Forms.Label colaPriceLabel;
        private System.Windows.Forms.PictureBox colaImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lemonLimeDisplayLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLPriceLabel;
        private System.Windows.Forms.PictureBox lemonLimeImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label creamSodaDisplayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label creamSodaPriceLabel;
        private System.Windows.Forms.PictureBox creamSodaImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label rootBeerDisplayLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rBPriceLabel;
        private System.Windows.Forms.PictureBox rootBeerImage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label grapeDisplayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label grapePriceLabel;
        private System.Windows.Forms.PictureBox grapeSodaImage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label totalSalesTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label salesDisplayLabel;
    }
}

