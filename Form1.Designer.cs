namespace Towny_Calculator
{
    partial class TownyCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TownyCalculator));
            this.gold1 = new System.Windows.Forms.TextBox();
            this.chunks1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chunksRES1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.goldRES1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gold1
            // 
            this.gold1.BackColor = System.Drawing.Color.GreenYellow;
            this.gold1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gold1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gold1.Location = new System.Drawing.Point(294, 35);
            this.gold1.Margin = new System.Windows.Forms.Padding(8);
            this.gold1.Name = "gold1";
            this.gold1.Size = new System.Drawing.Size(137, 42);
            this.gold1.TabIndex = 0;
            this.gold1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chunks1
            // 
            this.chunks1.BackColor = System.Drawing.Color.GreenYellow;
            this.chunks1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chunks1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chunks1.Location = new System.Drawing.Point(294, 167);
            this.chunks1.Margin = new System.Windows.Forms.Padding(8);
            this.chunks1.Name = "chunks1";
            this.chunks1.Size = new System.Drawing.Size(137, 42);
            this.chunks1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "How much gold do you have";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many chunks do you";
            // 
            // chunksRES1
            // 
            this.chunksRES1.BackColor = System.Drawing.Color.GreenYellow;
            this.chunksRES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chunksRES1.Enabled = false;
            this.chunksRES1.Location = new System.Drawing.Point(533, 48);
            this.chunksRES1.Name = "chunksRES1";
            this.chunksRES1.Size = new System.Drawing.Size(195, 42);
            this.chunksRES1.TabIndex = 9;
            this.chunksRES1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(433, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "How many chunks can you get:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-395, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(3031, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "—————————————————————————————————————————————————————————————————————————————————" +
    "———————————————————————";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(171, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "want to get";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(442, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "How much gold do you need:";
            // 
            // goldRES1
            // 
            this.goldRES1.BackColor = System.Drawing.Color.GreenYellow;
            this.goldRES1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goldRES1.Enabled = false;
            this.goldRES1.Location = new System.Drawing.Point(533, 185);
            this.goldRES1.Name = "goldRES1";
            this.goldRES1.Size = new System.Drawing.Size(195, 42);
            this.goldRES1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(452, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(452, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TownyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(745, 253);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goldRES1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chunksRES1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chunks1);
            this.Controls.Add(this.gold1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "TownyCalculator";
            this.Text = "Towny Chunks Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gold1;
        private System.Windows.Forms.TextBox chunks1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chunksRES1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox goldRES1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

