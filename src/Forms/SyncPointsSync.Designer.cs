﻿namespace Nikse.SubtitleEdit.Forms
{
    partial class SyncPointsSync
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
            this.groupBoxImportResult = new System.Windows.Forms.GroupBox();
            this.listBoxSyncPoints = new System.Windows.Forms.ListBox();
            this.labelNoOfSyncPoints = new System.Windows.Forms.Label();
            this.labelSyncInfo = new System.Windows.Forms.Label();
            this.buttonRemoveSyncPoint = new System.Windows.Forms.Button();
            this.buttonSetSyncPoint = new System.Windows.Forms.Button();
            this.SubtitleListview1 = new Nikse.SubtitleEdit.Controls.SubtitleListView();
            this.buttonApplySync = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxImportResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImportResult
            // 
            this.groupBoxImportResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImportResult.Controls.Add(this.listBoxSyncPoints);
            this.groupBoxImportResult.Controls.Add(this.labelNoOfSyncPoints);
            this.groupBoxImportResult.Controls.Add(this.labelSyncInfo);
            this.groupBoxImportResult.Controls.Add(this.buttonRemoveSyncPoint);
            this.groupBoxImportResult.Controls.Add(this.buttonSetSyncPoint);
            this.groupBoxImportResult.Controls.Add(this.SubtitleListview1);
            this.groupBoxImportResult.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImportResult.Name = "groupBoxImportResult";
            this.groupBoxImportResult.Size = new System.Drawing.Size(812, 395);
            this.groupBoxImportResult.TabIndex = 16;
            this.groupBoxImportResult.TabStop = false;
            // 
            // listBoxSyncPoints
            // 
            this.listBoxSyncPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listBoxSyncPoints.FormattingEnabled = true;
            this.listBoxSyncPoints.Location = new System.Drawing.Point(654, 242);
            this.listBoxSyncPoints.Name = "listBoxSyncPoints";
            this.listBoxSyncPoints.Size = new System.Drawing.Size(140, 82);
            this.listBoxSyncPoints.TabIndex = 18;
            this.listBoxSyncPoints.SelectedIndexChanged += new System.EventHandler(this.listBoxSyncPoints_SelectedIndexChanged);
            // 
            // labelNoOfSyncPoints
            // 
            this.labelNoOfSyncPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNoOfSyncPoints.AutoSize = true;
            this.labelNoOfSyncPoints.Location = new System.Drawing.Point(653, 225);
            this.labelNoOfSyncPoints.Name = "labelNoOfSyncPoints";
            this.labelNoOfSyncPoints.Size = new System.Drawing.Size(75, 13);
            this.labelNoOfSyncPoints.TabIndex = 16;
            this.labelNoOfSyncPoints.Text = "Sync points: 0";
            // 
            // labelSyncInfo
            // 
            this.labelSyncInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSyncInfo.AutoSize = true;
            this.labelSyncInfo.Location = new System.Drawing.Point(6, 376);
            this.labelSyncInfo.Name = "labelSyncInfo";
            this.labelSyncInfo.Size = new System.Drawing.Size(284, 13);
            this.labelSyncInfo.TabIndex = 17;
            this.labelSyncInfo.Text = "Set at least two sync points to make rough syncronization";
            // 
            // buttonRemoveSyncPoint
            // 
            this.buttonRemoveSyncPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRemoveSyncPoint.Location = new System.Drawing.Point(656, 201);
            this.buttonRemoveSyncPoint.Name = "buttonRemoveSyncPoint";
            this.buttonRemoveSyncPoint.Size = new System.Drawing.Size(138, 21);
            this.buttonRemoveSyncPoint.TabIndex = 14;
            this.buttonRemoveSyncPoint.Text = "Remove sync point";
            this.buttonRemoveSyncPoint.UseVisualStyleBackColor = true;
            this.buttonRemoveSyncPoint.Click += new System.EventHandler(this.buttonRemoveSyncPoint_Click);
            // 
            // buttonSetSyncPoint
            // 
            this.buttonSetSyncPoint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSetSyncPoint.Location = new System.Drawing.Point(656, 174);
            this.buttonSetSyncPoint.Name = "buttonSetSyncPoint";
            this.buttonSetSyncPoint.Size = new System.Drawing.Size(138, 21);
            this.buttonSetSyncPoint.TabIndex = 13;
            this.buttonSetSyncPoint.Text = "Set sync point";
            this.buttonSetSyncPoint.UseVisualStyleBackColor = true;
            this.buttonSetSyncPoint.Click += new System.EventHandler(this.buttonSetSyncPoint_Click);
            // 
            // SubtitleListview1
            // 
            this.SubtitleListview1.AllowDrop = true;
            this.SubtitleListview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtitleListview1.FirstVisibleIndex = -1;
            this.SubtitleListview1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtitleListview1.FullRowSelect = true;
            this.SubtitleListview1.GridLines = true;
            this.SubtitleListview1.HideSelection = false;
            this.SubtitleListview1.Location = new System.Drawing.Point(6, 19);
            this.SubtitleListview1.MultiSelect = false;
            this.SubtitleListview1.Name = "SubtitleListview1";
            this.SubtitleListview1.Size = new System.Drawing.Size(641, 354);
            this.SubtitleListview1.TabIndex = 12;
            this.SubtitleListview1.UseCompatibleStateImageBehavior = false;
            this.SubtitleListview1.View = System.Windows.Forms.View.Details;
            this.SubtitleListview1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SubtitleListview1_MouseDoubleClick);
            // 
            // buttonApplySync
            // 
            this.buttonApplySync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApplySync.Enabled = false;
            this.buttonApplySync.Location = new System.Drawing.Point(745, 413);
            this.buttonApplySync.Name = "buttonApplySync";
            this.buttonApplySync.Size = new System.Drawing.Size(80, 21);
            this.buttonApplySync.TabIndex = 15;
            this.buttonApplySync.Text = "Apply";
            this.buttonApplySync.UseVisualStyleBackColor = true;
            this.buttonApplySync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(664, 413);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(583, 413);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // SyncPointsSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 446);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonApplySync);
            this.Controls.Add(this.groupBoxImportResult);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "SyncPointsSync";
            this.ShowIcon = false;
            this.Text = "SyncPointsSync";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SyncPointsSync_KeyDown);
            this.groupBoxImportResult.ResumeLayout(false);
            this.groupBoxImportResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImportResult;
        private System.Windows.Forms.Label labelSyncInfo;
        private System.Windows.Forms.Label labelNoOfSyncPoints;
        private System.Windows.Forms.Button buttonSetSyncPoint;
        private System.Windows.Forms.Button buttonApplySync;
        private System.Windows.Forms.Button buttonRemoveSyncPoint;
        private Controls.SubtitleListView SubtitleListview1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ListBox listBoxSyncPoints;
    }
}