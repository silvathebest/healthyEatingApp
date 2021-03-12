
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
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.buttonFirstAnswer = new System.Windows.Forms.Button();
            this.buttonSecondAnswer = new System.Windows.Forms.Button();
            this.buttonThirdAnswer = new System.Windows.Forms.Button();
            this.labelQuestionCount = new System.Windows.Forms.Label();
            this.buttonInReturnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(63, 41);
            this.richTextBoxQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(452, 162);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // buttonFirstAnswer
            // 
            this.buttonFirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstAnswer.Location = new System.Drawing.Point(136, 247);
            this.buttonFirstAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFirstAnswer.Name = "buttonFirstAnswer";
            this.buttonFirstAnswer.Size = new System.Drawing.Size(311, 62);
            this.buttonFirstAnswer.TabIndex = 1;
            this.buttonFirstAnswer.Text = "button1";
            this.buttonFirstAnswer.UseVisualStyleBackColor = true;
            this.buttonFirstAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonSecondAnswer
            // 
            this.buttonSecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecondAnswer.Location = new System.Drawing.Point(136, 350);
            this.buttonSecondAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSecondAnswer.Name = "buttonSecondAnswer";
            this.buttonSecondAnswer.Size = new System.Drawing.Size(311, 62);
            this.buttonSecondAnswer.TabIndex = 2;
            this.buttonSecondAnswer.Text = "button2";
            this.buttonSecondAnswer.UseVisualStyleBackColor = true;
            this.buttonSecondAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonThirdAnswer
            // 
            this.buttonThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThirdAnswer.Location = new System.Drawing.Point(136, 447);
            this.buttonThirdAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThirdAnswer.Name = "buttonThirdAnswer";
            this.buttonThirdAnswer.Size = new System.Drawing.Size(311, 62);
            this.buttonThirdAnswer.TabIndex = 3;
            this.buttonThirdAnswer.Text = "button3";
            this.buttonThirdAnswer.UseVisualStyleBackColor = true;
            this.buttonThirdAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Location = new System.Drawing.Point(23, 18);
            this.labelQuestionCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(0, 17);
            this.labelQuestionCount.TabIndex = 4;
            // 
            // buttonInReturnMenu
            // 
            this.buttonInReturnMenu.Enabled = false;
            this.buttonInReturnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInReturnMenu.Location = new System.Drawing.Point(136, 350);
            this.buttonInReturnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInReturnMenu.Name = "buttonInReturnMenu";
            this.buttonInReturnMenu.Size = new System.Drawing.Size(311, 61);
            this.buttonInReturnMenu.TabIndex = 5;
            this.buttonInReturnMenu.Text = "Вернуться в  меню";
            this.buttonInReturnMenu.UseVisualStyleBackColor = true;
            this.buttonInReturnMenu.Visible = false;
            this.buttonInReturnMenu.Click += new System.EventHandler(this.buttonInReturnMenu_Click);
            // 
            // MainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(579, 565);
            this.Controls.Add(this.buttonInReturnMenu);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.buttonThirdAnswer);
            this.Controls.Add(this.buttonSecondAnswer);
            this.Controls.Add(this.buttonFirstAnswer);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Здоровое Питание";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
    }
}

