﻿
namespace WindowsFormsApp1
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Red;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оставшееся время";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusLeftLabel.Location = new System.Drawing.Point(92, 51);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(290, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(158, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(356, 60);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusRightLabel.Location = new System.Drawing.Point(224, 51);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 6;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusRightLabel.Location = new System.Drawing.Point(224, 101);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 11;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difference.Location = new System.Drawing.Point(356, 110);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(158, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(290, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusLeftLabel.Location = new System.Drawing.Point(92, 101);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timesRightLabel.Location = new System.Drawing.Point(224, 151);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 16;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(356, 160);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 3;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(158, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 14;
            this.label9.Text = "×";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(290, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 13;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timesLeftLabel.Location = new System.Drawing.Point(92, 151);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dividedRightLabel.Location = new System.Drawing.Point(224, 201);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 21;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quotient.Location = new System.Drawing.Point(356, 210);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 4;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(158, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 19;
            this.label13.Text = "/";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(290, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 18;
            this.label14.Text = "=";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(92, 201);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(196, 291);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начать тест";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Математический тест";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

