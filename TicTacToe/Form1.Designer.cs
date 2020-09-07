namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComboBoxCrossOrNought = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(106, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "X / O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nick name:";
            // 
            // NickNameBox
            // 
            this.NickNameBox.Location = new System.Drawing.Point(16, 218);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(274, 22);
            this.NickNameBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(168, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start the game!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ComboBoxCrossOrNought
            // 
            this.ComboBoxCrossOrNought.FormattingEnabled = true;
            this.ComboBoxCrossOrNought.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.ComboBoxCrossOrNought.Items.AddRange(new object[] {
            "Crosses",
            "Noughts"});
            this.ComboBoxCrossOrNought.Location = new System.Drawing.Point(420, 151);
            this.ComboBoxCrossOrNought.Name = "ComboBoxCrossOrNought";
            this.ComboBoxCrossOrNought.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxCrossOrNought.TabIndex = 4;
            this.ComboBoxCrossOrNought.Text = "Crosses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose crosses or noughts:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxCrossOrNought);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NickNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Beginning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Closing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxCrossOrNought;
    }
}

