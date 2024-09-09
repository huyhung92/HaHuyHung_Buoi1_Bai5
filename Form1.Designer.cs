namespace HaHuyHung_Buoi1_Bai5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtso = new TextBox();
            txtkq = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 23);
            label1.Name = "label1";
            label1.Size = new Size(212, 29);
            label1.TabIndex = 0;
            label1.Text = "Đọc Số Thành Chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 88);
            label2.Name = "label2";
            label2.Size = new Size(234, 29);
            label2.TabIndex = 1;
            label2.Text = "Nhập n (Từ 1 đến 9)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 155);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(83, 245);
            button1.Name = "button1";
            button1.Size = new Size(211, 41);
            button1.TabIndex = 3;
            button1.Text = "Thực Hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(432, 245);
            button2.Name = "button2";
            button2.Size = new Size(201, 41);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtso
            // 
            txtso.Location = new Point(351, 92);
            txtso.Name = "txtso";
            txtso.Size = new Size(250, 27);
            txtso.TabIndex = 5;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(351, 155);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(250, 27);
            txtkq.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtkq);
            Controls.Add(txtso);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox txtso;
        private TextBox txtkq;
    }
}
