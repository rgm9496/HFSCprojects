namespace CoachUI
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
            this.addButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.agelabel = new System.Windows.Forms.Label();
            this.seatlabel = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightSalmon;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Location = new System.Drawing.Point(78, 255);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 66);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add To Bus";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // getButton
            // 
            this.getButton.BackColor = System.Drawing.Color.LightSalmon;
            this.getButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getButton.Location = new System.Drawing.Point(354, 255);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(119, 66);
            this.getButton.TabIndex = 1;
            this.getButton.Text = "Get By Name";
            this.getButton.UseVisualStyleBackColor = false;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.LightSalmon;
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Location = new System.Drawing.Point(601, 255);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(121, 66);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove By Name";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightSalmon;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clearButton.Location = new System.Drawing.Point(354, 361);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 63);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nameTextBox.Location = new System.Drawing.Point(284, 143);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(289, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ageTextBox.Location = new System.Drawing.Point(284, 186);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(58, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // seatTextBox
            // 
            this.seatTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.seatTextBox.Location = new System.Drawing.Point(515, 184);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(58, 20);
            this.seatTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(232, 143);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(46, 18);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(232, 186);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(33, 18);
            this.agelabel.TabIndex = 8;
            this.agelabel.Text = "Age";
            // 
            // seatlabel
            // 
            this.seatlabel.AutoSize = true;
            this.seatlabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatlabel.Location = new System.Drawing.Point(418, 186);
            this.seatlabel.Name = "seatlabel";
            this.seatlabel.Size = new System.Drawing.Size(91, 18);
            this.seatlabel.TabIndex = 9;
            this.seatlabel.Text = "Seat Number";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("SimSun", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(302, 52);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(207, 27);
            this.titlelabel.TabIndex = 10;
            this.titlelabel.Text = "Coach Booking";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.seatlabel);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.seatTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Label seatlabel;
        private System.Windows.Forms.Label titlelabel;
    }
}

