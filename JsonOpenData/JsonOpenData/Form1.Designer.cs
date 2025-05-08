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
            this.SuspendLayout();
            // 
            // btnInlezenData
            // 
            this.btnInlezenData.Location = new System.Drawing.Point(218, 73);
            this.btnInlezenData.Name = "btnInlezenData";
            this.btnInlezenData.Size = new System.Drawing.Size(75, 23);
            this.btnInlezenData.TabIndex = 0;
            this.btnInlezenData.Text = "Inlezen data";
            this.btnInlezenData.UseVisualStyleBackColor = true;
            // 
            // lsbScholen
            // 
            this.lsbScholen.FormattingEnabled = true;
            this.lsbScholen.Location = new System.Drawing.Point(79, 143);
            this.lsbScholen.Name = "lsbScholen";
            this.lsbScholen.Size = new System.Drawing.Size(597, 277);
            this.lsbScholen.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbScholen);
            this.Controls.Add(this.btnInlezenData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInlezenData;
        private System.Windows.Forms.ListBox lsbScholen;
    }
}

