namespace TokenGenerator
{
    partial class TokenGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenGeneratorForm));
            this.txtTokenOutput = new System.Windows.Forms.TextBox();
            this.bttnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTokenOutput
            // 
            this.txtTokenOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTokenOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokenOutput.Location = new System.Drawing.Point(3, 70);
            this.txtTokenOutput.MaximumSize = new System.Drawing.Size(400, 150);
            this.txtTokenOutput.MaxLength = 50;
            this.txtTokenOutput.MinimumSize = new System.Drawing.Size(250, 35);
            this.txtTokenOutput.Multiline = true;
            this.txtTokenOutput.Name = "txtTokenOutput";
            this.txtTokenOutput.Size = new System.Drawing.Size(278, 35);
            this.txtTokenOutput.TabIndex = 7;
            // 
            // bttnGenerate
            // 
            this.bttnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnGenerate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnGenerate.Location = new System.Drawing.Point(3, 10);
            this.bttnGenerate.MaximumSize = new System.Drawing.Size(300, 150);
            this.bttnGenerate.MinimumSize = new System.Drawing.Size(250, 35);
            this.bttnGenerate.Name = "bttnGenerate";
            this.bttnGenerate.Size = new System.Drawing.Size(278, 35);
            this.bttnGenerate.TabIndex = 8;
            this.bttnGenerate.Text = "Generate Security Token";
            this.bttnGenerate.UseVisualStyleBackColor = false;
            this.bttnGenerate.Click += new System.EventHandler(this.bttnGenerate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.78125F));
            this.tableLayoutPanel1.Controls.Add(this.bttnGenerate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTokenOutput, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 111);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TokenGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "TokenGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Token Generator";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bttnGenerate;
        private System.Windows.Forms.TextBox txtTokenOutput;
    }
}

