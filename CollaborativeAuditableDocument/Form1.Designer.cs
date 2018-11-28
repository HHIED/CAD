namespace CollaborativeAuditableDocument
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sectionNumberTxt = new System.Windows.Forms.TextBox();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApproveList = new System.Windows.Forms.DataGridView();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.declineBtn = new System.Windows.Forms.Button();
            this.sectionList = new System.Windows.Forms.DataGridView();
            this.finalDocBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApproveList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1069, 600);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.declineBtn);
            this.tabPage1.Controls.Add(this.acceptBtn);
            this.tabPage1.Controls.Add(this.ApproveList);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ContentBox);
            this.tabPage1.Controls.Add(this.sectionNumberTxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1061, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sections";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.finalDocBox);
            this.tabPage2.Controls.Add(this.sectionList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Document";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sectionNumberTxt
            // 
            this.sectionNumberTxt.Location = new System.Drawing.Point(11, 33);
            this.sectionNumberTxt.Name = "sectionNumberTxt";
            this.sectionNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.sectionNumberTxt.TabIndex = 0;
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(8, 72);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(377, 156);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Section number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content";
            // 
            // ApproveList
            // 
            this.ApproveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApproveList.Location = new System.Drawing.Point(492, 35);
            this.ApproveList.Name = "ApproveList";
            this.ApproveList.Size = new System.Drawing.Size(546, 476);
            this.ApproveList.TabIndex = 4;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(492, 517);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 5;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // declineBtn
            // 
            this.declineBtn.Location = new System.Drawing.Point(582, 517);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(75, 23);
            this.declineBtn.TabIndex = 6;
            this.declineBtn.Text = "Decline";
            this.declineBtn.UseVisualStyleBackColor = true;
            // 
            // sectionList
            // 
            this.sectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionList.Location = new System.Drawing.Point(17, 15);
            this.sectionList.Name = "sectionList";
            this.sectionList.Size = new System.Drawing.Size(465, 491);
            this.sectionList.TabIndex = 0;
            // 
            // finalDocBox
            // 
            this.finalDocBox.Location = new System.Drawing.Point(557, 24);
            this.finalDocBox.Name = "finalDocBox";
            this.finalDocBox.Size = new System.Drawing.Size(464, 482);
            this.finalDocBox.TabIndex = 1;
            this.finalDocBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(11, 235);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApproveList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button declineBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.DataGridView ApproveList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.TextBox sectionNumberTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox finalDocBox;
        private System.Windows.Forms.DataGridView sectionList;
    }
}

