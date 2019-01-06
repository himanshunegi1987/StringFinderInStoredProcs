namespace StringFinderInStoredProcs
{
    partial class SearchView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.rtxtStoredProcsToLookFor = new System.Windows.Forms.RichTextBox();
            this.rtxtStoredProcLocations = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search String:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stored Procs (Look in):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stored Proc locations :";
            // 
            // cbxIsCaseSensitive
            // 
            this.cbxIsCaseSensitive.AutoSize = true;
            this.cbxIsCaseSensitive.Checked = true;
            this.cbxIsCaseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIsCaseSensitive.Location = new System.Drawing.Point(168, 323);
            this.cbxIsCaseSensitive.Margin = new System.Windows.Forms.Padding(4);
            this.cbxIsCaseSensitive.Name = "cbxIsCaseSensitive";
            this.cbxIsCaseSensitive.Size = new System.Drawing.Size(133, 21);
            this.cbxIsCaseSensitive.TabIndex = 3;
            this.cbxIsCaseSensitive.Text = "Is CaseSensitive";
            this.cbxIsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(913, 323);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchString
            // 
            this.txtSearchString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchString.Location = new System.Drawing.Point(171, 15);
            this.txtSearchString.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(845, 22);
            this.txtSearchString.TabIndex = 5;
            this.txtSearchString.Text = ".IdTypeOfPaymentMethod";
            // 
            // rtxtStoredProcsToLookFor
            // 
            this.rtxtStoredProcsToLookFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStoredProcsToLookFor.Location = new System.Drawing.Point(171, 47);
            this.rtxtStoredProcsToLookFor.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtStoredProcsToLookFor.Name = "rtxtStoredProcsToLookFor";
            this.rtxtStoredProcsToLookFor.Size = new System.Drawing.Size(845, 189);
            this.rtxtStoredProcsToLookFor.TabIndex = 6;
            this.rtxtStoredProcsToLookFor.Text = resources.GetString("rtxtStoredProcsToLookFor.Text");
            // 
            // rtxtStoredProcLocations
            // 
            this.rtxtStoredProcLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStoredProcLocations.Location = new System.Drawing.Point(168, 244);
            this.rtxtStoredProcLocations.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtStoredProcLocations.Name = "rtxtStoredProcLocations";
            this.rtxtStoredProcLocations.Size = new System.Drawing.Size(845, 71);
            this.rtxtStoredProcLocations.TabIndex = 7;
            this.rtxtStoredProcLocations.Text = "C:\\Code\\Database\\Treasury\\Trunk\\DB\\StoredProcedures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Result:";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtResult.Location = new System.Drawing.Point(168, 359);
            this.rtxtResult.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(845, 289);
            this.rtxtResult.TabIndex = 9;
            this.rtxtResult.Text = "";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 667);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtStoredProcLocations);
            this.Controls.Add(this.rtxtStoredProcsToLookFor);
            this.Controls.Add(this.txtSearchString);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxIsCaseSensitive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchView";
            this.Text = "SearchView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxIsCaseSensitive;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.RichTextBox rtxtStoredProcsToLookFor;
        private System.Windows.Forms.RichTextBox rtxtStoredProcLocations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtResult;
    }
}