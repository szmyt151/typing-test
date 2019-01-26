namespace TypingTest
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordCountText = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.typingSample = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.wordCountText);
            this.panel2.Controls.Add(this.instructions);
            this.panel2.Location = new System.Drawing.Point(601, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 594);
            this.panel2.TabIndex = 1;
            // 
            // wordCountText
            // 
            this.wordCountText.AutoSize = true;
            this.wordCountText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.wordCountText.Location = new System.Drawing.Point(16, 283);
            this.wordCountText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordCountText.Name = "wordCountText";
            this.wordCountText.Size = new System.Drawing.Size(0, 24);
            this.wordCountText.TabIndex = 1;
            this.wordCountText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instructions.Location = new System.Drawing.Point(88, 9);
            this.instructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(279, 24);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Start typing sample text to begin test";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.userInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.typingSample, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 597);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.BackColor = System.Drawing.SystemColors.Window;
            this.userInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(5, 303);
            this.userInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(583, 289);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "";
            // 
            // typingSample
            // 
            this.typingSample.DetectUrls = false;
            this.typingSample.Enabled = false;
            this.typingSample.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingSample.Location = new System.Drawing.Point(5, 5);
            this.typingSample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typingSample.Name = "typingSample";
            this.typingSample.ReadOnly = true;
            this.typingSample.Size = new System.Drawing.Size(581, 288);
            this.typingSample.TabIndex = 1;
            this.typingSample.Text = "Default sample text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1072, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox userInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wordCountText;
        private System.Windows.Forms.RichTextBox typingSample;
        private System.Windows.Forms.Button button1;
    }
}

