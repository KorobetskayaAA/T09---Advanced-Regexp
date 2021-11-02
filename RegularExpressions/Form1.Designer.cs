
namespace RegularExpressions
{
    partial class FormRegExp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegExp));
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBoxRegexp = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonFindAll = new System.Windows.Forms.Button();
            this.labelMathchResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 26);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(762, 336);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = resources.GetString("textBoxInput.Text");
            // 
            // textBoxRegexp
            // 
            this.textBoxRegexp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegexp.Location = new System.Drawing.Point(12, 368);
            this.textBoxRegexp.Name = "textBoxRegexp";
            this.textBoxRegexp.Size = new System.Drawing.Size(762, 23);
            this.textBoxRegexp.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFind.Location = new System.Drawing.Point(12, 397);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonFindAll
            // 
            this.buttonFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFindAll.Location = new System.Drawing.Point(112, 397);
            this.buttonFindAll.Name = "buttonFindAll";
            this.buttonFindAll.Size = new System.Drawing.Size(75, 23);
            this.buttonFindAll.TabIndex = 3;
            this.buttonFindAll.Text = "Найти все";
            this.buttonFindAll.UseVisualStyleBackColor = true;
            this.buttonFindAll.Click += new System.EventHandler(this.buttonFindAll_Click);
            // 
            // labelMathchResult
            // 
            this.labelMathchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMathchResult.AutoSize = true;
            this.labelMathchResult.Location = new System.Drawing.Point(208, 401);
            this.labelMathchResult.Name = "labelMathchResult";
            this.labelMathchResult.Size = new System.Drawing.Size(0, 15);
            this.labelMathchResult.TabIndex = 4;
            // 
            // FormRegExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 432);
            this.Controls.Add(this.labelMathchResult);
            this.Controls.Add(this.buttonFindAll);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxRegexp);
            this.Controls.Add(this.textBoxInput);
            this.Name = "FormRegExp";
            this.Text = "Регулярные выражения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxRegexp;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonFindAll;
        private System.Windows.Forms.Label labelMathchResult;
    }
}

