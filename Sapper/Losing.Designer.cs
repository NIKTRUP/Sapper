
namespace Sapper
{
    partial class Losing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Losing));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ok = new System.Windows.Forms.Button();
            this.Gif = new System.Windows.Forms.PictureBox();
            this.youLose = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Ok, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Gif, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.youLose, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.66254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(303, 292);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 28);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Gif
            // 
            this.Gif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gif.Image = ((System.Drawing.Image)(resources.GetObject("Gif.Image")));
            this.Gif.Location = new System.Drawing.Point(3, 53);
            this.Gif.Name = "Gif";
            this.Gif.Size = new System.Drawing.Size(375, 233);
            this.Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gif.TabIndex = 1;
            this.Gif.TabStop = false;
            // 
            // youLose
            // 
            this.youLose.AutoSize = true;
            this.youLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.youLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.youLose.Location = new System.Drawing.Point(3, 0);
            this.youLose.Name = "youLose";
            this.youLose.Size = new System.Drawing.Size(375, 50);
            this.youLose.TabIndex = 2;
            this.youLose.Text = "Вы проиграли";
            this.youLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Losing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 323);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Losing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Losing_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.PictureBox Gif;
        private System.Windows.Forms.Label youLose;
    }
}