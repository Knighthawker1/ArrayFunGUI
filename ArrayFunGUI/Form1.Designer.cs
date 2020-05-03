namespace ArrayFunGUI
{
    partial class frmArrayFunGUI
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
            this.listboxDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplayArray = new System.Windows.Forms.Button();
            this.btnLowest = new System.Windows.Forms.Button();
            this.btnHighest = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDescending = new System.Windows.Forms.Button();
            this.btnAscending = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listboxDisplay
            // 
            this.listboxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxDisplay.FormattingEnabled = true;
            this.listboxDisplay.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listboxDisplay.ItemHeight = 31;
            this.listboxDisplay.Location = new System.Drawing.Point(103, 68);
            this.listboxDisplay.Name = "listboxDisplay";
            this.listboxDisplay.Size = new System.Drawing.Size(56, 314);
            this.listboxDisplay.TabIndex = 0;
            this.listboxDisplay.TabStop = false;
            // 
            // btnDisplayArray
            // 
            this.btnDisplayArray.Location = new System.Drawing.Point(376, 46);
            this.btnDisplayArray.Name = "btnDisplayArray";
            this.btnDisplayArray.Size = new System.Drawing.Size(119, 50);
            this.btnDisplayArray.TabIndex = 0;
            this.btnDisplayArray.Text = "Display Array";
            this.btnDisplayArray.UseVisualStyleBackColor = true;
            this.btnDisplayArray.Click += new System.EventHandler(this.btnDisplayArray_Click);
            // 
            // btnLowest
            // 
            this.btnLowest.Location = new System.Drawing.Point(376, 122);
            this.btnLowest.Name = "btnLowest";
            this.btnLowest.Size = new System.Drawing.Size(119, 50);
            this.btnLowest.TabIndex = 1;
            this.btnLowest.Text = "Display Lowest";
            this.btnLowest.UseVisualStyleBackColor = true;
            this.btnLowest.Click += new System.EventHandler(this.btnLowest_Click);
            // 
            // btnHighest
            // 
            this.btnHighest.Location = new System.Drawing.Point(376, 196);
            this.btnHighest.Name = "btnHighest";
            this.btnHighest.Size = new System.Drawing.Size(119, 50);
            this.btnHighest.TabIndex = 2;
            this.btnHighest.Text = "Display Highest";
            this.btnHighest.UseVisualStyleBackColor = true;
            this.btnHighest.Click += new System.EventHandler(this.btnHighest_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(376, 272);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(119, 50);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Display Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(376, 347);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(119, 50);
            this.btnAverage.TabIndex = 4;
            this.btnAverage.Text = "Display Avg";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(482, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 50);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(574, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 50);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Listbox";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(574, 196);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 50);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Binary Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDescending
            // 
            this.btnDescending.Location = new System.Drawing.Point(574, 122);
            this.btnDescending.Name = "btnDescending";
            this.btnDescending.Size = new System.Drawing.Size(119, 50);
            this.btnDescending.TabIndex = 6;
            this.btnDescending.Text = "Display Descending";
            this.btnDescending.UseVisualStyleBackColor = true;
            this.btnDescending.Click += new System.EventHandler(this.btnDescending_Click);
            // 
            // btnAscending
            // 
            this.btnAscending.Location = new System.Drawing.Point(574, 46);
            this.btnAscending.Name = "btnAscending";
            this.btnAscending.Size = new System.Drawing.Size(119, 50);
            this.btnAscending.TabIndex = 5;
            this.btnAscending.Text = "Display Ascending";
            this.btnAscending.UseVisualStyleBackColor = true;
            this.btnAscending.Click += new System.EventHandler(this.btnAscending_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(574, 347);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(119, 50);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(727, 212);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // frmArrayFunGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDescending);
            this.Controls.Add(this.btnAscending);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnHighest);
            this.Controls.Add(this.btnLowest);
            this.Controls.Add(this.btnDisplayArray);
            this.Controls.Add(this.listboxDisplay);
            this.Name = "frmArrayFunGUI";
            this.Text = "Array Fun GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxDisplay;
        private System.Windows.Forms.Button btnDisplayArray;
        private System.Windows.Forms.Button btnLowest;
        private System.Windows.Forms.Button btnHighest;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDescending;
        private System.Windows.Forms.Button btnAscending;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

