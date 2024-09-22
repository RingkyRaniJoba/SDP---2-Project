namespace Hospital_Management_System
{
    partial class UserPanel
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx22 = new System.Windows.Forms.TextBox();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pid";
            // 
            // txtBx22
            // 
            this.txtBx22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBx22.Location = new System.Drawing.Point(237, 113);
            this.txtBx22.Name = "txtBx22";
            this.txtBx22.Size = new System.Drawing.Size(673, 26);
            this.txtBx22.TabIndex = 3;
            this.txtBx22.TextChanged += new System.EventHandler(this.txtBx22_TextChanged);
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(32, 189);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersWidth = 62;
            this.dataGridView11.RowTemplate.Height = 28;
            this.dataGridView11.Size = new System.Drawing.Size(1105, 150);
            this.dataGridView11.TabIndex = 4;
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "All Information of Patient";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(981, 490);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 45);
            this.button11.TabIndex = 6;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView11);
            this.Controls.Add(this.txtBx22);
            this.Controls.Add(this.label1);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx22;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button11;
    }
}