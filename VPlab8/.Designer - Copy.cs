using System.Windows.Forms;

namespace VPlab8
{
    partial class OrgForm
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
            this.OrgCodeTextBox = new System.Windows.Forms.TextBox();
            this.OrgFormName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OrgCodeLabel = new System.Windows.Forms.Label();
            this.prevRecord = new System.Windows.Forms.Button();
            this.nextRecord = new System.Windows.Forms.Button();
            this.recordNum = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.newRegButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrgCodeTextBox
            // 
            this.OrgCodeTextBox.Enabled = false;
            this.OrgCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrgCodeTextBox.Location = new System.Drawing.Point(45, 93);
            this.OrgCodeTextBox.Name = "OrgCodeTextBox";
            this.OrgCodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OrgCodeTextBox.Size = new System.Drawing.Size(149, 29);
            this.OrgCodeTextBox.TabIndex = 0;
            // 
            // OrgFormName
            // 
            this.OrgFormName.AutoSize = true;
            this.OrgFormName.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.OrgFormName.Location = new System.Drawing.Point(12, 3);
            this.OrgFormName.Name = "OrgFormName";
            this.OrgFormName.Size = new System.Drawing.Size(181, 37);
            this.OrgFormName.TabIndex = 1;
            this.OrgFormName.Text = "Организация";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrgCodeLabel
            // 
            this.OrgCodeLabel.AutoSize = true;
            this.OrgCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OrgCodeLabel.Location = new System.Drawing.Point(41, 69);
            this.OrgCodeLabel.Name = "OrgCodeLabel";
            this.OrgCodeLabel.Size = new System.Drawing.Size(134, 21);
            this.OrgCodeLabel.TabIndex = 2;
            this.OrgCodeLabel.Text = "Код организации";
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
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сокращенное название";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(45, 149);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(440, 29);
            this.nameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(41, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Полное название организации";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fullNameTextBox.Location = new System.Drawing.Point(45, 205);
            this.fullNameTextBox.Multiline = true;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(440, 54);
            this.fullNameTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(41, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Юридический адрес";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressTextBox.Location = new System.Drawing.Point(45, 286);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(440, 29);
            this.addressTextBox.TabIndex = 12;
            // 
            // newRegButton
            // 
            this.newRegButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRegButton.Location = new System.Drawing.Point(361, 12);
            this.newRegButton.Name = "newRegButton";
            this.newRegButton.Size = new System.Drawing.Size(124, 28);
            this.newRegButton.TabIndex = 17;
            this.newRegButton.Text = "Новая орг-ция";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(41, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Телефон";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(45, 342);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(440, 29);
            this.phoneTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(41, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "ФИО руководителя";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fioTextBox.Location = new System.Drawing.Point(45, 398);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(440, 29);
            this.fioTextBox.TabIndex = 21;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(361, 81);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 30);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // OrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 447);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newRegButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.recordNum);
            this.Controls.Add(this.nextRecord);
            this.Controls.Add(this.prevRecord);
            this.Controls.Add(this.OrgCodeLabel);
            this.Controls.Add(this.OrgFormName);
            this.Controls.Add(this.OrgCodeTextBox);
            this.Name = "OrgForm";
            this.Text = "OrgForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrgCodeTextBox;
        private System.Windows.Forms.Label OrgFormName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label OrgCodeLabel;
        private System.Windows.Forms.Button prevRecord;
        private System.Windows.Forms.Button nextRecord;
        private System.Windows.Forms.TextBox recordNum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button newRegButton;
        private System.Windows.Forms.Button saveButton;
        private Label label2;
        private TextBox phoneTextBox;
        private Label label5;
        private TextBox fioTextBox;
        private Button deleteButton;
    }
}