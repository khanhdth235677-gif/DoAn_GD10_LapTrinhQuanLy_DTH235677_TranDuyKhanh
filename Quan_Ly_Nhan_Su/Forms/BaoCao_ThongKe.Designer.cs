namespace Quan_Ly_Nhan_Su.Forms
{
    partial class BaoCao_ThongKe
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
            tpInHoSo = new TabPage();
            pnlInHoSo = new Panel();
            panelHeader2 = new Panel();
            label13 = new Label();
            tpThongKeNV = new TabPage();
            pnlThongKeNV = new Panel();
            panelHeader = new Panel();
            label4 = new Label();
            tabControlMain = new TabControl();
            tpThongKeDA = new TabPage();
            pnlThongKeDA = new Panel();
            panelHeader1 = new Panel();
            label5 = new Label();
            tpInHoSo.SuspendLayout();
            panelHeader2.SuspendLayout();
            tpThongKeNV.SuspendLayout();
            panelHeader.SuspendLayout();
            tabControlMain.SuspendLayout();
            tpThongKeDA.SuspendLayout();
            panelHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // tpInHoSo
            // 
            tpInHoSo.Controls.Add(pnlInHoSo);
            tpInHoSo.Controls.Add(panelHeader2);
            tpInHoSo.Location = new Point(4, 34);
            tpInHoSo.Name = "tpInHoSo";
            tpInHoSo.Padding = new Padding(3);
            tpInHoSo.Size = new Size(792, 412);
            tpInHoSo.TabIndex = 2;
            tpInHoSo.Text = "Hồ sơ nhân viên ";
            tpInHoSo.UseVisualStyleBackColor = true;
            // 
            // pnlInHoSo
            // 
            pnlInHoSo.Dock = DockStyle.Fill;
            pnlInHoSo.Location = new Point(3, 48);
            pnlInHoSo.Name = "pnlInHoSo";
            pnlInHoSo.Size = new Size(786, 361);
            pnlInHoSo.TabIndex = 2;
            // 
            // panelHeader2
            // 
            panelHeader2.BackColor = Color.Teal;
            panelHeader2.Controls.Add(label13);
            panelHeader2.Dock = DockStyle.Top;
            panelHeader2.Location = new Point(3, 3);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Size = new Size(786, 45);
            panelHeader2.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label13.ForeColor = Color.White;
            label13.Location = new Point(20, 10);
            label13.Name = "label13";
            label13.Size = new Size(172, 28);
            label13.TabIndex = 0;
            label13.Text = "Hồ sơ nhân viên ";
            // 
            // tpThongKeNV
            // 
            tpThongKeNV.Controls.Add(pnlThongKeNV);
            tpThongKeNV.Controls.Add(panelHeader);
            tpThongKeNV.Location = new Point(4, 34);
            tpThongKeNV.Name = "tpThongKeNV";
            tpThongKeNV.Padding = new Padding(3);
            tpThongKeNV.Size = new Size(792, 412);
            tpThongKeNV.TabIndex = 0;
            tpThongKeNV.Text = "Thống kê nhân viên";
            tpThongKeNV.UseVisualStyleBackColor = true;
            // 
            // pnlThongKeNV
            // 
            pnlThongKeNV.Dock = DockStyle.Fill;
            pnlThongKeNV.Location = new Point(3, 53);
            pnlThongKeNV.Name = "pnlThongKeNV";
            pnlThongKeNV.Size = new Size(786, 356);
            pnlThongKeNV.TabIndex = 8;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(label4);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(786, 50);
            panelHeader.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 9);
            label4.Name = "label4";
            label4.Size = new Size(199, 28);
            label4.TabIndex = 0;
            label4.Text = "Thống kê nhân viên";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tpThongKeNV);
            tabControlMain.Controls.Add(tpThongKeDA);
            tabControlMain.Controls.Add(tpInHoSo);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlMain.ItemSize = new Size(230, 30);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 450);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 1;
            // 
            // tpThongKeDA
            // 
            tpThongKeDA.Controls.Add(pnlThongKeDA);
            tpThongKeDA.Controls.Add(panelHeader1);
            tpThongKeDA.Location = new Point(4, 34);
            tpThongKeDA.Name = "tpThongKeDA";
            tpThongKeDA.Padding = new Padding(3);
            tpThongKeDA.Size = new Size(792, 412);
            tpThongKeDA.TabIndex = 1;
            tpThongKeDA.Text = "Thống kê dự án ";
            tpThongKeDA.UseVisualStyleBackColor = true;
            // 
            // pnlThongKeDA
            // 
            pnlThongKeDA.Dock = DockStyle.Fill;
            pnlThongKeDA.Location = new Point(3, 53);
            pnlThongKeDA.Name = "pnlThongKeDA";
            pnlThongKeDA.Size = new Size(786, 356);
            pnlThongKeDA.TabIndex = 4;
            // 
            // panelHeader1
            // 
            panelHeader1.BackColor = Color.Teal;
            panelHeader1.Controls.Add(label5);
            panelHeader1.Dock = DockStyle.Top;
            panelHeader1.Location = new Point(3, 3);
            panelHeader1.Name = "panelHeader1";
            panelHeader1.Size = new Size(786, 50);
            panelHeader1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 9);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 0;
            label5.Text = "Thống kê dự án";
            // 
            // BaoCao_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaoCao_ThongKe";
            Text = "BaoCao_ThongKe";
            tpInHoSo.ResumeLayout(false);
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            tpThongKeNV.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tpThongKeDA.ResumeLayout(false);
            panelHeader1.ResumeLayout(false);
            panelHeader1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tpInHoSo;
        private Panel panelHeader2;
        private Label label13;
        private TabPage tpThongKeNV;
        private Panel pnlThongKeNV;
        private Panel panelHeader;
        private Label label4;
        private TabControl tabControlMain;
        private TabPage tpThongKeDA;
        private Panel panelHeader1;
        private Label label5;
        private Panel pnlInHoSo;
        private Panel pnlThongKeDA;
    }
}