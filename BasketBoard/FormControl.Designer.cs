namespace BasketBoard
{
    partial class FormConrol
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConrol));
            this.text_a = new System.Windows.Forms.TextBox();
            this.text_b = new System.Windows.Forms.TextBox();
            this.button_a_plus1 = new System.Windows.Forms.Button();
            this.button_a_plus2 = new System.Windows.Forms.Button();
            this.button_a_plus3 = new System.Windows.Forms.Button();
            this.button_a_minus1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_b_plus3 = new System.Windows.Forms.Button();
            this.button_b_plus2 = new System.Windows.Forms.Button();
            this.button_b_plus1 = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button_show = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_a
            // 
            this.text_a.BackColor = System.Drawing.Color.Cornsilk;
            this.text_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_a.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_a.Location = new System.Drawing.Point(3, 3);
            this.text_a.Name = "text_a";
            this.text_a.Size = new System.Drawing.Size(338, 35);
            this.text_a.TabIndex = 0;
            this.text_a.TextChanged += new System.EventHandler(this.text_a_TextChanged);
            // 
            // text_b
            // 
            this.text_b.BackColor = System.Drawing.Color.Honeydew;
            this.text_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_b.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_b.Location = new System.Drawing.Point(467, 3);
            this.text_b.Name = "text_b";
            this.text_b.Size = new System.Drawing.Size(338, 35);
            this.text_b.TabIndex = 6;
            this.text_b.TextChanged += new System.EventHandler(this.text_b_TextChanged);
            // 
            // button_a_plus1
            // 
            this.button_a_plus1.BackColor = System.Drawing.Color.Cornsilk;
            this.button_a_plus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_a_plus1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_a_plus1.Location = new System.Drawing.Point(3, 205);
            this.button_a_plus1.Name = "button_a_plus1";
            this.button_a_plus1.Size = new System.Drawing.Size(338, 95);
            this.button_a_plus1.TabIndex = 2;
            this.button_a_plus1.Tag = "1";
            this.button_a_plus1.Text = "+1";
            this.button_a_plus1.UseVisualStyleBackColor = false;
            this.button_a_plus1.Click += new System.EventHandler(this.button_a_plus1_Click);
            // 
            // button_a_plus2
            // 
            this.button_a_plus2.BackColor = System.Drawing.Color.Cornsilk;
            this.button_a_plus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_a_plus2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_a_plus2.Location = new System.Drawing.Point(3, 306);
            this.button_a_plus2.Name = "button_a_plus2";
            this.button_a_plus2.Size = new System.Drawing.Size(338, 95);
            this.button_a_plus2.TabIndex = 3;
            this.button_a_plus2.Tag = "2";
            this.button_a_plus2.Text = "+2";
            this.button_a_plus2.UseVisualStyleBackColor = false;
            this.button_a_plus2.Click += new System.EventHandler(this.button_a_plus1_Click);
            // 
            // button_a_plus3
            // 
            this.button_a_plus3.BackColor = System.Drawing.Color.Cornsilk;
            this.button_a_plus3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_a_plus3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_a_plus3.Location = new System.Drawing.Point(3, 407);
            this.button_a_plus3.Name = "button_a_plus3";
            this.button_a_plus3.Size = new System.Drawing.Size(338, 95);
            this.button_a_plus3.TabIndex = 4;
            this.button_a_plus3.Tag = "3";
            this.button_a_plus3.Text = "+3";
            this.button_a_plus3.UseVisualStyleBackColor = false;
            this.button_a_plus3.Click += new System.EventHandler(this.button_a_plus1_Click);
            // 
            // button_a_minus1
            // 
            this.button_a_minus1.BackColor = System.Drawing.Color.Cornsilk;
            this.button_a_minus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_a_minus1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_a_minus1.Location = new System.Drawing.Point(3, 508);
            this.button_a_minus1.Name = "button_a_minus1";
            this.button_a_minus1.Size = new System.Drawing.Size(338, 100);
            this.button_a_minus1.TabIndex = 5;
            this.button_a_minus1.Tag = "-1";
            this.button_a_minus1.Text = "-1";
            this.button_a_minus1.UseVisualStyleBackColor = false;
            this.button_a_minus1.Click += new System.EventHandler(this.button_a_plus1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Honeydew;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(467, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(338, 100);
            this.button5.TabIndex = 11;
            this.button5.Tag = "-1";
            this.button5.Text = "-1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_b_plus1_Click);
            // 
            // button_b_plus3
            // 
            this.button_b_plus3.BackColor = System.Drawing.Color.Honeydew;
            this.button_b_plus3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_b_plus3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_b_plus3.Location = new System.Drawing.Point(467, 407);
            this.button_b_plus3.Name = "button_b_plus3";
            this.button_b_plus3.Size = new System.Drawing.Size(338, 95);
            this.button_b_plus3.TabIndex = 10;
            this.button_b_plus3.Tag = "3";
            this.button_b_plus3.Text = "+3";
            this.button_b_plus3.UseVisualStyleBackColor = false;
            this.button_b_plus3.Click += new System.EventHandler(this.button_b_plus1_Click);
            // 
            // button_b_plus2
            // 
            this.button_b_plus2.BackColor = System.Drawing.Color.Honeydew;
            this.button_b_plus2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_b_plus2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_b_plus2.Location = new System.Drawing.Point(467, 306);
            this.button_b_plus2.Name = "button_b_plus2";
            this.button_b_plus2.Size = new System.Drawing.Size(338, 95);
            this.button_b_plus2.TabIndex = 9;
            this.button_b_plus2.Tag = "2";
            this.button_b_plus2.Text = "+2";
            this.button_b_plus2.UseVisualStyleBackColor = false;
            this.button_b_plus2.Click += new System.EventHandler(this.button_b_plus1_Click);
            // 
            // button_b_plus1
            // 
            this.button_b_plus1.BackColor = System.Drawing.Color.Honeydew;
            this.button_b_plus1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_b_plus1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_b_plus1.Location = new System.Drawing.Point(467, 205);
            this.button_b_plus1.Name = "button_b_plus1";
            this.button_b_plus1.Size = new System.Drawing.Size(338, 95);
            this.button_b_plus1.TabIndex = 8;
            this.button_b_plus1.Tag = "1";
            this.button_b_plus1.Text = "+1";
            this.button_b_plus1.UseVisualStyleBackColor = false;
            this.button_b_plus1.Click += new System.EventHandler(this.button_b_plus1_Click);
            // 
            // button_reset
            // 
            this.button_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_reset.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reset.Location = new System.Drawing.Point(347, 508);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(114, 100);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "Сброс";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_a
            // 
            this.label_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_a.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(3, 101);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(338, 101);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "-";
            this.label_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_b
            // 
            this.label_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_b.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(467, 101);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(338, 101);
            this.label_b.TabIndex = 7;
            this.label_b.Text = "-";
            this.label_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.text_a, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.button5, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.label_b, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.button_b_plus3, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.label_a, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.button_b_plus2, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.button_reset, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.button_b_plus1, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.button_a_plus1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.button_a_plus2, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.button_a_plus3, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.button_a_minus1, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.text_b, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.button_show, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(808, 611);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // button_show
            // 
            this.button_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_show.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show.Location = new System.Drawing.Point(347, 104);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(114, 95);
            this.button_show.TabIndex = 12;
            this.button_show.Text = "Показать";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // FormConrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 611);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление баскетбольным экраном";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_a;
        private System.Windows.Forms.TextBox text_b;
        private System.Windows.Forms.Button button_a_plus1;
        private System.Windows.Forms.Button button_a_plus2;
        private System.Windows.Forms.Button button_a_plus3;
        private System.Windows.Forms.Button button_a_minus1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_b_plus3;
        private System.Windows.Forms.Button button_b_plus2;
        private System.Windows.Forms.Button button_b_plus1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button button_show;
    }
}

