namespace BaiTapLonCNPM
{
    partial class MainForm
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
            this.thêmSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChildFormAdd = new System.Windows.Forms.Panel();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelChildFormAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.thêmSảnPhẩmToolStripMenuItem,
            this.thêmAgentToolStripMenuItem,
            this.tạoHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            this.thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            this.thêmSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.thêmSảnPhẩmToolStripMenuItem.Text = "Thêm sản phẩm";
            this.thêmSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thêmSảnPhẩmToolStripMenuItem_Click);
            // 
            // thêmAgentToolStripMenuItem
            // 
            this.thêmAgentToolStripMenuItem.Name = "thêmAgentToolStripMenuItem";
            this.thêmAgentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.thêmAgentToolStripMenuItem.Text = "Thêm agent";
            this.thêmAgentToolStripMenuItem.Click += new System.EventHandler(this.thêmAgentToolStripMenuItem_Click);
            // 
            // tạoHóaĐơnToolStripMenuItem
            // 
            this.tạoHóaĐơnToolStripMenuItem.Name = "tạoHóaĐơnToolStripMenuItem";
            this.tạoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.tạoHóaĐơnToolStripMenuItem.Text = "Tạo Hóa Đơn";
            this.tạoHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.tạoHóaĐơnToolStripMenuItem_Click);
            // 
            // panelChildFormAdd
            // 
            this.panelChildFormAdd.Controls.Add(this.label1);
            this.panelChildFormAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormAdd.Location = new System.Drawing.Point(0, 24);
            this.panelChildFormAdd.Name = "panelChildFormAdd";
            this.panelChildFormAdd.Size = new System.Drawing.Size(884, 537);
            this.panelChildFormAdd.TabIndex = 2;
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiểu Thương Bán Quần Áo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelChildFormAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelChildFormAdd.ResumeLayout(false);
            this.panelChildFormAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Panel panelChildFormAdd;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}