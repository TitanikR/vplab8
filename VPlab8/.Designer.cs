using System.Windows.Forms;

namespace VPlab8
{
    partial class RegForm
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
            this.RegCodeTextBox = new System.Windows.Forms.TextBox();
            this.RegFormName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RegCodeLabel = new System.Windows.Forms.Label();
            this.prevRecord = new System.Windows.Forms.Button();
            this.nextRecord = new System.Windows.Forms.Button();
            this.recordNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.otchTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bringDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newRegButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegCodeTextBox
            // 
            this.RegCodeTextBox.Enabled = false;
            this.RegCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RegCodeTextBox.Location = new System.Drawing.Point(45, 93);
            this.RegCodeTextBox.Name = "RegCodeTextBox";
            this.RegCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RegCodeTextBox.Size = new System.Drawing.Size(149, 29);
            this.RegCodeTextBox.TabIndex = 0;
            // 
            // RegFormName
            // 
            this.RegFormName.AutoSize = true;
            this.RegFormName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.RegFormName.Location = new System.Drawing.Point(12, 3);
            this.RegFormName.Name = "RegFormName";
            this.RegFormName.Size = new System.Drawing.Size(168, 37);
            this.RegFormName.TabIndex = 1;
            this.RegFormName.Text = "Регистратор";
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
            this.RegCodeLabel.Size = new System.Drawing.Size(137, 21);
            this.RegCodeLabel.TabIndex = 2;
            this.RegCodeLabel.Text = "Код регистратора";
            // 
            // prevRecord
            // 
            this.prevRecord.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Bold);
            this.prevRecord.Location = new System.Drawing.Point(203, 12);
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
            this.nextRecord.Location = new System.Drawing.Point(298, 12);
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
            this.recordNum.Location = new System.Drawing.Point(254, 12);
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
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // familyTextBox
            // 
            this.familyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.familyTextBox.Location = new System.Drawing.Point(45, 149);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(149, 29);
            this.familyTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(196, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(200, 149);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 29);
            this.nameTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(349, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // otchTextBox
            // 
            this.otchTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.otchTextBox.Location = new System.Drawing.Point(353, 149);
            this.otchTextBox.Name = "otchTextBox";
            this.otchTextBox.Size = new System.Drawing.Size(133, 29);
            this.otchTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Должность";
            // 
            // postTextBox
            // 
            this.postTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.postTextBox.Location = new System.Drawing.Point(45, 214);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(235, 29);
            this.postTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(282, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Дата приема на работу";
            // 
            // bringDateTimePicker
            // 
            this.bringDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bringDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bringDateTimePicker.Location = new System.Drawing.Point(286, 214);
            this.bringDateTimePicker.Name = "bringDateTimePicker";
            this.bringDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.bringDateTimePicker.TabIndex = 16;
            // 
            // newRegButton
            // 
            this.newRegButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRegButton.Location = new System.Drawing.Point(361, 12);
            this.newRegButton.Name = "newRegButton";
            this.newRegButton.Size = new System.Drawing.Size(124, 28);
            this.newRegButton.TabIndex = 17;
            this.newRegButton.Text = "Новый рег-р";
            this.newRegButton.UseVisualStyleBackColor = true;
            this.newRegButton.Click += new System.EventHandler(this.newRegButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(362, 46);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(124, 29);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(362, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newRegButton);
            this.Controls.Add(this.bringDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.otchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.familyTextBox);
            this.Controls.Add(this.recordNum);
            this.Controls.Add(this.nextRecord);
            this.Controls.Add(this.prevRecord);
            this.Controls.Add(this.RegCodeLabel);
            this.Controls.Add(this.RegFormName);
            this.Controls.Add(this.RegCodeTextBox);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegCodeTextBox;
        private System.Windows.Forms.Label RegFormName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label RegCodeLabel;
        private System.Windows.Forms.Button prevRecord;
        private System.Windows.Forms.Button nextRecord;
        private System.Windows.Forms.TextBox recordNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker bringDateTimePicker;
        private System.Windows.Forms.Button newRegButton;
        private System.Windows.Forms.Button saveButton;
        private Button button1;
    }
}