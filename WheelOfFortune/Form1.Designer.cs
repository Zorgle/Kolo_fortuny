﻿using System;
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
            this.btnZ = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblWheelValue = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctWheel = new System.Windows.Forms.PictureBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer3Name = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.ForeColor = System.Drawing.Color.Red;
            this.btnA.Location = new System.Drawing.Point(12, 249);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 23);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.handleButton);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(93, 249);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 23);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.handleButton);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(174, 249);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.handleButton);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(255, 249);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 23);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.handleButton);
            // 
            // btnE
            // 
            this.btnE.ForeColor = System.Drawing.Color.Red;
            this.btnE.Location = new System.Drawing.Point(336, 249);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.handleButton);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(417, 249);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(75, 23);
            this.btnF.TabIndex = 8;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.handleButton);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(12, 278);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 23);
            this.btnG.TabIndex = 8;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.handleButton);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(93, 278);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(75, 23);
            this.btnH.TabIndex = 8;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.handleButton);
            // 
            // btnI
            // 
            this.btnI.ForeColor = System.Drawing.Color.Red;
            this.btnI.Location = new System.Drawing.Point(174, 278);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(75, 23);
            this.btnI.TabIndex = 8;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.handleButton);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(255, 278);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(75, 23);
            this.btnJ.TabIndex = 8;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.handleButton);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(336, 278);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(75, 23);
            this.btnK.TabIndex = 8;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.handleButton);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(417, 278);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(75, 23);
            this.btnL.TabIndex = 8;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.handleButton);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(12, 307);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 23);
            this.btnM.TabIndex = 8;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.handleButton);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(93, 307);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(75, 23);
            this.btnN.TabIndex = 8;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.handleButton);
            // 
            // btnO
            // 
            this.btnO.ForeColor = System.Drawing.Color.Red;
            this.btnO.Location = new System.Drawing.Point(174, 307);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(75, 23);
            this.btnO.TabIndex = 8;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.handleButton);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(255, 307);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 8;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.handleButton);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(336, 307);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(75, 23);
            this.btnQ.TabIndex = 8;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.handleButton);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(417, 307);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 23);
            this.btnR.TabIndex = 8;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.handleButton);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(12, 336);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 8;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.handleButton);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(93, 336);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(75, 23);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.handleButton);
            // 
            // btnU
            // 
            this.btnU.ForeColor = System.Drawing.Color.Red;
            this.btnU.Location = new System.Drawing.Point(174, 336);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(75, 23);
            this.btnU.TabIndex = 8;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.handleButton);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(255, 336);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(75, 23);
            this.btnV.TabIndex = 8;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.handleButton);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(336, 336);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 23);
            this.btnW.TabIndex = 8;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.handleButton);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(417, 336);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 8;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.handleButton);
            // 
            // btnY
            // 
            this.btnY.ForeColor = System.Drawing.Color.Red;
            this.btnY.Location = new System.Drawing.Point(12, 365);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 23);
            this.btnY.TabIndex = 8;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.handleButton);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(93, 365);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 23);
            this.btnZ.TabIndex = 8;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.handleButton);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(910, 249);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "label1";
            this.lblState.Visible = false;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(851, 249);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(35, 13);
            this.lblAngle.TabIndex = 12;
            this.lblAngle.Text = "label1";
            this.lblAngle.Visible = false;
            // 
            // lblWheelValue
            // 
            this.lblWheelValue.AutoSize = true;
            this.lblWheelValue.Location = new System.Drawing.Point(810, 249);
            this.lblWheelValue.Name = "lblWheelValue";
            this.lblWheelValue.Size = new System.Drawing.Size(13, 13);
            this.lblWheelValue.TabIndex = 12;
            this.lblWheelValue.Text = "0";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(169, 493);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(88, 26);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "hint area";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(555, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(63, 23);
            this.lblPoints.TabIndex = 12;
            this.lblPoints.Text = "Points:";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore1.Location = new System.Drawing.Point(908, 9);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(23, 26);
            this.lblScore1.TabIndex = 12;
            this.lblScore1.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::WheelOfFortune.Properties.Resources.Red_Triangle;
            this.pictureBox2.InitialImage = global::WheelOfFortune.Properties.Resources.Red_Triangle;
            this.pictureBox2.Location = new System.Drawing.Point(752, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pctWheel
            // 
            this.pctWheel.BackColor = System.Drawing.Color.Transparent;
            this.pctWheel.Image = global::WheelOfFortune.Properties.Resources.wheel;
            this.pctWheel.InitialImage = global::WheelOfFortune.Properties.Resources.wheel;
            this.pctWheel.Location = new System.Drawing.Point(585, 275);
            this.pctWheel.Margin = new System.Windows.Forms.Padding(0);
            this.pctWheel.Name = "pctWheel";
            this.pctWheel.Size = new System.Drawing.Size(360, 360);
            this.pctWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctWheel.TabIndex = 10;
            this.pctWheel.TabStop = false;
            this.pctWheel.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pctWheel.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore2.Location = new System.Drawing.Point(908, 35);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(23, 26);
            this.lblScore2.TabIndex = 13;
            this.lblScore2.Text = "0";
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore3.Location = new System.Drawing.Point(908, 61);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(23, 26);
            this.lblScore3.TabIndex = 14;
            this.lblScore3.Text = "0";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.Location = new System.Drawing.Point(644, 9);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(68, 23);
            this.lblPlayer1Name.TabIndex = 15;
            this.lblPlayer1Name.Text = "Player1";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.Location = new System.Drawing.Point(644, 37);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(68, 23);
            this.lblPlayer2Name.TabIndex = 16;
            this.lblPlayer2Name.Text = "Player2";
            // 
            // lblPlayer3Name
            // 
            this.lblPlayer3Name.AutoSize = true;
            this.lblPlayer3Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3Name.Location = new System.Drawing.Point(644, 63);
            this.lblPlayer3Name.Name = "lblPlayer3Name";
            this.lblPlayer3Name.Size = new System.Drawing.Size(68, 23);
            this.lblPlayer3Name.TabIndex = 17;
            this.lblPlayer3Name.Text = "Player3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 641);
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
            this.Controls.Add(this.btnZ);
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
        private Button btnZ;
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
    }
}
