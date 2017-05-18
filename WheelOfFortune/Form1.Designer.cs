using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
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
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblWheelValue = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnApostrophe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctWheel = new System.Windows.Forms.PictureBox();
            this.btnAmpersand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnB
            // 
            this.btnB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnB.BackColor = System.Drawing.SystemColors.Control;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(93, 417);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.handleButton);
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnC.BackColor = System.Drawing.SystemColors.Control;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(174, 417);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.handleButton);
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnD.BackColor = System.Drawing.SystemColors.Control;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(255, 417);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.handleButton);
            // 
            // btnE
            // 
            this.btnE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnE.BackColor = System.Drawing.SystemColors.Control;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.Red;
            this.btnE.Location = new System.Drawing.Point(336, 417);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.handleButton);
            // 
            // btnF
            // 
            this.btnF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnF.BackColor = System.Drawing.SystemColors.Control;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(417, 417);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 8;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.handleButton);
            // 
            // btnG
            // 
            this.btnG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnG.BackColor = System.Drawing.SystemColors.Control;
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(12, 446);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 8;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.handleButton);
            // 
            // btnH
            // 
            this.btnH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnH.BackColor = System.Drawing.SystemColors.Control;
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(93, 446);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 23);
            this.btnH.TabIndex = 8;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.handleButton);
            // 
            // btnI
            // 
            this.btnI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnI.BackColor = System.Drawing.SystemColors.Control;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.Color.Red;
            this.btnI.Location = new System.Drawing.Point(174, 446);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 23);
            this.btnI.TabIndex = 8;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.handleButton);
            // 
            // btnJ
            // 
            this.btnJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJ.BackColor = System.Drawing.SystemColors.Control;
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(255, 446);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(75, 23);
            this.btnJ.TabIndex = 8;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.handleButton);
            // 
            // btnK
            // 
            this.btnK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnK.BackColor = System.Drawing.SystemColors.Control;
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(336, 446);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 23);
            this.btnK.TabIndex = 8;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.handleButton);
            // 
            // btnL
            // 
            this.btnL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnL.BackColor = System.Drawing.SystemColors.Control;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(417, 446);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 8;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.handleButton);
            // 
            // btnM
            // 
            this.btnM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnM.BackColor = System.Drawing.SystemColors.Control;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(12, 475);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 23);
            this.btnM.TabIndex = 8;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.handleButton);
            // 
            // btnN
            // 
            this.btnN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnN.BackColor = System.Drawing.SystemColors.Control;
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(93, 475);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 23);
            this.btnN.TabIndex = 8;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.handleButton);
            // 
            // btnO
            // 
            this.btnO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnO.BackColor = System.Drawing.SystemColors.Control;
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.ForeColor = System.Drawing.Color.Red;
            this.btnO.Location = new System.Drawing.Point(174, 475);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(75, 23);
            this.btnO.TabIndex = 8;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.handleButton);
            // 
            // btnP
            // 
            this.btnP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnP.BackColor = System.Drawing.SystemColors.Control;
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(255, 475);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 8;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.handleButton);
            // 
            // btnQ
            // 
            this.btnQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQ.BackColor = System.Drawing.SystemColors.Control;
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(336, 475);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(75, 23);
            this.btnQ.TabIndex = 8;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.handleButton);
            // 
            // btnR
            // 
            this.btnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnR.BackColor = System.Drawing.SystemColors.Control;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(417, 475);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 8;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.handleButton);
            // 
            // btnS
            // 
            this.btnS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnS.BackColor = System.Drawing.SystemColors.Control;
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(12, 504);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 8;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.handleButton);
            // 
            // btnT
            // 
            this.btnT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnT.BackColor = System.Drawing.SystemColors.Control;
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(93, 504);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.handleButton);
            // 
            // btnU
            // 
            this.btnU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnU.BackColor = System.Drawing.SystemColors.Control;
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.Red;
            this.btnU.Location = new System.Drawing.Point(174, 504);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 8;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.handleButton);
            // 
            // btnV
            // 
            this.btnV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnV.BackColor = System.Drawing.SystemColors.Control;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(255, 504);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 23);
            this.btnV.TabIndex = 8;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.handleButton);
            // 
            // btnW
            // 
            this.btnW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnW.BackColor = System.Drawing.SystemColors.Control;
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnW.Location = new System.Drawing.Point(336, 504);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 23);
            this.btnW.TabIndex = 8;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = false;
            this.btnW.Click += new System.EventHandler(this.handleButton);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnX.BackColor = System.Drawing.SystemColors.Control;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(417, 504);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 8;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.handleButton);
            // 
            // btnY
            // 
            this.btnY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnY.BackColor = System.Drawing.SystemColors.Control;
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.ForeColor = System.Drawing.Color.Red;
            this.btnY.Location = new System.Drawing.Point(12, 533);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 23);
            this.btnY.TabIndex = 8;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.handleButton);
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(1149, 289);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "label1";
            this.lblState.Visible = false;
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(1090, 289);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(35, 13);
            this.lblAngle.TabIndex = 12;
            this.lblAngle.Text = "label1";
            this.lblAngle.Visible = false;
            // 
            // lblWheelValue
            // 
            this.lblWheelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWheelValue.AutoSize = true;
            this.lblWheelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheelValue.Location = new System.Drawing.Point(952, 273);
            this.lblWheelValue.Name = "lblWheelValue";
            this.lblWheelValue.Size = new System.Drawing.Size(18, 20);
            this.lblWheelValue.TabIndex = 12;
            this.lblWheelValue.Text = "0";
            this.lblWheelValue.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(7, 666);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(115, 33);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "hint area";
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(794, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(63, 23);
            this.lblPoints.TabIndex = 12;
            this.lblPoints.Text = "Points:";
            // 
            // lblScore1
            // 
            this.lblScore1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.Location = new System.Drawing.Point(1088, 6);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(43, 33);
            this.lblScore1.TabIndex = 12;
            this.lblScore1.Text = "$0";
            // 
            // lblScore2
            // 
            this.lblScore2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.Location = new System.Drawing.Point(1088, 42);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(43, 33);
            this.lblScore2.TabIndex = 13;
            this.lblScore2.Text = "$0";
            // 
            // lblScore3
            // 
            this.lblScore3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore3.AutoSize = true;
            this.lblScore3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore3.Location = new System.Drawing.Point(1088, 75);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(43, 33);
            this.lblScore3.TabIndex = 14;
            this.lblScore3.Text = "$0";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(883, 9);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(100, 33);
            this.lblPlayer1Name.TabIndex = 15;
            this.lblPlayer1Name.Text = "Player1";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.Location = new System.Drawing.Point(883, 42);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(100, 33);
            this.lblPlayer2Name.TabIndex = 16;
            this.lblPlayer2Name.Text = "Player2";
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3Name.Location = new System.Drawing.Point(883, 75);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(100, 33);
            this.lblPlayer3Name.TabIndex = 17;
            this.lblPlayer3Name.Text = "Player3";
            // 
            // btnA
            // 
            this.btnA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnA.BackColor = System.Drawing.SystemColors.Control;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Red;
            this.btnA.Location = new System.Drawing.Point(12, 417);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.handleButton);
            // 
            // btnSpace
            // 
            this.btnSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpace.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpace.Location = new System.Drawing.Point(174, 533);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(75, 23);
            this.btnSpace.TabIndex = 19;
            this.btnSpace.Text = " ";
            this.btnSpace.UseVisualStyleBackColor = false;
            this.btnSpace.Visible = false;
            // 
            // btnZ
            // 
            this.btnZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZ.BackColor = System.Drawing.SystemColors.Control;
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZ.Location = new System.Drawing.Point(93, 533);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 23);
            this.btnZ.TabIndex = 8;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = false;
            this.btnZ.Click += new System.EventHandler(this.handleButton);
            // 
            // btnSolve
            // 
            this.btnSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolve.Location = new System.Drawing.Point(1109, 263);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 20;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(12, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(150, 33);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(7, 608);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(115, 33);
            this.lblInfo2.TabIndex = 22;
            this.lblInfo2.Text = "hint area";
            // 
            // btnApostrophe
            // 
            this.btnApostrophe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApostrophe.BackColor = System.Drawing.SystemColors.Control;
            this.btnApostrophe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostrophe.Location = new System.Drawing.Point(255, 533);
            this.btnApostrophe.Name = "btnApostrophe";
            this.btnApostrophe.Size = new System.Drawing.Size(75, 23);
            this.btnApostrophe.TabIndex = 23;
            this.btnApostrophe.Text = "\'";
            this.btnApostrophe.UseVisualStyleBackColor = false;
            this.btnApostrophe.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WheelOfFortune.Properties.Resources.Red_Triangle;
            this.pictureBox2.InitialImage = global::WheelOfFortune.Properties.Resources.Red_Triangle;
            this.pictureBox2.Location = new System.Drawing.Point(919, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pctWheel
            // 
            this.pctWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pctWheel.BackColor = System.Drawing.Color.Transparent;
            this.pctWheel.Image = global::WheelOfFortune.Properties.Resources.wheel;
            this.pctWheel.InitialImage = global::WheelOfFortune.Properties.Resources.wheel;
            this.pctWheel.Location = new System.Drawing.Point(679, 306);
            this.pctWheel.Margin = new System.Windows.Forms.Padding(0);
            this.pctWheel.Name = "pctWheel";
            this.pctWheel.Size = new System.Drawing.Size(505, 497);
            this.pctWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctWheel.TabIndex = 10;
            this.pctWheel.TabStop = false;
            this.pctWheel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pctWheel.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnAmpersand
            // 
            this.btnAmpersand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAmpersand.BackColor = System.Drawing.SystemColors.Control;
            this.btnAmpersand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpersand.Location = new System.Drawing.Point(336, 533);
            this.btnAmpersand.Name = "btnAmpersand";
            this.btnAmpersand.Size = new System.Drawing.Size(75, 23);
            this.btnAmpersand.TabIndex = 24;
            this.btnAmpersand.Text = "&";
            this.btnAmpersand.UseVisualStyleBackColor = false;
            this.btnAmpersand.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1203, 809);
            this.Controls.Add(this.btnAmpersand);
            this.Controls.Add(this.btnApostrophe);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnSpace);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblPlayer3Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblWheelValue);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pctWheel);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Name = "Form1";
            this.Text = "Wheel of Fortune";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void drawSecretWord()
        {
            for (int i = 0; i < word.Length; i++)
            {
                this.Controls.Add(secretWord.field[i]);

            }
        }

        #endregion
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private PictureBox pctWheel;
        private Button btnG;
        private Button btnH;
        private Button btnI;
        private Button btnJ;
        private Button btnK;
        private Button btnL;
        private Button btnM;
        private Button btnN;
        private Button btnO;
        private Button btnP;
        private Button btnQ;
        private Button btnR;
        private Button btnS;
        private Button btnT;
        private Button btnU;
        private Button btnV;
        private Button btnW;
        private Button btnX;
        private Button btnY;
        private Button btnApostrophe;
        private Button btnAmpersand;
        private PictureBox pictureBox2;
        private Label lblState;
        private Label lblAngle;
        private Label lblWheelValue;
        private Label lblInfo;
        private Label lblPoints;
        private Label lblScore1;
        private Label lblScore2;
        private Label lblScore3;
        private Label lblPlayer1Name;
        private Label lblPlayer2Name;
        private Label lblPlayer3Name;
        private Button btnSpace;
        private Button btnZ;
        private Button btnSolve;
        private Label lblCategory;
        private Label lblInfo2;        
    }
}

