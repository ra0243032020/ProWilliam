
namespace William01.VISTA
{
    partial class Frm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clicParaMasInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickParaMasInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clicParaMasInformacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // clicParaMasInformacionToolStripMenuItem
            // 
            this.clicParaMasInformacionToolStripMenuItem.Name = "clicParaMasInformacionToolStripMenuItem";
            this.clicParaMasInformacionToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clicParaMasInformacionToolStripMenuItem.Text = "Clic para mas informacion";
            this.clicParaMasInformacionToolStripMenuItem.Click += new System.EventHandler(this.clicParaMasInformacionToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickParaMasInformacionToolStripMenuItem});
            this.arreglosToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            // 
            // clickParaMasInformacionToolStripMenuItem
            // 
            this.clickParaMasInformacionToolStripMenuItem.Name = "clickParaMasInformacionToolStripMenuItem";
            this.clickParaMasInformacionToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.clickParaMasInformacionToolStripMenuItem.Text = "click para mas informacion";
            this.clickParaMasInformacionToolStripMenuItem.Click += new System.EventHandler(this.clickParaMasInformacionToolStripMenuItem_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(797, 336);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clicParaMasInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickParaMasInformacionToolStripMenuItem;
    }
}