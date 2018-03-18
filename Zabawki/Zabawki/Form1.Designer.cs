namespace Zabawki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.toSelectingList = new System.Windows.Forms.ListBox();
            this.selectedList = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.speedDownButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depthDownButton = new System.Windows.Forms.Button();
            this.altitudeDownButton = new System.Windows.Forms.Button();
            this.speedUpButton = new System.Windows.Forms.Button();
            this.altitudeUpButton = new System.Windows.Forms.Button();
            this.depthUpButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.altitudeTable = new System.Windows.Forms.TableLayoutPanel();
            this.depthTable = new System.Windows.Forms.TableLayoutPanel();
            this.speedTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.altitudeTable.SuspendLayout();
            this.depthTable.SuspendLayout();
            this.speedTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // toSelectingList
            // 
            this.toSelectingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toSelectingList.FormattingEnabled = true;
            this.toSelectingList.ItemHeight = 25;
            this.toSelectingList.Location = new System.Drawing.Point(12, 36);
            this.toSelectingList.Name = "toSelectingList";
            this.toSelectingList.Size = new System.Drawing.Size(133, 154);
            this.toSelectingList.TabIndex = 0;
            // 
            // selectedList
            // 
            this.selectedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedList.FormattingEnabled = true;
            this.selectedList.ItemHeight = 20;
            this.selectedList.Location = new System.Drawing.Point(257, 36);
            this.selectedList.Name = "selectedList";
            this.selectedList.Size = new System.Drawing.Size(133, 144);
            this.selectedList.TabIndex = 1;
            this.selectedList.SelectedIndexChanged += new System.EventHandler(this.selectedList_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(151, 36);
            this.nameTextBox.MaxLength = 12;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To selecting";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(168, 98);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(65, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(168, 144);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(65, 23);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // speedDownButton
            // 
            this.speedDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedDownButton.Location = new System.Drawing.Point(43, 57);
            this.speedDownButton.Name = "speedDownButton";
            this.speedDownButton.Size = new System.Drawing.Size(39, 35);
            this.speedDownButton.TabIndex = 0;
            this.speedDownButton.Text = "-";
            this.speedDownButton.UseVisualStyleBackColor = true;
            this.speedDownButton.Click += new System.EventHandler(this.speedDownButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(140, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acceleration";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(162, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Depth";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(157, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Altitude";
            // 
            // depthDownButton
            // 
            this.depthDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depthDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.depthDownButton.Location = new System.Drawing.Point(43, 57);
            this.depthDownButton.Name = "depthDownButton";
            this.depthDownButton.Size = new System.Drawing.Size(39, 35);
            this.depthDownButton.TabIndex = 9;
            this.depthDownButton.Text = "-";
            this.depthDownButton.UseVisualStyleBackColor = true;
            this.depthDownButton.Click += new System.EventHandler(this.depthDownButton_Click);
            // 
            // altitudeDownButton
            // 
            this.altitudeDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altitudeDownButton.Location = new System.Drawing.Point(43, 57);
            this.altitudeDownButton.Name = "altitudeDownButton";
            this.altitudeDownButton.Size = new System.Drawing.Size(39, 35);
            this.altitudeDownButton.TabIndex = 10;
            this.altitudeDownButton.Text = "-";
            this.altitudeDownButton.UseVisualStyleBackColor = true;
            this.altitudeDownButton.Click += new System.EventHandler(this.altitudeDownButton_Click);
            // 
            // speedUpButton
            // 
            this.speedUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedUpButton.Location = new System.Drawing.Point(295, 57);
            this.speedUpButton.Name = "speedUpButton";
            this.speedUpButton.Size = new System.Drawing.Size(39, 35);
            this.speedUpButton.TabIndex = 11;
            this.speedUpButton.Text = "+";
            this.speedUpButton.UseVisualStyleBackColor = true;
            this.speedUpButton.Click += new System.EventHandler(this.speedUpButton_Click);
            // 
            // altitudeUpButton
            // 
            this.altitudeUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altitudeUpButton.Location = new System.Drawing.Point(295, 57);
            this.altitudeUpButton.Name = "altitudeUpButton";
            this.altitudeUpButton.Size = new System.Drawing.Size(39, 35);
            this.altitudeUpButton.TabIndex = 12;
            this.altitudeUpButton.Text = "+";
            this.altitudeUpButton.UseVisualStyleBackColor = true;
            this.altitudeUpButton.Click += new System.EventHandler(this.altitudeUpButton_Click);
            // 
            // depthUpButton
            // 
            this.depthUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depthUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.depthUpButton.Location = new System.Drawing.Point(295, 57);
            this.depthUpButton.Name = "depthUpButton";
            this.depthUpButton.Size = new System.Drawing.Size(39, 35);
            this.depthUpButton.TabIndex = 13;
            this.depthUpButton.Text = "+";
            this.depthUpButton.UseVisualStyleBackColor = true;
            this.depthUpButton.Click += new System.EventHandler(this.depthUpButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedLabel.Location = new System.Drawing.Point(177, 62);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(23, 25);
            this.speedLabel.TabIndex = 14;
            this.speedLabel.Text = "0";
            // 
            // depthLabel
            // 
            this.depthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.depthLabel.Location = new System.Drawing.Point(177, 62);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(23, 25);
            this.depthLabel.TabIndex = 15;
            this.depthLabel.Text = "0";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.altitudeLabel.Location = new System.Drawing.Point(177, 62);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(23, 25);
            this.altitudeLabel.TabIndex = 16;
            this.altitudeLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(282, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.altitudeTable);
            this.panel1.Controls.Add(this.depthTable);
            this.panel1.Controls.Add(this.speedTable);
            this.panel1.Location = new System.Drawing.Point(12, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 326);
            this.panel1.TabIndex = 10;
            // 
            // altitudeTable
            // 
            this.altitudeTable.ColumnCount = 3;
            this.altitudeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.altitudeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.altitudeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.altitudeTable.Controls.Add(this.altitudeUpButton, 2, 1);
            this.altitudeTable.Controls.Add(this.altitudeDownButton, 0, 1);
            this.altitudeTable.Controls.Add(this.label6, 1, 0);
            this.altitudeTable.Controls.Add(this.altitudeLabel, 1, 1);
            this.altitudeTable.Enabled = false;
            this.altitudeTable.Location = new System.Drawing.Point(0, 212);
            this.altitudeTable.Name = "altitudeTable";
            this.altitudeTable.RowCount = 2;
            this.altitudeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altitudeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.altitudeTable.Size = new System.Drawing.Size(378, 100);
            this.altitudeTable.TabIndex = 2;
            // 
            // depthTable
            // 
            this.depthTable.ColumnCount = 3;
            this.depthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.depthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.depthTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.depthTable.Controls.Add(this.depthUpButton, 2, 1);
            this.depthTable.Controls.Add(this.depthLabel, 1, 1);
            this.depthTable.Controls.Add(this.depthDownButton, 0, 1);
            this.depthTable.Controls.Add(this.label5, 1, 0);
            this.depthTable.Enabled = false;
            this.depthTable.Location = new System.Drawing.Point(0, 106);
            this.depthTable.Name = "depthTable";
            this.depthTable.RowCount = 2;
            this.depthTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.depthTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.depthTable.Size = new System.Drawing.Size(378, 100);
            this.depthTable.TabIndex = 1;
            // 
            // speedTable
            // 
            this.speedTable.BackColor = System.Drawing.SystemColors.Control;
            this.speedTable.ColumnCount = 3;
            this.speedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.speedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.speedTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.speedTable.Controls.Add(this.speedDownButton, 0, 1);
            this.speedTable.Controls.Add(this.speedLabel, 1, 1);
            this.speedTable.Controls.Add(this.speedUpButton, 2, 1);
            this.speedTable.Controls.Add(this.label4, 1, 0);
            this.speedTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedTable.Enabled = false;
            this.speedTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.speedTable.Location = new System.Drawing.Point(0, 0);
            this.speedTable.Name = "speedTable";
            this.speedTable.RowCount = 2;
            this.speedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.speedTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.speedTable.Size = new System.Drawing.Size(378, 100);
            this.speedTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(406, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.selectedList);
            this.Controls.Add(this.toSelectingList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toys";
            this.panel1.ResumeLayout(false);
            this.altitudeTable.ResumeLayout(false);
            this.altitudeTable.PerformLayout();
            this.depthTable.ResumeLayout(false);
            this.depthTable.PerformLayout();
            this.speedTable.ResumeLayout(false);
            this.speedTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox toSelectingList;
        private System.Windows.Forms.ListBox selectedList;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button speedDownButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button depthDownButton;
        private System.Windows.Forms.Button altitudeDownButton;
        private System.Windows.Forms.Button speedUpButton;
        private System.Windows.Forms.Button depthUpButton;
        private System.Windows.Forms.Button altitudeUpButton;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel speedTable;
        private System.Windows.Forms.TableLayoutPanel altitudeTable;
        private System.Windows.Forms.TableLayoutPanel depthTable;
    }
}

