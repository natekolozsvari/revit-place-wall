
namespace PlaceWall
{
    partial class Form1
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.placeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startXTextBox = new System.Windows.Forms.TextBox();
            this.startYTextBox = new System.Windows.Forms.TextBox();
            this.endXTextBox = new System.Windows.Forms.TextBox();
            this.endYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(153, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 32);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start coordinates";
            // 
            // placeButton
            // 
            this.placeButton.Location = new System.Drawing.Point(40, 182);
            this.placeButton.Name = "placeButton";
            this.placeButton.Size = new System.Drawing.Size(90, 32);
            this.placeButton.TabIndex = 3;
            this.placeButton.Text = "Place wall";
            this.placeButton.UseVisualStyleBackColor = true;
            this.placeButton.Click += new System.EventHandler(this.placeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "End coordinates";
            // 
            // startXTextBox
            // 
            this.startXTextBox.Location = new System.Drawing.Point(57, 55);
            this.startXTextBox.Name = "startXTextBox";
            this.startXTextBox.Size = new System.Drawing.Size(64, 20);
            this.startXTextBox.TabIndex = 5;
            this.startXTextBox.TextChanged += new System.EventHandler(this.startXTextBox_TextChanged);
            // 
            // startYTextBox
            // 
            this.startYTextBox.Location = new System.Drawing.Point(170, 55);
            this.startYTextBox.Name = "startYTextBox";
            this.startYTextBox.Size = new System.Drawing.Size(64, 20);
            this.startYTextBox.TabIndex = 6;
            this.startYTextBox.TextChanged += new System.EventHandler(this.startYTextBox_TextChanged);
            // 
            // endXTextBox
            // 
            this.endXTextBox.Location = new System.Drawing.Point(57, 120);
            this.endXTextBox.Name = "endXTextBox";
            this.endXTextBox.Size = new System.Drawing.Size(64, 20);
            this.endXTextBox.TabIndex = 7;
            this.endXTextBox.TextChanged += new System.EventHandler(this.endXTextBox_TextChanged);
            // 
            // endYTextBox
            // 
            this.endYTextBox.Location = new System.Drawing.Point(170, 120);
            this.endYTextBox.Name = "endYTextBox";
            this.endYTextBox.Size = new System.Drawing.Size(64, 20);
            this.endYTextBox.TabIndex = 8;
            this.endYTextBox.TextChanged += new System.EventHandler(this.endYTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 226);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endYTextBox);
            this.Controls.Add(this.endXTextBox);
            this.Controls.Add(this.startYTextBox);
            this.Controls.Add(this.startXTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button placeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startXTextBox;
        private System.Windows.Forms.TextBox startYTextBox;
        private System.Windows.Forms.TextBox endXTextBox;
        private System.Windows.Forms.TextBox endYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}