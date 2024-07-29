
namespace ComBot_FastSearchResult
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
            this.textBox_region = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_limit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_region
            // 
            this.textBox_region.Location = new System.Drawing.Point(12, 44);
            this.textBox_region.Name = "textBox_region";
            this.textBox_region.Size = new System.Drawing.Size(165, 20);
            this.textBox_region.TabIndex = 0;
            this.textBox_region.Text = "all";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(12, 83);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(516, 20);
            this.textBox_search.TabIndex = 1;
            // 
            // textBox_limit
            // 
            this.textBox_limit.Location = new System.Drawing.Point(192, 44);
            this.textBox_limit.Name = "textBox_limit";
            this.textBox_limit.Size = new System.Drawing.Size(165, 20);
            this.textBox_limit.TabIndex = 2;
            this.textBox_limit.Text = "26";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Регион поиска: all, ru, en ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поисковый запрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Offset";
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(363, 44);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(165, 20);
            this.textBox_offset.TabIndex = 7;
            this.textBox_offset.Text = "0";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 218);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(516, 144);
            this.textBox_result.TabIndex = 8;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(12, 109);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(79, 24);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат (Скопировать и вставить Excel)";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(449, 188);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(79, 24);
            this.button_remove.TabIndex = 11;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 364);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_offset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_limit);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_region);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_region;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.TextBox textBox_limit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_remove;
    }
}

