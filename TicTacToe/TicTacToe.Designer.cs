namespace TicTacToe
{
    partial class TicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Mesh1 = new System.Windows.Forms.TextBox();
            this.Mesh5 = new System.Windows.Forms.TextBox();
            this.Mesh2 = new System.Windows.Forms.TextBox();
            this.Mesh3 = new System.Windows.Forms.TextBox();
            this.Mesh6 = new System.Windows.Forms.TextBox();
            this.Mesh9 = new System.Windows.Forms.TextBox();
            this.Mesh8 = new System.Windows.Forms.TextBox();
            this.Mesh7 = new System.Windows.Forms.TextBox();
            this.Mesh4 = new System.Windows.Forms.TextBox();
            this.Error1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(116, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nick name: ";
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NickNameLabel.Location = new System.Drawing.Point(226, 12);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(50, 25);
            this.NickNameLabel.TabIndex = 2;
            this.NickNameLabel.Text = "Nick";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(180, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 18);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(180, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 18);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(313, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 424);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(464, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 424);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Mesh1
            // 
            this.Mesh1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh1.Location = new System.Drawing.Point(180, 120);
            this.Mesh1.Multiline = true;
            this.Mesh1.Name = "Mesh1";
            this.Mesh1.ReadOnly = true;
            this.Mesh1.Size = new System.Drawing.Size(133, 135);
            this.Mesh1.TabIndex = 7;
            this.Mesh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh1.Click += new System.EventHandler(this.Mesh_Clicked);
            this.Mesh1.TextChanged += new System.EventHandler(this.TicTacToe_Load);
            // 
            // Mesh5
            // 
            this.Mesh5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh5.Location = new System.Drawing.Point(332, 270);
            this.Mesh5.Multiline = true;
            this.Mesh5.Name = "Mesh5";
            this.Mesh5.ReadOnly = true;
            this.Mesh5.Size = new System.Drawing.Size(132, 135);
            this.Mesh5.TabIndex = 8;
            this.Mesh5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh5.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh2
            // 
            this.Mesh2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh2.Location = new System.Drawing.Point(332, 120);
            this.Mesh2.Multiline = true;
            this.Mesh2.Name = "Mesh2";
            this.Mesh2.ReadOnly = true;
            this.Mesh2.Size = new System.Drawing.Size(132, 135);
            this.Mesh2.TabIndex = 9;
            this.Mesh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh2.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh3
            // 
            this.Mesh3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh3.Location = new System.Drawing.Point(488, 120);
            this.Mesh3.Multiline = true;
            this.Mesh3.Name = "Mesh3";
            this.Mesh3.ReadOnly = true;
            this.Mesh3.Size = new System.Drawing.Size(135, 135);
            this.Mesh3.TabIndex = 10;
            this.Mesh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh3.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh6
            // 
            this.Mesh6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh6.Location = new System.Drawing.Point(488, 270);
            this.Mesh6.Multiline = true;
            this.Mesh6.Name = "Mesh6";
            this.Mesh6.ReadOnly = true;
            this.Mesh6.Size = new System.Drawing.Size(135, 135);
            this.Mesh6.TabIndex = 11;
            this.Mesh6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh6.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh9
            // 
            this.Mesh9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh9.Location = new System.Drawing.Point(488, 420);
            this.Mesh9.Multiline = true;
            this.Mesh9.Name = "Mesh9";
            this.Mesh9.ReadOnly = true;
            this.Mesh9.Size = new System.Drawing.Size(135, 124);
            this.Mesh9.TabIndex = 12;
            this.Mesh9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh9.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh8
            // 
            this.Mesh8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh8.Location = new System.Drawing.Point(332, 420);
            this.Mesh8.Multiline = true;
            this.Mesh8.Name = "Mesh8";
            this.Mesh8.ReadOnly = true;
            this.Mesh8.Size = new System.Drawing.Size(132, 124);
            this.Mesh8.TabIndex = 13;
            this.Mesh8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh8.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh7
            // 
            this.Mesh7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh7.Location = new System.Drawing.Point(180, 420);
            this.Mesh7.Multiline = true;
            this.Mesh7.Name = "Mesh7";
            this.Mesh7.ReadOnly = true;
            this.Mesh7.Size = new System.Drawing.Size(133, 124);
            this.Mesh7.TabIndex = 14;
            this.Mesh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh7.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Mesh4
            // 
            this.Mesh4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mesh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mesh4.Location = new System.Drawing.Point(180, 270);
            this.Mesh4.Multiline = true;
            this.Mesh4.Name = "Mesh4";
            this.Mesh4.ReadOnly = true;
            this.Mesh4.Size = new System.Drawing.Size(133, 135);
            this.Mesh4.TabIndex = 15;
            this.Mesh4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesh4.Click += new System.EventHandler(this.Mesh_Clicked);
            // 
            // Error1
            // 
            this.Error1.AutoSize = true;
            this.Error1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Error1.ForeColor = System.Drawing.Color.Red;
            this.Error1.Location = new System.Drawing.Point(606, 559);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(165, 20);
            this.Error1.TabIndex = 16;
            this.Error1.Text = "This field is taken!";
            this.Error1.Visible = false;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.Mesh4);
            this.Controls.Add(this.Mesh7);
            this.Controls.Add(this.Mesh8);
            this.Controls.Add(this.Mesh9);
            this.Controls.Add(this.Mesh6);
            this.Controls.Add(this.Mesh3);
            this.Controls.Add(this.Mesh2);
            this.Controls.Add(this.Mesh5);
            this.Controls.Add(this.Mesh1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NickNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Mesh1;
        private System.Windows.Forms.TextBox Mesh5;
        private System.Windows.Forms.TextBox Mesh2;
        private System.Windows.Forms.TextBox Mesh3;
        private System.Windows.Forms.TextBox Mesh6;
        private System.Windows.Forms.TextBox Mesh9;
        private System.Windows.Forms.TextBox Mesh8;
        private System.Windows.Forms.TextBox Mesh7;
        private System.Windows.Forms.TextBox Mesh4;
        private System.Windows.Forms.Label Error1;
    }
}