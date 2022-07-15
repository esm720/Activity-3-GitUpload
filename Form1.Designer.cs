namespace Hello_World
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
            this.firstButton = new System.Windows.Forms.Button();
            this.thirdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTwoo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hideLightButton = new System.Windows.Forms.Button();
            this.aceFront = new System.Windows.Forms.PictureBox();
            this.aceBack = new System.Windows.Forms.PictureBox();
            this.aceFrontButt = new System.Windows.Forms.Button();
            this.aceBackButt = new System.Windows.Forms.Button();
            this.exitButt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.readInputButt = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceBack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(127, 351);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(167, 99);
            this.firstButton.TabIndex = 1;
            this.firstButton.Text = "English";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // thirdButton
            // 
            this.thirdButton.Location = new System.Drawing.Point(668, 351);
            this.thirdButton.Name = "thirdButton";
            this.thirdButton.Size = new System.Drawing.Size(190, 99);
            this.thirdButton.TabIndex = 2;
            this.thirdButton.Text = "Italian";
            this.thirdButton.UseVisualStyleBackColor = true;
            this.thirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(770, 227);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select a language and I will say Good Morning.";
            // 
            // buttonTwoo
            // 
            this.buttonTwoo.Location = new System.Drawing.Point(384, 351);
            this.buttonTwoo.Name = "buttonTwoo";
            this.buttonTwoo.Size = new System.Drawing.Size(175, 99);
            this.buttonTwoo.TabIndex = 5;
            this.buttonTwoo.Text = "Spanish";
            this.buttonTwoo.UseVisualStyleBackColor = true;
            this.buttonTwoo.Click += new System.EventHandler(this.buttonTwoo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 501);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hideLightButton
            // 
            this.hideLightButton.Location = new System.Drawing.Point(742, 618);
            this.hideLightButton.Name = "hideLightButton";
            this.hideLightButton.Size = new System.Drawing.Size(150, 46);
            this.hideLightButton.TabIndex = 7;
            this.hideLightButton.Text = "Hide Lights";
            this.hideLightButton.UseVisualStyleBackColor = true;
            this.hideLightButton.Click += new System.EventHandler(this.hideLightButton_Click);
            // 
            // aceFront
            // 
            this.aceFront.Image = ((System.Drawing.Image)(resources.GetObject("aceFront.Image")));
            this.aceFront.Location = new System.Drawing.Point(96, 885);
            this.aceFront.Name = "aceFront";
            this.aceFront.Size = new System.Drawing.Size(283, 370);
            this.aceFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aceFront.TabIndex = 8;
            this.aceFront.TabStop = false;
            // 
            // aceBack
            // 
            this.aceBack.Image = ((System.Drawing.Image)(resources.GetObject("aceBack.Image")));
            this.aceBack.Location = new System.Drawing.Point(456, 885);
            this.aceBack.Name = "aceBack";
            this.aceBack.Size = new System.Drawing.Size(312, 370);
            this.aceBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aceBack.TabIndex = 9;
            this.aceBack.TabStop = false;
            // 
            // aceFrontButt
            // 
            this.aceFrontButt.Location = new System.Drawing.Point(144, 1324);
            this.aceFrontButt.Name = "aceFrontButt";
            this.aceFrontButt.Size = new System.Drawing.Size(192, 96);
            this.aceFrontButt.TabIndex = 10;
            this.aceFrontButt.Text = "Show the Card Back";
            this.aceFrontButt.UseVisualStyleBackColor = true;
            this.aceFrontButt.Click += new System.EventHandler(this.aceFrontButt_Click);
            // 
            // aceBackButt
            // 
            this.aceBackButt.Location = new System.Drawing.Point(527, 1324);
            this.aceBackButt.Name = "aceBackButt";
            this.aceBackButt.Size = new System.Drawing.Size(196, 96);
            this.aceBackButt.TabIndex = 11;
            this.aceBackButt.Text = "Show the Card Front";
            this.aceBackButt.UseVisualStyleBackColor = true;
            this.aceBackButt.Click += new System.EventHandler(this.aceBackButt_Click);
            // 
            // exitButt
            // 
            this.exitButt.Location = new System.Drawing.Point(361, 280);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(150, 46);
            this.exitButt.TabIndex = 5;
            this.exitButt.Text = "&Exit";
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 39);
            this.textBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter your first name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "Full Name Age:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(286, 176);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(302, 44);
            this.outputLabel.TabIndex = 16;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // readInputButt
            // 
            this.readInputButt.Location = new System.Drawing.Point(129, 280);
            this.readInputButt.Name = "readInputButt";
            this.readInputButt.Size = new System.Drawing.Size(150, 46);
            this.readInputButt.TabIndex = 4;
            this.readInputButt.Text = "Read Input";
            this.readInputButt.UseVisualStyleBackColor = true;
            this.readInputButt.Click += new System.EventHandler(this.readInputButt_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(24, 82);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(239, 32);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Enter your last name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(286, 79);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(302, 39);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1443, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1427, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = " ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 39);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.exitButt);
            this.groupBox1.Controls.Add(this.readInputButt);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.outputLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1094, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 366);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identity Group";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AcceptButton = this.readInputButt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButt;
            this.ClientSize = new System.Drawing.Size(1879, 1465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aceBackButt);
            this.Controls.Add(this.aceFrontButt);
            this.Controls.Add(this.aceBack);
            this.Controls.Add(this.aceFront);
            this.Controls.Add(this.hideLightButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTwoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirdButton);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "Code Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceBack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button firstButton;
        private Button thirdButton;
        private Label label1;
        private Label label2;
        private Button buttonTwoo;
        private PictureBox pictureBox1;
        private Button hideLightButton;
        private Button aceBackButt;
        private Button aceFrontButt;
        private PictureBox aceBack;
        private PictureBox aceFront;
        private Button exitButt;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label outputLabel;
        private Button readInputButt;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private GroupBox groupBox1;

        public EventHandler thirdButton_Click { get; private set; }
    }
}