
namespace BigBanTheory_Project5
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchPropBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.showPropBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addPropBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exitBtn
            // 
            this.exitBtn.ActiveBorderThickness = 1;
            this.exitBtn.ActiveCornerRadius = 4;
            this.exitBtn.ActiveFillColor = System.Drawing.Color.DimGray;
            this.exitBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exitBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.ButtonText = "Exit";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitBtn.IdleBorderThickness = 1;
            this.exitBtn.IdleCornerRadius = 10;
            this.exitBtn.IdleFillColor = System.Drawing.Color.Maroon;
            this.exitBtn.IdleForecolor = System.Drawing.Color.White;
            this.exitBtn.IdleLineColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(137, 191);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(181, 41);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // searchPropBtn
            // 
            this.searchPropBtn.ActiveBorderThickness = 1;
            this.searchPropBtn.ActiveCornerRadius = 4;
            this.searchPropBtn.ActiveFillColor = System.Drawing.Color.DimGray;
            this.searchPropBtn.ActiveForecolor = System.Drawing.Color.White;
            this.searchPropBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.searchPropBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.searchPropBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPropBtn.BackgroundImage")));
            this.searchPropBtn.ButtonText = "Search Property";
            this.searchPropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPropBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPropBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchPropBtn.IdleBorderThickness = 1;
            this.searchPropBtn.IdleCornerRadius = 10;
            this.searchPropBtn.IdleFillColor = System.Drawing.Color.DimGray;
            this.searchPropBtn.IdleForecolor = System.Drawing.Color.White;
            this.searchPropBtn.IdleLineColor = System.Drawing.Color.Black;
            this.searchPropBtn.Location = new System.Drawing.Point(137, 115);
            this.searchPropBtn.Margin = new System.Windows.Forms.Padding(5);
            this.searchPropBtn.Name = "searchPropBtn";
            this.searchPropBtn.Size = new System.Drawing.Size(181, 41);
            this.searchPropBtn.TabIndex = 2;
            this.searchPropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchPropBtn.Click += new System.EventHandler(this.searchPropBtn_Click);
            // 
            // showPropBtn
            // 
            this.showPropBtn.ActiveBorderThickness = 1;
            this.showPropBtn.ActiveCornerRadius = 4;
            this.showPropBtn.ActiveFillColor = System.Drawing.Color.DimGray;
            this.showPropBtn.ActiveForecolor = System.Drawing.Color.White;
            this.showPropBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.showPropBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.showPropBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPropBtn.BackgroundImage")));
            this.showPropBtn.ButtonText = "Show Property";
            this.showPropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPropBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPropBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.showPropBtn.IdleBorderThickness = 1;
            this.showPropBtn.IdleCornerRadius = 10;
            this.showPropBtn.IdleFillColor = System.Drawing.Color.DimGray;
            this.showPropBtn.IdleForecolor = System.Drawing.Color.White;
            this.showPropBtn.IdleLineColor = System.Drawing.Color.Black;
            this.showPropBtn.Location = new System.Drawing.Point(232, 64);
            this.showPropBtn.Margin = new System.Windows.Forms.Padding(5);
            this.showPropBtn.Name = "showPropBtn";
            this.showPropBtn.Size = new System.Drawing.Size(181, 41);
            this.showPropBtn.TabIndex = 1;
            this.showPropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPropBtn.Click += new System.EventHandler(this.showPropBtn_Click);
            // 
            // addPropBtn
            // 
            this.addPropBtn.ActiveBorderThickness = 1;
            this.addPropBtn.ActiveCornerRadius = 4;
            this.addPropBtn.ActiveFillColor = System.Drawing.Color.DimGray;
            this.addPropBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addPropBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.addPropBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.addPropBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPropBtn.BackgroundImage")));
            this.addPropBtn.ButtonText = "Add Property";
            this.addPropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPropBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPropBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addPropBtn.IdleBorderThickness = 1;
            this.addPropBtn.IdleCornerRadius = 10;
            this.addPropBtn.IdleFillColor = System.Drawing.Color.DimGray;
            this.addPropBtn.IdleForecolor = System.Drawing.Color.White;
            this.addPropBtn.IdleLineColor = System.Drawing.Color.Black;
            this.addPropBtn.Location = new System.Drawing.Point(41, 64);
            this.addPropBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addPropBtn.Name = "addPropBtn";
            this.addPropBtn.Size = new System.Drawing.Size(181, 41);
            this.addPropBtn.TabIndex = 0;
            this.addPropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addPropBtn.Click += new System.EventHandler(this.addPropBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(454, 290);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.searchPropBtn);
            this.Controls.Add(this.showPropBtn);
            this.Controls.Add(this.addPropBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 addPropBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 exitBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 searchPropBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 showPropBtn;
    }
}

