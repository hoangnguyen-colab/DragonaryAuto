
namespace DragonaryAuto
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
            this.startBtn = new System.Windows.Forms.Button();
            this.storyRdBtn = new System.Windows.Forms.RadioButton();
            this.emberRdBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.versionTxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(14, 110);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // storyRdBtn
            // 
            this.storyRdBtn.AutoSize = true;
            this.storyRdBtn.Checked = true;
            this.storyRdBtn.Location = new System.Drawing.Point(51, 19);
            this.storyRdBtn.Name = "storyRdBtn";
            this.storyRdBtn.Size = new System.Drawing.Size(49, 17);
            this.storyRdBtn.TabIndex = 3;
            this.storyRdBtn.TabStop = true;
            this.storyRdBtn.Text = "Story";
            this.storyRdBtn.UseVisualStyleBackColor = true;
            // 
            // emberRdBtn
            // 
            this.emberRdBtn.AutoSize = true;
            this.emberRdBtn.Location = new System.Drawing.Point(169, 19);
            this.emberRdBtn.Name = "emberRdBtn";
            this.emberRdBtn.Size = new System.Drawing.Size(60, 17);
            this.emberRdBtn.TabIndex = 4;
            this.emberRdBtn.Text = "Embers";
            this.emberRdBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.storyRdBtn);
            this.groupBox1.Controls.Add(this.emberRdBtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Location = new System.Drawing.Point(118, 110);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Stop Auto";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(212, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TestClick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // versionTxt
            // 
            this.versionTxt.Location = new System.Drawing.Point(252, 146);
            this.versionTxt.Name = "versionTxt";
            this.versionTxt.Size = new System.Drawing.Size(64, 23);
            this.versionTxt.TabIndex = 8;
            this.versionTxt.Text = "ver:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 168);
            this.Controls.Add(this.versionTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Dragonary Auto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RadioButton storyRdBtn;
        private System.Windows.Forms.RadioButton emberRdBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label versionTxt;
    }
}

