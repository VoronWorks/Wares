namespace TheBestShop
{
    partial class FormProductsChange
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
            this.btnChage = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbnameProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChage
            // 
            this.btnChage.Location = new System.Drawing.Point(209, 279);
            this.btnChage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChage.Name = "btnChage";
            this.btnChage.Size = new System.Drawing.Size(100, 32);
            this.btnChage.TabIndex = 50;
            this.btnChage.Text = "Изменить";
            this.btnChage.UseVisualStyleBackColor = true;
            this.btnChage.Click += new System.EventHandler(this.btnChage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 279);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbnameProd
            // 
            this.tbnameProd.Location = new System.Drawing.Point(32, 86);
            this.tbnameProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbnameProd.Name = "tbnameProd";
            this.tbnameProd.Size = new System.Drawing.Size(276, 22);
            this.tbnameProd.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Название товара";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(32, 142);
            this.tbCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(276, 22);
            this.tbCost.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Стоимость";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(77, 31);
            this.labelid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 16);
            this.labelid.TabIndex = 54;
            this.labelid.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Товар:";
            // 
            // FormProductsChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 346);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbnameProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProductsChange";
            this.Text = "Изменение товара";
            this.Load += new System.EventHandler(this.FormProductsChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbnameProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label3;
    }
}