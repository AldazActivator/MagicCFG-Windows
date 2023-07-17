using LibUsbDotNet.DeviceNotify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCFG
{
    public static class StringExtensions
    {
        public static string Inserting(this string str, string separator, int every)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 0;

            foreach (char c in str)
            {
                if (count == every)
                {
                    stringBuilder.Append(separator);
                    count = 0;
                }

                stringBuilder.Append(c);
                count++;
            }

            return stringBuilder.ToString();
        }
    }
    partial class MainCFG
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCFG));
            this.MainPanelUP = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.CloseCFG = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.DiagButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BoxPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ConnectButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLModel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.LblECID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LBLMode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadCDFGButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BackupCFGButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBoxSerial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModeTextB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RegionText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WMacText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BMacTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EMacText = new Guna.UI2.WinForms.Guna2TextBox();
            this.WriteSNBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteModeBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SNCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ModeCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.WmacCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.RegionCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.EMacCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.BMacCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.WriteWmacBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteRegionBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteEmacBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteBmacBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteMlbBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MLBCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MlbText = new Guna.UI2.WinForms.Guna2TextBox();
            this.WriteMtSNBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MtSN = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.MTSNTEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.WriteFcMBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteBcMBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteLCmBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteNSRNBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fcmCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.bcmCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.LCMUCHECK = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.NSRNCHECK = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.NVSNCHECK = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.ModelCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.WriteNVSNBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteModelBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label15 = new System.Windows.Forms.Label();
            this.FCMS_TEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BCMS_TEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LCMTEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.NSRNTEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.NVSNTEXT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ModelTextB = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClearButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SelectAllButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DeselectAllButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.WriteAllBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DriverRepairButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TerminalBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GoTerminal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.backgroundWorkerCFG = new System.ComponentModel.BackgroundWorker();
            this.Readbackground = new System.ComponentModel.BackgroundWorker();
            this.FactoryBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.UnlockBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Rbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Dissconect = new System.Windows.Forms.PictureBox();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.reloadPort = new Guna.UI2.WinForms.Guna2ImageButton();
            this.connect = new System.Windows.Forms.PictureBox();
            this.MainPanelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dissconect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanelUP
            // 
            this.MainPanelUP.Controls.Add(this.pictureBox1);
            this.MainPanelUP.Controls.Add(this.guna2HtmlLabel5);
            this.MainPanelUP.Controls.Add(this.labelName);
            this.MainPanelUP.Controls.Add(this.CloseCFG);
            this.MainPanelUP.Location = new System.Drawing.Point(0, -2);
            this.MainPanelUP.Name = "MainPanelUP";
            this.MainPanelUP.Size = new System.Drawing.Size(1001, 59);
            this.MainPanelUP.TabIndex = 326;
            this.MainPanelUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelUP_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MagicCFG.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 416;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(199, 29);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(77, 17);
            this.guna2HtmlLabel5.TabIndex = 408;
            this.guna2HtmlLabel5.Text = "Windows V1.0";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(61, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(146, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "MagicCFG";
            // 
            // CloseCFG
            // 
            this.CloseCFG.BackColor = System.Drawing.Color.Transparent;
            this.CloseCFG.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseCFG.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.CloseCFG.Image = ((System.Drawing.Image)(resources.GetObject("CloseCFG.Image")));
            this.CloseCFG.ImageOffset = new System.Drawing.Point(0, 0);
            this.CloseCFG.ImageRotate = 0F;
            this.CloseCFG.ImageSize = new System.Drawing.Size(25, 25);
            this.CloseCFG.Location = new System.Drawing.Point(937, 3);
            this.CloseCFG.Name = "CloseCFG";
            this.CloseCFG.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.CloseCFG.Size = new System.Drawing.Size(33, 38);
            this.CloseCFG.TabIndex = 324;
            this.CloseCFG.Click += new System.EventHandler(this.CloseCFG_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(-7, 55);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1079, 10);
            this.guna2Separator2.TabIndex = 326;
            // 
            // DiagButton
            // 
            this.DiagButton.BorderRadius = 6;
            this.DiagButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiagButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiagButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiagButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiagButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiagButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.DiagButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiagButton.ForeColor = System.Drawing.Color.White;
            this.DiagButton.Location = new System.Drawing.Point(24, 78);
            this.DiagButton.Name = "DiagButton";
            this.DiagButton.Size = new System.Drawing.Size(181, 31);
            this.DiagButton.TabIndex = 329;
            this.DiagButton.Text = "Enter Diag Mode";
            this.DiagButton.Click += new System.EventHandler(this.DiagButton_Click);
            // 
            // BoxPort
            // 
            this.BoxPort.BackColor = System.Drawing.Color.Transparent;
            this.BoxPort.BorderRadius = 10;
            this.BoxPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BoxPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BoxPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BoxPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BoxPort.ItemHeight = 20;
            this.BoxPort.Location = new System.Drawing.Point(24, 129);
            this.BoxPort.Name = "BoxPort";
            this.BoxPort.Size = new System.Drawing.Size(149, 26);
            this.BoxPort.TabIndex = 331;
            this.BoxPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoxPort_MouseClick);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BorderColor = System.Drawing.Color.DimGray;
            this.ConnectButton.BorderRadius = 6;
            this.ConnectButton.BorderThickness = 1;
            this.ConnectButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConnectButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConnectButton.FillColor = System.Drawing.Color.Silver;
            this.ConnectButton.FillColor2 = System.Drawing.Color.Silver;
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(24, 164);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(181, 31);
            this.ConnectButton.TabIndex = 333;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 334;
            this.label4.Text = "Select PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(354, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 335;
            this.label1.Text = "MODEL";
            // 
            // LBLModel
            // 
            this.LBLModel.BackColor = System.Drawing.Color.Transparent;
            this.LBLModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLModel.Location = new System.Drawing.Point(407, 127);
            this.LBLModel.Name = "LBLModel";
            this.LBLModel.Size = new System.Drawing.Size(8, 17);
            this.LBLModel.TabIndex = 336;
            this.LBLModel.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(354, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 337;
            this.label3.Text = "ECID";
            // 
            // LblECID
            // 
            this.LblECID.BackColor = System.Drawing.Color.Transparent;
            this.LblECID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblECID.Location = new System.Drawing.Point(407, 91);
            this.LblECID.Name = "LblECID";
            this.LblECID.Size = new System.Drawing.Size(8, 17);
            this.LblECID.TabIndex = 338;
            this.LblECID.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(354, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 339;
            this.label5.Text = "NAND";
            // 
            // LblNand
            // 
            this.LblNand.BackColor = System.Drawing.Color.Transparent;
            this.LblNand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblNand.Location = new System.Drawing.Point(407, 163);
            this.LblNand.Name = "LblNand";
            this.LblNand.Size = new System.Drawing.Size(8, 17);
            this.LblNand.TabIndex = 340;
            this.LblNand.Text = "-";
            // 
            // LBLMode
            // 
            this.LBLMode.BackColor = System.Drawing.Color.Transparent;
            this.LBLMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LBLMode.Location = new System.Drawing.Point(407, 200);
            this.LBLMode.Name = "LBLMode";
            this.LBLMode.Size = new System.Drawing.Size(8, 17);
            this.LBLMode.TabIndex = 342;
            this.LBLMode.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(354, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 341;
            this.label6.Text = "MODE";
            // 
            // ReadCDFGButton
            // 
            this.ReadCDFGButton.BorderColor = System.Drawing.Color.DimGray;
            this.ReadCDFGButton.BorderRadius = 6;
            this.ReadCDFGButton.BorderThickness = 1;
            this.ReadCDFGButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReadCDFGButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReadCDFGButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReadCDFGButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReadCDFGButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReadCDFGButton.Enabled = false;
            this.ReadCDFGButton.FillColor = System.Drawing.Color.Silver;
            this.ReadCDFGButton.FillColor2 = System.Drawing.Color.Silver;
            this.ReadCDFGButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReadCDFGButton.ForeColor = System.Drawing.Color.White;
            this.ReadCDFGButton.Location = new System.Drawing.Point(24, 198);
            this.ReadCDFGButton.Name = "ReadCDFGButton";
            this.ReadCDFGButton.Size = new System.Drawing.Size(181, 31);
            this.ReadCDFGButton.TabIndex = 343;
            this.ReadCDFGButton.Text = "Read SysCFG";
            this.ReadCDFGButton.Click += new System.EventHandler(this.ReadCDFGButton_Click);
            // 
            // BackupCFGButton
            // 
            this.BackupCFGButton.BorderColor = System.Drawing.Color.DimGray;
            this.BackupCFGButton.BorderRadius = 6;
            this.BackupCFGButton.BorderThickness = 1;
            this.BackupCFGButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackupCFGButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackupCFGButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackupCFGButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackupCFGButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackupCFGButton.Enabled = false;
            this.BackupCFGButton.FillColor = System.Drawing.Color.Silver;
            this.BackupCFGButton.FillColor2 = System.Drawing.Color.Silver;
            this.BackupCFGButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackupCFGButton.ForeColor = System.Drawing.Color.White;
            this.BackupCFGButton.Location = new System.Drawing.Point(24, 266);
            this.BackupCFGButton.Name = "BackupCFGButton";
            this.BackupCFGButton.Size = new System.Drawing.Size(181, 31);
            this.BackupCFGButton.TabIndex = 344;
            this.BackupCFGButton.Text = "Backup SysCFG";
            this.BackupCFGButton.Click += new System.EventHandler(this.BackupCFGButton_Click);
            // 
            // TextBoxSerial
            // 
            this.TextBoxSerial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSerial.DefaultText = "";
            this.TextBoxSerial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSerial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSerial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSerial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSerial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSerial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSerial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSerial.Location = new System.Drawing.Point(323, 263);
            this.TextBoxSerial.Name = "TextBoxSerial";
            this.TextBoxSerial.PasswordChar = '\0';
            this.TextBoxSerial.PlaceholderText = "";
            this.TextBoxSerial.SelectedText = "";
            this.TextBoxSerial.Size = new System.Drawing.Size(133, 19);
            this.TextBoxSerial.TabIndex = 345;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(243, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 346;
            this.label7.Text = "SN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(243, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 348;
            this.label8.Text = "Mode:";
            // 
            // ModeTextB
            // 
            this.ModeTextB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModeTextB.DefaultText = "";
            this.ModeTextB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModeTextB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModeTextB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModeTextB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModeTextB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModeTextB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ModeTextB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModeTextB.Location = new System.Drawing.Point(323, 288);
            this.ModeTextB.Name = "ModeTextB";
            this.ModeTextB.PasswordChar = '\0';
            this.ModeTextB.PlaceholderText = "";
            this.ModeTextB.SelectedText = "";
            this.ModeTextB.Size = new System.Drawing.Size(133, 19);
            this.ModeTextB.TabIndex = 347;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(243, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 350;
            this.label9.Text = "Region:";
            // 
            // RegionText
            // 
            this.RegionText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegionText.DefaultText = "";
            this.RegionText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegionText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegionText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegionText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegionText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegionText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegionText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegionText.Location = new System.Drawing.Point(323, 313);
            this.RegionText.Name = "RegionText";
            this.RegionText.PasswordChar = '\0';
            this.RegionText.PlaceholderText = "";
            this.RegionText.SelectedText = "";
            this.RegionText.Size = new System.Drawing.Size(133, 19);
            this.RegionText.TabIndex = 349;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(243, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 352;
            this.label10.Text = "WMac:";
            // 
            // WMacText
            // 
            this.WMacText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WMacText.DefaultText = "";
            this.WMacText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.WMacText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.WMacText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WMacText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WMacText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WMacText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WMacText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WMacText.Location = new System.Drawing.Point(323, 338);
            this.WMacText.Name = "WMacText";
            this.WMacText.PasswordChar = '\0';
            this.WMacText.PlaceholderText = "";
            this.WMacText.SelectedText = "";
            this.WMacText.Size = new System.Drawing.Size(133, 19);
            this.WMacText.TabIndex = 351;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(243, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 354;
            this.label11.Text = "BMac:";
            // 
            // BMacTxt
            // 
            this.BMacTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BMacTxt.DefaultText = "";
            this.BMacTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BMacTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BMacTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BMacTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BMacTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BMacTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BMacTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BMacTxt.Location = new System.Drawing.Point(323, 363);
            this.BMacTxt.Name = "BMacTxt";
            this.BMacTxt.PasswordChar = '\0';
            this.BMacTxt.PlaceholderText = "";
            this.BMacTxt.SelectedText = "";
            this.BMacTxt.Size = new System.Drawing.Size(133, 19);
            this.BMacTxt.TabIndex = 353;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(243, 388);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 356;
            this.label12.Text = "EMac:";
            // 
            // EMacText
            // 
            this.EMacText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EMacText.DefaultText = "";
            this.EMacText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EMacText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EMacText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EMacText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EMacText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EMacText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EMacText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EMacText.Location = new System.Drawing.Point(323, 388);
            this.EMacText.Name = "EMacText";
            this.EMacText.PasswordChar = '\0';
            this.EMacText.PlaceholderText = "";
            this.EMacText.SelectedText = "";
            this.EMacText.Size = new System.Drawing.Size(133, 19);
            this.EMacText.TabIndex = 355;
            // 
            // WriteSNBtn
            // 
            this.WriteSNBtn.BorderRadius = 5;
            this.WriteSNBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteSNBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteSNBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteSNBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteSNBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteSNBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteSNBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteSNBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteSNBtn.ForeColor = System.Drawing.Color.White;
            this.WriteSNBtn.Location = new System.Drawing.Point(487, 263);
            this.WriteSNBtn.Name = "WriteSNBtn";
            this.WriteSNBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteSNBtn.TabIndex = 357;
            this.WriteSNBtn.Text = "Write";
            this.WriteSNBtn.Click += new System.EventHandler(this.WriteSNBtn_Click);
            // 
            // WriteModeBtn
            // 
            this.WriteModeBtn.BorderRadius = 5;
            this.WriteModeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteModeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteModeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteModeBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteModeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteModeBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteModeBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteModeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteModeBtn.ForeColor = System.Drawing.Color.White;
            this.WriteModeBtn.Location = new System.Drawing.Point(487, 288);
            this.WriteModeBtn.Name = "WriteModeBtn";
            this.WriteModeBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteModeBtn.TabIndex = 358;
            this.WriteModeBtn.Text = "Write";
            this.WriteModeBtn.Click += new System.EventHandler(this.WriteModeBtn_Click);
            // 
            // SNCheck
            // 
            this.SNCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SNCheck.CheckedState.BorderRadius = 2;
            this.SNCheck.CheckedState.BorderThickness = 0;
            this.SNCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SNCheck.Location = new System.Drawing.Point(462, 263);
            this.SNCheck.Name = "SNCheck";
            this.SNCheck.Size = new System.Drawing.Size(20, 19);
            this.SNCheck.TabIndex = 359;
            this.SNCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SNCheck.UncheckedState.BorderRadius = 2;
            this.SNCheck.UncheckedState.BorderThickness = 0;
            this.SNCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ModeCheck
            // 
            this.ModeCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModeCheck.CheckedState.BorderRadius = 2;
            this.ModeCheck.CheckedState.BorderThickness = 0;
            this.ModeCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModeCheck.Location = new System.Drawing.Point(462, 288);
            this.ModeCheck.Name = "ModeCheck";
            this.ModeCheck.Size = new System.Drawing.Size(20, 19);
            this.ModeCheck.TabIndex = 360;
            this.ModeCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ModeCheck.UncheckedState.BorderRadius = 2;
            this.ModeCheck.UncheckedState.BorderThickness = 0;
            this.ModeCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // WmacCheck
            // 
            this.WmacCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WmacCheck.CheckedState.BorderRadius = 2;
            this.WmacCheck.CheckedState.BorderThickness = 0;
            this.WmacCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WmacCheck.Location = new System.Drawing.Point(462, 338);
            this.WmacCheck.Name = "WmacCheck";
            this.WmacCheck.Size = new System.Drawing.Size(20, 19);
            this.WmacCheck.TabIndex = 362;
            this.WmacCheck.Text = "WmacCheck";
            this.WmacCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.WmacCheck.UncheckedState.BorderRadius = 2;
            this.WmacCheck.UncheckedState.BorderThickness = 0;
            this.WmacCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // RegionCheck
            // 
            this.RegionCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegionCheck.CheckedState.BorderRadius = 2;
            this.RegionCheck.CheckedState.BorderThickness = 0;
            this.RegionCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegionCheck.Location = new System.Drawing.Point(462, 313);
            this.RegionCheck.Name = "RegionCheck";
            this.RegionCheck.Size = new System.Drawing.Size(20, 19);
            this.RegionCheck.TabIndex = 361;
            this.RegionCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RegionCheck.UncheckedState.BorderRadius = 2;
            this.RegionCheck.UncheckedState.BorderThickness = 0;
            this.RegionCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // EMacCheck
            // 
            this.EMacCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EMacCheck.CheckedState.BorderRadius = 2;
            this.EMacCheck.CheckedState.BorderThickness = 0;
            this.EMacCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EMacCheck.Location = new System.Drawing.Point(462, 388);
            this.EMacCheck.Name = "EMacCheck";
            this.EMacCheck.Size = new System.Drawing.Size(20, 19);
            this.EMacCheck.TabIndex = 364;
            this.EMacCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EMacCheck.UncheckedState.BorderRadius = 2;
            this.EMacCheck.UncheckedState.BorderThickness = 0;
            this.EMacCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // BMacCheck
            // 
            this.BMacCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BMacCheck.CheckedState.BorderRadius = 2;
            this.BMacCheck.CheckedState.BorderThickness = 0;
            this.BMacCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BMacCheck.Location = new System.Drawing.Point(462, 363);
            this.BMacCheck.Name = "BMacCheck";
            this.BMacCheck.Size = new System.Drawing.Size(20, 19);
            this.BMacCheck.TabIndex = 363;
            this.BMacCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BMacCheck.UncheckedState.BorderRadius = 2;
            this.BMacCheck.UncheckedState.BorderThickness = 0;
            this.BMacCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // WriteWmacBtn
            // 
            this.WriteWmacBtn.BorderRadius = 5;
            this.WriteWmacBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteWmacBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteWmacBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteWmacBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteWmacBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteWmacBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteWmacBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteWmacBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteWmacBtn.ForeColor = System.Drawing.Color.White;
            this.WriteWmacBtn.Location = new System.Drawing.Point(487, 338);
            this.WriteWmacBtn.Name = "WriteWmacBtn";
            this.WriteWmacBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteWmacBtn.TabIndex = 366;
            this.WriteWmacBtn.Text = "Write";
            this.WriteWmacBtn.Click += new System.EventHandler(this.WriteWmacBtn_Click);
            // 
            // WriteRegionBtn
            // 
            this.WriteRegionBtn.BorderRadius = 5;
            this.WriteRegionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteRegionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteRegionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteRegionBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteRegionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteRegionBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteRegionBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteRegionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteRegionBtn.ForeColor = System.Drawing.Color.White;
            this.WriteRegionBtn.Location = new System.Drawing.Point(487, 313);
            this.WriteRegionBtn.Name = "WriteRegionBtn";
            this.WriteRegionBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteRegionBtn.TabIndex = 365;
            this.WriteRegionBtn.Text = "Write";
            this.WriteRegionBtn.Click += new System.EventHandler(this.WriteRegionBtn_Click);
            // 
            // WriteEmacBtn
            // 
            this.WriteEmacBtn.BorderRadius = 5;
            this.WriteEmacBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteEmacBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteEmacBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteEmacBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteEmacBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteEmacBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteEmacBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteEmacBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteEmacBtn.ForeColor = System.Drawing.Color.White;
            this.WriteEmacBtn.Location = new System.Drawing.Point(487, 388);
            this.WriteEmacBtn.Name = "WriteEmacBtn";
            this.WriteEmacBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteEmacBtn.TabIndex = 368;
            this.WriteEmacBtn.Text = "Write";
            this.WriteEmacBtn.Click += new System.EventHandler(this.WriteEmacBtn_Click);
            // 
            // WriteBmacBtn
            // 
            this.WriteBmacBtn.BorderRadius = 5;
            this.WriteBmacBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteBmacBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteBmacBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteBmacBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteBmacBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteBmacBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteBmacBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteBmacBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteBmacBtn.ForeColor = System.Drawing.Color.White;
            this.WriteBmacBtn.Location = new System.Drawing.Point(487, 363);
            this.WriteBmacBtn.Name = "WriteBmacBtn";
            this.WriteBmacBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteBmacBtn.TabIndex = 367;
            this.WriteBmacBtn.Text = "Write";
            this.WriteBmacBtn.Click += new System.EventHandler(this.WriteBmacBtn_Click);
            // 
            // WriteMlbBtn
            // 
            this.WriteMlbBtn.BorderRadius = 5;
            this.WriteMlbBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteMlbBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteMlbBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteMlbBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteMlbBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteMlbBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteMlbBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteMlbBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteMlbBtn.ForeColor = System.Drawing.Color.White;
            this.WriteMlbBtn.Location = new System.Drawing.Point(487, 413);
            this.WriteMlbBtn.Name = "WriteMlbBtn";
            this.WriteMlbBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteMlbBtn.TabIndex = 372;
            this.WriteMlbBtn.Text = "Write";
            this.WriteMlbBtn.Click += new System.EventHandler(this.WriteMlbBtn_Click);
            // 
            // MLBCheck
            // 
            this.MLBCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MLBCheck.CheckedState.BorderRadius = 2;
            this.MLBCheck.CheckedState.BorderThickness = 0;
            this.MLBCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MLBCheck.Location = new System.Drawing.Point(462, 413);
            this.MLBCheck.Name = "MLBCheck";
            this.MLBCheck.Size = new System.Drawing.Size(20, 19);
            this.MLBCheck.TabIndex = 371;
            this.MLBCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MLBCheck.UncheckedState.BorderRadius = 2;
            this.MLBCheck.UncheckedState.BorderThickness = 0;
            this.MLBCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(243, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 370;
            this.label13.Text = "MLB:";
            // 
            // MlbText
            // 
            this.MlbText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MlbText.DefaultText = "";
            this.MlbText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MlbText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MlbText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MlbText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MlbText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MlbText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MlbText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MlbText.Location = new System.Drawing.Point(323, 413);
            this.MlbText.Name = "MlbText";
            this.MlbText.PasswordChar = '\0';
            this.MlbText.PlaceholderText = "";
            this.MlbText.SelectedText = "";
            this.MlbText.Size = new System.Drawing.Size(133, 19);
            this.MlbText.TabIndex = 369;
            // 
            // WriteMtSNBtn
            // 
            this.WriteMtSNBtn.BorderRadius = 5;
            this.WriteMtSNBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteMtSNBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteMtSNBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteMtSNBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteMtSNBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteMtSNBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteMtSNBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteMtSNBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteMtSNBtn.ForeColor = System.Drawing.Color.White;
            this.WriteMtSNBtn.Location = new System.Drawing.Point(816, 413);
            this.WriteMtSNBtn.Name = "WriteMtSNBtn";
            this.WriteMtSNBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteMtSNBtn.TabIndex = 400;
            this.WriteMtSNBtn.Text = "Write";
            this.WriteMtSNBtn.Click += new System.EventHandler(this.WriteMtSNBtn_Click);
            // 
            // MtSN
            // 
            this.MtSN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MtSN.CheckedState.BorderRadius = 2;
            this.MtSN.CheckedState.BorderThickness = 0;
            this.MtSN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MtSN.Location = new System.Drawing.Point(791, 413);
            this.MtSN.Name = "MtSN";
            this.MtSN.Size = new System.Drawing.Size(20, 19);
            this.MtSN.TabIndex = 399;
            this.MtSN.Text = "guna2CustomCheckBox8";
            this.MtSN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MtSN.UncheckedState.BorderRadius = 2;
            this.MtSN.UncheckedState.BorderThickness = 0;
            this.MtSN.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(596, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 398;
            this.label14.Text = "MTSN:";
            // 
            // MTSNTEXT
            // 
            this.MTSNTEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MTSNTEXT.DefaultText = "";
            this.MTSNTEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MTSNTEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MTSNTEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MTSNTEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MTSNTEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MTSNTEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MTSNTEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MTSNTEXT.Location = new System.Drawing.Point(652, 413);
            this.MTSNTEXT.Name = "MTSNTEXT";
            this.MTSNTEXT.PasswordChar = '\0';
            this.MTSNTEXT.PlaceholderText = "";
            this.MTSNTEXT.SelectedText = "";
            this.MTSNTEXT.Size = new System.Drawing.Size(133, 19);
            this.MTSNTEXT.TabIndex = 397;
            // 
            // WriteFcMBtn
            // 
            this.WriteFcMBtn.BorderRadius = 5;
            this.WriteFcMBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteFcMBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteFcMBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteFcMBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteFcMBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteFcMBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteFcMBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteFcMBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteFcMBtn.ForeColor = System.Drawing.Color.White;
            this.WriteFcMBtn.Location = new System.Drawing.Point(816, 388);
            this.WriteFcMBtn.Name = "WriteFcMBtn";
            this.WriteFcMBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteFcMBtn.TabIndex = 396;
            this.WriteFcMBtn.Text = "Write";
            this.WriteFcMBtn.Click += new System.EventHandler(this.WriteFcMBtn_Click);
            // 
            // WriteBcMBtn
            // 
            this.WriteBcMBtn.BorderRadius = 5;
            this.WriteBcMBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteBcMBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteBcMBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteBcMBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteBcMBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteBcMBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteBcMBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteBcMBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteBcMBtn.ForeColor = System.Drawing.Color.White;
            this.WriteBcMBtn.Location = new System.Drawing.Point(816, 363);
            this.WriteBcMBtn.Name = "WriteBcMBtn";
            this.WriteBcMBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteBcMBtn.TabIndex = 395;
            this.WriteBcMBtn.Text = "Write";
            this.WriteBcMBtn.Click += new System.EventHandler(this.WriteBcMBtn_Click);
            // 
            // WriteLCmBtn
            // 
            this.WriteLCmBtn.BorderRadius = 5;
            this.WriteLCmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteLCmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteLCmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteLCmBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteLCmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteLCmBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteLCmBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteLCmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteLCmBtn.ForeColor = System.Drawing.Color.White;
            this.WriteLCmBtn.Location = new System.Drawing.Point(816, 338);
            this.WriteLCmBtn.Name = "WriteLCmBtn";
            this.WriteLCmBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteLCmBtn.TabIndex = 394;
            this.WriteLCmBtn.Text = "Write";
            this.WriteLCmBtn.Click += new System.EventHandler(this.WriteLCmBtn_Click);
            // 
            // WriteNSRNBtn
            // 
            this.WriteNSRNBtn.BorderRadius = 5;
            this.WriteNSRNBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteNSRNBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteNSRNBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteNSRNBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteNSRNBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteNSRNBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteNSRNBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteNSRNBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteNSRNBtn.ForeColor = System.Drawing.Color.White;
            this.WriteNSRNBtn.Location = new System.Drawing.Point(816, 313);
            this.WriteNSRNBtn.Name = "WriteNSRNBtn";
            this.WriteNSRNBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteNSRNBtn.TabIndex = 393;
            this.WriteNSRNBtn.Text = "Write";
            // 
            // fcmCheck
            // 
            this.fcmCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fcmCheck.CheckedState.BorderRadius = 2;
            this.fcmCheck.CheckedState.BorderThickness = 0;
            this.fcmCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fcmCheck.Location = new System.Drawing.Point(791, 388);
            this.fcmCheck.Name = "fcmCheck";
            this.fcmCheck.Size = new System.Drawing.Size(20, 19);
            this.fcmCheck.TabIndex = 392;
            this.fcmCheck.Text = "guna2CustomCheckBox9";
            this.fcmCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.fcmCheck.UncheckedState.BorderRadius = 2;
            this.fcmCheck.UncheckedState.BorderThickness = 0;
            this.fcmCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // bcmCheck
            // 
            this.bcmCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bcmCheck.CheckedState.BorderRadius = 2;
            this.bcmCheck.CheckedState.BorderThickness = 0;
            this.bcmCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bcmCheck.Location = new System.Drawing.Point(791, 363);
            this.bcmCheck.Name = "bcmCheck";
            this.bcmCheck.Size = new System.Drawing.Size(20, 19);
            this.bcmCheck.TabIndex = 391;
            this.bcmCheck.Text = "guna2CustomCheckBox10";
            this.bcmCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bcmCheck.UncheckedState.BorderRadius = 2;
            this.bcmCheck.UncheckedState.BorderThickness = 0;
            this.bcmCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // LCMUCHECK
            // 
            this.LCMUCHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LCMUCHECK.CheckedState.BorderRadius = 2;
            this.LCMUCHECK.CheckedState.BorderThickness = 0;
            this.LCMUCHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LCMUCHECK.Location = new System.Drawing.Point(791, 338);
            this.LCMUCHECK.Name = "LCMUCHECK";
            this.LCMUCHECK.Size = new System.Drawing.Size(20, 19);
            this.LCMUCHECK.TabIndex = 390;
            this.LCMUCHECK.Text = "guna2CustomCheckBox11";
            this.LCMUCHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LCMUCHECK.UncheckedState.BorderRadius = 2;
            this.LCMUCHECK.UncheckedState.BorderThickness = 0;
            this.LCMUCHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // NSRNCHECK
            // 
            this.NSRNCHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NSRNCHECK.CheckedState.BorderRadius = 2;
            this.NSRNCHECK.CheckedState.BorderThickness = 0;
            this.NSRNCHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NSRNCHECK.Location = new System.Drawing.Point(791, 313);
            this.NSRNCHECK.Name = "NSRNCHECK";
            this.NSRNCHECK.Size = new System.Drawing.Size(20, 19);
            this.NSRNCHECK.TabIndex = 389;
            this.NSRNCHECK.Text = "guna2CustomCheckBox12";
            this.NSRNCHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NSRNCHECK.UncheckedState.BorderRadius = 2;
            this.NSRNCHECK.UncheckedState.BorderThickness = 0;
            this.NSRNCHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // NVSNCHECK
            // 
            this.NVSNCHECK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NVSNCHECK.CheckedState.BorderRadius = 2;
            this.NVSNCHECK.CheckedState.BorderThickness = 0;
            this.NVSNCHECK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NVSNCHECK.Location = new System.Drawing.Point(791, 288);
            this.NVSNCHECK.Name = "NVSNCHECK";
            this.NVSNCHECK.Size = new System.Drawing.Size(20, 19);
            this.NVSNCHECK.TabIndex = 388;
            this.NVSNCHECK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NVSNCHECK.UncheckedState.BorderRadius = 2;
            this.NVSNCHECK.UncheckedState.BorderThickness = 0;
            this.NVSNCHECK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ModelCheck
            // 
            this.ModelCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelCheck.CheckedState.BorderRadius = 2;
            this.ModelCheck.CheckedState.BorderThickness = 0;
            this.ModelCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelCheck.Location = new System.Drawing.Point(791, 263);
            this.ModelCheck.Name = "ModelCheck";
            this.ModelCheck.Size = new System.Drawing.Size(20, 19);
            this.ModelCheck.TabIndex = 387;
            this.ModelCheck.Text = "guna2CustomCheckBox14";
            this.ModelCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ModelCheck.UncheckedState.BorderRadius = 2;
            this.ModelCheck.UncheckedState.BorderThickness = 0;
            this.ModelCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // WriteNVSNBtn
            // 
            this.WriteNVSNBtn.BorderRadius = 5;
            this.WriteNVSNBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteNVSNBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteNVSNBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteNVSNBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteNVSNBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteNVSNBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteNVSNBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteNVSNBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteNVSNBtn.ForeColor = System.Drawing.Color.White;
            this.WriteNVSNBtn.Location = new System.Drawing.Point(816, 288);
            this.WriteNVSNBtn.Name = "WriteNVSNBtn";
            this.WriteNVSNBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteNVSNBtn.TabIndex = 386;
            this.WriteNVSNBtn.Text = "Write";
            this.WriteNVSNBtn.Click += new System.EventHandler(this.WriteNVSNBtn_Click);
            // 
            // WriteModelBtn
            // 
            this.WriteModelBtn.BorderRadius = 5;
            this.WriteModelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteModelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteModelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteModelBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteModelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteModelBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteModelBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteModelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteModelBtn.ForeColor = System.Drawing.Color.White;
            this.WriteModelBtn.Location = new System.Drawing.Point(816, 263);
            this.WriteModelBtn.Name = "WriteModelBtn";
            this.WriteModelBtn.Size = new System.Drawing.Size(59, 19);
            this.WriteModelBtn.TabIndex = 385;
            this.WriteModelBtn.Text = "Write";
            this.WriteModelBtn.Click += new System.EventHandler(this.WriteModelBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(596, 388);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 15);
            this.label15.TabIndex = 384;
            this.label15.Text = "FCMS";
            // 
            // FCMS_TEXT
            // 
            this.FCMS_TEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FCMS_TEXT.DefaultText = "";
            this.FCMS_TEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FCMS_TEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FCMS_TEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FCMS_TEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FCMS_TEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FCMS_TEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FCMS_TEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FCMS_TEXT.Location = new System.Drawing.Point(652, 388);
            this.FCMS_TEXT.Name = "FCMS_TEXT";
            this.FCMS_TEXT.PasswordChar = '\0';
            this.FCMS_TEXT.PlaceholderText = "";
            this.FCMS_TEXT.SelectedText = "";
            this.FCMS_TEXT.Size = new System.Drawing.Size(133, 19);
            this.FCMS_TEXT.TabIndex = 383;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(596, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 382;
            this.label16.Text = "BCMS:";
            // 
            // BCMS_TEXT
            // 
            this.BCMS_TEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BCMS_TEXT.DefaultText = "";
            this.BCMS_TEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BCMS_TEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BCMS_TEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BCMS_TEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BCMS_TEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BCMS_TEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BCMS_TEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BCMS_TEXT.Location = new System.Drawing.Point(652, 363);
            this.BCMS_TEXT.Name = "BCMS_TEXT";
            this.BCMS_TEXT.PasswordChar = '\0';
            this.BCMS_TEXT.PlaceholderText = "";
            this.BCMS_TEXT.SelectedText = "";
            this.BCMS_TEXT.Size = new System.Drawing.Size(133, 19);
            this.BCMS_TEXT.TabIndex = 381;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(596, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 380;
            this.label17.Text = "LCM#:";
            // 
            // LCMTEXT
            // 
            this.LCMTEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LCMTEXT.DefaultText = "";
            this.LCMTEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LCMTEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LCMTEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LCMTEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LCMTEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LCMTEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LCMTEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LCMTEXT.Location = new System.Drawing.Point(652, 338);
            this.LCMTEXT.Name = "LCMTEXT";
            this.LCMTEXT.PasswordChar = '\0';
            this.LCMTEXT.PlaceholderText = "";
            this.LCMTEXT.SelectedText = "";
            this.LCMTEXT.Size = new System.Drawing.Size(133, 19);
            this.LCMTEXT.TabIndex = 379;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label18.Location = new System.Drawing.Point(596, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 378;
            this.label18.Text = "NSRN:";
            // 
            // NSRNTEXT
            // 
            this.NSRNTEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NSRNTEXT.DefaultText = "";
            this.NSRNTEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NSRNTEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NSRNTEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NSRNTEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NSRNTEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NSRNTEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NSRNTEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NSRNTEXT.Location = new System.Drawing.Point(652, 313);
            this.NSRNTEXT.Name = "NSRNTEXT";
            this.NSRNTEXT.PasswordChar = '\0';
            this.NSRNTEXT.PlaceholderText = "";
            this.NSRNTEXT.SelectedText = "";
            this.NSRNTEXT.Size = new System.Drawing.Size(133, 19);
            this.NSRNTEXT.TabIndex = 377;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(596, 288);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 15);
            this.label19.TabIndex = 376;
            this.label19.Text = "NVSN:";
            // 
            // NVSNTEXT
            // 
            this.NVSNTEXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NVSNTEXT.DefaultText = "";
            this.NVSNTEXT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NVSNTEXT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NVSNTEXT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NVSNTEXT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NVSNTEXT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NVSNTEXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NVSNTEXT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NVSNTEXT.Location = new System.Drawing.Point(652, 288);
            this.NVSNTEXT.Name = "NVSNTEXT";
            this.NVSNTEXT.PasswordChar = '\0';
            this.NVSNTEXT.PlaceholderText = "";
            this.NVSNTEXT.SelectedText = "";
            this.NVSNTEXT.Size = new System.Drawing.Size(133, 19);
            this.NVSNTEXT.TabIndex = 375;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(596, 263);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 15);
            this.label20.TabIndex = 374;
            this.label20.Text = "Model:";
            // 
            // ModelTextB
            // 
            this.ModelTextB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ModelTextB.DefaultText = "";
            this.ModelTextB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ModelTextB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ModelTextB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTextB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ModelTextB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTextB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ModelTextB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ModelTextB.Location = new System.Drawing.Point(652, 263);
            this.ModelTextB.Name = "ModelTextB";
            this.ModelTextB.PasswordChar = '\0';
            this.ModelTextB.PlaceholderText = "";
            this.ModelTextB.SelectedText = "";
            this.ModelTextB.Size = new System.Drawing.Size(133, 19);
            this.ModelTextB.TabIndex = 373;
            // 
            // ClearButton
            // 
            this.ClearButton.Animated = true;
            this.ClearButton.BorderColor = System.Drawing.Color.Gray;
            this.ClearButton.BorderRadius = 3;
            this.ClearButton.BorderThickness = 1;
            this.ClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearButton.FillColor = System.Drawing.Color.Silver;
            this.ClearButton.FillColor2 = System.Drawing.Color.Silver;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(275, 464);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(131, 32);
            this.ClearButton.TabIndex = 403;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Animated = true;
            this.SelectAllButton.BorderColor = System.Drawing.Color.Gray;
            this.SelectAllButton.BorderRadius = 3;
            this.SelectAllButton.BorderThickness = 1;
            this.SelectAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectAllButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectAllButton.FillColor = System.Drawing.Color.Silver;
            this.SelectAllButton.FillColor2 = System.Drawing.Color.Silver;
            this.SelectAllButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectAllButton.ForeColor = System.Drawing.Color.White;
            this.SelectAllButton.Location = new System.Drawing.Point(420, 464);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(131, 32);
            this.SelectAllButton.TabIndex = 404;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // DeselectAllButton
            // 
            this.DeselectAllButton.Animated = true;
            this.DeselectAllButton.BorderColor = System.Drawing.Color.Gray;
            this.DeselectAllButton.BorderRadius = 3;
            this.DeselectAllButton.BorderThickness = 1;
            this.DeselectAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeselectAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeselectAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeselectAllButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeselectAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeselectAllButton.FillColor = System.Drawing.Color.Silver;
            this.DeselectAllButton.FillColor2 = System.Drawing.Color.Silver;
            this.DeselectAllButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeselectAllButton.ForeColor = System.Drawing.Color.White;
            this.DeselectAllButton.Location = new System.Drawing.Point(565, 464);
            this.DeselectAllButton.Name = "DeselectAllButton";
            this.DeselectAllButton.Size = new System.Drawing.Size(131, 32);
            this.DeselectAllButton.TabIndex = 405;
            this.DeselectAllButton.Text = "Deselect All";
            this.DeselectAllButton.Click += new System.EventHandler(this.DeselectAllButton_Click);
            // 
            // WriteAllBtn
            // 
            this.WriteAllBtn.Animated = true;
            this.WriteAllBtn.BorderColor = System.Drawing.Color.Gray;
            this.WriteAllBtn.BorderRadius = 3;
            this.WriteAllBtn.BorderThickness = 1;
            this.WriteAllBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WriteAllBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WriteAllBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteAllBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WriteAllBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WriteAllBtn.Enabled = false;
            this.WriteAllBtn.FillColor = System.Drawing.Color.Silver;
            this.WriteAllBtn.FillColor2 = System.Drawing.Color.Silver;
            this.WriteAllBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WriteAllBtn.ForeColor = System.Drawing.Color.White;
            this.WriteAllBtn.Location = new System.Drawing.Point(711, 464);
            this.WriteAllBtn.Name = "WriteAllBtn";
            this.WriteAllBtn.Size = new System.Drawing.Size(131, 32);
            this.WriteAllBtn.TabIndex = 406;
            this.WriteAllBtn.Text = "Write All";
            this.WriteAllBtn.Click += new System.EventHandler(this.WriteAllBtn_Click);
            // 
            // DriverRepairButton
            // 
            this.DriverRepairButton.BorderColor = System.Drawing.Color.DimGray;
            this.DriverRepairButton.BorderRadius = 6;
            this.DriverRepairButton.BorderThickness = 1;
            this.DriverRepairButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DriverRepairButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DriverRepairButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DriverRepairButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DriverRepairButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DriverRepairButton.FillColor = System.Drawing.Color.Silver;
            this.DriverRepairButton.FillColor2 = System.Drawing.Color.Silver;
            this.DriverRepairButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DriverRepairButton.ForeColor = System.Drawing.Color.White;
            this.DriverRepairButton.Location = new System.Drawing.Point(24, 232);
            this.DriverRepairButton.Name = "DriverRepairButton";
            this.DriverRepairButton.Size = new System.Drawing.Size(181, 31);
            this.DriverRepairButton.TabIndex = 407;
            this.DriverRepairButton.Text = "Driver Repair";
            this.DriverRepairButton.Click += new System.EventHandler(this.DriverRepairButton_Click);
            // 
            // TerminalBox
            // 
            this.TerminalBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TerminalBox.DefaultText = "";
            this.TerminalBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TerminalBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TerminalBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TerminalBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TerminalBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TerminalBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TerminalBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TerminalBox.Location = new System.Drawing.Point(16, 544);
            this.TerminalBox.Name = "TerminalBox";
            this.TerminalBox.PasswordChar = '\0';
            this.TerminalBox.PlaceholderText = "";
            this.TerminalBox.SelectedText = "";
            this.TerminalBox.Size = new System.Drawing.Size(124, 19);
            this.TerminalBox.TabIndex = 409;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(16, 424);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(189, 114);
            this.richTextBox1.TabIndex = 410;
            this.richTextBox1.Text = "";
            // 
            // GoTerminal
            // 
            this.GoTerminal.BorderRadius = 5;
            this.GoTerminal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GoTerminal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GoTerminal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoTerminal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GoTerminal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GoTerminal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GoTerminal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GoTerminal.ForeColor = System.Drawing.Color.White;
            this.GoTerminal.Location = new System.Drawing.Point(146, 544);
            this.GoTerminal.Name = "GoTerminal";
            this.GoTerminal.Size = new System.Drawing.Size(59, 19);
            this.GoTerminal.TabIndex = 411;
            this.GoTerminal.Text = "Exec";
            this.GoTerminal.Click += new System.EventHandler(this.GoTerminal_Click);
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressIndicator1.Enabled = false;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(278, 234);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(20, 23);
            this.guna2ProgressIndicator1.TabIndex = 413;
            this.guna2ProgressIndicator1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.progressBar1.BorderRadius = 7;
            this.progressBar1.FillColor = System.Drawing.Color.Transparent;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(246, 544);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.progressBar1.Size = new System.Drawing.Size(662, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 412;
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorkerCFG
            // 
            this.backgroundWorkerCFG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCFG_DoWork);
            this.backgroundWorkerCFG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCFG_ProgressChanged);
            // 
            // Readbackground
            // 
            this.Readbackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Readbackground_DoWork);
            // 
            // FactoryBtn
            // 
            this.FactoryBtn.BorderColor = System.Drawing.Color.DimGray;
            this.FactoryBtn.BorderRadius = 6;
            this.FactoryBtn.BorderThickness = 1;
            this.FactoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FactoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FactoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FactoryBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FactoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FactoryBtn.FillColor = System.Drawing.Color.Silver;
            this.FactoryBtn.FillColor2 = System.Drawing.Color.Silver;
            this.FactoryBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FactoryBtn.ForeColor = System.Drawing.Color.White;
            this.FactoryBtn.Location = new System.Drawing.Point(24, 370);
            this.FactoryBtn.Name = "FactoryBtn";
            this.FactoryBtn.Size = new System.Drawing.Size(181, 31);
            this.FactoryBtn.TabIndex = 414;
            this.FactoryBtn.Text = "Factory Reset";
            this.FactoryBtn.Click += new System.EventHandler(this.FactoryBtn_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(213, 63);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 550);
            this.guna2VSeparator1.TabIndex = 415;
            // 
            // UnlockBtn
            // 
            this.UnlockBtn.BorderColor = System.Drawing.Color.DimGray;
            this.UnlockBtn.BorderRadius = 6;
            this.UnlockBtn.BorderThickness = 1;
            this.UnlockBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UnlockBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UnlockBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnlockBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnlockBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UnlockBtn.FillColor = System.Drawing.Color.Silver;
            this.UnlockBtn.FillColor2 = System.Drawing.Color.Silver;
            this.UnlockBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UnlockBtn.ForeColor = System.Drawing.Color.White;
            this.UnlockBtn.Location = new System.Drawing.Point(24, 300);
            this.UnlockBtn.Name = "UnlockBtn";
            this.UnlockBtn.Size = new System.Drawing.Size(181, 31);
            this.UnlockBtn.TabIndex = 417;
            this.UnlockBtn.Text = "iCloud Unlock";
            this.UnlockBtn.Click += new System.EventHandler(this.UnlockBtn_Click);
            // 
            // Rbtn
            // 
            this.Rbtn.BorderColor = System.Drawing.Color.DimGray;
            this.Rbtn.BorderRadius = 6;
            this.Rbtn.BorderThickness = 1;
            this.Rbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Rbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Rbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Rbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Rbtn.FillColor = System.Drawing.Color.Silver;
            this.Rbtn.FillColor2 = System.Drawing.Color.Silver;
            this.Rbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rbtn.ForeColor = System.Drawing.Color.White;
            this.Rbtn.Location = new System.Drawing.Point(24, 335);
            this.Rbtn.Name = "Rbtn";
            this.Rbtn.Size = new System.Drawing.Size(181, 31);
            this.Rbtn.TabIndex = 418;
            this.Rbtn.Text = "Reboot iDevice";
            this.Rbtn.Click += new System.EventHandler(this.Rbtn_Click);
            // 
            // Dissconect
            // 
            this.Dissconect.Image = ((System.Drawing.Image)(resources.GetObject("Dissconect.Image")));
            this.Dissconect.Location = new System.Drawing.Point(222, 84);
            this.Dissconect.Name = "Dissconect";
            this.Dissconect.Size = new System.Drawing.Size(133, 145);
            this.Dissconect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dissconect.TabIndex = 328;
            this.Dissconect.TabStop = false;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton3.Location = new System.Drawing.Point(525, 89);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton3.Size = new System.Drawing.Size(23, 19);
            this.guna2ImageButton3.TabIndex = 402;
            // 
            // reloadPort
            // 
            this.reloadPort.BackColor = System.Drawing.Color.Transparent;
            this.reloadPort.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reloadPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadPort.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.reloadPort.Image = ((System.Drawing.Image)(resources.GetObject("reloadPort.Image")));
            this.reloadPort.ImageOffset = new System.Drawing.Point(0, 0);
            this.reloadPort.ImageRotate = 0F;
            this.reloadPort.ImageSize = new System.Drawing.Size(20, 20);
            this.reloadPort.Location = new System.Drawing.Point(181, 129);
            this.reloadPort.Name = "reloadPort";
            this.reloadPort.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.reloadPort.Size = new System.Drawing.Size(26, 26);
            this.reloadPort.TabIndex = 332;
            // 
            // connect
            // 
            this.connect.Image = global::MagicCFG.Properties.Resources.iphone7;
            this.connect.Location = new System.Drawing.Point(235, 93);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(113, 126);
            this.connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connect.TabIndex = 408;
            this.connect.TabStop = false;
            this.connect.Visible = false;
            // 
            // MainCFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(971, 613);
            this.Controls.Add(this.Rbtn);
            this.Controls.Add(this.UnlockBtn);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.FactoryBtn);
            this.Controls.Add(this.guna2ProgressIndicator1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.GoTerminal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TerminalBox);
            this.Controls.Add(this.Dissconect);
            this.Controls.Add(this.DriverRepairButton);
            this.Controls.Add(this.WriteAllBtn);
            this.Controls.Add(this.DeselectAllButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.WriteMtSNBtn);
            this.Controls.Add(this.MtSN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MTSNTEXT);
            this.Controls.Add(this.WriteFcMBtn);
            this.Controls.Add(this.WriteBcMBtn);
            this.Controls.Add(this.WriteLCmBtn);
            this.Controls.Add(this.WriteNSRNBtn);
            this.Controls.Add(this.fcmCheck);
            this.Controls.Add(this.bcmCheck);
            this.Controls.Add(this.LCMUCHECK);
            this.Controls.Add(this.NSRNCHECK);
            this.Controls.Add(this.NVSNCHECK);
            this.Controls.Add(this.ModelCheck);
            this.Controls.Add(this.WriteNVSNBtn);
            this.Controls.Add(this.WriteModelBtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.FCMS_TEXT);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BCMS_TEXT);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.LCMTEXT);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.NSRNTEXT);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.NVSNTEXT);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ModelTextB);
            this.Controls.Add(this.WriteMlbBtn);
            this.Controls.Add(this.MLBCheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.MlbText);
            this.Controls.Add(this.WriteEmacBtn);
            this.Controls.Add(this.WriteBmacBtn);
            this.Controls.Add(this.WriteWmacBtn);
            this.Controls.Add(this.WriteRegionBtn);
            this.Controls.Add(this.EMacCheck);
            this.Controls.Add(this.BMacCheck);
            this.Controls.Add(this.WmacCheck);
            this.Controls.Add(this.RegionCheck);
            this.Controls.Add(this.ModeCheck);
            this.Controls.Add(this.SNCheck);
            this.Controls.Add(this.WriteModeBtn);
            this.Controls.Add(this.WriteSNBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EMacText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BMacTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WMacText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RegionText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModeTextB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxSerial);
            this.Controls.Add(this.BackupCFGButton);
            this.Controls.Add(this.ReadCDFGButton);
            this.Controls.Add(this.LBLMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblNand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblECID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBLModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.reloadPort);
            this.Controls.Add(this.BoxPort);
            this.Controls.Add(this.DiagButton);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.MainPanelUP);
            this.Controls.Add(this.connect);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainCFG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagicCFG";
            this.Load += new System.EventHandler(this.MainCFG_Load);
            this.MainPanelUP.ResumeLayout(false);
            this.MainPanelUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dissconect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void Readbackground_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            bool statc = false;

            try
            {
                // Llama a ReadDeviceInBackgroundAsync() en un hilo secundario usando Task.Run
                statc = await Task.Run(() => ReadDeviceInBackgroundAsync());
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la lectura
                Console.WriteLine($"Error durante la lectura: {ex.Message}");
            }
            finally
            {
                // Actualiza la interfaz de usuario en el hilo principal utilizando Invoke
                if (statc == true)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Actualiza la interfaz de usuario para la conexión exitosa
                        deviceDFUconnect();
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Actualiza la interfaz de usuario para la desconexión
                        deviceDFUdissconnect();
                    });
                }
            }

        }



        private void BoxPort_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.BoxPort.Text = "";
                this.BoxPort.Items.Clear();
                string[] portNames = SerialPort.GetPortNames();
                foreach (string item in portNames)
                {
                    this.BoxPort.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " This machine has no serial port !");
            }
        }


        public static string ParseMactoMacHex(string hex)
        {
            var mac = new System.Text.StringBuilder();
            hex = hex.Replace(":", "");
            string v1 = hex.Substring(0, 2);
            string v2 = hex.Substring(2, 2);
            string v3 = hex.Substring(4, 2);
            string v4 = hex.Substring(6, 2);
            string v5 = hex.Substring(8, 2);
            string v6 = hex.Substring(10, 2);
            mac.Append($"0x{v4}{v3}{v2}{v1} 0x0000{v6}{v5} 0x00000000 0x00000000");
            return mac.ToString();
        }




        public string GetEcidDIAGMode()
        {
            var query = new SelectQuery("Win32_PnPEntity", "PNPClass = 'Ports'");

            // Creamos el objeto ManagementObjectSearcher para ejecutar la consulta
            using (var searcher = new ManagementObjectSearcher(query))
            {
                // Iteramos sobre los resultados de la consulta
                foreach (var device in searcher.Get())
                {
                    // Obtenemos el nombre del puerto (DeviceID), descripción del dispositivo y el tipo de puerto
                    var deviceID = device["DeviceID"].ToString();
                    var description = device["Description"].ToString();

                    // Comprobamos si el dispositivo contiene la información del ECID
                    if (deviceID.Contains("ECID"))
                    {
                        // Mostramos el dispositivo encontrado con ECID en la consola
                        Console.WriteLine("Dispositivo encontrado:");
                        Console.WriteLine("Nombre del puerto: " + deviceID);
                        Console.WriteLine("Descripción: " + description);
                        Console.WriteLine("-----------------------------------------");
                        string delimitador = "ECID:";

                        // Dividimos la cadena usando el delimitador y nos quedamos con la segunda parte
                        string[] partes = deviceID.Split(new string[] { delimitador }, StringSplitOptions.None);
                        string resultadoEcid = partes[1].Trim();

                        Console.WriteLine(resultadoEcid);
                        iOSDevice.ECID = resultadoEcid;
                        return resultadoEcid;
                    }
                }
            }

            iOSDevice.ECID = "";
            return "Error";

        }


        private void backgroundWorkerCFG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // Change the value of the ProgressBar to the BackgroundWorker progress.

            progressBar1.Value = e.ProgressPercentage;
        }


        private void OnDeviceNotifyEvent(object sender, DeviceNotifyEventArgs e)
        {
            if (e.EventType.ToString() == "DeviceRemoveComplete")

            {
                Readbackground.RunWorkerAsync();

            }

            else

            {
                Readbackground.RunWorkerAsync();

            }
        }
        private void MainPanelUP_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {

            if (ConnectButton.Text == "Dissconect")
            {

                ReadCDFGButton.Enabled = false;
                BackupCFGButton.Enabled = false;
                WriteAllBtn.Enabled = false;
                ConnectButton.Text = "Connect";
            }
            else
            {
                WriteAllBtn.Enabled = true;
                ReadCDFGButton.Enabled = true;
                BackupCFGButton.Enabled = true;
                ConnectButton.Text = "Dissconect";
            }


        }


        public static void USB(bool sx)
        {
            UsbDeviceNotifier.Enabled = sx;

        }

        private void CloseCFG_Click(object sender, EventArgs e)
        {
            var processesByName = Process.GetProcessesByName("irecovery");
            var tool = Process.GetProcessesByName("MagicCFG");
            if (processesByName.Length >= 1)
            {
                foreach (var process in processesByName) process.Kill();
                foreach (var process in tool) process.Kill();
            }
            Environment.Exit(1);
        }

        private void MainCFG_Load(object sender, EventArgs e)
        {
            UsbDeviceNotifier.OnDeviceNotify += OnDeviceNotifyEvent;

            string appName = Application.ProductName;
            string formName = this.Text;
            if (appName != "MagicCFG" || formName != "MagicCFG"){ Application.Exit();}
        }


        public void LogMessage(string message)
        {
            // Agregar mensaje al control RichTextBox
            richTextBox1.AppendText(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + message + Environment.NewLine);

        }


        private void ReadMethod()
        {
            CheckForIllegalCrossThreadCalls = false;

            if (labelName.Text != "MagicCFG") { Application.Exit(); }

            var res = iRecovery.getIdeviceInfo();

            if (res == false)
            {
                deviceDFUdissconnect();

            }
            else
            {
                deviceDFUconnect();
            }
        }

        private async Task<bool> ReadDeviceInBackgroundAsync()
        {

            var res = iRecovery.getIdeviceInfo();

            if (res == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public void deviceDFUconnect()
        {
            Dissconect.Visible = false;
            LblECID.Text = iOSDevice.ECID;
            LBLModel.Text = iOSDevice.DetermineModel(iOSDevice.ProductType);
            LBLMode.Text = iOSDevice.Mode;
            connect.Visible = true;

            iOSDevice.Model = iOSDevice.DetermineModel(iOSDevice.ProductType);

            Image imagenDesdeRecursos = null; // Inicializamos la variable aquí

            if (iOSDevice.Model.StartsWith("iPhone 6"))
            {
                imagenDesdeRecursos = Properties.Resources.iPhone6sPlus;
            }
            else if (iOSDevice.Model.StartsWith("iPhone 7"))
            {
                imagenDesdeRecursos = Properties.Resources.iphone7;
            }
            else if (iOSDevice.Model.StartsWith("iPhone 7 Plus"))
            {
                imagenDesdeRecursos = Properties.Resources.iPhone7Plus;
            }
            else if (iOSDevice.Model.StartsWith("iPhone 8"))
            {
                imagenDesdeRecursos = Properties.Resources.iphone8;
            }
            else if (iOSDevice.Model.StartsWith("iPhone 8 Plus"))
            {
                imagenDesdeRecursos = Properties.Resources.iphone8Plus;
            }
            else if (iOSDevice.Model.StartsWith("iPhone X"))
            {
                imagenDesdeRecursos = Properties.Resources.iphonex;
            }
            else if (iOSDevice.Model.StartsWith("iPad"))
            {
                imagenDesdeRecursos = Properties.Resources.iPadblack;
            }
            else
            {
                imagenDesdeRecursos = Properties.Resources.iphone7; // Imagen por defecto si no se cumple ninguna condición
            }

            connect.Image = imagenDesdeRecursos;
        }

        public void deviceDFUdissconnect()
        {
            Dissconect.Visible = true;
            LblECID.Text = "-";
            LBLModel.Text = "-";
            LBLMode.Text = "-";
            LblNand.Text = "-";
            connect.Visible = false;
        }


        private void IniciarAnimacion()
        {
            guna2ProgressIndicator1.AnimationSpeed = 90;
            guna2ProgressIndicator1.AutoStart = true;
            guna2ProgressIndicator1.Enabled = true;
            guna2ProgressIndicator1.Visible = true;

            progressBar1.Visible = true;
            progressBar1.Maximum = 0;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;

        }

        private void DetenerAnimacion()
        {
            guna2ProgressIndicator1.AnimationSpeed = 0;
            guna2ProgressIndicator1.AutoStart = false;
            guna2ProgressIndicator1.Enabled = false;
            guna2ProgressIndicator1.Visible = false;

            progressBar1.Visible = false;
            progressBar1.Maximum = 0;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Marquee;

        }


        private bool Openport()
        {

            bool isOpen = this.serialPort.IsOpen;
            if (!isOpen)
            {
                try
                {
                    bool flag = this.BoxPort.SelectedIndex == -1;
                    if (flag)
                    {
                        MessageBox.Show("Error: Unable to find any usb serial modem in this machine. if you wish to continue if you have DCSD or Alex cable", "info!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        //string portName = COM().ToString();
                        string portName = this.BoxPort.SelectedItem.ToString();
                        string value = "8";
                        int baudRate = Convert.ToInt32("9600");
                        int dataBits = Convert.ToInt32(value);
                        this.serialPort.PortName = portName;
                        this.serialPort.BaudRate = baudRate;
                        this.serialPort.DataBits = dataBits;
                        this.serialPort.StopBits = StopBits.One;
                        this.serialPort.Parity = Parity.None;
                        bool flag2 = this.string_19 != null;
                        if (flag2)
                        {
                            fileStream_0 = File.Create(string_19);
                        }
                        this.serialPort.Open();
                        this.serialPort.WriteLine("");
                        this.method_3();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                
            }
            return true;
        }

        public string method_3()
        {
            bool isOpen = this.serialPort.IsOpen;
            string result;
            if (isOpen)
            {
                try
                {
                    string text = this.serialPort.ReadExisting();
                    string_14 += text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Is there a problem with your baud rate?？？？");
                    return string_14;
                }
                this.serialPort.DiscardInBuffer();
                result = string_14;
            }
            else
            {
                MessageBox.Show("Serial port not open", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = string_14;
            }
            return result;
        }


        public static string RemoveTheFuckingChars(string funcKey, string key)
        {

            string str = key;
            int index = str.IndexOf($"{funcKey}\n");



            if (index != -1)
            {
                string substring = str.Substring(index);
                string restring = substring;
                restring = restring.Remove(0, 1);

                if (restring.Length >= 2)
                {
                    restring = restring.Remove(restring.Length - 2);
                }

                return restring;
            }
            else
            {
                return "error";
            }
        }

        public static string MakeHex(string input)
        {
            string[] parts = input.Split(' ');
            StringBuilder output = new StringBuilder();

            foreach (string hexString in parts)
            {
                string fixedHexString = hexString.Replace("0x", "");
                while (fixedHexString.Length != 0)
                {
                    string hexPair = fixedHexString.Substring(fixedHexString.Length - 2);
                    if (fixedHexString.Length >= 2)
                    {
                        fixedHexString = fixedHexString.Remove(fixedHexString.Length - 2);
                    }
                    else
                    {
                        break;
                    }

                    output.Append(hexPair);
                }
            }

            return output.ToString();
        }

        public static string RemoveDangerousCharsForSYSCFG(string str)
        {
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_:+";
            string cleanedString = new string(str.Where(c => allowedChars.Contains(c)).ToArray());
            str = cleanedString;
            return str;
        }


        public static string ExtractValue(string input, string keyword)
        {
            string pattern = keyword + "\\n(.*?)\\n";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            string result;
            if (!match.Success)
            {
                result = null;
            }
            else
            {
                result = match.Groups[1].Value.Trim();
            }
            return result;
        }


        public void RunTerminalPort(string CMD) 
        {

            if (!Openport())
            {
                DetenerAnimacion();
                return;

            }

            Console.WriteLine(CMD);

            serialPort.WriteLine(CMD);

            LogMessage($"Commnd Running: {CMD}");


        }

        private void WriteSNBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("SrNm", TextBoxSerial.Text);

                MessageBox.Show(@"New SN Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }


        }

        private void WriteModeBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("Mod#", "");

                MessageBox.Show(@"New mode Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }


        }

        private void WriteRegionBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("Regn", "");

                MessageBox.Show(@"New mode Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }

        }

        private void WriteWmacBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("WMac", WMacText.Text);

                MessageBox.Show(@"New Wifi Address Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteBmacBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("BMac", BMacTxt.Text);

                MessageBox.Show(@"New Bluetooth Address Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteEmacBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("EMac", EMacText.Text);

                MessageBox.Show(@"New Emac Address Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }



        private void WriteMlbBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("MLB#", "");

                MessageBox.Show(@"New MLB Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteModelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("RMd#", "");

                MessageBox.Show(@"New Model Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteNVSNBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("NvSn", "");

                MessageBox.Show(@"New NvSn Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteLCmBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("LCM#\t", "");

                MessageBox.Show(@"New LCM Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteBcMBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("BCMS", "");

                MessageBox.Show(@"New BCMS Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteFcMBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("FCMS", "");

                MessageBox.Show(@"New BCMS Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        private void WriteMtSNBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("MtSN", "");

                MessageBox.Show(@"New BCMS Added", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }
        }

        public void WriteAllNandData()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to do this action?", "information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                WriteNandDataDevice("SrNm", TextBoxSerial.Text);
                WriteNandDataDevice("Mod#", "");
                WriteNandDataDevice("Regn", "");
                WriteNandDataDevice("WMac", WMacText.Text);
                WriteNandDataDevice("BMac", BMacTxt.Text);
                WriteNandDataDevice("EMac", EMacText.Text);
                WriteNandDataDevice("MLB#", "");
                WriteNandDataDevice("RMd#", "");
                WriteNandDataDevice("NvSn", "");
                WriteNandDataDevice("LCM#\t", "");
                WriteNandDataDevice("BCMS", "");
                WriteNandDataDevice("FCMS", "");
                WriteNandDataDevice("MtSN", "");

            }
            else
            {
                // Aquí puedes colocar el código para cancelar la acción si el usuario no está seguro
                Console.WriteLine("Acción cancelada.");
            }


        }

        public void Checkers(bool state)
        {

            SNCheck.Checked = state;
            ModeCheck.Checked = state;
            RegionCheck.Checked = state;
            WmacCheck.Checked = state;
            BMacCheck.Checked = state;
            EMacCheck.Checked = state;
            ModelCheck.Checked = state;
            NVSNCHECK.Checked = state;
            NSRNCHECK.Checked = state;
            LCMUCHECK.Checked = state;
            bcmCheck.Checked = state;
            fcmCheck.Checked = state;
            MtSN.Checked = state;
            MLBCheck.Checked = state;
        }

        public void ClearAll()
        { 
            string Result = "";

            richTextBox1.Clear();
            RegionText.Text = Result; 
            MlbText.Text = Result; 
            ModeTextB.Text = Result; 
            ModelTextB.Text = Result; 
            NVSNTEXT.Text = Result; 
            NSRNTEXT.Text = Result; 
            LCMTEXT.Text = Result; 
            BCMS_TEXT.Text = Result; 
            FCMS_TEXT.Text = Result; 
            MTSNTEXT.Text = Result;
            EMacText.Text = Result;
            BMacTxt.Text = Result;
            WMacText.Text = Result;
            TextBoxSerial.Text = Result;
        }


        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            Checkers(true);
        }

        private void DeselectAllButton_Click(object sender, EventArgs e)
        {
            Checkers(false);
        }


        private Dictionary<string, Dictionary<string, object>> phoneModelsDictionary;




        private void InitializeDictionary()
        {
        phoneModelsDictionary = new Dictionary<string, Dictionary<string, object>>
        {
        {
        "A1566", new Dictionary<string, object>
        {
        { "Name", "iPad Air 2" },
        { "Model", "iPad5,3" },
        { "FCCID", new List<string> { "BCG‑E2643A", "BCG‑E2643B" } }
        }
        },
        {
        "A1567", new Dictionary<string, object>
        {
        { "Name", "iPad Air 2" },
        { "Model", "iPad5,4" },
        { "FCCID", new List<string> { "BCG‑E2643A", "BCG‑E2643B" } }
        }
        },
        {
        "A1584", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (12.9-inch)" },
        { "Model", "iPad6,7" },
        { "FCCID", new List<string> { "BCG‑E2945A" } }
        }
        },
        {
        "A1652", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (12.9-inch)" },
        { "Model", "iPad6,8" },
        { "FCCID", new List<string> { "BCG‑E2945A" } }
        }
        },
        {
        "A1673", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (9.7-inch)" },
        { "Model", "iPad6,3" },
        { "FCCID", "BCG‑E2816A" }
        }
        },
        {
        "A1549", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (9.7-inch)" },
        { "Model", "iPad6,4" },
        { "FCCID", "BCG‑E2816A" }
        }
        },
        {
        "A1822", new Dictionary<string, object>
        {
        { "Name", "iPad (5th generation)" },
        { "Model", "iPad6,11" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
         {
        "A1823", new Dictionary<string, object>
        {
        { "Name", "iPad (5th generation)" },
        { "Model", "iPad6,12" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1670", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (12.9-inch, 2nd generation)" },
        { "Model", "iPad7,1" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1671", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (12.9-inch, 2nd generation)" },
        { "Model", "iPad7,2" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1821", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (12.9-inch, 2nd generation)" },
        { "Model", "iPad7,2" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1701", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (10.5-inch)" },
        { "Model", "iPad7,3" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
          {
        "A1709", new Dictionary<string, object>
        {
        { "Name", "iPad Pro (10.5-inch)" },
        { "Model", "iPad7,4" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
         {
        "A1893", new Dictionary<string, object>
        {
        { "Name", "iPad (6th generation)" },
        { "Model", "iPad7,5" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1954", new Dictionary<string, object>
        {
        { "Name", "iPad (6th generation)" },
        { "Model", "iPad7,6" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
         {
        "A2197", new Dictionary<string, object>
        {
        { "Name", "iPad (7th generation)" },
        { "Model", "iPad7,11" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A2200", new Dictionary<string, object>
        {
        { "Name", "iPad (7th generation)" },
        { "Model", "iPad7,12" },
        { "FCCID", "BCG‑E2817A" }
        }
        },
        {
        "A1633", new Dictionary<string, object>
        {
        { "Name", "iPhone 6s" },
        { "Model", "iPhone8,1" },
        { "FCCID", "BCG-E2946A" }
        }
        },
        {
        "A1634", new Dictionary<string, object>
        {
        { "Name", "iPhone 6s Plus" },
        { "Model", "iPhone8,2" },
        { "FCCID", "BCG-E2944A" }
        }
        },
        {
        "A1660", new Dictionary<string, object>
        {
        { "Name", "iPhone 7" },
        { "Model", "iPhone9,1" },
        { "FCCID", new List<string> { "BCG‑E3085A", "BCG‑E3086A" } }
        }
        },
        {
        "A1778", new Dictionary<string, object>
        {
        { "Name", "iPhone 7" },
        { "Model", "iPhone9,3" },
        { "FCCID", "BCG‑E3091A" }
        }
        },
        {
        "A1661", new Dictionary<string, object>
        {
        { "Name", "iPhone 7 Plus" },
        { "Model", "iPhone9,2" },
        { "FCCID", new List<string> { "BCG‑E3087A", "BCG‑E3088A" } }
        }
        },
        {
        "A1784", new Dictionary<string, object>
        {
        { "Name", "iPhone 7 Plus" },
        { "Model", "iPhone9,4" },
        { "FCCID", "BCG‑E3092A" }
        }
        },
        {
        "A1863", new Dictionary<string, object>
        {
        { "Name", "iPhone 8" },
        { "Model", "iPhone10,1" },
        { "FCCID", new List<string> { "BCG-E3159A", "BCG-E3171A" } }
        }
        },
        {
        "A1905", new Dictionary<string, object>
        {
        { "Name", "iPhone 8" },
        { "Model", "iPhone10,4" },
        { "FCCID", "BCG-E3172A" }
        }
        },
        {
        "A1864", new Dictionary<string, object>
        {
        { "Name", "iPhone 8 Plus" },
        { "Model", "iPhone10,2" },
        { "FCCID", new List<string> { "BCG-E3160A", "BCG-E3173A" } }
        }
        },
        {
        "A1897", new Dictionary<string, object>
        {
        { "Name", "iPhone 8 Plus" },
        { "Model", "iPhone10,5" },
        { "FCCID", "BCG-E3174A" }
        }
        },
        {
        "A1865", new Dictionary<string, object>
        {
        { "Name", "iPhone X" },
        { "Model", "iPhone10,3" },
        { "FCCID", "BCG-E3161A" }
        }
        },

        {
        "A1901", new Dictionary<string, object>
        {
        { "Name", "iPhone X" },
        { "Model", "iPhone10,6" },
        { "FCCID", "BCG-E3175A" }
        }

        }     
        };
        }

        private string GetModelByANumber(string aNumber)
        {
            if (phoneModelsDictionary.TryGetValue(aNumber, out Dictionary<string, object> modelData))
            {
                string name = modelData["Name"].ToString();
                string model = modelData["Model"].ToString();

                // Aquí puedes hacer lo que desees con los datos del modelo encontrado
                iOSDevice.Model = model;
                return name;
            }
            else
            {
                return "Model Not Found";
            }
        }



        private SerialPort serialPort = new SerialPort();
        private string string_19;
        public static string string_0 = Directory.GetCurrentDirectory();
        public static string string_6;
        public static string string_7;
        public static string string_8;
        public static string string_15;
        public static string string_16;
        public static string string_17;
        public static string string_18;
        public static string string_14;
        private FileStream fileStream_0;
        public int deviceAge = 1;

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton CloseCFG;
        private Guna.UI2.WinForms.Guna2Panel MainPanelUP;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2ImageButton reloadPort;
        private Guna.UI2.WinForms.Guna2ComboBox BoxPort;
        private Guna.UI2.WinForms.Guna2GradientButton DiagButton;
        private System.Windows.Forms.PictureBox Dissconect;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblNand;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblECID;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton ConnectButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GradientButton DriverRepairButton;
        private Guna.UI2.WinForms.Guna2GradientButton WriteAllBtn;
        private Guna.UI2.WinForms.Guna2GradientButton DeselectAllButton;
        private Guna.UI2.WinForms.Guna2GradientButton SelectAllButton;
        private Guna.UI2.WinForms.Guna2GradientButton ClearButton;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2GradientButton WriteMtSNBtn;
        private Guna.UI2.WinForms.Guna2CustomCheckBox MtSN;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox MTSNTEXT;
        private Guna.UI2.WinForms.Guna2GradientButton WriteFcMBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteBcMBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteLCmBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteNSRNBtn;
        private Guna.UI2.WinForms.Guna2CustomCheckBox fcmCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox bcmCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox LCMUCHECK;
        private Guna.UI2.WinForms.Guna2CustomCheckBox NSRNCHECK;
        private Guna.UI2.WinForms.Guna2CustomCheckBox NVSNCHECK;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ModelCheck;
        private Guna.UI2.WinForms.Guna2GradientButton WriteNVSNBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteModelBtn;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox FCMS_TEXT;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox BCMS_TEXT;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox LCMTEXT;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox NSRNTEXT;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox NVSNTEXT;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox ModelTextB;
        private Guna.UI2.WinForms.Guna2GradientButton WriteMlbBtn;
        private Guna.UI2.WinForms.Guna2CustomCheckBox MLBCheck;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox MlbText;
        private Guna.UI2.WinForms.Guna2GradientButton WriteEmacBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteBmacBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteWmacBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteRegionBtn;
        private Guna.UI2.WinForms.Guna2CustomCheckBox EMacCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox BMacCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox WmacCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox RegionCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ModeCheck;
        private Guna.UI2.WinForms.Guna2CustomCheckBox SNCheck;
        private Guna.UI2.WinForms.Guna2GradientButton WriteModeBtn;
        private Guna.UI2.WinForms.Guna2GradientButton WriteSNBtn;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox EMacText;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox BMacTxt;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox WMacText;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox RegionText;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox ModeTextB;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSerial;
        private Guna.UI2.WinForms.Guna2GradientButton BackupCFGButton;
        private Guna.UI2.WinForms.Guna2GradientButton ReadCDFGButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel LBLMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox connect;
        private Guna.UI2.WinForms.Guna2GradientButton GoTerminal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2TextBox TerminalBox;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCFG;
        private System.ComponentModel.BackgroundWorker Readbackground;
        private Guna.UI2.WinForms.Guna2GradientButton FactoryBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton Rbtn;
        private Guna.UI2.WinForms.Guna2GradientButton UnlockBtn;
    }
}

