
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(14, 259);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 294);
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
    }
}

