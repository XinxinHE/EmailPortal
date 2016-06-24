namespace EmailPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.TextBox();
            this.EmailList = new System.Windows.Forms.ListBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(740, 277);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(237, 20);
            this.Subject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sender";
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(740, 243);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(237, 20);
            this.Sender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Body";
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(740, 310);
            this.Body.Multiline = true;
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(237, 90);
            this.Body.TabIndex = 5;
            this.Body.TextChanged += new System.EventHandler(this.Body_TextChanged);
            // 
            // EmailList
            // 
            this.EmailList.FormattingEnabled = true;
            this.EmailList.Location = new System.Drawing.Point(12, 12);
            this.EmailList.Name = "EmailList";
            this.EmailList.Size = new System.Drawing.Size(224, 329);
            this.EmailList.TabIndex = 6;
            this.EmailList.SelectedIndexChanged += new System.EventHandler(this.EmailList_SelectedIndexChanged);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(242, 12);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(422, 432);
            this.axAcroPDF1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 471);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.EmailList);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Body;
        private System.Windows.Forms.ListBox EmailList;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}

