﻿
namespace healthyEatingApp
{
    partial class MainTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTest));
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.buttonFirstAnswer = new System.Windows.Forms.Button();
            this.buttonSecondAnswer = new System.Windows.Forms.Button();
            this.buttonThirdAnswer = new System.Windows.Forms.Button();
            this.labelQuestionCount = new System.Windows.Forms.Label();
            this.buttonInReturnMenu = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.richTextBoxAdvice = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BackColor = System.Drawing.Color.White;
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(204, 633);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(715, 165);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // buttonFirstAnswer
            // 
            this.buttonFirstAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonFirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstAnswer.Location = new System.Drawing.Point(400, 722);
            this.buttonFirstAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFirstAnswer.Name = "buttonFirstAnswer";
            this.buttonFirstAnswer.Size = new System.Drawing.Size(349, 62);
            this.buttonFirstAnswer.TabIndex = 1;
            this.buttonFirstAnswer.Text = "button1";
            this.buttonFirstAnswer.UseVisualStyleBackColor = true;
            this.buttonFirstAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonSecondAnswer
            // 
            this.buttonSecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecondAnswer.Location = new System.Drawing.Point(403, 805);
            this.buttonSecondAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSecondAnswer.Name = "buttonSecondAnswer";
            this.buttonSecondAnswer.Size = new System.Drawing.Size(347, 62);
            this.buttonSecondAnswer.TabIndex = 2;
            this.buttonSecondAnswer.Text = "button2";
            this.buttonSecondAnswer.UseVisualStyleBackColor = true;
            this.buttonSecondAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonThirdAnswer
            // 
            this.buttonThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThirdAnswer.Location = new System.Drawing.Point(403, 885);
            this.buttonThirdAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThirdAnswer.Name = "buttonThirdAnswer";
            this.buttonThirdAnswer.Size = new System.Drawing.Size(347, 62);
            this.buttonThirdAnswer.TabIndex = 3;
            this.buttonThirdAnswer.Text = "button3";
            this.buttonThirdAnswer.UseVisualStyleBackColor = true;
            this.buttonThirdAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Location = new System.Drawing.Point(16, 11);
            this.labelQuestionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(0, 16);
            this.labelQuestionCount.TabIndex = 4;
            // 
            // buttonInReturnMenu
            // 
            this.buttonInReturnMenu.Enabled = false;
            this.buttonInReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInReturnMenu.Location = new System.Drawing.Point(400, 805);
            this.buttonInReturnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInReturnMenu.Name = "buttonInReturnMenu";
            this.buttonInReturnMenu.Size = new System.Drawing.Size(349, 62);
            this.buttonInReturnMenu.TabIndex = 5;
            this.buttonInReturnMenu.Text = "Вернуться в  меню";
            this.buttonInReturnMenu.UseVisualStyleBackColor = true;
            this.buttonInReturnMenu.Visible = false;
            this.buttonInReturnMenu.Click += new System.EventHandler(this.buttonInReturnMenu_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(16, 31);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1097, 572);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(403, 887);
            this.buttonNextQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(347, 58);
            this.buttonNextQuestion.TabIndex = 7;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // richTextBoxAdvice
            // 
            this.richTextBoxAdvice.BackColor = System.Drawing.Color.White;
            this.richTextBoxAdvice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAdvice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxAdvice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxAdvice.Location = new System.Drawing.Point(68, 635);
            this.richTextBoxAdvice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxAdvice.Name = "richTextBoxAdvice";
            this.richTextBoxAdvice.ReadOnly = true;
            this.richTextBoxAdvice.Size = new System.Drawing.Size(988, 245);
            this.richTextBoxAdvice.TabIndex = 8;
            this.richTextBoxAdvice.Text = "";
            // 
            // MainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 961);
            this.Controls.Add(this.richTextBoxAdvice);
            this.Controls.Add(this.buttonFirstAnswer);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonInReturnMenu);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.buttonThirdAnswer);
            this.Controls.Add(this.buttonSecondAnswer);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Здоровое Питание";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainTest_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.Button buttonFirstAnswer;
        private System.Windows.Forms.Button buttonSecondAnswer;
        private System.Windows.Forms.Button buttonThirdAnswer;
        private System.Windows.Forms.Label labelQuestionCount;
        private System.Windows.Forms.Button buttonInReturnMenu;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxAdvice;
    }
}

