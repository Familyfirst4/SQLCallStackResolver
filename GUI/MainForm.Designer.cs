﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License - see LICENSE file in this repo.

namespace Microsoft.SqlServer.Utils.Misc.SQLCallStackResolver {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing) {
                _resolver.Dispose();

                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.genericOpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.callStackInput = new System.Windows.Forms.TextBox();
            this.finalOutput = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GetPDBDnldScript = new System.Windows.Forms.Button();
            this.DLLrecurse = new System.Windows.Forms.CheckBox();
            this.BinaryPathPicker = new System.Windows.Forms.Button();
            this.binaryPaths = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BucketizeXEL = new System.Windows.Forms.CheckBox();
            this.LoadXELButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cachePDB = new System.Windows.Forms.CheckBox();
            this.selectSQLPDB = new System.Windows.Forms.Button();
            this.PDBPathPicker = new System.Windows.Forms.Button();
            this.pdbRecurse = new System.Windows.Forms.CheckBox();
            this.pdbPaths = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputFilePathPicker = new System.Windows.Forms.Button();
            this.outputFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FramesOnSingleLine = new System.Windows.Forms.CheckBox();
            this.IncludeLineNumbers = new System.Windows.Forms.CheckBox();
            this.EnterBaseAddresses = new System.Windows.Forms.Button();
            this.includeOffsets = new System.Windows.Forms.CheckBox();
            this.RelookupSource = new System.Windows.Forms.CheckBox();
            this.ResolveCallStackButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.cancelButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.genericSaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.showInlineFrames = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.ResolveCallStackButton);
            this.splitContainer2.Size = new System.Drawing.Size(1305, 828);
            this.splitContainer2.SplitterDistance = 510;
            this.splitContainer2.TabIndex = 30;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.callStackInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.finalOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1305, 510);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 30;
            // 
            // callStackInput
            // 
            this.callStackInput.AllowDrop = true;
            this.callStackInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.callStackInput.Location = new System.Drawing.Point(0, 0);
            this.callStackInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.callStackInput.MaxLength = 999999999;
            this.callStackInput.Multiline = true;
            this.callStackInput.Name = "callStackInput";
            this.callStackInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.callStackInput.Size = new System.Drawing.Size(431, 510);
            this.callStackInput.TabIndex = 8;
            this.callStackInput.Text = resources.GetString("callStackInput.Text");
            this.callStackInput.WordWrap = false;
            this.callStackInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.CallStackInput_DragDrop);
            this.callStackInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.CallStackInput_DragOver);
            // 
            // finalOutput
            // 
            this.finalOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalOutput.Location = new System.Drawing.Point(0, 0);
            this.finalOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finalOutput.MaxLength = 999999999;
            this.finalOutput.Multiline = true;
            this.finalOutput.Name = "finalOutput";
            this.finalOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.finalOutput.Size = new System.Drawing.Size(870, 510);
            this.finalOutput.TabIndex = 8;
            this.finalOutput.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GetPDBDnldScript);
            this.groupBox4.Controls.Add(this.DLLrecurse);
            this.groupBox4.Controls.Add(this.BinaryPathPicker);
            this.groupBox4.Controls.Add(this.binaryPaths);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(15, 292);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1276, 53);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SPECIAL CASES";
            // 
            // GetPDBDnldScript
            // 
            this.GetPDBDnldScript.Location = new System.Drawing.Point(947, 16);
            this.GetPDBDnldScript.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetPDBDnldScript.Name = "GetPDBDnldScript";
            this.GetPDBDnldScript.Size = new System.Drawing.Size(323, 30);
            this.GetPDBDnldScript.TabIndex = 13;
            this.GetPDBDnldScript.Text = "Generate PDB download script";
            this.GetPDBDnldScript.UseVisualStyleBackColor = true;
            this.GetPDBDnldScript.Click += new System.EventHandler(this.GetPDBDnldScript_Click);
            // 
            // DLLrecurse
            // 
            this.DLLrecurse.AutoSize = true;
            this.DLLrecurse.Location = new System.Drawing.Point(673, 20);
            this.DLLrecurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DLLrecurse.Name = "DLLrecurse";
            this.DLLrecurse.Size = new System.Drawing.Size(264, 21);
            this.DLLrecurse.TabIndex = 10;
            this.DLLrecurse.Text = "Search for DLLs and EXE recursively";
            this.DLLrecurse.UseVisualStyleBackColor = true;
            // 
            // BinaryPathPicker
            // 
            this.BinaryPathPicker.Location = new System.Drawing.Point(635, 18);
            this.BinaryPathPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BinaryPathPicker.Name = "BinaryPathPicker";
            this.BinaryPathPicker.Size = new System.Drawing.Size(33, 23);
            this.BinaryPathPicker.TabIndex = 20;
            this.BinaryPathPicker.Text = "...";
            this.BinaryPathPicker.UseVisualStyleBackColor = true;
            this.BinaryPathPicker.Click += new System.EventHandler(this.BinaryPathPicker_Click);
            // 
            // binaryPaths
            // 
            this.binaryPaths.Location = new System.Drawing.Point(261, 18);
            this.binaryPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.binaryPaths.Name = "binaryPaths";
            this.binaryPaths.Size = new System.Drawing.Size(367, 22);
            this.binaryPaths.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Specify Path(s) to SQL Server binaries";
            this.formToolTip.SetToolTip(this.label2, "Only need to do this if you are dealing with incomplete stacks collected by -T365" +
        "6 OR if you need to get PowerShell commands to download PDBs for a specific buil" +
        "d of SQL");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BucketizeXEL);
            this.groupBox3.Controls.Add(this.LoadXELButton);
            this.groupBox3.Location = new System.Drawing.Point(15, 91);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1276, 64);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STEP 1: Either directly paste raw callstack(s) in textbox above, or import XEL fi" +
    "le(s)";
            // 
            // BucketizeXEL
            // 
            this.BucketizeXEL.AutoSize = true;
            this.BucketizeXEL.Checked = true;
            this.BucketizeXEL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BucketizeXEL.Location = new System.Drawing.Point(332, 28);
            this.BucketizeXEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BucketizeXEL.Name = "BucketizeXEL";
            this.BucketizeXEL.Size = new System.Drawing.Size(676, 21);
            this.BucketizeXEL.TabIndex = 22;
            this.BucketizeXEL.Text = "Aggregate similar callstacks from XEL (generally leave checked unless you need in" +
    "dividual event data)";
            this.BucketizeXEL.UseVisualStyleBackColor = true;
            // 
            // LoadXELButton
            // 
            this.LoadXELButton.Location = new System.Drawing.Point(11, 18);
            this.LoadXELButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadXELButton.Name = "LoadXELButton";
            this.LoadXELButton.Size = new System.Drawing.Size(304, 37);
            this.LoadXELButton.TabIndex = 15;
            this.LoadXELButton.Text = "Select XEL files and import callstacks";
            this.LoadXELButton.UseVisualStyleBackColor = true;
            this.LoadXELButton.Click += new System.EventHandler(this.LoadXELButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cachePDB);
            this.groupBox2.Controls.Add(this.selectSQLPDB);
            this.groupBox2.Controls.Add(this.PDBPathPicker);
            this.groupBox2.Controls.Add(this.pdbRecurse);
            this.groupBox2.Controls.Add(this.pdbPaths);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1276, 65);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STEP 2: Either use preset symbol downloads or set custom PDB search paths";
            // 
            // cachePDB
            // 
            this.cachePDB.AutoSize = true;
            this.cachePDB.Location = new System.Drawing.Point(1076, 27);
            this.cachePDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cachePDB.Name = "cachePDB";
            this.cachePDB.Size = new System.Drawing.Size(109, 21);
            this.cachePDB.TabIndex = 33;
            this.cachePDB.Text = "Cache PDBs";
            this.formToolTip.SetToolTip(this.cachePDB, "This option will copy PDBs from the paths specified to the %TEMP%\\SymCache folder" +
        ". It is highly recommended to use this if you have a UNC path specified.");
            this.cachePDB.UseVisualStyleBackColor = true;
            // 
            // selectSQLPDB
            // 
            this.selectSQLPDB.Location = new System.Drawing.Point(9, 23);
            this.selectSQLPDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectSQLPDB.Name = "selectSQLPDB";
            this.selectSQLPDB.Size = new System.Drawing.Size(377, 31);
            this.selectSQLPDB.TabIndex = 32;
            this.selectSQLPDB.Text = "Use public PDBs for a known SQL Server build";
            this.selectSQLPDB.UseVisualStyleBackColor = true;
            this.selectSQLPDB.Click += new System.EventHandler(this.SelectSQLPDB_Click);
            // 
            // PDBPathPicker
            // 
            this.PDBPathPicker.Location = new System.Drawing.Point(825, 27);
            this.PDBPathPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PDBPathPicker.Name = "PDBPathPicker";
            this.PDBPathPicker.Size = new System.Drawing.Size(33, 23);
            this.PDBPathPicker.TabIndex = 29;
            this.PDBPathPicker.Text = "...";
            this.PDBPathPicker.UseVisualStyleBackColor = true;
            this.PDBPathPicker.Click += new System.EventHandler(this.PDBPathPicker_Click);
            // 
            // pdbRecurse
            // 
            this.pdbRecurse.AutoSize = true;
            this.pdbRecurse.Checked = true;
            this.pdbRecurse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdbRecurse.Location = new System.Drawing.Point(864, 27);
            this.pdbRecurse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pdbRecurse.Name = "pdbRecurse";
            this.pdbRecurse.Size = new System.Drawing.Size(207, 21);
            this.pdbRecurse.TabIndex = 28;
            this.pdbRecurse.Text = "Search for PDBs recursively";
            this.pdbRecurse.UseVisualStyleBackColor = true;
            // 
            // pdbPaths
            // 
            this.pdbPaths.Location = new System.Drawing.Point(507, 26);
            this.pdbPaths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pdbPaths.Name = "pdbPaths";
            this.pdbPaths.Size = new System.Drawing.Size(312, 22);
            this.pdbPaths.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Path(s) to PDBs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showInlineFrames);
            this.groupBox1.Controls.Add(this.outputFilePathPicker);
            this.groupBox1.Controls.Add(this.outputFilePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FramesOnSingleLine);
            this.groupBox1.Controls.Add(this.IncludeLineNumbers);
            this.groupBox1.Controls.Add(this.EnterBaseAddresses);
            this.groupBox1.Controls.Add(this.includeOffsets);
            this.groupBox1.Controls.Add(this.RelookupSource);
            this.groupBox1.Location = new System.Drawing.Point(15, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1276, 84);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STEP 0: Input and output options";
            // 
            // outputFilePathPicker
            // 
            this.outputFilePathPicker.Location = new System.Drawing.Point(1224, 22);
            this.outputFilePathPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFilePathPicker.Name = "outputFilePathPicker";
            this.outputFilePathPicker.Size = new System.Drawing.Size(33, 23);
            this.outputFilePathPicker.TabIndex = 32;
            this.outputFilePathPicker.Text = "...";
            this.outputFilePathPicker.UseVisualStyleBackColor = true;
            this.outputFilePathPicker.Click += new System.EventHandler(this.outputFilePathPicker_Click);
            // 
            // outputFilePath
            // 
            this.outputFilePath.Location = new System.Drawing.Point(833, 21);
            this.outputFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputFilePath.Name = "outputFilePath";
            this.outputFilePath.Size = new System.Drawing.Size(384, 22);
            this.outputFilePath.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "OUTPUT: Redirect output to file";
            // 
            // FramesOnSingleLine
            // 
            this.FramesOnSingleLine.AutoSize = true;
            this.FramesOnSingleLine.Location = new System.Drawing.Point(9, 21);
            this.FramesOnSingleLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FramesOnSingleLine.Name = "FramesOnSingleLine";
            this.FramesOnSingleLine.Size = new System.Drawing.Size(301, 21);
            this.FramesOnSingleLine.TabIndex = 23;
            this.FramesOnSingleLine.Text = "INPUT: Callstack frames are in a single line";
            this.formToolTip.SetToolTip(this.FramesOnSingleLine, "Required if copy-pasting XE callstack from SSMS");
            this.FramesOnSingleLine.UseVisualStyleBackColor = true;
            // 
            // IncludeLineNumbers
            // 
            this.IncludeLineNumbers.AutoSize = true;
            this.IncludeLineNumbers.Checked = true;
            this.IncludeLineNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeLineNumbers.Location = new System.Drawing.Point(806, 50);
            this.IncludeLineNumbers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncludeLineNumbers.Name = "IncludeLineNumbers";
            this.IncludeLineNumbers.Size = new System.Drawing.Size(270, 21);
            this.IncludeLineNumbers.TabIndex = 16;
            this.IncludeLineNumbers.Text = "OUTPUT: Source lines (private PDBs)";
            this.IncludeLineNumbers.UseVisualStyleBackColor = true;
            // 
            // EnterBaseAddresses
            // 
            this.EnterBaseAddresses.Location = new System.Drawing.Point(411, 21);
            this.EnterBaseAddresses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterBaseAddresses.Name = "EnterBaseAddresses";
            this.EnterBaseAddresses.Size = new System.Drawing.Size(193, 47);
            this.EnterBaseAddresses.TabIndex = 3;
            this.EnterBaseAddresses.Text = "INPUT: Specify base addresses for modules";
            this.formToolTip.SetToolTip(this.EnterBaseAddresses, "Required for working with XEL files and hex address-only callstacks");
            this.EnterBaseAddresses.UseVisualStyleBackColor = true;
            this.EnterBaseAddresses.Click += new System.EventHandler(this.EnterBaseAddresses_Click);
            // 
            // includeOffsets
            // 
            this.includeOffsets.AutoSize = true;
            this.includeOffsets.Location = new System.Drawing.Point(616, 50);
            this.includeOffsets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.includeOffsets.Name = "includeOffsets";
            this.includeOffsets.Size = new System.Drawing.Size(173, 21);
            this.includeOffsets.TabIndex = 17;
            this.includeOffsets.Text = "OUTPUT: Func offsets";
            this.includeOffsets.UseVisualStyleBackColor = true;
            // 
            // RelookupSource
            // 
            this.RelookupSource.AutoSize = true;
            this.RelookupSource.Location = new System.Drawing.Point(9, 47);
            this.RelookupSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RelookupSource.Name = "RelookupSource";
            this.RelookupSource.Size = new System.Drawing.Size(398, 21);
            this.RelookupSource.TabIndex = 16;
            this.RelookupSource.Text = "INPUT: Re-lookup source (rare case, needs private PDBs)";
            this.RelookupSource.UseVisualStyleBackColor = true;
            // 
            // ResolveCallStackButton
            // 
            this.ResolveCallStackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolveCallStackButton.Location = new System.Drawing.Point(15, 230);
            this.ResolveCallStackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResolveCallStackButton.Name = "ResolveCallStackButton";
            this.ResolveCallStackButton.Size = new System.Drawing.Size(1276, 55);
            this.ResolveCallStackButton.TabIndex = 29;
            this.ResolveCallStackButton.Text = "STEP 3: Resolve callstacks!";
            this.ResolveCallStackButton.UseVisualStyleBackColor = true;
            this.ResolveCallStackButton.Click += new System.EventHandler(this.ResolveCallstacks_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar,
            this.cancelButton});
            this.statusStrip1.Location = new System.Drawing.Point(0, 798);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1305, 30);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(700, 24);
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancelButton.Enabled = false;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShowDropDownArrow = false;
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // showInlineFrames
            // 
            this.showInlineFrames.AutoSize = true;
            this.showInlineFrames.Checked = true;
            this.showInlineFrames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showInlineFrames.Location = new System.Drawing.Point(1093, 50);
            this.showInlineFrames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showInlineFrames.Name = "showInlineFrames";
            this.showInlineFrames.Size = new System.Drawing.Size(176, 21);
            this.showInlineFrames.TabIndex = 33;
            this.showInlineFrames.Text = "OUTPUT: Inline frames";
            this.showInlineFrames.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1305, 828);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLCallstackResolver (http://aka.ms/sqlstack)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog genericOpenFileDlg;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox callStackInput;
        private System.Windows.Forms.TextBox finalOutput;
        private System.Windows.Forms.CheckBox DLLrecurse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox binaryPaths;
        private System.Windows.Forms.Button BinaryPathPicker;
        private System.Windows.Forms.Button GetPDBDnldScript;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox FramesOnSingleLine;
        private System.Windows.Forms.CheckBox BucketizeXEL;
        private System.Windows.Forms.Button LoadXELButton;
        private System.Windows.Forms.Button EnterBaseAddresses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectSQLPDB;
        private System.Windows.Forms.Button PDBPathPicker;
        private System.Windows.Forms.CheckBox pdbRecurse;
        private System.Windows.Forms.TextBox pdbPaths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox IncludeLineNumbers;
        private System.Windows.Forms.CheckBox includeOffsets;
        private System.Windows.Forms.CheckBox RelookupSource;
        private System.Windows.Forms.Button ResolveCallStackButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.CheckBox cachePDB;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button outputFilePathPicker;
        private System.Windows.Forms.TextBox outputFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog genericSaveFileDlg;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripDropDownButton cancelButton;
        private System.Windows.Forms.CheckBox showInlineFrames;
    }
}
