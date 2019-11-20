namespace BluePrints
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightClick
            // 
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickToolStripMenuItem});
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(99, 26);
            // 
            // clickToolStripMenuItem
            // 
            this.clickToolStripMenuItem.Name = "clickToolStripMenuItem";
            this.clickToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.clickToolStripMenuItem.Text = "click";
            this.clickToolStripMenuItem.Click += new System.EventHandler(this.clickToolStripMenuItem_Click);
            // 
            // compilerBtn
            // 
            this.compilerBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.compilerBtn.Location = new System.Drawing.Point(502, 12);
            this.compilerBtn.Name = "compilerBtn";
            this.compilerBtn.Size = new System.Drawing.Size(115, 41);
            this.compilerBtn.TabIndex = 1;
            this.compilerBtn.Text = "Compile";
            this.compilerBtn.UseVisualStyleBackColor = false;
            this.compilerBtn.Click += new System.EventHandler(this.compilerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BluePrints.Properties.Resources.grid;
            this.ClientSize = new System.Drawing.Size(1204, 718);
            this.ContextMenuStrip = this.RightClick;
            this.Controls.Add(this.compilerBtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1220, 757);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1220, 757);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PythonBlueprints";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip RightClick;
        private System.Windows.Forms.ToolStripMenuItem clickToolStripMenuItem;
        private System.Windows.Forms.Button compilerBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

