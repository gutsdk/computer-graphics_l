
namespace KGLB1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeriсTransparent = new System.Windows.Forms.NumericUpDown();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсTransparent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прозрачность(в %)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1333, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость перемещения:";
            // 
            // numeriсTransparent
            // 
            this.numeriсTransparent.Location = new System.Drawing.Point(1336, 25);
            this.numeriсTransparent.Name = "numeriсTransparent";
            this.numeriсTransparent.ReadOnly = true;
            this.numeriсTransparent.Size = new System.Drawing.Size(120, 20);
            this.numeriсTransparent.TabIndex = 2;
            this.numeriсTransparent.Enter += new System.EventHandler(this.numeriсTransparent_Enter);
            this.numeriсTransparent.Leave += new System.EventHandler(this.numeriсTransparent_Leave);
            this.numeriсTransparent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.numeriсTransparent_MouseDoubleClick);
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(1336, 76);
            this.numericSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.ReadOnly = true;
            this.numericSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericSpeed.TabIndex = 3;
            this.numericSpeed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericSpeed.Enter += new System.EventHandler(this.numericSpeed_Enter);
            this.numericSpeed.Leave += new System.EventHandler(this.numericSpeed_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1388, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 799);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericSpeed);
            this.Controls.Add(this.numeriсTransparent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lb";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.numeriсTransparent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numeriсTransparent;
        public System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.Label label3;
    }
}

