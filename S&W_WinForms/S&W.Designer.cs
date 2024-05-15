namespace S_W_WinForms
{
    partial class S_W
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
            pictureBox1 = new PictureBox();
            groupBox = new GroupBox();
            RefreshShoppingList = new Button();
            StoreItemsList = new ListBox();
            AddBtn = new Button();
            RemoveBtn = new Button();
            IdTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            PriceTextBox = new TextBox();
            NameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.S_W_Logo;
            pictureBox1.Location = new Point(346, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox
            // 
            groupBox.BackColor = SystemColors.MenuBar;
            groupBox.Controls.Add(RefreshShoppingList);
            groupBox.Controls.Add(StoreItemsList);
            groupBox.Controls.Add(AddBtn);
            groupBox.Controls.Add(RemoveBtn);
            groupBox.Controls.Add(IdTextBox);
            groupBox.Controls.Add(QuantityTextBox);
            groupBox.Controls.Add(PriceTextBox);
            groupBox.Controls.Add(NameTextBox);
            groupBox.Location = new Point(12, 82);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(776, 356);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            // 
            // RefreshShoppingList
            // 
            RefreshShoppingList.BackColor = Color.Cyan;
            RefreshShoppingList.Location = new Point(695, 327);
            RefreshShoppingList.Name = "RefreshShoppingList";
            RefreshShoppingList.Size = new Size(75, 23);
            RefreshShoppingList.TabIndex = 7;
            RefreshShoppingList.Text = "Refresh";
            RefreshShoppingList.UseVisualStyleBackColor = false;
            RefreshShoppingList.Click += RefreshShoppingList_Click;
            // 
            // StoreItemsList
            // 
            StoreItemsList.FormattingEnabled = true;
            StoreItemsList.ItemHeight = 15;
            StoreItemsList.Location = new Point(6, 169);
            StoreItemsList.Name = "StoreItemsList";
            StoreItemsList.Size = new Size(764, 154);
            StoreItemsList.TabIndex = 6;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(128, 255, 128);
            AddBtn.Location = new Point(454, 67);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(52, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.BackColor = Color.LightCoral;
            RemoveBtn.Location = new Point(386, 114);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(62, 23);
            RemoveBtn.TabIndex = 5;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(334, 114);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.PlaceholderText = "Id";
            IdTextBox.Size = new Size(46, 23);
            IdTextBox.TabIndex = 4;
            IdTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(416, 66);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.PlaceholderText = "Qty";
            QuantityTextBox.Size = new Size(32, 23);
            QuantityTextBox.TabIndex = 2;
            QuantityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(370, 66);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.PlaceholderText = "Price";
            PriceTextBox.Size = new Size(40, 23);
            PriceTextBox.TabIndex = 1;
            PriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(264, 67);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "Name of Product";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // S_W
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox);
            Controls.Add(pictureBox1);
            Name = "S_W";
            Text = "S&W";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox;
        private TextBox NameTextBox;
        private TextBox QuantityTextBox;
        private TextBox PriceTextBox;
        private Button RemoveBtn;
        private TextBox IdTextBox;
        private Button AddBtn;
        private ListBox StoreItemsList;
        private Button RefreshShoppingList;
    }
}
