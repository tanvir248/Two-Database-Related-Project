﻿
namespace Mini_School
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CommenttextBox5 = new System.Windows.Forms.TextBox();
            this.finaltextBox4 = new System.Windows.Forms.TextBox();
            this.midtextBox1 = new System.Windows.Forms.TextBox();
            this.cttextBox3 = new System.Windows.Forms.TextBox();
            this.idtextBox2 = new System.Windows.Forms.TextBox();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.seedatabutton3 = new System.Windows.Forms.Button();
            this.refreshbutton2 = new System.Windows.Forms.Button();
            this.adddatabutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CommenttextBox5);
            this.groupBox1.Controls.Add(this.finaltextBox4);
            this.groupBox1.Controls.Add(this.midtextBox1);
            this.groupBox1.Controls.Add(this.cttextBox3);
            this.groupBox1.Controls.Add(this.idtextBox2);
            this.groupBox1.Controls.Add(this.nametextBox1);
            this.groupBox1.Controls.Add(this.seedatabutton3);
            this.groupBox1.Controls.Add(this.refreshbutton2);
            this.groupBox1.Controls.Add(this.adddatabutton1);
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 483);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Students";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Class Five",
            "Class Eight",
            "Class Ten",
            "Batch HSC"});
            this.comboBox1.Location = new System.Drawing.Point(156, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(41, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Comments : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(80, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Final : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(83, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(85, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mid : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(36, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CT / Class : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name : ";
            // 
            // CommenttextBox5
            // 
            this.CommenttextBox5.Location = new System.Drawing.Point(156, 297);
            this.CommenttextBox5.Multiline = true;
            this.CommenttextBox5.Name = "CommenttextBox5";
            this.CommenttextBox5.Size = new System.Drawing.Size(204, 99);
            this.CommenttextBox5.TabIndex = 0;
            // 
            // finaltextBox4
            // 
            this.finaltextBox4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaltextBox4.Location = new System.Drawing.Point(156, 208);
            this.finaltextBox4.Name = "finaltextBox4";
            this.finaltextBox4.Size = new System.Drawing.Size(204, 28);
            this.finaltextBox4.TabIndex = 0;
            this.finaltextBox4.TextChanged += new System.EventHandler(this.feestextBox4_TextChanged);
            // 
            // midtextBox1
            // 
            this.midtextBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtextBox1.Location = new System.Drawing.Point(156, 161);
            this.midtextBox1.Name = "midtextBox1";
            this.midtextBox1.Size = new System.Drawing.Size(204, 28);
            this.midtextBox1.TabIndex = 0;
            // 
            // cttextBox3
            // 
            this.cttextBox3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cttextBox3.Location = new System.Drawing.Point(156, 118);
            this.cttextBox3.Name = "cttextBox3";
            this.cttextBox3.Size = new System.Drawing.Size(204, 28);
            this.cttextBox3.TabIndex = 0;
            // 
            // idtextBox2
            // 
            this.idtextBox2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox2.Location = new System.Drawing.Point(156, 68);
            this.idtextBox2.Name = "idtextBox2";
            this.idtextBox2.Size = new System.Drawing.Size(204, 28);
            this.idtextBox2.TabIndex = 0;
            // 
            // nametextBox1
            // 
            this.nametextBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox1.Location = new System.Drawing.Point(156, 30);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(204, 28);
            this.nametextBox1.TabIndex = 0;
            // 
            // seedatabutton3
            // 
            this.seedatabutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seedatabutton3.FlatAppearance.BorderSize = 0;
            this.seedatabutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seedatabutton3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedatabutton3.ForeColor = System.Drawing.Color.Yellow;
            this.seedatabutton3.Location = new System.Drawing.Point(156, 429);
            this.seedatabutton3.Name = "seedatabutton3";
            this.seedatabutton3.Size = new System.Drawing.Size(121, 34);
            this.seedatabutton3.TabIndex = 3;
            this.seedatabutton3.Text = "See Data";
            this.seedatabutton3.UseVisualStyleBackColor = true;
            this.seedatabutton3.Click += new System.EventHandler(this.seedatabutton3_Click);
            // 
            // refreshbutton2
            // 
            this.refreshbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbutton2.BackgroundImage")));
            this.refreshbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbutton2.FlatAppearance.BorderSize = 0;
            this.refreshbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbutton2.Location = new System.Drawing.Point(15, 417);
            this.refreshbutton2.Name = "refreshbutton2";
            this.refreshbutton2.Size = new System.Drawing.Size(76, 46);
            this.refreshbutton2.TabIndex = 3;
            this.refreshbutton2.UseVisualStyleBackColor = true;
            this.refreshbutton2.Click += new System.EventHandler(this.refreshbutton2_Click);
            // 
            // adddatabutton1
            // 
            this.adddatabutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adddatabutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddatabutton1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adddatabutton1.ForeColor = System.Drawing.Color.Lime;
            this.adddatabutton1.Location = new System.Drawing.Point(313, 429);
            this.adddatabutton1.Name = "adddatabutton1";
            this.adddatabutton1.Size = new System.Drawing.Size(75, 34);
            this.adddatabutton1.TabIndex = 3;
            this.adddatabutton1.Text = "Add";
            this.adddatabutton1.UseVisualStyleBackColor = true;
            this.adddatabutton1.Click += new System.EventHandler(this.adddatabutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 473);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(83, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1023, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommenttextBox5;
        private System.Windows.Forms.TextBox finaltextBox4;
        private System.Windows.Forms.TextBox midtextBox1;
        private System.Windows.Forms.TextBox cttextBox3;
        private System.Windows.Forms.TextBox idtextBox2;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Button seedatabutton3;
        private System.Windows.Forms.Button refreshbutton2;
        private System.Windows.Forms.Button adddatabutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}