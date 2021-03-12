
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
            this.richTextBoxQuestion.Location = new System.Drawing.Point(47, 33);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(339, 132);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.Text = "";
            // 
            // buttonFirstAnswer
            // 
            this.buttonFirstAnswer.Location = new System.Drawing.Point(102, 201);
            this.buttonFirstAnswer.Name = "buttonFirstAnswer";
            this.buttonFirstAnswer.Size = new System.Drawing.Size(233, 50);
            this.buttonFirstAnswer.TabIndex = 1;
            this.buttonFirstAnswer.Text = "button1";
            this.buttonFirstAnswer.UseVisualStyleBackColor = true;
            this.buttonFirstAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonSecondAnswer
            // 
            this.buttonSecondAnswer.Location = new System.Drawing.Point(102, 284);
            this.buttonSecondAnswer.Name = "buttonSecondAnswer";
            this.buttonSecondAnswer.Size = new System.Drawing.Size(233, 50);
            this.buttonSecondAnswer.TabIndex = 2;
            this.buttonSecondAnswer.Text = "button2";
            this.buttonSecondAnswer.UseVisualStyleBackColor = true;
            this.buttonSecondAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // buttonThirdAnswer
            // 
            this.buttonThirdAnswer.Location = new System.Drawing.Point(102, 363);
            this.buttonThirdAnswer.Name = "buttonThirdAnswer";
            this.buttonThirdAnswer.Size = new System.Drawing.Size(233, 50);
            this.buttonThirdAnswer.TabIndex = 3;
            this.buttonThirdAnswer.Text = "button3";
            this.buttonThirdAnswer.UseVisualStyleBackColor = true;
            this.buttonThirdAnswer.Click += new System.EventHandler(this.update_Click);
            // 
            // labelQuestionCount
            // 
            this.labelQuestionCount.AutoSize = true;
            this.labelQuestionCount.Location = new System.Drawing.Point(17, 15);
            this.labelQuestionCount.Name = "labelQuestionCount";
            this.labelQuestionCount.Size = new System.Drawing.Size(0, 13);
            this.labelQuestionCount.TabIndex = 4;
            // 
            // buttonInReturnMenu
            // 
            this.buttonInReturnMenu.Enabled = false;
            this.buttonInReturnMenu.Location = new System.Drawing.Point(102, 284);
            this.buttonInReturnMenu.Name = "buttonInReturnMenu";
            this.buttonInReturnMenu.Size = new System.Drawing.Size(233, 50);
            this.buttonInReturnMenu.TabIndex = 5;
            this.buttonInReturnMenu.Text = "Вернуться в  меню";
            this.buttonInReturnMenu.UseVisualStyleBackColor = true;
            this.buttonInReturnMenu.Visible = false;
            this.buttonInReturnMenu.Click += new System.EventHandler(this.buttonInReturnMenu_Click);
            // 
            // MainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 459);
            this.Controls.Add(this.buttonInReturnMenu);
            this.Controls.Add(this.labelQuestionCount);
            this.Controls.Add(this.buttonThirdAnswer);
            this.Controls.Add(this.buttonSecondAnswer);
            this.Controls.Add(this.buttonFirstAnswer);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Margin = new System.Windows.Forms.Padding(2);
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

