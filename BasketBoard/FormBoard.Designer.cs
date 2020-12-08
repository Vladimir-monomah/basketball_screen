namespace BasketBoard
{
    partial class FormBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoard));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label_a_name = new System.Windows.Forms.Label();
            this.label_b_name = new System.Windows.Forms.Label();
            this.label_a_points = new System.Windows.Forms.Label();
            this.label_b_points = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.label_b_points, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label_a_points, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label_b_name, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label_a_name, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.12779F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.87221F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1139, 651);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Resize += new System.EventHandler(this.tableLayoutPanel_Resize);
            // 
            // label_a_name
            // 
            this.label_a_name.BackColor = System.Drawing.Color.Cornsilk;
            this.label_a_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_a_name.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a_name.Location = new System.Drawing.Point(3, 0);
            this.label_a_name.Name = "label_a_name";
            this.label_a_name.Size = new System.Drawing.Size(563, 131);
            this.label_a_name.TabIndex = 0;
            this.label_a_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_b_name
            // 
            this.label_b_name.BackColor = System.Drawing.Color.Honeydew;
            this.label_b_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_b_name.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b_name.Location = new System.Drawing.Point(572, 0);
            this.label_b_name.Name = "label_b_name";
            this.label_b_name.Size = new System.Drawing.Size(564, 131);
            this.label_b_name.TabIndex = 1;
            this.label_b_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_a_points
            // 
            this.label_a_points.BackColor = System.Drawing.Color.Cornsilk;
            this.label_a_points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_a_points.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a_points.Location = new System.Drawing.Point(3, 131);
            this.label_a_points.Name = "label_a_points";
            this.label_a_points.Size = new System.Drawing.Size(563, 520);
            this.label_a_points.TabIndex = 2;
            this.label_a_points.Text = "label3";
            this.label_a_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_b_points
            // 
            this.label_b_points.BackColor = System.Drawing.Color.Honeydew;
            this.label_b_points.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_b_points.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b_points.Location = new System.Drawing.Point(572, 131);
            this.label_b_points.Name = "label_b_points";
            this.label_b_points.Size = new System.Drawing.Size(564, 520);
            this.label_b_points.TabIndex = 3;
            this.label_b_points.Text = "label4";
            this.label_b_points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 651);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Баскетбольное табло";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBoard_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label_b_points;
        private System.Windows.Forms.Label label_a_points;
        private System.Windows.Forms.Label label_b_name;
        private System.Windows.Forms.Label label_a_name;
    }
}