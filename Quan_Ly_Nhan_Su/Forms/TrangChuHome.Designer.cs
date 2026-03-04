namespace Quan_Ly_Nhan_Su.Forms
{
    partial class TrangChuHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuHome));
            panelMain = new Panel();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BackgroundImage = (Image)resources.GetObject("panelMain.BackgroundImage");
            panelMain.BackgroundImageLayout = ImageLayout.Zoom;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(774, 468);
            panelMain.TabIndex = 2;
            // 
            // TrangChuHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 468);
            Controls.Add(panelMain);
            Name = "TrangChuHome";
            Text = "TrangChuHome";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
    }
}