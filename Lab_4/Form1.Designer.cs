namespace Lab_4
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
            this.black_btn = new System.Windows.Forms.Button();
            this.mocca_btn = new System.Windows.Forms.Button();
            this.latte_btn = new System.Windows.Forms.Button();
            this.choco_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // black_btn
            // 
            this.black_btn.Location = new System.Drawing.Point(361, 250);
            this.black_btn.Name = "black_btn";
            this.black_btn.Size = new System.Drawing.Size(94, 45);
            this.black_btn.TabIndex = 1;
            this.black_btn.Text = "Black coffee";
            this.black_btn.UseVisualStyleBackColor = true;
            this.black_btn.Click += new System.EventHandler(this.black_btn_Click);
            // 
            // mocca_btn
            // 
            this.mocca_btn.Location = new System.Drawing.Point(361, 301);
            this.mocca_btn.Name = "mocca_btn";
            this.mocca_btn.Size = new System.Drawing.Size(94, 45);
            this.mocca_btn.TabIndex = 1;
            this.mocca_btn.Text = "Mocca";
            this.mocca_btn.UseVisualStyleBackColor = true;
            this.mocca_btn.Click += new System.EventHandler(this.mocca_btn_Click);
            // 
            // latte_btn
            // 
            this.latte_btn.Location = new System.Drawing.Point(487, 250);
            this.latte_btn.Name = "latte_btn";
            this.latte_btn.Size = new System.Drawing.Size(93, 45);
            this.latte_btn.TabIndex = 1;
            this.latte_btn.Text = "Latte";
            this.latte_btn.UseVisualStyleBackColor = true;
            this.latte_btn.Click += new System.EventHandler(this.latte_btn_Click);
            // 
            // choco_btn
            // 
            this.choco_btn.Location = new System.Drawing.Point(487, 301);
            this.choco_btn.Name = "choco_btn";
            this.choco_btn.Size = new System.Drawing.Size(93, 45);
            this.choco_btn.TabIndex = 1;
            this.choco_btn.Text = "Chocolate";
            this.choco_btn.UseVisualStyleBackColor = true;
            this.choco_btn.Click += new System.EventHandler(this.choco_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Increase material";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product
            // 
            this.Product.Image = global::Lab_4.Properties.Resources.product;
            this.Product.Location = new System.Drawing.Point(422, 362);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(158, 122);
            this.Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Product.TabIndex = 2;
            this.Product.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab_4.Properties.Resources.vending_machine;
            this.pictureBox1.Location = new System.Drawing.Point(22, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 760);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.latte_btn);
            this.Controls.Add(this.choco_btn);
            this.Controls.Add(this.mocca_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.black_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button black_btn;
        private System.Windows.Forms.Button mocca_btn;
        private System.Windows.Forms.Button latte_btn;
        private System.Windows.Forms.Button choco_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Product;
    }
}

