namespace JsonOpenData
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
            this.btnInlezenData = new System.Windows.Forms.Button();
            this.lsbScholen = new System.Windows.Forms.ListBox();
            this.btnInladenDataToiletten = new System.Windows.Forms.Button();
            this.lsbToilettenGent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInlezenData
            // 
            this.btnInlezenData.Location = new System.Drawing.Point(169, 95);
            this.btnInlezenData.Name = "btnInlezenData";
            this.btnInlezenData.Size = new System.Drawing.Size(130, 23);
            this.btnInlezenData.TabIndex = 0;
            this.btnInlezenData.Text = "Inlezen data scholen";
            this.btnInlezenData.UseVisualStyleBackColor = true;
            this.btnInlezenData.Click += new System.EventHandler(this.btnInlezenData_Click);
            // 
            // lsbScholen
            // 
            this.lsbScholen.FormattingEnabled = true;
            this.lsbScholen.Location = new System.Drawing.Point(79, 143);
            this.lsbScholen.Name = "lsbScholen";
            this.lsbScholen.Size = new System.Drawing.Size(324, 277);
            this.lsbScholen.TabIndex = 1;
            // 
            // btnInladenDataToiletten
            // 
            this.btnInladenDataToiletten.Location = new System.Drawing.Point(511, 95);
            this.btnInladenDataToiletten.Name = "btnInladenDataToiletten";
            this.btnInladenDataToiletten.Size = new System.Drawing.Size(130, 23);
            this.btnInladenDataToiletten.TabIndex = 0;
            this.btnInladenDataToiletten.Text = "Toiletten Gent";
            this.btnInladenDataToiletten.UseVisualStyleBackColor = true;
            this.btnInladenDataToiletten.Click += new System.EventHandler(this.btnInladenDataToiletten_Click);
            // 
            // lsbToilettenGent
            // 
            this.lsbToilettenGent.FormattingEnabled = true;
            this.lsbToilettenGent.Location = new System.Drawing.Point(421, 143);
            this.lsbToilettenGent.Name = "lsbToilettenGent";
            this.lsbToilettenGent.Size = new System.Drawing.Size(324, 277);
            this.lsbToilettenGent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbToilettenGent);
            this.Controls.Add(this.btnInladenDataToiletten);
            this.Controls.Add(this.lsbScholen);
            this.Controls.Add(this.btnInlezenData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInlezenData;
        private System.Windows.Forms.ListBox lsbScholen;
        private System.Windows.Forms.Button btnInladenDataToiletten;
        private System.Windows.Forms.ListBox lsbToilettenGent;
    }
}

