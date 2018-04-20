namespace DBproject
{
    partial class startup
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_card_details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reservations ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cars information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Company Expenditures";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Company Revenues";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_card_details
            // 
            this.btn_card_details.Location = new System.Drawing.Point(115, 319);
            this.btn_card_details.Name = "btn_card_details";
            this.btn_card_details.Size = new System.Drawing.Size(127, 50);
            this.btn_card_details.TabIndex = 4;
            this.btn_card_details.Text = "Card Details";
            this.btn_card_details.UseVisualStyleBackColor = true;
            this.btn_card_details.Click += new System.EventHandler(this.btn_card_details_Click);
            // 
            // startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 460);
            this.Controls.Add(this.btn_card_details);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "startup";
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.startup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_card_details;
    }
}