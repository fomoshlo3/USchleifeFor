namespace USchleifeFor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblOutput = new System.Windows.Forms.Label();
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(12, 9);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(34, 15);
            this.LblOutput.TabIndex = 0;
            this.LblOutput.Text = "(leer)";
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(417, 9);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 1;
            this.CmdAnzeigen1.Text = "Anzeigen 1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(417, 38);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 2;
            this.CmdAnzeigen2.Text = "Anzeigen 2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(504, 364);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Controls.Add(this.LblOutput);
            this.Name = "MainForm";
            this.Text = "USchleifeFor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblOutput;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
    }
}