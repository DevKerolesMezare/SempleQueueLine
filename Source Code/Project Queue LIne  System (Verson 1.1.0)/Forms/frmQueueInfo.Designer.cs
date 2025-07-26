namespace QueueLine_Project.Forms
{
    partial class frmQueueInfo
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
            this.ctrlQueueInfo1 = new QueueLine_Project.usercontrols.ctrlQueueInfo();
            this.SuspendLayout();
            // 
            // ctrlQueueInfo1
            // 
            this.ctrlQueueInfo1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ctrlQueueInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrlQueueInfo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlQueueInfo1.Location = new System.Drawing.Point(5, 5);
            this.ctrlQueueInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlQueueInfo1.Name = "ctrlQueueInfo1";
            this.ctrlQueueInfo1.Size = new System.Drawing.Size(367, 453);
            this.ctrlQueueInfo1.TabIndex = 0;
            // 
            // frmQueueInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 464);
            this.Controls.Add(this.ctrlQueueInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQueueInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueueInfo_FormClosing);
            this.ResumeLayout(false);

        }


        #endregion

        private usercontrols.ctrlQueueInfo ctrlQueueInfo1;
    }
}