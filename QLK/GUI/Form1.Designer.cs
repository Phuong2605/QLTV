namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMTS = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.btnSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RenderBody = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư viện Học viện Kỹ thuật Quân sự";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnMTS);
            this.panel2.Controls.Add(this.btnNghiepVu);
            this.panel2.Controls.Add(this.btnSach);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 417);
            this.panel2.TabIndex = 1;
            // 
            // btnMTS
            // 
            this.btnMTS.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnMTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMTS.Location = new System.Drawing.Point(0, 219);
            this.btnMTS.Name = "btnMTS";
            this.btnMTS.Size = new System.Drawing.Size(136, 43);
            this.btnMTS.TabIndex = 4;
            this.btnMTS.Text = "Mượn trả sách";
            this.btnMTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMTS.UseVisualStyleBackColor = true;
            // 
            // btnNghiepVu
            // 
            this.btnNghiepVu.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiepVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 170);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(136, 43);
            this.btnNghiepVu.TabIndex = 3;
            this.btnNghiepVu.Text = "Quản Lý Nghiệp Vụ";
            this.btnNghiepVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNghiepVu.UseVisualStyleBackColor = true;
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            // 
            // btnSach
            // 
            this.btnSach.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSach.Location = new System.Drawing.Point(0, 121);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(136, 43);
            this.btnSach.TabIndex = 2;
            this.btnSach.Text = "Quản Lý Sách";
            this.btnSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // RenderBody
            // 
            this.RenderBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RenderBody.Location = new System.Drawing.Point(137, 53);
            this.RenderBody.Name = "RenderBody";
            this.RenderBody.Size = new System.Drawing.Size(790, 416);
            this.RenderBody.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::GUI.Properties.Resources.ưew;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 114);
            this.panel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 471);
            this.Controls.Add(this.RenderBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel RenderBody;
        private System.Windows.Forms.Button btnMTS;
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Panel panel4;
    }
}

