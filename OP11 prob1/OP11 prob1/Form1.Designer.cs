using System.Drawing;
using System.Windows.Forms;

namespace _11._2
{
    partial class Form1
    {
        /// <summary> 
        ///  Required designer variable. 
        /// </summary> 
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///  Clean up any resources being used. 
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
        ///  Required method for Designer support - do not modify 
        ///  the contents of this method with the code editor. 
        /// </summary> 
        private void InitializeComponent()
        {
            this.phnumber = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.resulted = new System.Windows.Forms.ListBox();
            this.all = new System.Windows.Forms.ListBox();
            this.table = new System.Windows.Forms.Label();
            this.found = new System.Windows.Forms.Label();
            this.zodiact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phnumber
            // 
            this.phnumber.AutoSize = true;
            this.phnumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phnumber.Location = new System.Drawing.Point(12, 78);
            this.phnumber.Name = "phnumber";
            this.phnumber.Size = new System.Drawing.Size(105, 19);
            this.phnumber.TabIndex = 0;
            this.phnumber.Text = "Знак зодиака:";
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(36, 209);
            this.find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(99, 40);
            this.find.TabIndex = 2;
            this.find.Text = "Поиск";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // resulted
            // 
            this.resulted.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resulted.FormattingEnabled = true;
            this.resulted.ItemHeight = 19;
            this.resulted.Location = new System.Drawing.Point(197, 56);
            this.resulted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resulted.Name = "resulted";
            this.resulted.Size = new System.Drawing.Size(465, 61);
            this.resulted.TabIndex = 3;
            // 
            // all
            // 
            this.all.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all.FormattingEnabled = true;
            this.all.ItemHeight = 19;
            this.all.Location = new System.Drawing.Point(174, 179);
            this.all.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(523, 61);
            this.all.TabIndex = 4;
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table.Location = new System.Drawing.Point(204, 149);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(56, 19);
            this.table.TabIndex = 5;
            this.table.Text = "Табло:";
            // 
            // found
            // 
            this.found.AutoSize = true;
            this.found.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.found.Location = new System.Drawing.Point(204, 26);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(134, 19);
            this.found.TabIndex = 6;
            this.found.Text = "Найденные люди:";
            // 
            // zodiact
            // 
            this.zodiact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zodiact.Location = new System.Drawing.Point(12, 100);
            this.zodiact.Name = "zodiact";
            this.zodiact.Size = new System.Drawing.Size(139, 27);
            this.zodiact.TabIndex = 7;
            this.zodiact.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Фильтр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zodiact);
            this.Controls.Add(this.found);
            this.Controls.Add(this.table);
            this.Controls.Add(this.all);
            this.Controls.Add(this.resulted);
            this.Controls.Add(this.find);
            this.Controls.Add(this.phnumber);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label phnumber;
        private Button find;
        private ListBox resulted;
        private ListBox all;
        private Label table;
        private Label found;
        private TextBox zodiact;
        private Button button1;
    }
}
