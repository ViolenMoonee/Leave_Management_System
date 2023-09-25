namespace ViolenMoonee_Leave_Managment_System
{
    partial class LeaverequesrForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtreason = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btmviewNote = new System.Windows.Forms.Button();
            this.Btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apply for leave ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(62, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(62, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start date of leave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(62, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "End date of leave";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(62, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reason for the leave";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(213, 76);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(200, 20);
            this.txtfullname.TabIndex = 5;
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(213, 122);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(200, 20);
            this.DateStart.TabIndex = 6;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(213, 180);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(200, 20);
            this.DateEnd.TabIndex = 7;
            // 
            // txtreason
            // 
            this.txtreason.Location = new System.Drawing.Point(213, 237);
            this.txtreason.Multiline = true;
            this.txtreason.Name = "txtreason";
            this.txtreason.Size = new System.Drawing.Size(202, 90);
            this.txtreason.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(66, 409);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 42);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btmviewNote
            // 
            this.btmviewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btmviewNote.Location = new System.Drawing.Point(233, 409);
            this.btmviewNote.Name = "btmviewNote";
            this.btmviewNote.Size = new System.Drawing.Size(121, 42);
            this.btmviewNote.TabIndex = 10;
            this.btmviewNote.Text = "Search Status";
            this.btmviewNote.UseVisualStyleBackColor = true;
            this.btmviewNote.Click += new System.EventHandler(this.btmviewNote_Click);
            // 
            // Btnlogout
            // 
            this.Btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btnlogout.Location = new System.Drawing.Point(408, 409);
            this.Btnlogout.Name = "Btnlogout";
            this.Btnlogout.Size = new System.Drawing.Size(121, 42);
            this.Btnlogout.TabIndex = 11;
            this.Btnlogout.Text = "Logout";
            this.Btnlogout.UseVisualStyleBackColor = true;
            this.Btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // LeaverequesrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(577, 479);
            this.Controls.Add(this.Btnlogout);
            this.Controls.Add(this.btmviewNote);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtreason);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LeaverequesrForm";
            this.Text = "LeaverequesrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btmviewNote;
        private System.Windows.Forms.Button Btnlogout;
    }
}