namespace Mic_mute_and_unmute
{
    partial class MicMuteUnmute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicMuteUnmute));
            this.btn_mute = new System.Windows.Forms.Button();
            this.btn_Unmute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_abt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mute
            // 
            this.btn_mute.BackColor = System.Drawing.Color.Tomato;
            this.btn_mute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mute.Location = new System.Drawing.Point(139, 108);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(143, 60);
            this.btn_mute.TabIndex = 0;
            this.btn_mute.Text = "Mute";
            this.btn_mute.UseVisualStyleBackColor = false;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // btn_Unmute
            // 
            this.btn_Unmute.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Unmute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unmute.Location = new System.Drawing.Point(139, 195);
            this.btn_Unmute.Name = "btn_Unmute";
            this.btn_Unmute.Size = new System.Drawing.Size(143, 60);
            this.btn_Unmute.TabIndex = 1;
            this.btn_Unmute.Text = "UnMute";
            this.btn_Unmute.UseVisualStyleBackColor = false;
            this.btn_Unmute.Click += new System.EventHandler(this.btn_Unmute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Status : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "status";
            // 
            // btn_abt
            // 
            this.btn_abt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_abt.Location = new System.Drawing.Point(337, 13);
            this.btn_abt.Name = "btn_abt";
            this.btn_abt.Size = new System.Drawing.Size(75, 23);
            this.btn_abt.TabIndex = 4;
            this.btn_abt.Text = "About";
            this.btn_abt.UseVisualStyleBackColor = false;
            this.btn_abt.Click += new System.EventHandler(this.btn_abt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(114, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mute/Unmute Microphone";
            // 
            // MicMuteUnmute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_abt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Unmute);
            this.Controls.Add(this.btn_mute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MicMuteUnmute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mic mute/Unmute";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mute;
        private System.Windows.Forms.Button btn_Unmute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_abt;
        private System.Windows.Forms.Label label3;
    }
}

