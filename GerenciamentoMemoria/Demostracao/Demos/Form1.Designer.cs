namespace Demos
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Stack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringsEConstantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Stack,
            this.heapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Stack
            // 
            this.Stack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.Stack.Name = "Stack";
            this.Stack.Size = new System.Drawing.Size(47, 20);
            this.Stack.Text = "Stack";
            this.Stack.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Exemplo1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // heapToolStripMenuItem
            // 
            this.heapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringsEConstantesToolStripMenuItem});
            this.heapToolStripMenuItem.Name = "heapToolStripMenuItem";
            this.heapToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.heapToolStripMenuItem.Text = "Heap";
            // 
            // stringsEConstantesToolStripMenuItem
            // 
            this.stringsEConstantesToolStripMenuItem.Name = "stringsEConstantesToolStripMenuItem";
            this.stringsEConstantesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.stringsEConstantesToolStripMenuItem.Text = "Strings e Constantes";
            this.stringsEConstantesToolStripMenuItem.Click += new System.EventHandler(this.stringsEConstantesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Stack;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem heapToolStripMenuItem;
        private ToolStripMenuItem stringsEConstantesToolStripMenuItem;
    }
}