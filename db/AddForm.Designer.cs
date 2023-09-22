
namespace db
{
    partial class AddForm
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.testDataSet1 = new db.testDataSet();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление учетную запись ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(267, 95);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(167, 29);
            this.tbPhone.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(166, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(268, 29);
            this.tbName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя заказчика:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(54, 267);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 36);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(289, 267);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(134, 36);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 135);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 29);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Идентификатор клиента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата заказа:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 333);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Text = "Форма добавления записи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private testDataSet testDataSet1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}