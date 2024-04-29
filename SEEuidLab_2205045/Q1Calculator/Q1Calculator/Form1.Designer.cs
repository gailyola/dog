namespace Q1Calculator
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
            this.txtMainBox = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMainBox
            // 
            this.txtMainBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainBox.Location = new System.Drawing.Point(12, 12);
            this.txtMainBox.Name = "txtMainBox";
            this.txtMainBox.Size = new System.Drawing.Size(270, 38);
            this.txtMainBox.TabIndex = 0;
            this.txtMainBox.Text = "0";
            this.txtMainBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMainBox.TextChanged += new System.EventHandler(this.txtMainBox_TextChanged);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(12, 273);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(201, 43);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(12, 224);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(63, 43);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(81, 224);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(63, 43);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(219, 273);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(63, 43);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(150, 224);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(63, 43);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(150, 175);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(63, 43);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(12, 175);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(63, 43);
            this.btnFour.TabIndex = 7;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(81, 175);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(63, 43);
            this.btnFive.TabIndex = 8;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 126);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(63, 43);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(81, 126);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(63, 43);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(150, 126);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(63, 43);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 43);
            this.btnClear.TabIndex = 14;
            this.btnClear.Tag = "";
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(219, 224);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(63, 43);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(219, 175);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(63, 43);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(219, 126);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(63, 43);
            this.btnMultiplication.TabIndex = 17;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(219, 77);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(63, 43);
            this.btnDivision.TabIndex = 18;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(12, 77);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(132, 43);
            this.btnOff.TabIndex = 19;
            this.btnOff.Text = "off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 329);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtMainBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainBox;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnOff;
    }
}

