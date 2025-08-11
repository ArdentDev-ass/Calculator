namespace Калькулятор
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button[] numButtons = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.Button buttonAdd, buttonSub, buttonMul, buttonDiv, buttonEq, buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // textBox_Result
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(258, 38);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Numeric buttons
            int xPos = 12, yPos = 60;
            int btnSize = 60;
            for (int i = 1; i <= 9; i++)
            {
                numButtons[i] = new System.Windows.Forms.Button();
                numButtons[i].Text = i.ToString();
                numButtons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
                numButtons[i].Size = new System.Drawing.Size(btnSize, btnSize);
                numButtons[i].Location = new System.Drawing.Point(xPos, yPos);
                numButtons[i].Click += new System.EventHandler(this.button_Click);
                this.Controls.Add(numButtons[i]);

                xPos += btnSize + 6;
                if (i % 3 == 0)
                {
                    xPos = 12;
                    yPos += btnSize + 6;
                }
            }

            // 0 button
            numButtons[0] = new System.Windows.Forms.Button();
            numButtons[0].Text = "0";
            numButtons[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            numButtons[0].Size = new System.Drawing.Size(btnSize, btnSize);
            numButtons[0].Location = new System.Drawing.Point(12, yPos);
            numButtons[0].Click += new System.EventHandler(this.button_Click);
            this.Controls.Add(numButtons[0]);

            // Operators
            buttonAdd = CreateOpButton("+", 198, 60);
            buttonSub = CreateOpButton("-", 198, 126);
            buttonMul = CreateOpButton("*", 198, 192);
            buttonDiv = CreateOpButton("/", 198, 258);
            buttonEq = CreateOpButton("=", 78, yPos);
            buttonClear = CreateOpButton("C", 144, yPos);

            // Form1
            this.ClientSize = new System.Drawing.Size(282, 330);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Button CreateOpButton(string text, int x, int y)
        {
            Button b = new Button();
            b.Text = text;
            b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            b.Size = new System.Drawing.Size(60, 60);
            b.Location = new System.Drawing.Point(x, y);
            if (text == "=")
                b.Click += new System.EventHandler(this.button16_Click);
            else if (text == "C")
                b.Click += new System.EventHandler(this.button5_Click);
            else
                b.Click += new System.EventHandler(this.operator_Click);
            this.Controls.Add(b);
            return b;
        }
    }
}