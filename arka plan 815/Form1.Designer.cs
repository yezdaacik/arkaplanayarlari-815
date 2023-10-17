namespace arka_plan_815
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
            this.rbRenk1 = new System.Windows.Forms.RadioButton();
            this.rbRenk2 = new System.Windows.Forms.RadioButton();
            this.btnUygula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRenk1
            // 
            this.rbRenk1.AutoSize = true;
            this.rbRenk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk1.Location = new System.Drawing.Point(44, 38);
            this.rbRenk1.Name = "rbRenk1";
            this.rbRenk1.Size = new System.Drawing.Size(92, 20);
            this.rbRenk1.TabIndex = 0;
            this.rbRenk1.TabStop = true;
            this.rbRenk1.Text = "Dark Mode";
            this.rbRenk1.UseVisualStyleBackColor = true;
            // 
            // rbRenk2
            // 
            this.rbRenk2.AutoSize = true;
            this.rbRenk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRenk2.Location = new System.Drawing.Point(44, 61);
            this.rbRenk2.Name = "rbRenk2";
            this.rbRenk2.Size = new System.Drawing.Size(91, 20);
            this.rbRenk2.TabIndex = 1;
            this.rbRenk2.TabStop = true;
            this.rbRenk2.Text = "Light Mode";
            this.rbRenk2.UseVisualStyleBackColor = true;
            // 
            // btnUygula
            // 
            this.btnUygula.Location = new System.Drawing.Point(57, 107);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(75, 23);
            this.btnUygula.TabIndex = 2;
            this.btnUygula.Text = "Uygula";
            this.btnUygula.UseVisualStyleBackColor = true;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 171);
            this.Controls.Add(this.btnUygula);
            this.Controls.Add(this.rbRenk2);
            this.Controls.Add(this.rbRenk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRenk1;
        private System.Windows.Forms.RadioButton rbRenk2;
        private System.Windows.Forms.Button btnUygula;
    }
}

