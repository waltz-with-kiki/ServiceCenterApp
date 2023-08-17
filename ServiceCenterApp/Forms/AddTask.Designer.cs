
namespace ServiceCenterApp.Forms
{
    partial class AddTask
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
            System.Windows.Forms.DateTimePicker dateTimePicker;
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.IsPickupBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new System.Drawing.Point(14, 205);
            dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(233, 23);
            dateTimePicker.TabIndex = 8;
            dateTimePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(14, 40);
            this.nameField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(282, 24);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(14, 87);
            this.numberField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberField.Multiline = true;
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(282, 24);
            this.numberField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пункт назначения";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(14, 133);
            this.addressField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addressField.Multiline = true;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(282, 24);
            this.addressField.TabIndex = 5;
            // 
            // IsPickupBox
            // 
            this.IsPickupBox.AutoSize = true;
            this.IsPickupBox.Location = new System.Drawing.Point(18, 164);
            this.IsPickupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IsPickupBox.Name = "IsPickupBox";
            this.IsPickupBox.Size = new System.Drawing.Size(89, 19);
            this.IsPickupBox.TabIndex = 6;
            this.IsPickupBox.Text = "Самовывоз";
            this.IsPickupBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Доставить к:";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(160, 235);
            this.confirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(88, 27);
            this.confirm.TabIndex = 9;
            this.confirm.Text = "Добавить";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 368);
            this.Controls.Add(this.confirm);
            this.Controls.Add(dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsPickupBox);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.ShowInTaskbar = false;
            this.Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.CheckBox IsPickupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}