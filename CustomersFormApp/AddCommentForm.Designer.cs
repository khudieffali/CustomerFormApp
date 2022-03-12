
namespace CustomersFormApp
{
    partial class AddCommentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchCommnet = new System.Windows.Forms.RichTextBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.dtgComments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müştərilər";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(13, 55);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(252, 31);
            this.cmbCustomers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rəy";
            // 
            // rchCommnet
            // 
            this.rchCommnet.Location = new System.Drawing.Point(13, 182);
            this.rchCommnet.Name = "rchCommnet";
            this.rchCommnet.Size = new System.Drawing.Size(252, 153);
            this.rchCommnet.TabIndex = 2;
            this.rchCommnet.Text = "";
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.Purple;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnComment.Location = new System.Drawing.Point(13, 393);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(252, 45);
            this.btnComment.TabIndex = 3;
            this.btnComment.Text = "Əlavə Et";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // dtgComments
            // 
            this.dtgComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgComments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComments.Location = new System.Drawing.Point(311, 55);
            this.dtgComments.Name = "dtgComments";
            this.dtgComments.RowHeadersWidth = 51;
            this.dtgComments.RowTemplate.Height = 29;
            this.dtgComments.Size = new System.Drawing.Size(492, 383);
            this.dtgComments.TabIndex = 4;
            // 
            // AddCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgComments);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.rchCommnet);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCommentForm";
            this.Text = "AddCommentForm";
            this.Load += new System.EventHandler(this.AddCommentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchCommnet;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.DataGridView dtgComments;
    }
}