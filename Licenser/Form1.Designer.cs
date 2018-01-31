namespace Licenser
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_loadPrivateKey = new System.Windows.Forms.Button();
            this.textBox_license = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.textBox_verify = new System.Windows.Forms.TextBox();
            this.button_verify = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_publicKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.86831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.13169F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_fileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_loadPrivateKey, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_generate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_license, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_verify, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_publicKey, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_verify, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fileName.Location = new System.Drawing.Point(119, 3);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(364, 20);
            this.textBox_fileName.TabIndex = 0;
            // 
            // button_loadPrivateKey
            // 
            this.button_loadPrivateKey.Location = new System.Drawing.Point(3, 3);
            this.button_loadPrivateKey.Name = "button_loadPrivateKey";
            this.button_loadPrivateKey.Size = new System.Drawing.Size(108, 22);
            this.button_loadPrivateKey.TabIndex = 1;
            this.button_loadPrivateKey.Text = "Load Private Key";
            this.button_loadPrivateKey.UseVisualStyleBackColor = true;
            this.button_loadPrivateKey.Click += new System.EventHandler(this.button_loadPrivateKey_Click);
            // 
            // textBox_license
            // 
            this.textBox_license.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_license.Location = new System.Drawing.Point(119, 67);
            this.textBox_license.Name = "textBox_license";
            this.textBox_license.ReadOnly = true;
            this.textBox_license.Size = new System.Drawing.Size(364, 20);
            this.textBox_license.TabIndex = 2;
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(3, 67);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(109, 23);
            this.button_generate.TabIndex = 3;
            this.button_generate.Text = "Generate License";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // textBox_verify
            // 
            this.textBox_verify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_verify.Location = new System.Drawing.Point(119, 147);
            this.textBox_verify.Name = "textBox_verify";
            this.textBox_verify.Size = new System.Drawing.Size(364, 20);
            this.textBox_verify.TabIndex = 4;
            // 
            // button_verify
            // 
            this.button_verify.Location = new System.Drawing.Point(3, 147);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(108, 23);
            this.button_verify.TabIndex = 5;
            this.button_verify.Text = "Verify License";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // label_message
            // 
            this.label_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(3, 178);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 13);
            this.label_message.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Public Key";
            // 
            // textBox_publicKey
            // 
            this.textBox_publicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_publicKey.Location = new System.Drawing.Point(119, 121);
            this.textBox_publicKey.Name = "textBox_publicKey";
            this.textBox_publicKey.Size = new System.Drawing.Size(364, 20);
            this.textBox_publicKey.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 196);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Button button_loadPrivateKey;
        private System.Windows.Forms.TextBox textBox_license;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox textBox_verify;
        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_publicKey;
    }
}

