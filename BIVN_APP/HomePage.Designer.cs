using System;
using System.Collections.Generic;
using System.Text;
namespace BIVN_APP
{
    partial class HomePage
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printMultiplePagesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            renderToBitmapsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cutMarginsWhenPrintingToolStripMenuItem = new ToolStripMenuItem();
            shrinkToMarginsWhenPrintingToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            deleteCurrentPageToolStripMenuItem = new ToolStripMenuItem();
            rotateCurrentPageToolStripMenuItem = new ToolStripMenuItem();
            rotate0ToolStripMenuItem = new ToolStripMenuItem();
            rotate90ToolStripMenuItem = new ToolStripMenuItem();
            rotate180ToolStripMenuItem = new ToolStripMenuItem();
            rotate270ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            showRangeOfPagesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            informationToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            _page = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            _zoom = new ToolStripTextBox();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            _fitWidth = new ToolStripButton();
            _fitHeight = new ToolStripButton();
            _fitBest = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            _rotateLeft = new ToolStripButton();
            _rotateRight = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            _showToolbar = new ToolStripButton();
            _showBookmarks = new ToolStripButton();
            _getTextFromPage = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            _pageToolStripLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            _coordinatesToolStripLabel = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            pdfViewer1 = new PdfiumViewer.PdfViewer();
            listView1 = new ListView();
            label1 = new Label();
            saveImage = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1127, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem1, printPreviewToolStripMenuItem, printMultiplePagesToolStripMenuItem, toolStripMenuItem3, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(223, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(220, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(223, 26);
            printPreviewToolStripMenuItem.Text = "Print Preview";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // printMultiplePagesToolStripMenuItem
            // 
            printMultiplePagesToolStripMenuItem.Name = "printMultiplePagesToolStripMenuItem";
            printMultiplePagesToolStripMenuItem.Size = new Size(223, 26);
            printMultiplePagesToolStripMenuItem.Text = "Print Multiple Pages";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(223, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, toolStripMenuItem7, renderToBitmapsToolStripMenuItem, toolStripMenuItem2, cutMarginsWhenPrintingToolStripMenuItem, shrinkToMarginsWhenPrintingToolStripMenuItem, toolStripMenuItem4, deleteCurrentPageToolStripMenuItem, rotateCurrentPageToolStripMenuItem, toolStripMenuItem5, showRangeOfPagesToolStripMenuItem, toolStripMenuItem6, informationToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuItem.Size = new Size(302, 26);
            findToolStripMenuItem.Text = "&Find";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(299, 6);
            // 
            // renderToBitmapsToolStripMenuItem
            // 
            renderToBitmapsToolStripMenuItem.Name = "renderToBitmapsToolStripMenuItem";
            renderToBitmapsToolStripMenuItem.Size = new Size(302, 26);
            renderToBitmapsToolStripMenuItem.Text = "&Render to Bitmaps";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(299, 6);
            // 
            // cutMarginsWhenPrintingToolStripMenuItem
            // 
            cutMarginsWhenPrintingToolStripMenuItem.Name = "cutMarginsWhenPrintingToolStripMenuItem";
            cutMarginsWhenPrintingToolStripMenuItem.Size = new Size(302, 26);
            cutMarginsWhenPrintingToolStripMenuItem.Text = "Cut margins when printing";
            cutMarginsWhenPrintingToolStripMenuItem.Click += cutMarginsWhenPrintingToolStripMenuItem_Click;
            // 
            // shrinkToMarginsWhenPrintingToolStripMenuItem
            // 
            shrinkToMarginsWhenPrintingToolStripMenuItem.Name = "shrinkToMarginsWhenPrintingToolStripMenuItem";
            shrinkToMarginsWhenPrintingToolStripMenuItem.Size = new Size(302, 26);
            shrinkToMarginsWhenPrintingToolStripMenuItem.Text = "Shrink to margins when printing";
            shrinkToMarginsWhenPrintingToolStripMenuItem.Click += shrinkToMarginsWhenPrintingToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(299, 6);
            // 
            // deleteCurrentPageToolStripMenuItem
            // 
            deleteCurrentPageToolStripMenuItem.Name = "deleteCurrentPageToolStripMenuItem";
            deleteCurrentPageToolStripMenuItem.Size = new Size(302, 26);
            deleteCurrentPageToolStripMenuItem.Text = "Delete Current Page";
            deleteCurrentPageToolStripMenuItem.Click += deleteCurrentPageToolStripMenuItem_Click;
            // 
            // rotateCurrentPageToolStripMenuItem
            // 
            rotateCurrentPageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rotate0ToolStripMenuItem, rotate90ToolStripMenuItem, rotate180ToolStripMenuItem, rotate270ToolStripMenuItem });
            rotateCurrentPageToolStripMenuItem.Name = "rotateCurrentPageToolStripMenuItem";
            rotateCurrentPageToolStripMenuItem.Size = new Size(302, 26);
            rotateCurrentPageToolStripMenuItem.Text = "Rotate Current Page";
            // 
            // rotate0ToolStripMenuItem
            // 
            rotate0ToolStripMenuItem.Name = "rotate0ToolStripMenuItem";
            rotate0ToolStripMenuItem.Size = new Size(170, 26);
            rotate0ToolStripMenuItem.Text = "Rotate 0°";
            rotate0ToolStripMenuItem.Click += rotate0ToolStripMenuItem_Click;
            // 
            // rotate90ToolStripMenuItem
            // 
            rotate90ToolStripMenuItem.Name = "rotate90ToolStripMenuItem";
            rotate90ToolStripMenuItem.Size = new Size(170, 26);
            rotate90ToolStripMenuItem.Text = "Rotate 90°";
            rotate90ToolStripMenuItem.Click += rotate90ToolStripMenuItem_Click;
            // 
            // rotate180ToolStripMenuItem
            // 
            rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            rotate180ToolStripMenuItem.Size = new Size(170, 26);
            rotate180ToolStripMenuItem.Text = "Rotate 180°";
            rotate180ToolStripMenuItem.Click += rotate180ToolStripMenuItem_Click;
            // 
            // rotate270ToolStripMenuItem
            // 
            rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            rotate270ToolStripMenuItem.Size = new Size(170, 26);
            rotate270ToolStripMenuItem.Text = "Rotate 270°";
            rotate270ToolStripMenuItem.Click += rotate270ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(299, 6);
            // 
            // showRangeOfPagesToolStripMenuItem
            // 
            showRangeOfPagesToolStripMenuItem.Name = "showRangeOfPagesToolStripMenuItem";
            showRangeOfPagesToolStripMenuItem.Size = new Size(302, 26);
            showRangeOfPagesToolStripMenuItem.Text = "Show range of pages";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(299, 6);
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(302, 26);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, _page, toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripSeparator2, toolStripLabel2, _zoom, toolStripSeparator7, toolStripButton4, toolStripButton3, toolStripSeparator3, _fitWidth, _fitHeight, _fitBest, toolStripSeparator5, _rotateLeft, _rotateRight, toolStripSeparator6, _showToolbar, _showBookmarks, _getTextFromPage });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1127, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(44, 24);
            toolStripLabel1.Text = "Page:";
            // 
            // _page
            // 
            _page.Name = "_page";
            _page.Size = new Size(132, 27);
            _page.KeyDown += _page_KeyDown;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "<";
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = ">";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(52, 24);
            toolStripLabel2.Text = "Zoom:";
            // 
            // _zoom
            // 
            _zoom.Name = "_zoom";
            _zoom.Size = new Size(132, 27);
            _zoom.KeyDown += _zoom_KeyDown;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 27);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "+";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "-";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // _fitWidth
            // 
            _fitWidth.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitWidth.ImageTransparentColor = Color.Magenta;
            _fitWidth.Name = "_fitWidth";
            _fitWidth.Size = new Size(73, 24);
            _fitWidth.Text = "Fit Width";
            _fitWidth.Click += _fitWidth_Click;
            // 
            // _fitHeight
            // 
            _fitHeight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitHeight.ImageTransparentColor = Color.Magenta;
            _fitHeight.Name = "_fitHeight";
            _fitHeight.Size = new Size(78, 24);
            _fitHeight.Text = "Fit Height";
            _fitHeight.Click += _fitHeight_Click;
            // 
            // _fitBest
            // 
            _fitBest.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _fitBest.ImageTransparentColor = Color.Magenta;
            _fitBest.Name = "_fitBest";
            _fitBest.Size = new Size(61, 24);
            _fitBest.Text = "Fit Best";
            _fitBest.Click += _fitBest_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // _rotateLeft
            // 
            _rotateLeft.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _rotateLeft.ImageTransparentColor = Color.Magenta;
            _rotateLeft.Name = "_rotateLeft";
            _rotateLeft.Size = new Size(86, 24);
            _rotateLeft.Text = "Rotate Left";
            _rotateLeft.Click += _rotateLeft_Click;
            // 
            // _rotateRight
            // 
            _rotateRight.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _rotateRight.ImageTransparentColor = Color.Magenta;
            _rotateRight.Name = "_rotateRight";
            _rotateRight.Size = new Size(96, 24);
            _rotateRight.Text = "Rotate Right";
            _rotateRight.Click += _rotateRight_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 27);
            // 
            // _showToolbar
            // 
            _showToolbar.CheckOnClick = true;
            _showToolbar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _showToolbar.ImageTransparentColor = Color.Magenta;
            _showToolbar.Name = "_showToolbar";
            _showToolbar.Size = new Size(104, 24);
            _showToolbar.Text = "Show Toolbar";
            _showToolbar.Click += _hideToolbar_Click;
            // 
            // _showBookmarks
            // 
            _showBookmarks.CheckOnClick = true;
            _showBookmarks.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _showBookmarks.ImageTransparentColor = Color.Magenta;
            _showBookmarks.Name = "_showBookmarks";
            _showBookmarks.Size = new Size(126, 24);
            _showBookmarks.Text = "Show Bookmarks";
            _showBookmarks.Click += _hideBookmarks_Click;
            // 
            // _getTextFromPage
            // 
            _getTextFromPage.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _getTextFromPage.ImageTransparentColor = Color.Magenta;
            _getTextFromPage.Name = "_getTextFromPage";
            _getTextFromPage.Size = new Size(67, 24);
            _getTextFromPage.Text = "Get Text";
            _getTextFromPage.ToolTipText = "Get Text From Current Page";
            _getTextFromPage.Click += _getTextFromPage_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, _pageToolStripLabel, toolStripStatusLabel2, _coordinatesToolStripLabel });
            statusStrip1.Location = new Point(0, 559);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 18, 0);
            statusStrip1.Size = new Size(1127, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(44, 20);
            toolStripStatusLabel1.Text = "Page:";
            // 
            // _pageToolStripLabel
            // 
            _pageToolStripLabel.Name = "_pageToolStripLabel";
            _pageToolStripLabel.Size = new Size(53, 20);
            _pageToolStripLabel.Text = "(page)";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(92, 20);
            toolStripStatusLabel2.Text = "Coordinates:";
            // 
            // _coordinatesToolStripLabel
            // 
            _coordinatesToolStripLabel.Name = "_coordinatesToolStripLabel";
            _coordinatesToolStripLabel.Size = new Size(97, 20);
            _coordinatesToolStripLabel.Text = "(coordinates)";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 57);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pdfViewer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(saveImage);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(1127, 502);
            splitContainer1.SplitterDistance = 800;
            splitContainer1.SplitterWidth = 11;
            splitContainer1.TabIndex = 4;
            // 
            // pdfViewer1
            // 
            pdfViewer1.Dock = DockStyle.Fill;
            pdfViewer1.Location = new Point(0, 0);
            pdfViewer1.Margin = new Padding(6, 4, 6, 4);
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.Size = new Size(800, 502);
            pdfViewer1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(16, 326);
            listView1.Name = "listView1";
            listView1.Size = new Size(252, 154);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(16, -4);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 3;
            label1.Text = "Vùng chọn";
            // 
            // saveImage
            // 
            saveImage.BackColor = SystemColors.MenuHighlight;
            saveImage.Cursor = Cursors.Hand;
            saveImage.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveImage.ForeColor = SystemColors.InactiveBorder;
            saveImage.Location = new Point(16, 273);
            saveImage.Name = "saveImage";
            saveImage.Size = new Size(98, 33);
            saveImage.TabIndex = 1;
            saveImage.Text = "Lưu";
            saveImage.UseVisualStyleBackColor = false;
            saveImage.Click += saveImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 585);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "HomePage";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Shown += MainForm_Shown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        //#endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderToBitmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox _page;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToMarginsWhenPrintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _fitWidth;
        private System.Windows.Forms.ToolStripButton _fitHeight;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox _zoom;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _rotateLeft;
        private System.Windows.Forms.ToolStripButton _rotateRight;
        private System.Windows.Forms.ToolStripButton _fitBest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton _showToolbar;
        private System.Windows.Forms.ToolStripButton _showBookmarks;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateCurrentPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _pageToolStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel _coordinatesToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showRangeOfPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton _getTextFromPage;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem printMultiplePagesToolStripMenuItem;
        private SplitContainer splitContainer1;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private PictureBox pictureBox1;
        private Button saveImage;
        private Label label1;
        private ListView listView1;
    }
}
