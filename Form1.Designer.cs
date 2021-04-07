namespace BankManagementSystem
{
    partial class Form1
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
            this.CustPersonalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustPersonalInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustPersonalInfoBindingSource
            // 
            this.CustPersonalInfoBindingSource.DataMember = "CustPersonalInfo";
           // this.CustPersonalInfoBindingSource.DataSource = this.Database1DataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 406);
            this.Name = "Form1";
            this.Text = "Customer Profile Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustPersonalInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource CustPersonalInfoBindingSource;
//private Database1DataSet1 Database1DataSet1;
  //      private Database1DataSet1TableAdapters.CustPersonalInfoTableAdapter CustPersonalInfoTableAdapter;

    }
}