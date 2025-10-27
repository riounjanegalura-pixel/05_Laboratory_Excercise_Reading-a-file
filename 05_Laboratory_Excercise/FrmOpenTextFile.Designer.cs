namespace _05_Laboratory_Excercise
{
    partial class FrmOpenTextFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenTextFile));
            this.bntOpen = new System.Windows.Forms.Button();
            this.lvShowText = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntOpen
            // 
            this.bntOpen.BackColor = System.Drawing.Color.HotPink;
            this.bntOpen.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntOpen.Location = new System.Drawing.Point(190, 337);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(138, 45);
            this.bntOpen.TabIndex = 0;
            this.bntOpen.Text = "Open";
            this.bntOpen.UseVisualStyleBackColor = false;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // lvShowText
            // 
            this.lvShowText.BackColor = System.Drawing.Color.GhostWhite;
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(12, 36);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(494, 256);
            this.lvShowText.TabIndex = 1;
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.bntOpen);
            this.Name = "FrmOpenTextFile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

