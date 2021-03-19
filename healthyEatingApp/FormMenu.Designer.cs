
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonBeginTest = new System.Windows.Forms.Button();
            this.buttonBeginCalc = new System.Windows.Forms.Button();
            this.richTextBoxStart = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonBeginTest
            // 
            this.buttonBeginTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBeginTest.Location = new System.Drawing.Point(62, 299);
            this.buttonBeginTest.Name = "buttonBeginTest";
            this.buttonBeginTest.Size = new System.Drawing.Size(245, 51);
            this.buttonBeginTest.TabIndex = 0;
            this.buttonBeginTest.Text = "Пройти тест на здоровое питание";
            this.buttonBeginTest.UseVisualStyleBackColor = true;
            this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginTest_Click);
            // 
            // buttonBeginCalc
            // 
            this.buttonBeginCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBeginCalc.Location = new System.Drawing.Point(62, 368);
            this.buttonBeginCalc.Name = "buttonBeginCalc";
            this.buttonBeginCalc.Size = new System.Drawing.Size(245, 51);
            this.buttonBeginCalc.TabIndex = 1;
            this.buttonBeginCalc.Text = "Перейти к калькулятору калорий";
            this.buttonBeginCalc.UseVisualStyleBackColor = true;
            this.buttonBeginCalc.Click += new System.EventHandler(this.buttonBeginCalc_Click);
            // 
            // richTextBoxStart
            // 
            this.richTextBoxStart.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxStart.Location = new System.Drawing.Point(1, 10);
            this.richTextBoxStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStart.Name = "richTextBoxStart";
            this.richTextBoxStart.Size = new System.Drawing.Size(537, 284);
            this.richTextBoxStart.TabIndex = 2;
            this.richTextBoxStart.Text = "";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 437);
            this.Controls.Add(this.richTextBoxStart);
            this.Controls.Add(this.buttonBeginCalc);
            this.Controls.Add(this.buttonBeginTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.SizeChanged += new System.EventHandler(this.FormMenu_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBeginTest;
        private System.Windows.Forms.Button buttonBeginCalc;
        private System.Windows.Forms.RichTextBox richTextBoxStart;
    }
}