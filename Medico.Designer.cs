namespace Hospital
{
    partial class Medico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TN = new System.Windows.Forms.TextBox();
            this.TES = new System.Windows.Forms.TextBox();
            this.TE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BG = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
            this.BB = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TID
            // 
            this.TID.AccessibleDescription = "";
            this.TID.AccessibleName = "";
            this.TID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TID.BackColor = System.Drawing.SystemColors.Info;
            this.TID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TID.Location = new System.Drawing.Point(501, 214);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(104, 13);
            this.TID.TabIndex = 0;
            this.TID.Tag = "alex";
            this.TID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 173);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // TN
            // 
            this.TN.BackColor = System.Drawing.SystemColors.Info;
            this.TN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TN.Location = new System.Drawing.Point(641, 214);
            this.TN.Name = "TN";
            this.TN.Size = new System.Drawing.Size(152, 13);
            this.TN.TabIndex = 4;
            // 
            // TES
            // 
            this.TES.BackColor = System.Drawing.SystemColors.Info;
            this.TES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TES.Location = new System.Drawing.Point(643, 301);
            this.TES.Name = "TES";
            this.TES.Size = new System.Drawing.Size(131, 13);
            this.TES.TabIndex = 5;
            // 
            // TE
            // 
            this.TE.BackColor = System.Drawing.SystemColors.Info;
            this.TE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TE.Location = new System.Drawing.Point(501, 301);
            this.TE.Name = "TE";
            this.TE.Size = new System.Drawing.Size(120, 13);
            this.TE.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exequatur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 68);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(306, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mantenimiento";
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.Crimson;
            this.BG.FlatAppearance.BorderSize = 0;
            this.BG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BG.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BG.Location = new System.Drawing.Point(502, 331);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(293, 23);
            this.BG.TabIndex = 10;
            this.BG.Text = "Guardar";
            this.BG.UseVisualStyleBackColor = false;
            this.BG.Click += new System.EventHandler(this.button1_Click);
            // 
            // BA
            // 
            this.BA.BackColor = System.Drawing.Color.Crimson;
            this.BA.FlatAppearance.BorderSize = 0;
            this.BA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BA.ForeColor = System.Drawing.Color.Cornsilk;
            this.BA.Location = new System.Drawing.Point(21, 368);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(148, 23);
            this.BA.TabIndex = 11;
            this.BA.Text = "Actualizar";
            this.BA.UseVisualStyleBackColor = false;
            this.BA.Click += new System.EventHandler(this.button2_Click);
            // 
            // BB
            // 
            this.BB.BackColor = System.Drawing.Color.Crimson;
            this.BB.FlatAppearance.BorderSize = 0;
            this.BB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BB.ForeColor = System.Drawing.Color.FloralWhite;
            this.BB.Location = new System.Drawing.Point(175, 368);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(148, 23);
            this.BB.TabIndex = 12;
            this.BB.Text = "Borrar";
            this.BB.UseVisualStyleBackColor = false;
            this.BB.Click += new System.EventHandler(this.BB_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(820, 541);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 502;
            this.lineShape4.X2 = 633;
            this.lineShape4.Y1 = 319;
            this.lineShape4.Y2 = 319;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 644;
            this.lineShape3.X2 = 794;
            this.lineShape3.Y1 = 319;
            this.lineShape3.Y2 = 319;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 639;
            this.lineShape2.X2 = 789;
            this.lineShape2.Y1 = 232;
            this.lineShape2.Y2 = 232;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 501;
            this.lineShape1.X2 = 600;
            this.lineShape1.Y1 = 232;
            this.lineShape1.Y2 = 232;
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(820, 541);
            this.Controls.Add(this.BB);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.BG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TE);
            this.Controls.Add(this.TES);
            this.Controls.Add(this.TN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medico";
            this.Text = "citas";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TN;
        private System.Windows.Forms.TextBox TES;
        private System.Windows.Forms.TextBox TE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BG;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.Button BB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}