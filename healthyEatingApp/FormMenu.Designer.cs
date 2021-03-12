
namespace healthyEatingApp
{
    partial class FormMenu
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
            this.buttonBeginTest = new System.Windows.Forms.Button();
            this.buttonBeginCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBeginTest
            // 
            this.buttonBeginTest.Location = new System.Drawing.Point(24, 30);
            this.buttonBeginTest.Name = "buttonBeginTest";
            this.buttonBeginTest.Size = new System.Drawing.Size(245, 51);
            this.buttonBeginTest.TabIndex = 0;
            this.buttonBeginTest.Text = "Пройти тест на здоровое питание";
            this.buttonBeginTest.UseVisualStyleBackColor = true;
            this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginTest_Click);
            // 
            // buttonBeginCalc
            // 
            this.buttonBeginCalc.Location = new System.Drawing.Point(24, 107);
            this.buttonBeginCalc.Name = "buttonBeginCalc";
            this.buttonBeginCalc.Size = new System.Drawing.Size(245, 51);
            this.buttonBeginCalc.TabIndex = 1;
            this.buttonBeginCalc.Text = "Перейти к калькулятору калорий";
            this.buttonBeginCalc.UseVisualStyleBackColor = true;
            this.buttonBeginCalc.Click += new System.EventHandler(this.buttonBeginCalc_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 183);
            this.Controls.Add(this.buttonBeginCalc);
            this.Controls.Add(this.buttonBeginTest);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBeginTest;
        private System.Windows.Forms.Button buttonBeginCalc;
    }
}