
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
            this.buttonBeginTest.Location = new System.Drawing.Point(32, 37);
            this.buttonBeginTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBeginTest.Name = "buttonBeginTest";
            this.buttonBeginTest.Size = new System.Drawing.Size(327, 63);
            this.buttonBeginTest.TabIndex = 0;
            this.buttonBeginTest.Text = "Пройти тест на здоровое питание";
            this.buttonBeginTest.UseVisualStyleBackColor = true;
            this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginTest_Click);
            // 
            // buttonBeginCalc
            // 
            this.buttonBeginCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBeginCalc.Location = new System.Drawing.Point(32, 132);
            this.buttonBeginCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBeginCalc.Name = "buttonBeginCalc";
            this.buttonBeginCalc.Size = new System.Drawing.Size(327, 63);
            this.buttonBeginCalc.TabIndex = 1;
            this.buttonBeginCalc.Text = "Перейти к калькулятору калорий";
            this.buttonBeginCalc.UseVisualStyleBackColor = true;
            this.buttonBeginCalc.Click += new System.EventHandler(this.buttonBeginCalc_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 225);
            this.Controls.Add(this.buttonBeginCalc);
            this.Controls.Add(this.buttonBeginTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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