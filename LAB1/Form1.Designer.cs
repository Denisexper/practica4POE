namespace LAB1
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
            this.titulolabel = new System.Windows.Forms.Label();
            this.jugutescombobox = new System.Windows.Forms.ComboBox();
            this.jugueteslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.titulolabel.Location = new System.Drawing.Point(12, 18);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(197, 26);
            this.titulolabel.TabIndex = 0;
            this.titulolabel.Text = "TIENDA CHEROS";
            // 
            // jugutescombobox
            // 
            this.jugutescombobox.FormattingEnabled = true;
            this.jugutescombobox.Location = new System.Drawing.Point(12, 115);
            this.jugutescombobox.Name = "jugutescombobox";
            this.jugutescombobox.Size = new System.Drawing.Size(216, 28);
            this.jugutescombobox.TabIndex = 1;
            // 
            // jugueteslabel
            // 
            this.jugueteslabel.AutoSize = true;
            this.jugueteslabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jugueteslabel.Location = new System.Drawing.Point(12, 78);
            this.jugueteslabel.Name = "jugueteslabel";
            this.jugueteslabel.Size = new System.Drawing.Size(427, 25);
            this.jugueteslabel.TabIndex = 2;
            this.jugueteslabel.Text = "Seleccionar juguete queu deseas comprar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jugueteslabel);
            this.Controls.Add(this.jugutescombobox);
            this.Controls.Add(this.titulolabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titulolabel;
        private ComboBox jugutescombobox;
        private Label jugueteslabel;
    }
}