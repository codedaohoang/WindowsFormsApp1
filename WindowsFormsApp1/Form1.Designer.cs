
namespace WindowsFormsApp1
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
            this.txtson = new System.Windows.Forms.TextBox();
            this.txtsom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCountPerfectSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonPerfectSquare = new System.Windows.Forms.RadioButton();
            this.radioButtonCountPrime = new System.Windows.Forms.RadioButton();
            this.radioButtonPrime = new System.Windows.Forms.RadioButton();
            this.radioButtonDivisible = new System.Windows.Forms.RadioButton();
            this.radioButtonEven = new System.Windows.Forms.RadioButton();
            this.radioButtonProduct = new System.Windows.Forms.RadioButton();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực hiện phép tính";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số n";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "so m";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtson
            // 
            this.txtson.Location = new System.Drawing.Point(113, 138);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(100, 20);
            this.txtson.TabIndex = 1;
            this.txtson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsom
            // 
            this.txtsom.Location = new System.Drawing.Point(113, 208);
            this.txtsom.Name = "txtsom";
            this.txtsom.Size = new System.Drawing.Size(100, 20);
            this.txtsom.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCountPerfectSquare);
            this.groupBox1.Controls.Add(this.radioButtonPerfectSquare);
            this.groupBox1.Controls.Add(this.radioButtonCountPrime);
            this.groupBox1.Controls.Add(this.radioButtonPrime);
            this.groupBox1.Controls.Add(this.radioButtonDivisible);
            this.groupBox1.Controls.Add(this.radioButtonEven);
            this.groupBox1.Controls.Add(this.radioButtonProduct);
            this.groupBox1.Controls.Add(this.radioButtonSum);
            this.groupBox1.Location = new System.Drawing.Point(588, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chuc nang";
            // 
            // radioButtonCountPerfectSquare
            // 
            this.radioButtonCountPerfectSquare.AutoSize = true;
            this.radioButtonCountPerfectSquare.Location = new System.Drawing.Point(6, 181);
            this.radioButtonCountPerfectSquare.Name = "radioButtonCountPerfectSquare";
            this.radioButtonCountPerfectSquare.Size = new System.Drawing.Size(131, 17);
            this.radioButtonCountPerfectSquare.TabIndex = 0;
            this.radioButtonCountPerfectSquare.TabStop = true;
            this.radioButtonCountPerfectSquare.Text = "Đếm số chính phương";
            this.radioButtonCountPerfectSquare.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerfectSquare
            // 
            this.radioButtonPerfectSquare.AutoSize = true;
            this.radioButtonPerfectSquare.Location = new System.Drawing.Point(6, 158);
            this.radioButtonPerfectSquare.Name = "radioButtonPerfectSquare";
            this.radioButtonPerfectSquare.Size = new System.Drawing.Size(141, 17);
            this.radioButtonPerfectSquare.TabIndex = 0;
            this.radioButtonPerfectSquare.TabStop = true;
            this.radioButtonPerfectSquare.Text = "Liệt kê số chính phương";
            this.radioButtonPerfectSquare.UseVisualStyleBackColor = true;
            this.radioButtonPerfectSquare.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButtonCountPrime
            // 
            this.radioButtonCountPrime.AutoSize = true;
            this.radioButtonCountPrime.Location = new System.Drawing.Point(6, 135);
            this.radioButtonCountPrime.Name = "radioButtonCountPrime";
            this.radioButtonCountPrime.Size = new System.Drawing.Size(111, 17);
            this.radioButtonCountPrime.TabIndex = 0;
            this.radioButtonCountPrime.TabStop = true;
            this.radioButtonCountPrime.Text = "Đếm số nguyên tố";
            this.radioButtonCountPrime.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrime
            // 
            this.radioButtonPrime.AutoSize = true;
            this.radioButtonPrime.Location = new System.Drawing.Point(7, 112);
            this.radioButtonPrime.Name = "radioButtonPrime";
            this.radioButtonPrime.Size = new System.Drawing.Size(121, 17);
            this.radioButtonPrime.TabIndex = 0;
            this.radioButtonPrime.TabStop = true;
            this.radioButtonPrime.Text = "Liệt kê số nguyên tố";
            this.radioButtonPrime.UseVisualStyleBackColor = true;
            this.radioButtonPrime.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonDivisible
            // 
            this.radioButtonDivisible.AutoSize = true;
            this.radioButtonDivisible.Location = new System.Drawing.Point(6, 89);
            this.radioButtonDivisible.Name = "radioButtonDivisible";
            this.radioButtonDivisible.Size = new System.Drawing.Size(166, 17);
            this.radioButtonDivisible.TabIndex = 0;
            this.radioButtonDivisible.TabStop = true;
            this.radioButtonDivisible.Text = "Liệt kê số chia hết cho 2 và 3";
            this.radioButtonDivisible.UseVisualStyleBackColor = true;
            // 
            // radioButtonEven
            // 
            this.radioButtonEven.AutoSize = true;
            this.radioButtonEven.Location = new System.Drawing.Point(7, 66);
            this.radioButtonEven.Name = "radioButtonEven";
            this.radioButtonEven.Size = new System.Drawing.Size(98, 17);
            this.radioButtonEven.TabIndex = 0;
            this.radioButtonEven.TabStop = true;
            this.radioButtonEven.Text = "Liệt kê số chẵn";
            this.radioButtonEven.UseVisualStyleBackColor = true;
            this.radioButtonEven.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonProduct
            // 
            this.radioButtonProduct.AutoSize = true;
            this.radioButtonProduct.Location = new System.Drawing.Point(7, 43);
            this.radioButtonProduct.Name = "radioButtonProduct";
            this.radioButtonProduct.Size = new System.Drawing.Size(82, 17);
            this.radioButtonProduct.TabIndex = 0;
            this.radioButtonProduct.TabStop = true;
            this.radioButtonProduct.Text = "Tích dãy số";
            this.radioButtonProduct.UseVisualStyleBackColor = true;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(87, 17);
            this.radioButtonSum.TabIndex = 0;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Tổng dãy số ";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số m";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(113, 280);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(206, 20);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.txtsom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.TextBox txtsom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCountPerfectSquare;
        private System.Windows.Forms.RadioButton radioButtonPerfectSquare;
        private System.Windows.Forms.RadioButton radioButtonCountPrime;
        private System.Windows.Forms.RadioButton radioButtonPrime;
        private System.Windows.Forms.RadioButton radioButtonDivisible;
        private System.Windows.Forms.RadioButton radioButtonEven;
        private System.Windows.Forms.RadioButton radioButtonProduct;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label5;
    }
}

