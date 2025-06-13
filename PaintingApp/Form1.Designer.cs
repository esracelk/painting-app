namespace PaintingApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_trash = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.btn_purple = new System.Windows.Forms.Button();
            this.btn_brown = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_orange = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_hexagon = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_file);
            this.panel1.Controls.Add(this.btn_deleteAll);
            this.panel1.Controls.Add(this.btn_trash);
            this.panel1.Controls.Add(this.btn_select);
            this.panel1.Controls.Add(this.btn_white);
            this.panel1.Controls.Add(this.btn_purple);
            this.panel1.Controls.Add(this.btn_brown);
            this.panel1.Controls.Add(this.btn_yellow);
            this.panel1.Controls.Add(this.btn_black);
            this.panel1.Controls.Add(this.btn_orange);
            this.panel1.Controls.Add(this.btn_green);
            this.panel1.Controls.Add(this.btn_blue);
            this.panel1.Controls.Add(this.btn_red);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.btn_triangle);
            this.panel1.Controls.Add(this.btn_hexagon);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(728, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 508);
            this.panel1.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_save.Image = global::PaintingApp.Properties.Resources.icons8_save_32;
            this.btn_save.Location = new System.Drawing.Point(64, 424);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(40, 40);
            this.btn_save.TabIndex = 13;
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_file
            // 
            this.btn_file.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_file.Image = global::PaintingApp.Properties.Resources.icons8_file_30;
            this.btn_file.Location = new System.Drawing.Point(3, 424);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(40, 40);
            this.btn_file.TabIndex = 12;
            this.btn_file.UseVisualStyleBackColor = false;
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_deleteAll.Image = global::PaintingApp.Properties.Resources.icons8_pencil_30;
            this.btn_deleteAll.Location = new System.Drawing.Point(3, 345);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(50, 50);
            this.btn_deleteAll.TabIndex = 3;
            this.btn_deleteAll.UseVisualStyleBackColor = false;
            // 
            // btn_trash
            // 
            this.btn_trash.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_trash.Image = global::PaintingApp.Properties.Resources.icons8_delete_trash_30;
            this.btn_trash.Location = new System.Drawing.Point(64, 289);
            this.btn_trash.Name = "btn_trash";
            this.btn_trash.Size = new System.Drawing.Size(50, 50);
            this.btn_trash.TabIndex = 4;
            this.btn_trash.UseVisualStyleBackColor = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_select.Image = global::PaintingApp.Properties.Resources.icons8_click_30;
            this.btn_select.Location = new System.Drawing.Point(3, 289);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(50, 50);
            this.btn_select.TabIndex = 2;
            this.btn_select.UseVisualStyleBackColor = false;
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.White;
            this.btn_white.Location = new System.Drawing.Point(92, 226);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(35, 33);
            this.btn_white.TabIndex = 3;
            this.btn_white.UseVisualStyleBackColor = false;
            // 
            // btn_purple
            // 
            this.btn_purple.BackColor = System.Drawing.Color.Purple;
            this.btn_purple.Location = new System.Drawing.Point(8, 226);
            this.btn_purple.Name = "btn_purple";
            this.btn_purple.Size = new System.Drawing.Size(35, 33);
            this.btn_purple.TabIndex = 4;
            this.btn_purple.UseVisualStyleBackColor = false;
            // 
            // btn_brown
            // 
            this.btn_brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_brown.Location = new System.Drawing.Point(49, 226);
            this.btn_brown.Name = "btn_brown";
            this.btn_brown.Size = new System.Drawing.Size(35, 33);
            this.btn_brown.TabIndex = 5;
            this.btn_brown.UseVisualStyleBackColor = false;
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Location = new System.Drawing.Point(92, 187);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(35, 33);
            this.btn_yellow.TabIndex = 6;
            this.btn_yellow.UseVisualStyleBackColor = false;
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.Color.Black;
            this.btn_black.Location = new System.Drawing.Point(49, 187);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(35, 33);
            this.btn_black.TabIndex = 7;
            this.btn_black.UseVisualStyleBackColor = false;
            // 
            // btn_orange
            // 
            this.btn_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_orange.Location = new System.Drawing.Point(8, 187);
            this.btn_orange.Name = "btn_orange";
            this.btn_orange.Size = new System.Drawing.Size(35, 33);
            this.btn_orange.TabIndex = 8;
            this.btn_orange.UseVisualStyleBackColor = false;
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_green.Location = new System.Drawing.Point(92, 148);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(35, 33);
            this.btn_green.TabIndex = 9;
            this.btn_green.UseVisualStyleBackColor = false;
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.Blue;
            this.btn_blue.Location = new System.Drawing.Point(49, 148);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(35, 33);
            this.btn_blue.TabIndex = 10;
            this.btn_blue.UseVisualStyleBackColor = false;
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(8, 148);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(35, 33);
            this.btn_red.TabIndex = 11;
            this.btn_red.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(3, 406);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 15);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "File Operations";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(3, 271);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 15);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Shape Tools";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(3, 130);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Colors";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Shapes";
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_circle.FlatAppearance.BorderSize = 0;
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.Image = global::PaintingApp.Properties.Resources.icons8_circle_35;
            this.btn_circle.Location = new System.Drawing.Point(67, 21);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(60, 50);
            this.btn_circle.TabIndex = 5;
            this.btn_circle.UseVisualStyleBackColor = false;
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_triangle.FlatAppearance.BorderSize = 0;
            this.btn_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_triangle.Image = global::PaintingApp.Properties.Resources.icons8_triangle_40;
            this.btn_triangle.Location = new System.Drawing.Point(8, 77);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(60, 50);
            this.btn_triangle.TabIndex = 4;
            this.btn_triangle.UseVisualStyleBackColor = false;
            // 
            // btn_hexagon
            // 
            this.btn_hexagon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_hexagon.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_hexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hexagon.Image = global::PaintingApp.Properties.Resources.icons8_hexagon_35;
            this.btn_hexagon.Location = new System.Drawing.Point(67, 77);
            this.btn_hexagon.Name = "btn_hexagon";
            this.btn_hexagon.Size = new System.Drawing.Size(60, 50);
            this.btn_hexagon.TabIndex = 3;
            this.btn_hexagon.UseVisualStyleBackColor = false;
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_rectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rectangle.FlatAppearance.BorderSize = 0;
            this.btn_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rectangle.Image = global::PaintingApp.Properties.Resources.icons8_rectangle_40__1_;
            this.btn_rectangle.Location = new System.Drawing.Point(8, 21);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(60, 50);
            this.btn_rectangle.TabIndex = 2;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            // 
            // panelDraw
            // 
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(0, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(862, 508);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox panelDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_hexagon;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_orange;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.Button btn_purple;
        private System.Windows.Forms.Button btn_brown;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_trash;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_file;
    }
}

