namespace Client
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marcaTextLabel = new System.Windows.Forms.Label();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.anDeFabricatieTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kilometrajTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.newCarButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 400);
            this.listBox1.TabIndex = 0;
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(12, 442);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(175, 58);
            this.deleteCarButton.TabIndex = 1;
            this.deleteCarButton.Text = "DeleteCar";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(193, 442);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(190, 58);
            this.showDetailsButton.TabIndex = 2;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(738, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(448, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(549, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(206, 27);
            this.idTextBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(791, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 357);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // marcaTextLabel
            // 
            this.marcaTextLabel.AutoSize = true;
            this.marcaTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.marcaTextLabel.Location = new System.Drawing.Point(448, 130);
            this.marcaTextLabel.Name = "marcaTextLabel";
            this.marcaTextLabel.Size = new System.Drawing.Size(59, 20);
            this.marcaTextLabel.TabIndex = 7;
            this.marcaTextLabel.Text = "Brand:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.marcaTextBox.Location = new System.Drawing.Point(549, 127);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.ReadOnly = true;
            this.marcaTextBox.Size = new System.Drawing.Size(206, 27);
            this.marcaTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(448, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modelTextBox.Location = new System.Drawing.Point(549, 191);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(206, 27);
            this.modelTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(448, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Year:";
            // 
            // anDeFabricatieTextBox
            // 
            this.anDeFabricatieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.anDeFabricatieTextBox.Location = new System.Drawing.Point(549, 259);
            this.anDeFabricatieTextBox.Name = "anDeFabricatieTextBox";
            this.anDeFabricatieTextBox.ReadOnly = true;
            this.anDeFabricatieTextBox.Size = new System.Drawing.Size(206, 27);
            this.anDeFabricatieTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(448, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mileage:";
            // 
            // kilometrajTextBox
            // 
            this.kilometrajTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kilometrajTextBox.Location = new System.Drawing.Point(549, 330);
            this.kilometrajTextBox.Name = "kilometrajTextBox";
            this.kilometrajTextBox.ReadOnly = true;
            this.kilometrajTextBox.Size = new System.Drawing.Size(206, 27);
            this.kilometrajTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(448, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price:";
            // 
            // pretTextBox
            // 
            this.pretTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretTextBox.Location = new System.Drawing.Point(549, 397);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.ReadOnly = true;
            this.pretTextBox.Size = new System.Drawing.Size(206, 27);
            this.pretTextBox.TabIndex = 16;
            // 
            // newCarButton
            // 
            this.newCarButton.Location = new System.Drawing.Point(627, 442);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(474, 58);
            this.newCarButton.TabIndex = 17;
            this.newCarButton.Text = "Add New Car";
            this.newCarButton.UseVisualStyleBackColor = true;
            this.newCarButton.Click += new System.EventHandler(this.newCarButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(389, 442);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(232, 58);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update Details";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 512);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.newCarButton);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kilometrajTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anDeFabricatieTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.marcaTextLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Button showDetailsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label marcaTextLabel;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox anDeFabricatieTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kilometrajTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.Button updateButton;
    }
}

