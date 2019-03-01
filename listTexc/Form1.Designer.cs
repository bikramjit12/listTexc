namespace listTexc
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
            this.lblFruitList = new System.Windows.Forms.ListBox();
            this.btnFruitList = new System.Windows.Forms.Button();
            this.btnAddFruit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFruitList
            // 
            this.lblFruitList.FormattingEnabled = true;
            this.lblFruitList.Location = new System.Drawing.Point(78, 49);
            this.lblFruitList.Name = "lblFruitList";
            this.lblFruitList.Size = new System.Drawing.Size(120, 95);
            this.lblFruitList.TabIndex = 0;
            // 
            // btnFruitList
            // 
            this.btnFruitList.Location = new System.Drawing.Point(329, 49);
            this.btnFruitList.Name = "btnFruitList";
            this.btnFruitList.Size = new System.Drawing.Size(75, 23);
            this.btnFruitList.TabIndex = 1;
            this.btnFruitList.Text = "Fruit List";
            this.btnFruitList.UseVisualStyleBackColor = true;
            this.btnFruitList.Click += new System.EventHandler(this.btnFruitList_Click);
            // 
            // btnAddFruit
            // 
            this.btnAddFruit.Location = new System.Drawing.Point(556, 49);
            this.btnAddFruit.Name = "btnAddFruit";
            this.btnAddFruit.Size = new System.Drawing.Size(75, 23);
            this.btnAddFruit.TabIndex = 1;
            this.btnAddFruit.Text = "Add Fruit";
            this.btnAddFruit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddFruit);
            this.Controls.Add(this.btnFruitList);
            this.Controls.Add(this.lblFruitList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblFruitList;
        private System.Windows.Forms.Button btnFruitList;
        private System.Windows.Forms.Button btnAddFruit;
    }
}

