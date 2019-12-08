namespace _5._12._09_ICopmarer_person
{
    partial class MainForm
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
            this.cmbPersons = new System.Windows.Forms.ComboBox();
            this.lblAddANewPerson = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.btnCreateANewPerson = new System.Windows.Forms.Button();
            this.lblPersonProperties = new System.Windows.Forms.Label();
            this.btnPrintAlThePersons = new System.Windows.Forms.Button();
            this.btnPrintAllSortedBy = new System.Windows.Forms.Button();
            this.cmbPrintAllSortedBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersons
            // 
            this.cmbPersons.FormattingEnabled = true;
            this.cmbPersons.Location = new System.Drawing.Point(249, 16);
            this.cmbPersons.Name = "cmbPersons";
            this.cmbPersons.Size = new System.Drawing.Size(230, 21);
            this.cmbPersons.TabIndex = 0;
            this.cmbPersons.SelectedIndexChanged += new System.EventHandler(this.cmbPersons_SelectedIndexChanged);
            // 
            // lblAddANewPerson
            // 
            this.lblAddANewPerson.AutoSize = true;
            this.lblAddANewPerson.Location = new System.Drawing.Point(13, 19);
            this.lblAddANewPerson.Name = "lblAddANewPerson";
            this.lblAddANewPerson.Size = new System.Drawing.Size(93, 13);
            this.lblAddANewPerson.TabIndex = 1;
            this.lblAddANewPerson.Text = "Add a new person";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(16, 63);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(16, 94);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "John";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(60, 55);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(46, 20);
            this.numAge.TabIndex = 6;
            this.numAge.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(60, 86);
            this.numHeight.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(46, 20);
            this.numHeight.TabIndex = 7;
            this.numHeight.Value = new decimal(new int[] {
            175,
            0,
            0,
            0});
            // 
            // btnCreateANewPerson
            // 
            this.btnCreateANewPerson.Location = new System.Drawing.Point(16, 171);
            this.btnCreateANewPerson.Name = "btnCreateANewPerson";
            this.btnCreateANewPerson.Size = new System.Drawing.Size(116, 23);
            this.btnCreateANewPerson.TabIndex = 8;
            this.btnCreateANewPerson.Text = "Create a new person";
            this.btnCreateANewPerson.UseVisualStyleBackColor = true;
            this.btnCreateANewPerson.Click += new System.EventHandler(this.btnCreateANewPerson_Click);
            // 
            // lblPersonProperties
            // 
            this.lblPersonProperties.AutoSize = true;
            this.lblPersonProperties.Location = new System.Drawing.Point(246, 55);
            this.lblPersonProperties.Name = "lblPersonProperties";
            this.lblPersonProperties.Size = new System.Drawing.Size(235, 13);
            this.lblPersonProperties.TabIndex = 9;
            this.lblPersonProperties.Text = "properties of the selectet person will appear here";
            // 
            // btnPrintAlThePersons
            // 
            this.btnPrintAlThePersons.Location = new System.Drawing.Point(16, 200);
            this.btnPrintAlThePersons.Name = "btnPrintAlThePersons";
            this.btnPrintAlThePersons.Size = new System.Drawing.Size(157, 23);
            this.btnPrintAlThePersons.TabIndex = 10;
            this.btnPrintAlThePersons.Text = "Print All the existing persons";
            this.btnPrintAlThePersons.UseVisualStyleBackColor = true;
            this.btnPrintAlThePersons.Click += new System.EventHandler(this.btnPrintAlThePersons_Click);
            // 
            // btnPrintAllSortedBy
            // 
            this.btnPrintAllSortedBy.AutoSize = true;
            this.btnPrintAllSortedBy.Location = new System.Drawing.Point(16, 229);
            this.btnPrintAllSortedBy.Name = "btnPrintAllSortedBy";
            this.btnPrintAllSortedBy.Size = new System.Drawing.Size(100, 23);
            this.btnPrintAllSortedBy.TabIndex = 11;
            this.btnPrintAllSortedBy.Text = "Print all sorted by:";
            this.btnPrintAllSortedBy.UseVisualStyleBackColor = true;
            this.btnPrintAllSortedBy.Click += new System.EventHandler(this.btnPrintAllSortedBy_Click);
            // 
            // cmbPrintAllSortedBy
            // 
            this.cmbPrintAllSortedBy.FormattingEnabled = true;
            this.cmbPrintAllSortedBy.Location = new System.Drawing.Point(122, 230);
            this.cmbPrintAllSortedBy.Name = "cmbPrintAllSortedBy";
            this.cmbPrintAllSortedBy.Size = new System.Drawing.Size(51, 21);
            this.cmbPrintAllSortedBy.TabIndex = 12;
            this.cmbPrintAllSortedBy.SelectedIndexChanged += new System.EventHandler(this.cmbPrintAllSortedBy_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 274);
            this.Controls.Add(this.cmbPrintAllSortedBy);
            this.Controls.Add(this.btnPrintAllSortedBy);
            this.Controls.Add(this.btnPrintAlThePersons);
            this.Controls.Add(this.lblPersonProperties);
            this.Controls.Add(this.btnCreateANewPerson);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAddANewPerson);
            this.Controls.Add(this.cmbPersons);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersons;
        private System.Windows.Forms.Label lblAddANewPerson;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button btnCreateANewPerson;
        private System.Windows.Forms.Label lblPersonProperties;
        private System.Windows.Forms.Button btnPrintAlThePersons;
        private System.Windows.Forms.Button btnPrintAllSortedBy;
        private System.Windows.Forms.ComboBox cmbPrintAllSortedBy;
    }
}