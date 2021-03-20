
namespace my_form
{
    partial class Form_3
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
            this.name = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(33, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Number:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(36, 39);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 23);
            this.num.TabIndex = 1;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(36, 69);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 3;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(36, 104);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 15);
            this.output.TabIndex = 4;
            // 
            // Form_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 149);
            this.Controls.Add(this.output);
            this.Controls.Add(this.run);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name);
            this.Name = "Form_3";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label output;
    }
}