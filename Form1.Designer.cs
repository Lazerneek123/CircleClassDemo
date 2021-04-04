namespace ДодатковеЗавдання
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createObject = new System.Windows.Forms.Button();
            this.hideObject = new System.Windows.Forms.Button();
            this.showObject = new System.Windows.Forms.Button();
            this.listObjekt = new System.Windows.Forms.ComboBox();
            this.listObjectName = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonReduction = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonTurnRight = new System.Windows.Forms.Button();
            this.buttonTurnLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFront = new System.Windows.Forms.Button();
            this.buttonMagnification = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drawCanvass = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawCanvass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createObject
            // 
            this.createObject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.createObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createObject.Location = new System.Drawing.Point(610, 64);
            this.createObject.Name = "createObject";
            this.createObject.Size = new System.Drawing.Size(169, 38);
            this.createObject.TabIndex = 1;
            this.createObject.Text = "Створити новий об\'єкт";
            this.createObject.UseVisualStyleBackColor = true;
            this.createObject.Click += new System.EventHandler(this.createObject_Click);
            // 
            // hideObject
            // 
            this.hideObject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hideObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hideObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.hideObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideObject.Location = new System.Drawing.Point(610, 120);
            this.hideObject.Name = "hideObject";
            this.hideObject.Size = new System.Drawing.Size(169, 38);
            this.hideObject.TabIndex = 2;
            this.hideObject.Text = "Приховати об\'єкт";
            this.hideObject.UseVisualStyleBackColor = true;
            this.hideObject.Click += new System.EventHandler(this.hideObject_Click);
            // 
            // showObject
            // 
            this.showObject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.showObject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.showObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showObject.Location = new System.Drawing.Point(610, 176);
            this.showObject.Name = "showObject";
            this.showObject.Size = new System.Drawing.Size(169, 38);
            this.showObject.TabIndex = 3;
            this.showObject.Text = "Показати об\'єкт";
            this.showObject.UseVisualStyleBackColor = true;
            this.showObject.Click += new System.EventHandler(this.showObject_Click);
            // 
            // listObjekt
            // 
            this.listObjekt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listObjekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listObjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listObjekt.FormattingEnabled = true;
            this.listObjekt.Location = new System.Drawing.Point(610, 28);
            this.listObjekt.Name = "listObjekt";
            this.listObjekt.Size = new System.Drawing.Size(169, 21);
            this.listObjekt.TabIndex = 4;
            // 
            // listObjectName
            // 
            this.listObjectName.AutoSize = true;
            this.listObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listObjectName.Location = new System.Drawing.Point(607, 12);
            this.listObjectName.Name = "listObjectName";
            this.listObjectName.Size = new System.Drawing.Size(105, 13);
            this.listObjectName.TabIndex = 5;
            this.listObjectName.Text = "Перелік об\'єктів";
            // 
            // buttonLeft
            // 
            this.buttonLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Image = global::ДодатковеЗавдання.Properties.Resources.Вливо;
            this.buttonLeft.Location = new System.Drawing.Point(610, 310);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 53);
            this.buttonLeft.TabIndex = 9;
            this.buttonLeft.Text = "\r\n";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDown.Image = global::ДодатковеЗавдання.Properties.Resources.Вниз;
            this.buttonDown.Location = new System.Drawing.Point(669, 391);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(53, 30);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.Text = "\r\n";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.Image = global::ДодатковеЗавдання.Properties.Resources.Вверх;
            this.buttonUp.Location = new System.Drawing.Point(669, 249);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(53, 30);
            this.buttonUp.TabIndex = 11;
            this.buttonUp.Text = "\r\n";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonReduction
            // 
            this.buttonReduction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonReduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonReduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReduction.Image = global::ДодатковеЗавдання.Properties.Resources.Минус;
            this.buttonReduction.Location = new System.Drawing.Point(669, 338);
            this.buttonReduction.Name = "buttonReduction";
            this.buttonReduction.Size = new System.Drawing.Size(53, 30);
            this.buttonReduction.TabIndex = 12;
            this.buttonReduction.Text = "\r\n";
            this.buttonReduction.UseVisualStyleBackColor = true;
            this.buttonReduction.Click += new System.EventHandler(this.buttonReduction_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Image = global::ДодатковеЗавдання.Properties.Resources.Вправо;
            this.buttonRight.Location = new System.Drawing.Point(749, 310);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 53);
            this.buttonRight.TabIndex = 13;
            this.buttonRight.Text = "\r\n";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonTurnRight
            // 
            this.buttonTurnRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTurnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTurnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonTurnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTurnRight.Image = global::ДодатковеЗавдання.Properties.Resources.ПоворотВправо;
            this.buttonTurnRight.Location = new System.Drawing.Point(610, 463);
            this.buttonTurnRight.Name = "buttonTurnRight";
            this.buttonTurnRight.Size = new System.Drawing.Size(50, 50);
            this.buttonTurnRight.TabIndex = 14;
            this.buttonTurnRight.Text = "\r\n";
            this.buttonTurnRight.UseVisualStyleBackColor = true;
            this.buttonTurnRight.Click += new System.EventHandler(this.buttonTurnRight_Click);
            // 
            // buttonTurnLeft
            // 
            this.buttonTurnLeft.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTurnLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonTurnLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonTurnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTurnLeft.Image = global::ДодатковеЗавдання.Properties.Resources.ПоворотВливо;
            this.buttonTurnLeft.Location = new System.Drawing.Point(729, 463);
            this.buttonTurnLeft.Name = "buttonTurnLeft";
            this.buttonTurnLeft.Size = new System.Drawing.Size(50, 50);
            this.buttonTurnLeft.TabIndex = 17;
            this.buttonTurnLeft.Text = "\r\n";
            this.buttonTurnLeft.UseVisualStyleBackColor = true;
            this.buttonTurnLeft.Click += new System.EventHandler(this.buttonTurnLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(746, 638);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "by teo";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // buttonColor
            // 
            this.buttonColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonColor.Image = global::ДодатковеЗавдання.Properties.Resources.Колир;
            this.buttonColor.Location = new System.Drawing.Point(729, 568);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(50, 50);
            this.buttonColor.TabIndex = 21;
            this.buttonColor.Text = "\r\n";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonFront
            // 
            this.buttonFront.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFront.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonFront.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonFront.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFront.Image = global::ДодатковеЗавдання.Properties.Resources.ПереднийПлан;
            this.buttonFront.Location = new System.Drawing.Point(610, 568);
            this.buttonFront.Name = "buttonFront";
            this.buttonFront.Size = new System.Drawing.Size(50, 50);
            this.buttonFront.TabIndex = 22;
            this.buttonFront.Text = "\r\n";
            this.buttonFront.UseVisualStyleBackColor = true;
            this.buttonFront.Click += new System.EventHandler(this.buttonFront_Click);
            // 
            // buttonMagnification
            // 
            this.buttonMagnification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMagnification.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMagnification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMagnification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonMagnification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMagnification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMagnification.Image = global::ДодатковеЗавдання.Properties.Resources.Плюс;
            this.buttonMagnification.Location = new System.Drawing.Point(669, 302);
            this.buttonMagnification.Name = "buttonMagnification";
            this.buttonMagnification.Size = new System.Drawing.Size(53, 30);
            this.buttonMagnification.TabIndex = 8;
            this.buttonMagnification.Text = "\r\n";
            this.buttonMagnification.UseVisualStyleBackColor = true;
            this.buttonMagnification.Click += new System.EventHandler(this.buttonMagnification_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(589, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 13);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // drawCanvass
            // 
            this.drawCanvass.BackColor = System.Drawing.Color.White;
            this.drawCanvass.Location = new System.Drawing.Point(12, 12);
            this.drawCanvass.Name = "drawCanvass";
            this.drawCanvass.Size = new System.Drawing.Size(577, 638);
            this.drawCanvass.TabIndex = 19;
            this.drawCanvass.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Location = new System.Drawing.Point(589, 427);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 13);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(589, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 13);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.buttonFront);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drawCanvass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTurnLeft);
            this.Controls.Add(this.buttonTurnRight);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonReduction);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonMagnification);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listObjectName);
            this.Controls.Add(this.listObjekt);
            this.Controls.Add(this.showObject);
            this.Controls.Add(this.hideObject);
            this.Controls.Add(this.createObject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle Class Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawCanvass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createObject;
        private System.Windows.Forms.Button hideObject;
        private System.Windows.Forms.Button showObject;
        private System.Windows.Forms.ComboBox listObjekt;
        private System.Windows.Forms.Label listObjectName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonMagnification;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonReduction;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonTurnRight;
        private System.Windows.Forms.Button buttonTurnLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox drawCanvass;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonFront;
    }
}

