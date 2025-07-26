namespace QueueLine_UI.UserControls
{
    partial class ctrlTicketController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIsuueTicket = new System.Windows.Forms.Button();
            this.btnRecall = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMarkServed = new System.Windows.Forms.Button();
            this.lblCurrentTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnIsuueTicket);
            this.panel1.Controls.Add(this.btnRecall);
            this.panel1.Controls.Add(this.btnSkip);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnMarkServed);
            this.panel1.Controls.Add(this.lblCurrentTicket);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 380);
            this.panel1.TabIndex = 2;
            // 
            // btnIsuueTicket
            // 
            this.btnIsuueTicket.BackColor = System.Drawing.Color.White;
            this.btnIsuueTicket.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIsuueTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIsuueTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIsuueTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsuueTicket.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsuueTicket.ForeColor = System.Drawing.Color.Black;
            this.btnIsuueTicket.Location = new System.Drawing.Point(103, 322);
            this.btnIsuueTicket.Name = "btnIsuueTicket";
            this.btnIsuueTicket.Size = new System.Drawing.Size(149, 53);
            this.btnIsuueTicket.TabIndex = 6;
            this.btnIsuueTicket.Text = "Issue Ticket ✅ ";
            this.btnIsuueTicket.UseVisualStyleBackColor = false;
            this.btnIsuueTicket.Click += new System.EventHandler(this.btnIsuueTicket_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecall.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecall.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecall.ForeColor = System.Drawing.Color.White;
            this.btnRecall.Location = new System.Drawing.Point(129, 202);
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.Size = new System.Drawing.Size(107, 47);
            this.btnRecall.TabIndex = 5;
            this.btnRecall.Text = "ReCall";
            this.btnRecall.UseVisualStyleBackColor = false;
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSkip.FlatAppearance.BorderSize = 2;
            this.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(244, 202);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(104, 47);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(8, 202);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 47);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Call Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMarkServed
            // 
            this.btnMarkServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnMarkServed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkServed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMarkServed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMarkServed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMarkServed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkServed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkServed.ForeColor = System.Drawing.Color.White;
            this.btnMarkServed.Location = new System.Drawing.Point(67, 263);
            this.btnMarkServed.Name = "btnMarkServed";
            this.btnMarkServed.Size = new System.Drawing.Size(225, 53);
            this.btnMarkServed.TabIndex = 2;
            this.btnMarkServed.Text = "Mark as Served ✅ ";
            this.btnMarkServed.UseVisualStyleBackColor = false;
            this.btnMarkServed.Click += new System.EventHandler(this.btnMarkServed_Click);
            // 
            // lblCurrentTicket
            // 
            this.lblCurrentTicket.AutoSize = true;
            this.lblCurrentTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentTicket.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTicket.Location = new System.Drawing.Point(154, 82);
            this.lblCurrentTicket.Name = "lblCurrentTicket";
            this.lblCurrentTicket.Size = new System.Drawing.Size(30, 34);
            this.lblCurrentTicket.TabIndex = 1;
            this.lblCurrentTicket.Text = "  ";
            this.lblCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Ticket";
            // 
            // ctrlTicketController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlTicketController";
            this.Size = new System.Drawing.Size(368, 390);
            this.Load += new System.EventHandler(this.ctrlServeTicket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecall;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMarkServed;
        private System.Windows.Forms.Label lblCurrentTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIsuueTicket;
    }
}
