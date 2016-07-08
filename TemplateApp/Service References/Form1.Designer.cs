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
            this.dxControl1 = new TemplateApp.DxControl();
            ((System.ComponentModel.ISupportInitialize)(this.reMesh)).BeginInit();
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
            this.reMesh.DecimalPlaces = 1;
            this.reMesh.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.reMesh.Location = new System.Drawing.Point(719, 12);
            this.reMesh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reMesh.Name = "reMesh";
            this.reMesh.Size = new System.Drawing.Size(53, 20);
            this.reMesh.TabIndex = 5;
            this.reMesh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reMesh.ValueChanged += new System.EventHandler(this.reMesh_ValueChanged);
            // 
            // dxControl1
            // 
            this.dxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dxControl1.EnablePaint = false;
            this.dxControl1.Location = new System.Drawing.Point(0, 0);
            this.dxControl1.Name = "dxControl1";
            this.dxControl1.Size = new System.Drawing.Size(784, 741);
            this.dxControl1.TabIndex = 3;
            this.dxControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dxControl1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.reMesh);
            this.Controls.Add(this.dxControl1);
            this.Name = "Form1";
            this.Text = "Тестовое приложение";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.reMesh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DxControl dxControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown reMesh;
    }
}

