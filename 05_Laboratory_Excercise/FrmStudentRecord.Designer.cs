namespace _05_Laboratory_Excercise
{
    partial class FrmStudentRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentRecord));
            this.lvShowText = new System.Windows.Forms.ListView();
            this.bntregister = new System.Windows.Forms.Button();
            this.bntFind = new System.Windows.Forms.Button();
            this.bntUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShowText
            // 
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(12, 23);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(499, 218);
            this.lvShowText.TabIndex = 0;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // bntregister
            // 
            this.bntregister.BackColor = System.Drawing.Color.HotPink;
            this.bntregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntregister.Location = new System.Drawing.Point(12, 264);
            this.bntregister.Name = "bntregister";
            this.bntregister.Size = new System.Drawing.Size(155, 47);
            this.bntregister.TabIndex = 1;
            this.bntregister.Text = "REGISTER";
            this.bntregister.UseVisualStyleBackColor = false;
            this.bntregister.Click += new System.EventHandler(this.bntregister_Click);
            // 
            // bntFind
            // 
            this.bntFind.BackColor = System.Drawing.Color.HotPink;
            this.bntFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntFind.Location = new System.Drawing.Point(183, 264);
            this.bntFind.Name = "bntFind";
            this.bntFind.Size = new System.Drawing.Size(155, 47);
            this.bntFind.TabIndex = 2;
            this.bntFind.Text = "FIND";
            this.bntFind.UseVisualStyleBackColor = false;
            this.bntFind.Click += new System.EventHandler(this.bntFind_Click);
            // 
            // bntUpload
            // 
            this.bntUpload.BackColor = System.Drawing.Color.HotPink;
            this.bntUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntUpload.Location = new System.Drawing.Point(356, 264);
            this.bntUpload.Name = "bntUpload";
            this.bntUpload.Size = new System.Drawing.Size(155, 47);
            this.bntUpload.TabIndex = 3;
            this.bntUpload.Text = "UPLOAD";
            this.bntUpload.UseVisualStyleBackColor = false;
            this.bntUpload.Click += new System.EventHandler(this.bntUpload_Click);
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.bntUpload);
            this.Controls.Add(this.bntFind);
            this.Controls.Add(this.bntregister);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button bntregister;
        private System.Windows.Forms.Button bntFind;
        private System.Windows.Forms.Button bntUpload;
    }
}