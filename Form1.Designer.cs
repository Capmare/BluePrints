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
            this.function1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerBtn = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightClick
            // 
            this.RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.function1ToolStripMenuItem});
            this.RightClick.Name = "RightClick";
            this.RightClick.Size = new System.Drawing.Size(128, 26);
            // 
            // function1ToolStripMenuItem
            // 
            this.function1ToolStripMenuItem.Name = "function1ToolStripMenuItem";
            this.function1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.function1ToolStripMenuItem.Text = "Function1";
            this.function1ToolStripMenuItem.Click += new System.EventHandler(this.function1ToolStripMenuItem_Click);
            // 
            // compilerBtn
            // 
            this.compilerBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.compilerBtn.Location = new System.Drawing.Point(502, 12);
            this.compilerBtn.Name = "compilerBtn";
            this.compilerBtn.Size = new System.Drawing.Size(115, 41);
            this.compilerBtn.TabIndex = 1;
            this.compilerBtn.Text = "Compile";
            this.compilerBtn.UseVisualStyleBackColor = true;
            this.compilerBtn.Click += new System.EventHandler(this.compilerBtn_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::BluePrints.Properties.Resources.grid;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.ImageIndex = 0;
            this.BackButton.ImageList = this.imageList1;
            this.BackButton.Location = new System.Drawing.Point(60, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(66, 65);
            this.BackButton.TabIndex = 2;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Untitled-1.png");
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
            this.Controls.Add(this.BackButton);
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
        private System.Windows.Forms.Button compilerBtn;
        private System.Windows.Forms.ToolStripMenuItem function1ToolStripMenuItem;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}

