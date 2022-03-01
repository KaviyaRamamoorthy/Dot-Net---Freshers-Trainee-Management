namespace Freshers_Management
{
    partial class CreateForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.dobText = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.qualiText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qualification :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(187, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile Number :";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(399, 109);
            this.nameText.Multiline = true;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(241, 34);
            this.nameText.TabIndex = 5;
            this.nameText.Validating += new System.ComponentModel.CancelEventHandler(this.NameText_Validating);
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(397, 344);
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(241, 76);
            this.addressText.TabIndex = 6;
            // 
            // mobileText
            // 
            this.mobileText.Location = new System.Drawing.Point(397, 169);
            this.mobileText.Multiline = true;
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(241, 34);
            this.mobileText.TabIndex = 9;
            this.mobileText.Validating += new System.ComponentModel.CancelEventHandler(this.MobileText_Validating);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Create.Location = new System.Drawing.Point(329, 448);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(149, 45);
            this.Create.TabIndex = 10;
            this.Create.Text = "Add";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click_1);
            // 
            // dobText
            // 
            this.dobText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobText.Location = new System.Drawing.Point(399, 284);
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(239, 32);
            this.dobText.TabIndex = 13;
            this.dobText.Validating += new System.ComponentModel.CancelEventHandler(this.DobText_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ld";
            this.label6.Visible = false;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(399, 77);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 26);
            this.idText.TabIndex = 15;
            this.idText.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // qualiText
            // 
            this.qualiText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualiText.FormattingEnabled = true;
            this.qualiText.Items.AddRange(new object[] {
            "B.Tech",
            "BCA",
            "B.Sc",
            "M.Tech",
            "MCA",
            "M.Sc",
            "Phd"});
            this.qualiText.Location = new System.Drawing.Point(397, 229);
            this.qualiText.Name = "qualiText";
            this.qualiText.Size = new System.Drawing.Size(239, 34);
            this.qualiText.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(324, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fresher Trainee Details";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(878, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qualiText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dobText);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.mobileText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox mobileText;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DateTimePicker dobText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox qualiText;
        private System.Windows.Forms.Label label7;
    }
}