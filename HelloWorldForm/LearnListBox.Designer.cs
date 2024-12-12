namespace HelloWorldForm
{
    partial class LearnListBox
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
            this.listBoxMonths = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMonths
            // 
            this.listBoxMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBoxMonths.FormattingEnabled = true;
            this.listBoxMonths.ItemHeight = 29;
            this.listBoxMonths.Location = new System.Drawing.Point(254, 45);
            this.listBoxMonths.Name = "listBoxMonths";
            this.listBoxMonths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMonths.Size = new System.Drawing.Size(292, 265);
            this.listBoxMonths.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(235, 349);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(32, 8, 32, 8);
            this.button1.Size = new System.Drawing.Size(331, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display results";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnEventClick);
            // 
            // LearnListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMonths);
            this.Name = "LearnListBox";
            this.Text = "LearnListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMonths;
        private System.Windows.Forms.Button button1;
    }
}