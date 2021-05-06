namespace Advanced_CSharp_exercises
{
    partial class frmMovableButtons
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentPos = new System.Windows.Forms.Button();
            this.topLeft = new System.Windows.Forms.Button();
            this.nudMovement = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentPos);
            this.groupBox1.Controls.Add(this.topLeft);
            this.groupBox1.Controls.Add(this.nudMovement);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(441, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // currentPos
            // 
            this.currentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPos.Location = new System.Drawing.Point(11, 51);
            this.currentPos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentPos.Name = "currentPos";
            this.currentPos.Size = new System.Drawing.Size(191, 39);
            this.currentPos.TabIndex = 5;
            this.currentPos.Text = "From current position";
            this.currentPos.UseVisualStyleBackColor = true;
            this.currentPos.Click += new System.EventHandler(this.currentPos_Click);
            // 
            // topLeft
            // 
            this.topLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.topLeft.Location = new System.Drawing.Point(233, 50);
            this.topLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(191, 39);
            this.topLeft.TabIndex = 5;
            this.topLeft.Text = "From top left";
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.topLeft_Click);
            // 
            // nudMovement
            // 
            this.nudMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMovement.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMovement.Location = new System.Drawing.Point(151, 22);
            this.nudMovement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudMovement.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMovement.Name = "nudMovement";
            this.nudMovement.Size = new System.Drawing.Size(65, 23);
            this.nudMovement.TabIndex = 4;
            this.nudMovement.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movement:";
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(108, 73);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(88, 27);
            this.btn.TabIndex = 1;
            this.btn.Text = "Random button";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // frmMovableButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 298);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMovableButtons";
            this.Text = "Movable buttons form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button topLeft;
        private System.Windows.Forms.NumericUpDown nudMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button currentPos;
    }
}