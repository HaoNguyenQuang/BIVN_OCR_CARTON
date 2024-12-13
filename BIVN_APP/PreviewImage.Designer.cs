namespace BIVN_APP
{
    partial class PreviewImage
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
            picturePreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePreview).BeginInit();
            SuspendLayout();
            // 
            // picturePreview
            // 
            picturePreview.Dock = DockStyle.Fill;
            picturePreview.Location = new Point(0, 0);
            picturePreview.Name = "picturePreview";
            picturePreview.Size = new Size(800, 450);
            picturePreview.SizeMode = PictureBoxSizeMode.AutoSize;
            picturePreview.TabIndex = 0;
            picturePreview.TabStop = false;
            // 
            // PreviewImage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picturePreview);
            Name = "PreviewImage";
            Text = "PreviewImage";
            ((System.ComponentModel.ISupportInitialize)picturePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturePreview;
    }
}