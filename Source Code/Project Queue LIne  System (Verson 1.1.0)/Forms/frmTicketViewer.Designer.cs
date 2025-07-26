namespace QueueLine_Project.Forms
{
    partial class frmTicketViewer
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
            this.ctrlTicketViewer1 = new QueueLine_Project.usercontrols.ctrlTicketViewer();
            this.SuspendLayout();
            // 
            // ctrlTicketViewer1
            // 
            this.ctrlTicketViewer1.Location = new System.Drawing.Point(-1, -1);
            this.ctrlTicketViewer1.Name = "ctrlTicketViewer1";
            this.ctrlTicketViewer1.Size = new System.Drawing.Size(397, 721);
            this.ctrlTicketViewer1.TabIndex = 0;
            // 
            // frmTicketViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 719);
            this.Controls.Add(this.ctrlTicketViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTicketViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTicketViewer_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private usercontrols.ctrlTicketViewer ctrlTicketViewer1;
    }
}