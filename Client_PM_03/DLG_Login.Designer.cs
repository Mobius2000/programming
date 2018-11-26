namespace Client_PM
{
    partial class DLG_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBX_UserName = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.LBLINK_Create = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.CHBX_Remember = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // TBX_UserName
            // 
            this.TBX_UserName.Location = new System.Drawing.Point(108, 91);
            this.TBX_UserName.Name = "TBX_UserName";
            this.TBX_UserName.Size = new System.Drawing.Size(188, 26);
            this.TBX_UserName.TabIndex = 0;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Location = new System.Drawing.Point(108, 141);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(188, 26);
            this.TBX_Password.TabIndex = 1;
            this.TBX_Password.UseSystemPasswordChar = true;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.Location = new System.Drawing.Point(147, 250);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(76, 29);
            this.BTN_Ok.TabIndex = 2;
            this.BTN_Ok.Text = "Login";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // LBLINK_Create
            // 
            this.LBLINK_Create.AutoSize = true;
            this.LBLINK_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLINK_Create.Location = new System.Drawing.Point(16, 257);
            this.LBLINK_Create.Name = "LBLINK_Create";
            this.LBLINK_Create.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLINK_Create.Size = new System.Drawing.Size(104, 16);
            this.LBLINK_Create.TabIndex = 4;
            this.LBLINK_Create.TabStop = true;
            this.LBLINK_Create.Text = "Create one now!";
            this.LBLINK_Create.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LBLINK_Create_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t have account? ";
            // 
            // CHBX_Remember
            // 
            this.CHBX_Remember.AutoSize = true;
            this.CHBX_Remember.Location = new System.Drawing.Point(163, 194);
            this.CHBX_Remember.Name = "CHBX_Remember";
            this.CHBX_Remember.Size = new System.Drawing.Size(133, 24);
            this.CHBX_Remember.TabIndex = 6;
            this.CHBX_Remember.Text = "Remember me";
            this.CHBX_Remember.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Photo Manager";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(229, 250);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 29);
            this.BTN_Cancel.TabIndex = 8;
            this.BTN_Cancel.Text = "Exit";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // DLG_Login
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(316, 291);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CHBX_Remember);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBLINK_Create);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.TBX_Password);
            this.Controls.Add(this.TBX_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DLG_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.DLG_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBX_UserName;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.LinkLabel LBLINK_Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHBX_Remember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}

//Gros penis magique
