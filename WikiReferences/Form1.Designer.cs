namespace WikiReferences
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
            this.btnGetReferences = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetReferences
            // 
            this.btnGetReferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetReferences.Location = new System.Drawing.Point(41, 49);
            this.btnGetReferences.Name = "btnGetReferences";
            this.btnGetReferences.Size = new System.Drawing.Size(250, 35);
            this.btnGetReferences.TabIndex = 0;
            this.btnGetReferences.Text = "Get References";
            this.btnGetReferences.UseVisualStyleBackColor = true;
            this.btnGetReferences.Click += new System.EventHandler(this.btnGetReferences_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(41, 23);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(250, 20);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://en.wikipedia.org/wiki/Grammy_Award_for_Song_of_the_Year";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 550);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 676);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnGetReferences);
            this.Name = "Form1";
            this.Text = "Wiki References";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetReferences;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ListBox listBox1;
    }
}

