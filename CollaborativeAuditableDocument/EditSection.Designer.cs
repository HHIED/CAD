namespace CollaborativeAuditableDocument
{
    partial class EditSection
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editComplete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.sectionNumberTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(15, 29);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 20);
            this.titleTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title";
            // 
            // editComplete
            // 
            this.editComplete.Location = new System.Drawing.Point(15, 274);
            this.editComplete.Name = "editComplete";
            this.editComplete.Size = new System.Drawing.Size(100, 23);
            this.editComplete.TabIndex = 14;
            this.editComplete.Text = "Complete Edit";
            this.editComplete.UseVisualStyleBackColor = true;
            this.editComplete.Click += new System.EventHandler(this.editComplete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Section number";
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(12, 111);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(377, 156);
            this.ContentBox.TabIndex = 11;
            this.ContentBox.Text = "";
            // 
            // sectionNumberTxt
            // 
            this.sectionNumberTxt.Location = new System.Drawing.Point(15, 72);
            this.sectionNumberTxt.Name = "sectionNumberTxt";
            this.sectionNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.sectionNumberTxt.TabIndex = 10;
            // 
            // EditSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.sectionNumberTxt);
            this.Name = "EditSection";
            this.Text = "EditSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.TextBox sectionNumberTxt;
    }
}