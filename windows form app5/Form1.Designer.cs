
namespace windows_form_app5
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
            this.btnrannum = new System.Windows.Forms.Button();
            this.lblRanNum = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnsound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnrannum
            // 
            this.btnrannum.Location = new System.Drawing.Point(37, 49);
            this.btnrannum.Name = "btnrannum";
            this.btnrannum.Size = new System.Drawing.Size(123, 38);
            this.btnrannum.TabIndex = 0;
            this.btnrannum.Text = "Randomnumber";
            this.btnrannum.UseVisualStyleBackColor = true;
            this.btnrannum.Click += new System.EventHandler(this.btnrannum_Click);
            // 
            // lblRanNum
            // 
            this.lblRanNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRanNum.Location = new System.Drawing.Point(183, 62);
            this.lblRanNum.Name = "lblRanNum";
            this.lblRanNum.Size = new System.Drawing.Size(173, 23);
            this.lblRanNum.TabIndex = 1;
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(88, 143);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(87, 33);
            this.btnimage.TabIndex = 3;
            this.btnimage.Text = "Changeimage";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::windows_form_app5.Properties.Resources.step_4_1;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(508, 107);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(162, 97);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // btnsound
            // 
            this.btnsound.Location = new System.Drawing.Point(288, 143);
            this.btnsound.Name = "btnsound";
            this.btnsound.Size = new System.Drawing.Size(75, 23);
            this.btnsound.TabIndex = 4;
            this.btnsound.Text = "playsound";
            this.btnsound.UseVisualStyleBackColor = true;
            this.btnsound.Click += new System.EventHandler(this.btnsound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsound);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblRanNum);
            this.Controls.Add(this.btnrannum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrannum;
        private System.Windows.Forms.Label lblRanNum;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.Button btnsound;
    }
}

