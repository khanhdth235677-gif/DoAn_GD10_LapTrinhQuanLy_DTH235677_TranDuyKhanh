using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Nhan_Su.Forms
{
    public partial class TrangChu : Form
    {
       
        private double fadeOpacity = 0;
        private Button currentButton;
        private Form activeForm = null;
        private Dictionary<string, Form> formCache = new Dictionary<string, Form>();

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DarkBlue;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidebar.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.LightGray;
                    previousBtn.ForeColor = Color.Black;
                }
            }
        }
        private void OpenChildForm(string formName)
        {
            if (activeForm != null)
                activeForm.Hide();

            if (!formCache.ContainsKey(formName))
            {
                Form newForm = null;

                switch (formName)
                {
                    case "TrangChu":
                        newForm = new TrangChuHome();
                        break;
                    case "NhanVien":
                        newForm = new NhanVien();
                        break;
                    case "BoPhan":
                        newForm = new BoPhan();
                        break;
                    case "DuAn":
                        newForm = new DuAn();
                        break;
                    case "BangLuong":
                        newForm = new BangLuong();
                        break;
                    case "NghiPhep":
                        newForm = new NghiPhep();
                        break;
                    case "ChamCong":
                        newForm = new ChamCong();
                        break;
                }

                if (newForm == null) return;

                newForm.TopLevel = false;
                newForm.FormBorderStyle = FormBorderStyle.None;
                newForm.Dock = DockStyle.Fill;

                panelMain.Controls.Add(newForm);
                formCache.Add(formName, newForm);
            }

            activeForm = formCache[formName];
            activeForm.Show();
            activeForm.BringToFront();

            fadeOpacity = 0;
            activeForm.Opacity = 0;
            fadeTimer.Start();
        }
        public TrangChu()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("NhanVien");
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("TrangChu");
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("BoPhan");
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("ChamCong");
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("BangLuong");
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("DuAn");
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm("NghiPhep");
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (activeForm == null)
            {
                fadeTimer.Stop();
                return;
            }

            fadeOpacity += 0.05;

            if (fadeOpacity >= 1)
            {
                fadeOpacity = 1;
                fadeTimer.Stop();
            }

            activeForm.Opacity = fadeOpacity;
        }
    }
}
