using System.Windows.Forms;

namespace VPlab8
{
    partial class DocForm
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
            this.components = new System.ComponentModel.Container();
            this.DocCodeTextBox = new System.Windows.Forms.TextBox();
            this.DocFormName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RegCodeLabel = new System.Windows.Forms.Label();
            this.prevRecord = new System.Windows.Forms.Button();
            this.nextRecord = new System.Windows.Forms.Button();
            this.recordNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.docNumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newRegButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orgComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DocCodeTextBox
            // 
            this.DocCodeTextBox.Enabled = false;
            this.DocCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DocCodeTextBox.Location = new System.Drawing.Point(45, 93);
            this.DocCodeTextBox.Name = "DocCodeTextBox";
            this.DocCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DocCodeTextBox.Size = new System.Drawing.Size(149, 29);
            this.DocCodeTextBox.TabIndex = 0;
            // 
            // DocFormName
            // 
            this.DocFormName.AutoSize = true;
            this.DocFormName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.DocFormName.Location = new System.Drawing.Point(12, 3);
            this.DocFormName.Name = "DocFormName";
            this.DocFormName.Size = new System.Drawing.Size(138, 37);
            this.DocFormName.TabIndex = 1;
            this.DocFormName.Text = "Документ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RegCodeLabel
            // 
            this.RegCodeLabel.AutoSize = true;
            this.RegCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegCodeLabel.Location = new System.Drawing.Point(41, 69);
            this.RegCodeLabel.Name = "RegCodeLabel";
            this.RegCodeLabel.Size = new System.Drawing.Size(118, 21);
            this.RegCodeLabel.TabIndex = 2;
            this.RegCodeLabel.Text = "Код документа";
            // 
            // prevRecord
            // 
            this.prevRecord.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Bold);
            this.prevRecord.Location = new System.Drawing.Point(192, 12);
            this.prevRecord.Name = "prevRecord";
            this.prevRecord.Size = new System.Drawing.Size(45, 27);
            this.prevRecord.TabIndex = 3;
            this.prevRecord.Text = "<";
            this.prevRecord.UseVisualStyleBackColor = true;
            this.prevRecord.Click += new System.EventHandler(this.prevRecord_Click);
            // 
            // nextRecord
            // 
            this.nextRecord.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Bold);
            this.nextRecord.Location = new System.Drawing.Point(287, 12);
            this.nextRecord.Name = "nextRecord";
            this.nextRecord.Size = new System.Drawing.Size(46, 27);
            this.nextRecord.TabIndex = 4;
            this.nextRecord.Text = ">";
            this.nextRecord.UseVisualStyleBackColor = true;
            this.nextRecord.Click += new System.EventHandler(this.nextRecord_Click);
            // 
            // recordNum
            // 
            this.recordNum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.recordNum.Location = new System.Drawing.Point(243, 12);
            this.recordNum.Name = "recordNum";
            this.recordNum.Size = new System.Drawing.Size(38, 27);
            this.recordNum.TabIndex = 5;
            this.recordNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recordNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(41, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер документа";
            // 
            // docNumTextBox
            // 
            this.docNumTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.docNumTextBox.Location = new System.Drawing.Point(45, 149);
            this.docNumTextBox.Name = "docNumTextBox";
            this.docNumTextBox.Size = new System.Drawing.Size(234, 29);
            this.docNumTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Краткое содержание документа";
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contentTextBox.Location = new System.Drawing.Point(45, 214);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(440, 58);
            this.contentTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(283, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата регистрации";
            // 
            // regDateTimePicker
            // 
            this.regDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regDateTimePicker.Location = new System.Drawing.Point(285, 149);
            this.regDateTimePicker.Name = "regDateTimePicker";
            this.regDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.regDateTimePicker.TabIndex = 16;
            // 
            // newRegButton
            // 
            this.newRegButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newRegButton.Location = new System.Drawing.Point(353, 12);
            this.newRegButton.Name = "newRegButton";
            this.newRegButton.Size = new System.Drawing.Size(132, 28);
            this.newRegButton.TabIndex = 17;
            this.newRegButton.Text = "Новый док-т";
            this.newRegButton.UseVisualStyleBackColor = true;
            this.newRegButton.Click += new System.EventHandler(this.newRegButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(353, 46);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 29);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(45, 299);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(141, 29);
            this.typeComboBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(41, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тип документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(188, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Код организации";
            // 
            // orgComboBox
            // 
            this.orgComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgComboBox.FormattingEnabled = true;
            this.orgComboBox.Location = new System.Drawing.Point(192, 299);
            this.orgComboBox.Name = "orgComboBox";
            this.orgComboBox.Size = new System.Drawing.Size(141, 29);
            this.orgComboBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(335, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Код регистратора";
            // 
            // regComboBox
            // 
            this.regComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regComboBox.FormattingEnabled = true;
            this.regComboBox.Location = new System.Drawing.Point(339, 299);
            this.regComboBox.Name = "regComboBox";
            this.regComboBox.Size = new System.Drawing.Size(146, 29);
            this.regComboBox.TabIndex = 23;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(353, 81);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 29);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 384);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.regComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orgComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newRegButton);
            this.Controls.Add(this.regDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docNumTextBox);
            this.Controls.Add(this.recordNum);
            this.Controls.Add(this.nextRecord);
            this.Controls.Add(this.prevRecord);
            this.Controls.Add(this.RegCodeLabel);
            this.Controls.Add(this.DocFormName);
            this.Controls.Add(this.DocCodeTextBox);
            this.Name = "DocForm";
            this.Text = "DocForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DocCodeTextBox;
        private System.Windows.Forms.Label DocFormName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label RegCodeLabel;
        private System.Windows.Forms.Button prevRecord;
        private System.Windows.Forms.Button nextRecord;
        private System.Windows.Forms.TextBox recordNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox docNumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker regDateTimePicker;
        private System.Windows.Forms.Button newRegButton;
        private System.Windows.Forms.Button saveButton;
        private ComboBox typeComboBox;
        private Label label2;
        private Label label3;
        private ComboBox orgComboBox;
        private Label label6;
        private ComboBox regComboBox;
        private Button deleteButton;
    }
}