namespace CalculatorWinformPlugins
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.display = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.footerMadeBy = new System.Windows.Forms.TextBox();
            this.errorMessage = new System.Windows.Forms.TextBox();
            this.footerLink = new System.Windows.Forms.LinkLabel();
            this.power = new System.Windows.Forms.Button();
            this.nthRoot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AccessibleDescription = "Where numbers are displayed when keyed in or calculated";
            this.display.AccessibleName = "Display";
            this.display.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Font = new System.Drawing.Font("Kelly Slab", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 13);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(399, 64);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n1
            // 
            this.n1.AccessibleName = "One";
            this.n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n1.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(12, 336);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(75, 75);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.AccessibleName = "Two";
            this.n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n2.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(93, 336);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(75, 75);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.AccessibleName = "Three";
            this.n3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n3.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(174, 337);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(75, 75);
            this.n3.TabIndex = 1;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.AccessibleName = "Four";
            this.n4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n4.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(12, 255);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(75, 75);
            this.n4.TabIndex = 1;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.AccessibleName = "Five";
            this.n5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n5.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(93, 255);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(75, 75);
            this.n5.TabIndex = 1;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.AccessibleName = "Six";
            this.n6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n6.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(174, 255);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(75, 75);
            this.n6.TabIndex = 1;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.AccessibleName = "Seven";
            this.n7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n7.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(12, 174);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(75, 75);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.AccessibleName = "Eight";
            this.n8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n8.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(93, 174);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(75, 75);
            this.n8.TabIndex = 1;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.AccessibleName = "Nine";
            this.n9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n9.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(174, 174);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(75, 75);
            this.n9.TabIndex = 1;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.AccessibleName = "Zero";
            this.n0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.n0.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(12, 417);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(75, 75);
            this.n0.TabIndex = 1;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // clear
            // 
            this.clear.AccessibleDescription = "Clears the display";
            this.clear.AccessibleName = "Clear";
            this.clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clear.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(253, 93);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 75);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus
            // 
            this.plus.AccessibleDescription = "";
            this.plus.AccessibleName = "Plus";
            this.plus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plus.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(255, 336);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 75);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.AccessibleDescription = "";
            this.minus.AccessibleName = "Minus";
            this.minus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minus.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(336, 336);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 75);
            this.minus.TabIndex = 1;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.AccessibleDescription = "";
            this.multiply.AccessibleName = "Multiply";
            this.multiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.multiply.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(255, 255);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 75);
            this.multiply.TabIndex = 1;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.AccessibleDescription = "";
            this.divide.AccessibleName = "Divide";
            this.divide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.divide.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(336, 255);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 75);
            this.divide.TabIndex = 1;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // equals
            // 
            this.equals.AccessibleDescription = "Performs the current calculation";
            this.equals.AccessibleName = "Equals";
            this.equals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equals.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(255, 417);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(156, 75);
            this.equals.TabIndex = 1;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // point
            // 
            this.point.AccessibleDescription = "";
            this.point.AccessibleName = "Point";
            this.point.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.point.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(93, 417);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 75);
            this.point.TabIndex = 1;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // footerMadeBy
            // 
            this.footerMadeBy.AccessibleName = "Footer Part 1";
            this.footerMadeBy.BackColor = System.Drawing.SystemColors.Control;
            this.footerMadeBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.footerMadeBy.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerMadeBy.Location = new System.Drawing.Point(10, 597);
            this.footerMadeBy.Multiline = true;
            this.footerMadeBy.Name = "footerMadeBy";
            this.footerMadeBy.ReadOnly = true;
            this.footerMadeBy.Size = new System.Drawing.Size(399, 32);
            this.footerMadeBy.TabIndex = 2;
            this.footerMadeBy.TabStop = false;
            this.footerMadeBy.Text = "Made by Duncan Ritchie, 2019/11/26";
            this.footerMadeBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorMessage
            // 
            this.errorMessage.AccessibleDescription = "Error message (if any)";
            this.errorMessage.AccessibleName = "Error message (if any)";
            this.errorMessage.BackColor = System.Drawing.SystemColors.Control;
            this.errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorMessage.Font = new System.Drawing.Font("Kelly Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorMessage.Location = new System.Drawing.Point(12, 511);
            this.errorMessage.Multiline = true;
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.ReadOnly = true;
            this.errorMessage.Size = new System.Drawing.Size(399, 80);
            this.errorMessage.TabIndex = 3;
            this.errorMessage.TabStop = false;
            this.errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // footerLink
            // 
            this.footerLink.AccessibleDescription = "Link to my website";
            this.footerLink.AccessibleName = "Link";
            this.footerLink.ActiveLinkColor = System.Drawing.Color.Navy;
            this.footerLink.AutoSize = true;
            this.footerLink.Font = new System.Drawing.Font("Candara", 10.8F);
            this.footerLink.Location = new System.Drawing.Point(8, 620);
            this.footerLink.MinimumSize = new System.Drawing.Size(399, 0);
            this.footerLink.Name = "footerLink";
            this.footerLink.Size = new System.Drawing.Size(399, 23);
            this.footerLink.TabIndex = 4;
            this.footerLink.TabStop = true;
            this.footerLink.Text = "www.duncanritchie.co.uk";
            this.footerLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.footerLink.VisitedLinkColor = System.Drawing.Color.Blue;
            this.footerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.footerLink_LinkClicked);
            // 
            // power
            // 
            this.power.AccessibleDescription = "";
            this.power.AccessibleName = "Power";
            this.power.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.power.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(255, 174);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(75, 75);
            this.power.TabIndex = 1;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // nthRoot
            // 
            this.nthRoot.AccessibleDescription = "";
            this.nthRoot.AccessibleName = "Nth Root";
            this.nthRoot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nthRoot.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nthRoot.Location = new System.Drawing.Point(336, 174);
            this.nthRoot.Name = "nthRoot";
            this.nthRoot.Size = new System.Drawing.Size(75, 75);
            this.nthRoot.TabIndex = 1;
            this.nthRoot.Text = "ⁿ√";
            this.nthRoot.UseVisualStyleBackColor = false;
            this.nthRoot.Click += new System.EventHandler(this.nthRoot_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 788);
            this.Controls.Add(this.footerLink);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.footerMadeBy);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.point);
            this.Controls.Add(this.nthRoot);
            this.Controls.Add(this.power);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Duncan’s Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.TextBox footerMadeBy;
        private System.Windows.Forms.TextBox errorMessage;
        private System.Windows.Forms.LinkLabel footerLink;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button nthRoot;
    }
}

