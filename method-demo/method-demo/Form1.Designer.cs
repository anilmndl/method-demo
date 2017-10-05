namespace method_demo
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
            this.LblHello = new System.Windows.Forms.Label();
            this.LblWorld = new System.Windows.Forms.Label();
            this.textBoxTemp1 = new System.Windows.Forms.TextBox();
            this.textBoxTemp2 = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Location = new System.Drawing.Point(71, 45);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(19, 13);
            this.LblHello.TabIndex = 0;
            this.LblHello.Text = "na";
            // 
            // LblWorld
            // 
            this.LblWorld.AutoSize = true;
            this.LblWorld.Location = new System.Drawing.Point(71, 103);
            this.LblWorld.Name = "LblWorld";
            this.LblWorld.Size = new System.Drawing.Size(19, 13);
            this.LblWorld.TabIndex = 1;
            this.LblWorld.Text = "na";
            // 
            // textBoxTemp1
            // 
            this.textBoxTemp1.Location = new System.Drawing.Point(158, 38);
            this.textBoxTemp1.Name = "textBoxTemp1";
            this.textBoxTemp1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemp1.TabIndex = 2;
            // 
            // textBoxTemp2
            // 
            this.textBoxTemp2.Location = new System.Drawing.Point(158, 103);
            this.textBoxTemp2.Name = "textBoxTemp2";
            this.textBoxTemp2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemp2.TabIndex = 3;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(74, 197);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(116, 23);
            this.BtnGo.TabIndex = 4;
            this.BtnGo.Text = "Go Get Them";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.textBoxTemp2);
            this.Controls.Add(this.textBoxTemp1);
            this.Controls.Add(this.LblWorld);
            this.Controls.Add(this.LblHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHello;
        private System.Windows.Forms.Label LblWorld;
        private System.Windows.Forms.TextBox textBoxTemp1;
        private System.Windows.Forms.TextBox textBoxTemp2;
        private System.Windows.Forms.Button BtnGo;
    }
}

