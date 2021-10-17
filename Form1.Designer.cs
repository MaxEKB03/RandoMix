
namespace RandoMix
{
    partial class Form1
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
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.tabPageRandomString = new System.Windows.Forms.TabPage();
            this.tabPageRandomInt = new System.Windows.Forms.TabPage();
            this.randomIntRight = new System.Windows.Forms.Panel();
            this.randomIntCentral = new System.Windows.Forms.Panel();
            this.intCentralBottom = new System.Windows.Forms.Panel();
            this.intButtonClear = new System.Windows.Forms.Button();
            this.intButtonStart = new System.Windows.Forms.Button();
            this.intCentralTop = new System.Windows.Forms.Panel();
            this.intControlPanel = new System.Windows.Forms.Panel();
            this.intAnswerPanel = new System.Windows.Forms.Panel();
            this.randomIntLeft = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRandomInt.SuspendLayout();
            this.randomIntCentral.SuspendLayout();
            this.intCentralBottom.SuspendLayout();
            this.intCentralTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 29);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(986, 480);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // tabPageRandomString
            // 
            this.tabPageRandomString.Location = new System.Drawing.Point(4, 29);
            this.tabPageRandomString.Name = "tabPageRandomString";
            this.tabPageRandomString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandomString.Size = new System.Drawing.Size(986, 480);
            this.tabPageRandomString.TabIndex = 2;
            this.tabPageRandomString.Text = "Random String";
            this.tabPageRandomString.UseVisualStyleBackColor = true;
            // 
            // tabPageRandomInt
            // 
            this.tabPageRandomInt.Controls.Add(this.randomIntRight);
            this.tabPageRandomInt.Controls.Add(this.randomIntCentral);
            this.tabPageRandomInt.Controls.Add(this.randomIntLeft);
            this.tabPageRandomInt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageRandomInt.Location = new System.Drawing.Point(4, 29);
            this.tabPageRandomInt.Name = "tabPageRandomInt";
            this.tabPageRandomInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandomInt.Size = new System.Drawing.Size(986, 480);
            this.tabPageRandomInt.TabIndex = 0;
            this.tabPageRandomInt.Text = "Random Int";
            this.tabPageRandomInt.UseVisualStyleBackColor = true;
            // 
            // randomIntRight
            // 
            this.randomIntRight.BackColor = System.Drawing.Color.Transparent;
            this.randomIntRight.Location = new System.Drawing.Point(736, 0);
            this.randomIntRight.Name = "randomIntRight";
            this.randomIntRight.Size = new System.Drawing.Size(244, 480);
            this.randomIntRight.TabIndex = 2;
            // 
            // randomIntCentral
            // 
            this.randomIntCentral.BackColor = System.Drawing.Color.Transparent;
            this.randomIntCentral.Controls.Add(this.intCentralBottom);
            this.randomIntCentral.Controls.Add(this.intCentralTop);
            this.randomIntCentral.Location = new System.Drawing.Point(217, 0);
            this.randomIntCentral.Name = "randomIntCentral";
            this.randomIntCentral.Size = new System.Drawing.Size(519, 480);
            this.randomIntCentral.TabIndex = 1;
            // 
            // intCentralBottom
            // 
            this.intCentralBottom.BackColor = System.Drawing.Color.Transparent;
            this.intCentralBottom.Controls.Add(this.intButtonClear);
            this.intCentralBottom.Controls.Add(this.intButtonStart);
            this.intCentralBottom.Location = new System.Drawing.Point(13, 368);
            this.intCentralBottom.Name = "intCentralBottom";
            this.intCentralBottom.Size = new System.Drawing.Size(492, 93);
            this.intCentralBottom.TabIndex = 1;
            // 
            // intButtonClear
            // 
            this.intButtonClear.Location = new System.Drawing.Point(19, 10);
            this.intButtonClear.Name = "intButtonClear";
            this.intButtonClear.Size = new System.Drawing.Size(219, 65);
            this.intButtonClear.TabIndex = 1;
            this.intButtonClear.Text = "CLEAR";
            this.intButtonClear.UseVisualStyleBackColor = true;
            // 
            // intButtonStart
            // 
            this.intButtonStart.Location = new System.Drawing.Point(260, 10);
            this.intButtonStart.Name = "intButtonStart";
            this.intButtonStart.Size = new System.Drawing.Size(219, 65);
            this.intButtonStart.TabIndex = 0;
            this.intButtonStart.Text = "START";
            this.intButtonStart.UseVisualStyleBackColor = true;
            // 
            // intCentralTop
            // 
            this.intCentralTop.BackColor = System.Drawing.Color.Transparent;
            this.intCentralTop.Controls.Add(this.intControlPanel);
            this.intCentralTop.Controls.Add(this.intAnswerPanel);
            this.intCentralTop.Location = new System.Drawing.Point(13, 20);
            this.intCentralTop.Name = "intCentralTop";
            this.intCentralTop.Size = new System.Drawing.Size(492, 342);
            this.intCentralTop.TabIndex = 0;
            // 
            // intControlPanel
            // 
            this.intControlPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.intControlPanel.Location = new System.Drawing.Point(19, 158);
            this.intControlPanel.Name = "intControlPanel";
            this.intControlPanel.Size = new System.Drawing.Size(460, 167);
            this.intControlPanel.TabIndex = 1;
            // 
            // intAnswerPanel
            // 
            this.intAnswerPanel.BackColor = System.Drawing.Color.Silver;
            this.intAnswerPanel.Location = new System.Drawing.Point(19, 17);
            this.intAnswerPanel.Name = "intAnswerPanel";
            this.intAnswerPanel.Size = new System.Drawing.Size(460, 123);
            this.intAnswerPanel.TabIndex = 0;
            // 
            // randomIntLeft
            // 
            this.randomIntLeft.BackColor = System.Drawing.Color.Transparent;
            this.randomIntLeft.Location = new System.Drawing.Point(0, 3);
            this.randomIntLeft.Name = "randomIntLeft";
            this.randomIntLeft.Size = new System.Drawing.Size(217, 477);
            this.randomIntLeft.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRandomInt);
            this.tabControl.Controls.Add(this.tabPageRandomString);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(994, 513);
            this.tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 513);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1012, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Resize);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabPageRandomInt.ResumeLayout(false);
            this.randomIntCentral.ResumeLayout(false);
            this.intCentralBottom.ResumeLayout(false);
            this.intCentralTop.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage tabPageRandomString;
        private System.Windows.Forms.TabPage tabPageRandomInt;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel randomIntRight;
        private System.Windows.Forms.Panel randomIntCentral;
        private System.Windows.Forms.Panel randomIntLeft;
        private System.Windows.Forms.Panel intCentralBottom;
        private System.Windows.Forms.Panel intCentralTop;
        private System.Windows.Forms.Button intButtonStart;
        private System.Windows.Forms.Panel intControlPanel;
        private System.Windows.Forms.Panel intAnswerPanel;
        private System.Windows.Forms.Button intButtonClear;
    }
}

