namespace BMI
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
            this.gewicht_label = new System.Windows.Forms.Label();
            this.Lengte_label = new System.Windows.Forms.Label();
            this.gewicht_textbox = new System.Windows.Forms.TextBox();
            this.lengte_textbox = new System.Windows.Forms.TextBox();
            this.button_toonBMI = new System.Windows.Forms.Button();
            this.label_BMI = new System.Windows.Forms.Label();
            this.textBox_BMI = new System.Windows.Forms.TextBox();
            this.button_sluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gewicht_label
            // 
            this.gewicht_label.AutoSize = true;
            this.gewicht_label.Location = new System.Drawing.Point(12, 21);
            this.gewicht_label.Name = "gewicht_label";
            this.gewicht_label.Size = new System.Drawing.Size(89, 17);
            this.gewicht_label.TabIndex = 0;
            this.gewicht_label.Text = "gewicht in kg";
            // 
            // Lengte_label
            // 
            this.Lengte_label.AutoSize = true;
            this.Lengte_label.Location = new System.Drawing.Point(12, 49);
            this.Lengte_label.Name = "Lengte_label";
            this.Lengte_label.Size = new System.Drawing.Size(102, 17);
            this.Lengte_label.TabIndex = 1;
            this.Lengte_label.Text = "lengte in meter";
            // 
            // gewicht_textbox
            // 
            this.gewicht_textbox.Location = new System.Drawing.Point(139, 18);
            this.gewicht_textbox.Name = "gewicht_textbox";
            this.gewicht_textbox.ShortcutsEnabled = false;
            this.gewicht_textbox.Size = new System.Drawing.Size(100, 22);
            this.gewicht_textbox.TabIndex = 2;
            this.gewicht_textbox.TextChanged += new System.EventHandler(this.gewicht_textbox_TextChanged);
            // 
            // lengte_textbox
            // 
            this.lengte_textbox.Location = new System.Drawing.Point(139, 46);
            this.lengte_textbox.Name = "lengte_textbox";
            this.lengte_textbox.Size = new System.Drawing.Size(100, 22);
            this.lengte_textbox.TabIndex = 3;
            this.lengte_textbox.TextChanged += new System.EventHandler(this.lengte_textbox_TextChanged);
            // 
            // button_toonBMI
            // 
            this.button_toonBMI.Location = new System.Drawing.Point(139, 87);
            this.button_toonBMI.Name = "button_toonBMI";
            this.button_toonBMI.Size = new System.Drawing.Size(100, 23);
            this.button_toonBMI.TabIndex = 4;
            this.button_toonBMI.Text = "TOON BMI";
            this.button_toonBMI.UseVisualStyleBackColor = true;
            this.button_toonBMI.Click += new System.EventHandler(this.button_toonBMI_Click);
            // 
            // label_BMI
            // 
            this.label_BMI.AutoSize = true;
            this.label_BMI.Location = new System.Drawing.Point(12, 137);
            this.label_BMI.Name = "label_BMI";
            this.label_BMI.Size = new System.Drawing.Size(31, 17);
            this.label_BMI.TabIndex = 5;
            this.label_BMI.Text = "BMI";
            // 
            // textBox_BMI
            // 
            this.textBox_BMI.Location = new System.Drawing.Point(139, 137);
            this.textBox_BMI.Name = "textBox_BMI";
            this.textBox_BMI.Size = new System.Drawing.Size(100, 22);
            this.textBox_BMI.TabIndex = 6;
            this.textBox_BMI.TextChanged += new System.EventHandler(this.textBox_BMI_TextChanged);
            // 
            // button_sluiten
            // 
            this.button_sluiten.Location = new System.Drawing.Point(12, 230);
            this.button_sluiten.Name = "button_sluiten";
            this.button_sluiten.Size = new System.Drawing.Size(75, 23);
            this.button_sluiten.TabIndex = 7;
            this.button_sluiten.Text = "SLUIT";
            this.button_sluiten.UseVisualStyleBackColor = true;
            this.button_sluiten.Click += new System.EventHandler(this.button_sluiten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.button_sluiten);
            this.Controls.Add(this.textBox_BMI);
            this.Controls.Add(this.label_BMI);
            this.Controls.Add(this.button_toonBMI);
            this.Controls.Add(this.lengte_textbox);
            this.Controls.Add(this.gewicht_textbox);
            this.Controls.Add(this.Lengte_label);
            this.Controls.Add(this.gewicht_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gewicht_label;
        private System.Windows.Forms.Label Lengte_label;
        private System.Windows.Forms.TextBox gewicht_textbox;
        private System.Windows.Forms.TextBox lengte_textbox;
        private System.Windows.Forms.Button button_toonBMI;
        private System.Windows.Forms.Label label_BMI;
        private System.Windows.Forms.TextBox textBox_BMI;
        private System.Windows.Forms.Button button_sluiten;
    }
}

