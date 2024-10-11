namespace LineReplicator
{
    partial class LineReplicatorForm
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
            inputPnl = new Panel();
            inputRtb = new RichTextBox();
            inputLbl = new Label();
            templatePnl = new Panel();
            templateRtb = new RichTextBox();
            templatLbl = new Label();
            outputPnl = new Panel();
            outputRtb = new RichTextBox();
            outputLbl = new Label();
            resultPnl = new Panel();
            resultRtb = new RichTextBox();
            resultLbl = new Label();
            PerformReplaceBtn = new Button();
            ClearAllBtn = new Button();
            inputPnl.SuspendLayout();
            templatePnl.SuspendLayout();
            outputPnl.SuspendLayout();
            resultPnl.SuspendLayout();
            SuspendLayout();
            // 
            // inputPnl
            // 
            inputPnl.Controls.Add(inputRtb);
            inputPnl.Controls.Add(inputLbl);
            inputPnl.Location = new Point(0, 0);
            inputPnl.Name = "inputPnl";
            inputPnl.Size = new Size(446, 133);
            inputPnl.TabIndex = 1;
            // 
            // inputRtb
            // 
            inputRtb.Location = new Point(2, 19);
            inputRtb.Name = "inputRtb";
            inputRtb.Size = new Size(441, 109);
            inputRtb.TabIndex = 1;
            inputRtb.Text = "";
            // 
            // inputLbl
            // 
            inputLbl.AutoSize = true;
            inputLbl.Location = new Point(1, 1);
            inputLbl.Name = "inputLbl";
            inputLbl.Size = new Size(239, 15);
            inputLbl.TabIndex = 0;
            inputLbl.Text = "Input (List of items forllowed by a line feed.)";
            // 
            // templatePnl
            // 
            templatePnl.Controls.Add(templateRtb);
            templatePnl.Controls.Add(templatLbl);
            templatePnl.Location = new Point(0, 139);
            templatePnl.Name = "templatePnl";
            templatePnl.Size = new Size(446, 135);
            templatePnl.TabIndex = 2;
            // 
            // templateRtb
            // 
            templateRtb.Location = new Point(3, 19);
            templateRtb.Name = "templateRtb";
            templateRtb.Size = new Size(440, 109);
            templateRtb.TabIndex = 2;
            templateRtb.Text = "";
            // 
            // templatLbl
            // 
            templatLbl.AutoSize = true;
            templatLbl.Location = new Point(1, 1);
            templatLbl.Name = "templatLbl";
            templatLbl.Size = new Size(143, 15);
            templatLbl.TabIndex = 1;
            templatLbl.Text = "Template (Placeholder $1)";
            // 
            // outputPnl
            // 
            outputPnl.Controls.Add(outputRtb);
            outputPnl.Controls.Add(outputLbl);
            outputPnl.Location = new Point(1, 309);
            outputPnl.Name = "outputPnl";
            outputPnl.Size = new Size(445, 134);
            outputPnl.TabIndex = 4;
            // 
            // outputRtb
            // 
            outputRtb.Enabled = false;
            outputRtb.Location = new Point(1, 19);
            outputRtb.Name = "outputRtb";
            outputRtb.Size = new Size(442, 109);
            outputRtb.TabIndex = 3;
            outputRtb.Text = "";
            // 
            // outputLbl
            // 
            outputLbl.AutoSize = true;
            outputLbl.Location = new Point(2, 3);
            outputLbl.Name = "outputLbl";
            outputLbl.Size = new Size(308, 15);
            outputLbl.TabIndex = 1;
            outputLbl.Text = "Output (Produced strings substituted by the placeholder)";
            // 
            // resultPnl
            // 
            resultPnl.Controls.Add(resultRtb);
            resultPnl.Controls.Add(resultLbl);
            resultPnl.Location = new Point(0, 450);
            resultPnl.Name = "resultPnl";
            resultPnl.Size = new Size(446, 61);
            resultPnl.TabIndex = 10;
            // 
            // resultRtb
            // 
            resultRtb.Enabled = false;
            resultRtb.Location = new Point(3, 19);
            resultRtb.Name = "resultRtb";
            resultRtb.Size = new Size(440, 37);
            resultRtb.TabIndex = 6;
            resultRtb.Text = "";
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(1, 1);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(57, 15);
            resultLbl.TabIndex = 1;
            resultLbl.Text = "Feedback";
            // 
            // PerformReplaceBtn
            // 
            PerformReplaceBtn.Location = new Point(3, 280);
            PerformReplaceBtn.Name = "PerformReplaceBtn";
            PerformReplaceBtn.Size = new Size(146, 24);
            PerformReplaceBtn.TabIndex = 3;
            PerformReplaceBtn.Text = "&Produce Output";
            PerformReplaceBtn.UseVisualStyleBackColor = true;
            PerformReplaceBtn.Click += PerformReplaceBtn_Click;
            // 
            // ClearAllBtn
            // 
            ClearAllBtn.Location = new Point(300, 280);
            ClearAllBtn.Name = "ClearAllBtn";
            ClearAllBtn.Size = new Size(146, 24);
            ClearAllBtn.TabIndex = 5;
            ClearAllBtn.Text = "Clear all";
            ClearAllBtn.UseVisualStyleBackColor = true;
            ClearAllBtn.Click += ClearAllBtn_Click;
            // 
            // MultipleStringsForm
            // 
            AcceptButton = PerformReplaceBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = ClearAllBtn;
            ClientSize = new Size(449, 515);
            Controls.Add(ClearAllBtn);
            Controls.Add(PerformReplaceBtn);
            Controls.Add(resultPnl);
            Controls.Add(outputPnl);
            Controls.Add(templatePnl);
            Controls.Add(inputPnl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MultipleStringsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Line Replicator (Ver 1.0.1)";
            inputPnl.ResumeLayout(false);
            inputPnl.PerformLayout();
            templatePnl.ResumeLayout(false);
            templatePnl.PerformLayout();
            outputPnl.ResumeLayout(false);
            outputPnl.PerformLayout();
            resultPnl.ResumeLayout(false);
            resultPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label inputLbl;
        private Panel inputPnl;
        private RichTextBox inputRtb;

        private Label templatLbl;
        private Panel templatePnl;
        private RichTextBox templateRtb;

        private Label outputLbl;
        private Panel outputPnl;
        private RichTextBox outputRtb;

        private Label resultLbl;
        private Panel resultPnl;
        private RichTextBox resultRtb;
        private Button PerformReplaceBtn;
        private Button ClearAllBtn;
    }
}
