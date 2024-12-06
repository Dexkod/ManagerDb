namespace ManagerDb
{
    partial class Form1
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
            SearchTextBox = new TextBox();
            TableLabel = new Label();
            dataGridView1 = new DataGridView();
            SelectButton = new Button();
            DeleteButton = new Button();
            ChangeButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(69, 51);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(193, 27);
            SearchTextBox.TabIndex = 0;
            // 
            // TableLabel
            // 
            TableLabel.AutoSize = true;
            TableLabel.Location = new Point(139, 16);
            TableLabel.Name = "TableLabel";
            TableLabel.Size = new Size(68, 20);
            TableLabel.TabIndex = 1;
            TableLabel.Text = "Таблица";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(602, 333);
            dataGridView1.TabIndex = 2;
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(311, 49);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(109, 29);
            SelectButton.TabIndex = 3;
            SelectButton.Text = "Посмотреть";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(650, 259);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(650, 208);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(94, 29);
            ChangeButton.TabIndex = 5;
            ChangeButton.Text = "Сохранить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(650, 157);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddButton);
            Controls.Add(ChangeButton);
            Controls.Add(DeleteButton);
            Controls.Add(SelectButton);
            Controls.Add(dataGridView1);
            Controls.Add(TableLabel);
            Controls.Add(SearchTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private Label TableLabel;
        private DataGridView dataGridView1;
        private Button SelectButton;
        private Button DeleteButton;
        private Button ChangeButton;
        private Button AddButton;
    }
}
