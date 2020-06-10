namespace HospitalOTTO
{
    partial class Habitaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BB = new System.Windows.Forms.Button();
            this.BA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Tno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tp = new System.Windows.Forms.TextBox();
            this.BG = new System.Windows.Forms.Button();
            this.Combo1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbuscar = new System.Windows.Forms.ComboBox();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 37);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(271, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mantenimiento";
            // 
            // BB
            // 
            this.BB.BackColor = System.Drawing.Color.Crimson;
            this.BB.FlatAppearance.BorderSize = 0;
            this.BB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BB.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BB.ForeColor = System.Drawing.Color.FloralWhite;
            this.BB.Location = new System.Drawing.Point(166, 380);
            this.BB.Name = "BB";
            this.BB.Size = new System.Drawing.Size(148, 23);
            this.BB.TabIndex = 31;
            this.BB.Text = "Borrar";
            this.BB.UseVisualStyleBackColor = false;
            this.BB.Click += new System.EventHandler(this.BB_Click);
            // 
            // BA
            // 
            this.BA.BackColor = System.Drawing.Color.Crimson;
            this.BA.FlatAppearance.BorderSize = 0;
            this.BA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BA.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BA.ForeColor = System.Drawing.Color.Cornsilk;
            this.BA.Location = new System.Drawing.Point(12, 380);
            this.BA.Name = "BA";
            this.BA.Size = new System.Drawing.Size(148, 23);
            this.BA.TabIndex = 30;
            this.BA.Text = "Actualizar";
            this.BA.UseVisualStyleBackColor = false;
            this.BA.Click += new System.EventHandler(this.BA_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 173);
            this.dataGridView1.TabIndex = 29;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 538;
            this.lineShape1.X2 = 720;
            this.lineShape1.Y1 = 307;
            this.lineShape1.Y2 = 307;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 550;
            this.lineShape2.X2 = 720;
            this.lineShape2.Y1 = 266;
            this.lineShape2.Y2 = 266;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 508;
            this.lineShape4.X2 = 720;
            this.lineShape4.Y1 = 223;
            this.lineShape4.Y2 = 223;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 450);
            this.shapeContainer1.TabIndex = 32;
            this.shapeContainer1.TabStop = false;
            // 
            // Tno
            // 
            this.Tno.BackColor = System.Drawing.SystemColors.Info;
            this.Tno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tno.Location = new System.Drawing.Point(552, 251);
            this.Tno.Name = "Tno";
            this.Tno.Size = new System.Drawing.Size(152, 13);
            this.Tno.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID:";
            // 
            // Tid
            // 
            this.Tid.AccessibleDescription = "";
            this.Tid.AccessibleName = "";
            this.Tid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Tid.BackColor = System.Drawing.SystemColors.Info;
            this.Tid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tid.Location = new System.Drawing.Point(511, 209);
            this.Tid.Name = "Tid";
            this.Tid.Size = new System.Drawing.Size(104, 13);
            this.Tid.TabIndex = 34;
            this.Tid.Tag = "alex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Precio:";
            // 
            // Tp
            // 
            this.Tp.BackColor = System.Drawing.SystemColors.Info;
            this.Tp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tp.Location = new System.Drawing.Point(541, 293);
            this.Tp.Name = "Tp";
            this.Tp.Size = new System.Drawing.Size(131, 13);
            this.Tp.TabIndex = 38;
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.Crimson;
            this.BG.FlatAppearance.BorderSize = 0;
            this.BG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BG.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BG.Location = new System.Drawing.Point(482, 380);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(239, 23);
            this.BG.TabIndex = 42;
            this.BG.Text = "Guardar";
            this.BG.UseVisualStyleBackColor = false;
            this.BG.Click += new System.EventHandler(this.BG_Click);
            // 
            // Combo1
            // 
            this.Combo1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo1.FormattingEnabled = true;
            this.Combo1.Items.AddRange(new object[] {
            "Doble",
            "Privada",
            "Suite"});
            this.Combo1.Location = new System.Drawing.Point(526, 336);
            this.Combo1.Name = "Combo1";
            this.Combo1.Size = new System.Drawing.Size(195, 24);
            this.Combo1.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 33);
            this.label7.TabIndex = 45;
            this.label7.Text = "Habitaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Registro";
            // 
            // Cbuscar
            // 
            this.Cbuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbuscar.FormattingEnabled = true;
            this.Cbuscar.Items.AddRange(new object[] {
            "Doble",
            "Privada",
            "Suite"});
            this.Cbuscar.Location = new System.Drawing.Point(119, 155);
            this.Cbuscar.Name = "Cbuscar";
            this.Cbuscar.Size = new System.Drawing.Size(195, 24);
            this.Cbuscar.TabIndex = 47;
            // 
            // Bbuscar
            // 
            this.Bbuscar.BackColor = System.Drawing.Color.Crimson;
            this.Bbuscar.FlatAppearance.BorderSize = 0;
            this.Bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbuscar.ForeColor = System.Drawing.Color.Cornsilk;
            this.Bbuscar.Location = new System.Drawing.Point(12, 156);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(100, 23);
            this.Bbuscar.TabIndex = 48;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.Cbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.BG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tp);
            this.Controls.Add(this.Tno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tid);
            this.Controls.Add(this.BB);
            this.Controls.Add(this.BA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.Habitaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BB;
        private System.Windows.Forms.Button BA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox Tno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tp;
        private System.Windows.Forms.Button BG;
        private System.Windows.Forms.ComboBox Combo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbuscar;
        private System.Windows.Forms.Button Bbuscar;
    }
}