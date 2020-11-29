namespace Paint_Red21
{
    partial class Red_21
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
            this.paintSurface = new System.Windows.Forms.PictureBox();
            this.Pencil = new System.Windows.Forms.Button();
            this.NAngle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // paintSurface
            // 
            this.paintSurface.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.paintSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintSurface.Location = new System.Drawing.Point(181, 12);
            this.paintSurface.Name = "paintSurface";
            this.paintSurface.Size = new System.Drawing.Size(607, 441);
            this.paintSurface.TabIndex = 0;
            this.paintSurface.TabStop = false;
            this.paintSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseDown);
            this.paintSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseMove);
            this.paintSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintSurface_MouseUp);
            // 
            // Pencil
            // 
            this.Pencil.Location = new System.Drawing.Point(25, 82);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(75, 23);
            this.Pencil.TabIndex = 1;
            this.Pencil.Text = "Карандусь";
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // NAngle
            // 
            this.NAngle.Location = new System.Drawing.Point(25, 112);
            this.NAngle.Name = "NAngle";
            this.NAngle.Size = new System.Drawing.Size(75, 23);
            this.NAngle.TabIndex = 2;
            this.NAngle.Text = "8хуёвНаУглах";
            this.NAngle.UseVisualStyleBackColor = true;
            this.NAngle.Click += new System.EventHandler(this.NAngle_Click);
            // 
            // Red_21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.NAngle);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.paintSurface);
            this.Name = "Red_21";
            this.Text = "Red_21";
            this.Load += new System.EventHandler(this.Red_21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paintSurface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paintSurface;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button NAngle;
    }
}

