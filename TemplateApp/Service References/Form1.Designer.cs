namespace TemplateApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reMesh = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusZ = new System.Windows.Forms.Button();
            this.minusZ = new System.Windows.Forms.Button();
            this.plusY = new System.Windows.Forms.Button();
            this.minusY = new System.Windows.Forms.Button();
            this.plusX = new System.Windows.Forms.Button();
            this.minusX = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.countOZ = new System.Windows.Forms.Label();
            this.countOY = new System.Windows.Forms.Label();
            this.countOX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stepChanger = new System.Windows.Forms.NumericUpDown();
            this.dxControl1 = new TemplateApp.DxControl();
            this.minusScale = new System.Windows.Forms.Button();
            this.plusScale = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reMesh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reMesh
            // 
            this.reMesh.Location = new System.Drawing.Point(17, 12);
            this.reMesh.Name = "reMesh";
            this.reMesh.ReadOnly = true;
            this.reMesh.Size = new System.Drawing.Size(75, 20);
            this.reMesh.TabIndex = 5;
            this.reMesh.ValueChanged += new System.EventHandler(this.reMesh_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.plusScale);
            this.panel1.Controls.Add(this.minusScale);
            this.panel1.Controls.Add(this.plusZ);
            this.panel1.Controls.Add(this.minusZ);
            this.panel1.Controls.Add(this.plusY);
            this.panel1.Controls.Add(this.minusY);
            this.panel1.Controls.Add(this.plusX);
            this.panel1.Controls.Add(this.minusX);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.countOZ);
            this.panel1.Controls.Add(this.countOY);
            this.panel1.Controls.Add(this.countOX);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stepChanger);
            this.panel1.Controls.Add(this.reMesh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(792, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 669);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Коэффициент:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "поворот по OZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "поворот по OY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "поворот по OX";
            // 
            // plusZ
            // 
            this.plusZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusZ.Location = new System.Drawing.Point(142, 259);
            this.plusZ.Name = "plusZ";
            this.plusZ.Size = new System.Drawing.Size(32, 23);
            this.plusZ.TabIndex = 10;
            this.plusZ.Text = "+";
            this.plusZ.UseVisualStyleBackColor = true;
            this.plusZ.Click += new System.EventHandler(this.plusZ_Click);
            // 
            // minusZ
            // 
            this.minusZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusZ.Location = new System.Drawing.Point(17, 259);
            this.minusZ.Name = "minusZ";
            this.minusZ.Size = new System.Drawing.Size(32, 23);
            this.minusZ.TabIndex = 10;
            this.minusZ.Text = "−";
            this.minusZ.UseVisualStyleBackColor = true;
            this.minusZ.Click += new System.EventHandler(this.minusZ_Click);
            // 
            // plusY
            // 
            this.plusY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusY.Location = new System.Drawing.Point(142, 230);
            this.plusY.Name = "plusY";
            this.plusY.Size = new System.Drawing.Size(32, 23);
            this.plusY.TabIndex = 10;
            this.plusY.Text = "+";
            this.plusY.UseVisualStyleBackColor = true;
            this.plusY.Click += new System.EventHandler(this.plusY_Click);
            // 
            // minusY
            // 
            this.minusY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusY.Location = new System.Drawing.Point(17, 230);
            this.minusY.Name = "minusY";
            this.minusY.Size = new System.Drawing.Size(32, 23);
            this.minusY.TabIndex = 10;
            this.minusY.Text = "−";
            this.minusY.UseVisualStyleBackColor = true;
            this.minusY.Click += new System.EventHandler(this.minusY_Click);
            // 
            // plusX
            // 
            this.plusX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusX.Location = new System.Drawing.Point(142, 201);
            this.plusX.Name = "plusX";
            this.plusX.Size = new System.Drawing.Size(32, 23);
            this.plusX.TabIndex = 10;
            this.plusX.Text = "+";
            this.plusX.UseVisualStyleBackColor = true;
            this.plusX.Click += new System.EventHandler(this.plusX_Click);
            // 
            // minusX
            // 
            this.minusX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusX.Location = new System.Drawing.Point(17, 201);
            this.minusX.Name = "minusX";
            this.minusX.Size = new System.Drawing.Size(32, 23);
            this.minusX.TabIndex = 10;
            this.minusX.Text = "−";
            this.minusX.UseVisualStyleBackColor = true;
            this.minusX.Click += new System.EventHandler(this.minusX_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 669);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // countOZ
            // 
            this.countOZ.AutoSize = true;
            this.countOZ.Location = new System.Drawing.Point(48, 102);
            this.countOZ.Name = "countOZ";
            this.countOZ.Size = new System.Drawing.Size(0, 13);
            this.countOZ.TabIndex = 8;
            // 
            // countOY
            // 
            this.countOY.AutoSize = true;
            this.countOY.Location = new System.Drawing.Point(49, 77);
            this.countOY.Name = "countOY";
            this.countOY.Size = new System.Drawing.Size(0, 13);
            this.countOY.TabIndex = 8;
            // 
            // countOX
            // 
            this.countOX.AutoSize = true;
            this.countOX.Location = new System.Drawing.Point(48, 51);
            this.countOX.Name = "countOX";
            this.countOX.Size = new System.Drawing.Size(0, 13);
            this.countOX.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OZ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "OX:";
            // 
            // stepChanger
            // 
            this.stepChanger.DecimalPlaces = 2;
            this.stepChanger.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepChanger.Location = new System.Drawing.Point(121, 175);
            this.stepChanger.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stepChanger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepChanger.Name = "stepChanger";
            this.stepChanger.ReadOnly = true;
            this.stepChanger.Size = new System.Drawing.Size(53, 20);
            this.stepChanger.TabIndex = 5;
            this.stepChanger.Value = new decimal(new int[] {
            4,
            0,
            0,
            131072});
            this.stepChanger.ValueChanged += new System.EventHandler(this.stepChanger_ValueChanged);
            // 
            // dxControl1
            // 
            this.dxControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dxControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dxControl1.EnablePaint = false;
            this.dxControl1.Location = new System.Drawing.Point(0, 0);
            this.dxControl1.Name = "dxControl1";
            this.dxControl1.Size = new System.Drawing.Size(800, 669);
            this.dxControl1.TabIndex = 3;
            // 
            // minusScale
            // 
            this.minusScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusScale.Location = new System.Drawing.Point(17, 357);
            this.minusScale.Name = "minusScale";
            this.minusScale.Size = new System.Drawing.Size(32, 23);
            this.minusScale.TabIndex = 10;
            this.minusScale.Text = "−";
            this.minusScale.UseVisualStyleBackColor = true;
            this.minusScale.Click += new System.EventHandler(this.minusScale_Click);
            // 
            // plusScale
            // 
            this.plusScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusScale.Location = new System.Drawing.Point(142, 357);
            this.plusScale.Name = "plusScale";
            this.plusScale.Size = new System.Drawing.Size(32, 23);
            this.plusScale.TabIndex = 10;
            this.plusScale.Text = "+";
            this.plusScale.UseVisualStyleBackColor = true;
            this.plusScale.Click += new System.EventHandler(this.plusScale_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "умен. / увел.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Маштаб:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dxControl1);
            this.Name = "Form1";
            this.Text = "Тестовое приложение";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.reMesh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepChanger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DxControl dxControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown reMesh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countOZ;
        private System.Windows.Forms.Label countOY;
        private System.Windows.Forms.Label countOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button plusZ;
        private System.Windows.Forms.Button minusZ;
        private System.Windows.Forms.Button plusY;
        private System.Windows.Forms.Button minusY;
        private System.Windows.Forms.Button plusX;
        private System.Windows.Forms.Button minusX;
        private System.Windows.Forms.NumericUpDown stepChanger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button plusScale;
        private System.Windows.Forms.Button minusScale;
    }
}

