using BaoCAo.Class.Component;

namespace BaoCAo
{
    partial class Main
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
            pHeader = new Panel();
            pBalance = new Panel();
            lBalance = new Label();
            pNotice = new Panel();
            pNew = new Panel();
            lAcc = new Label();
            lCom = new Label();
            lLib = new Label();
            lStore = new Label();
            fBody1 = new CustomForm.fBody();
            search1 = new CustomForm.Search();
            pBody = new Panel();
            pHeader.SuspendLayout();
            pBalance.SuspendLayout();
            pBody.SuspendLayout();
            SuspendLayout();
            // 
            // pHeader
            // 
            pHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pHeader.BackColor = SystemColors.ActiveCaptionText;
            pHeader.Controls.Add(pBalance);
            pHeader.Controls.Add(pNotice);
            pHeader.Controls.Add(pNew);
            pHeader.Controls.Add(lAcc);
            pHeader.Controls.Add(lCom);
            pHeader.Controls.Add(lLib);
            pHeader.Controls.Add(lStore);
            pHeader.Location = new Point(1, 1);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(1305, 45);
            pHeader.TabIndex = 1;
            // 
            // pBalance
            // 
            pBalance.Anchor = AnchorStyles.Right;
            pBalance.Controls.Add(lBalance);
            pBalance.Location = new Point(1164, 6);
            pBalance.Name = "pBalance";
            pBalance.Size = new Size(130, 31);
            pBalance.TabIndex = 2;
            // 
            // lBalance
            // 
            lBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lBalance.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBalance.ForeColor = SystemColors.ButtonFace;
            lBalance.Location = new Point(0, 0);
            lBalance.Name = "lBalance";
            lBalance.Size = new Size(130, 31);
            lBalance.TabIndex = 0;
            lBalance.Text = "Balance : 100$";
            lBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pNotice
            // 
            pNotice.Anchor = AnchorStyles.Right;
            pNotice.BackColor = Color.Chartreuse;
            pNotice.Location = new Point(1129, 6);
            pNotice.Name = "pNotice";
            pNotice.Size = new Size(29, 31);
            pNotice.TabIndex = 1;
            // 
            // pNew
            // 
            pNew.Anchor = AnchorStyles.Right;
            pNew.BackColor = Color.GreenYellow;
            pNew.Location = new Point(1094, 6);
            pNew.Name = "pNew";
            pNew.Size = new Size(29, 31);
            pNew.TabIndex = 0;
            // 
            // lAcc
            // 
            lAcc.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            lAcc.ForeColor = SystemColors.ControlLight;
            lAcc.Location = new Point(373, 0);
            lAcc.Name = "lAcc";
            lAcc.Size = new Size(100, 45);
            lAcc.TabIndex = 3;
            lAcc.Text = "ACC";
            lAcc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lCom
            // 
            lCom.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold);
            lCom.ForeColor = SystemColors.ControlLight;
            lCom.Location = new Point(253, 0);
            lCom.Name = "lCom";
            lCom.Size = new Size(114, 45);
            lCom.TabIndex = 2;
            lCom.Text = "COM";
            lCom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lLib
            // 
            lLib.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lLib.ForeColor = SystemColors.ControlLight;
            lLib.Location = new Point(156, 0);
            lLib.Name = "lLib";
            lLib.Size = new Size(91, 45);
            lLib.TabIndex = 1;
            lLib.Text = "LIB";
            lLib.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lStore
            // 
            lStore.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lStore.ForeColor = SystemColors.ControlLight;
            lStore.Location = new Point(0, 0);
            lStore.Name = "lStore";
            lStore.Size = new Size(150, 45);
            lStore.TabIndex = 0;
            lStore.Text = "STORE";
            lStore.TextAlign = ContentAlignment.MiddleLeft;
            lStore.Click += lStore_Click;
            // 
            // fBody1
            // 
            fBody1.AutoScroll = true;
            fBody1.Dock = DockStyle.Fill;
            fBody1.Location = new Point(0, 0);
            fBody1.main = null;
            fBody1.Name = "fBody1";
            fBody1.Size = new Size(1305, 532);
            fBody1.TabIndex = 2;
            fBody1.main = this;
            fBody1.setGameReccom(Game.GetAllGame());
            // 
            // search1
            // 
            search1.AutoScroll = true;
            search1.Dock = DockStyle.Fill;
            search1.Location = new Point(0, 0);
            search1.Name = "search1";
            search1.Size = new Size(1305, 532);
            search1.TabIndex = 3;
            search1.SearchChanged += rs_Cliked;
            // 
            // pBody
            // 
            pBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBody.Controls.Add(fBody1);
            pBody.Controls.Add(search1);
            pBody.Location = new Point(1, 52);
            pBody.Name = "pBody";
            pBody.Size = new Size(1305, 532);
            pBody.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 583);
            Controls.Add(pBody);
            Controls.Add(pHeader);
            Name = "Main";
            Text = "Form1";
            pHeader.ResumeLayout(false);
            pBalance.ResumeLayout(false);
            pBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pHeader;
        private Label lStore;
        private Label lAcc;
        private Label lCom;
        private Label lLib;
        private Panel pBalance;
        private Panel pNotice;
        private Panel pNew;
        private Label lBalance;
        private CustomForm.fBody fBody1;
        private CustomForm.Search search1;
        private Panel pBody;
    }
}
