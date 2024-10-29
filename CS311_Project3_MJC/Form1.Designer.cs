namespace CS311_Project3_MJC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictPizza = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            lblSize = new Label();
            cboSize = new ComboBox();
            grpCrustType = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblToppings = new Label();
            ckbPepperoni = new CheckBox();
            ckbSausage = new CheckBox();
            ckbItalian = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbMushroom = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            rtfOrderSummary = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            grpCrustType.SuspendLayout();
            SuspendLayout();
            // 
            // pictPizza
            // 
            pictPizza.Image = Properties.Resources.pizza1;
            pictPizza.Location = new Point(12, -22);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(198, 167);
            pictPizza.TabIndex = 0;
            pictPizza.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Vivaldi", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(360, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(276, 55);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Mama Mia's";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 336);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 3;
            label1.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(686, 346);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(85, 23);
            lblSubTotal.TabIndex = 4;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(729, 385);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(42, 23);
            lblTax.TabIndex = 5;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(717, 426);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(777, 342);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 7;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(777, 381);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(777, 422);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(720, 489);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(182, 73);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(160, 162);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 23);
            lblSize.TabIndex = 11;
            lblSize.Text = "Size:";
            // 
            // cboSize
            // 
            cboSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(213, 159);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(151, 31);
            cboSize.TabIndex = 12;
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            // 
            // grpCrustType
            // 
            grpCrustType.Controls.Add(rdoRegular);
            grpCrustType.Controls.Add(rdoThick);
            grpCrustType.Controls.Add(rdoThin);
            grpCrustType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrustType.Location = new Point(521, 159);
            grpCrustType.Name = "grpCrustType";
            grpCrustType.Size = new Size(381, 39);
            grpCrustType.TabIndex = 13;
            grpCrustType.TabStop = false;
            grpCrustType.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoRegular.Location = new Point(285, 4);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(90, 27);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rdoRegular_CheckedChanged;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoThick.Location = new Point(196, 4);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(71, 27);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoThin.Location = new Point(111, 4);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(64, 27);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppings.Location = new Point(69, 195);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(88, 23);
            lblToppings.TabIndex = 14;
            lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbPepperoni.Location = new Point(160, 221);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(101, 24);
            ckbPepperoni.TabIndex = 15;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            ckbPepperoni.CheckedChanged += ckbPepperoni_CheckedChanged;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbSausage.Location = new Point(160, 246);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(87, 24);
            ckbSausage.TabIndex = 16;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            ckbSausage.CheckedChanged += ckbSausage_CheckedChanged;
            // 
            // ckbItalian
            // 
            ckbItalian.AutoSize = true;
            ckbItalian.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbItalian.Location = new Point(160, 306);
            ckbItalian.Name = "ckbItalian";
            ckbItalian.Size = new Size(173, 24);
            ckbItalian.TabIndex = 17;
            ckbItalian.Text = "Spicy Italian Sausage";
            ckbItalian.UseVisualStyleBackColor = true;
            ckbItalian.CheckedChanged += chkItalian_CheckedChanged;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbCanadianBacon.Location = new Point(160, 276);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(141, 24);
            ckbCanadianBacon.TabIndex = 18;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            ckbCanadianBacon.CheckedChanged += ckbCanadianBacon_CheckedChanged;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbBlackOlives.Location = new Point(360, 276);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(112, 24);
            ckbBlackOlives.TabIndex = 22;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            ckbBlackOlives.CheckedChanged += ckbBlackOlives_CheckedChanged;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbGreenOlives.Location = new Point(360, 306);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(117, 24);
            ckbGreenOlives.TabIndex = 21;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            ckbGreenOlives.CheckedChanged += ckbGreenOlives_CheckedChanged;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbGreenPepper.Location = new Point(360, 246);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(124, 24);
            ckbGreenPepper.TabIndex = 20;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            ckbGreenPepper.CheckedChanged += ckbGreenPepper_CheckedChanged;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbOnion.Location = new Point(360, 221);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(73, 24);
            ckbOnion.TabIndex = 19;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            ckbOnion.CheckedChanged += ckbOnion_CheckedChanged;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbExtraCheese.Location = new Point(570, 276);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(118, 24);
            ckbExtraCheese.TabIndex = 26;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            ckbExtraCheese.CheckedChanged += ckbExtraCheese_CheckedChanged;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbMushroom.Location = new Point(570, 306);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(106, 24);
            ckbMushroom.TabIndex = 25;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            ckbMushroom.CheckedChanged += ckbMushroom_CheckedChanged;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbJalepeno.Location = new Point(570, 246);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(92, 24);
            ckbJalepeno.TabIndex = 24;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            ckbJalepeno.CheckedChanged += ckbJalepeno_CheckedChanged;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbBananaPeppers.Location = new Point(570, 221);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(140, 24);
            ckbBananaPeppers.TabIndex = 23;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            ckbBananaPeppers.CheckedChanged += ckbBananaPeppers_CheckedChanged;
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(160, 346);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.ReadOnly = true;
            rtfOrderSummary.Size = new Size(516, 231);
            rtfOrderSummary.TabIndex = 27;
            rtfOrderSummary.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 601);
            Controls.Add(rtfOrderSummary);
            Controls.Add(ckbExtraCheese);
            Controls.Add(ckbMushroom);
            Controls.Add(ckbJalepeno);
            Controls.Add(ckbBananaPeppers);
            Controls.Add(ckbBlackOlives);
            Controls.Add(ckbGreenOlives);
            Controls.Add(ckbGreenPepper);
            Controls.Add(ckbOnion);
            Controls.Add(ckbCanadianBacon);
            Controls.Add(ckbItalian);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPepperoni);
            Controls.Add(lblToppings);
            Controls.Add(grpCrustType);
            Controls.Add(cboSize);
            Controls.Add(lblSize);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictPizza);
            Name = "Form1";
            Text = "Mama Mia's";
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            grpCrustType.ResumeLayout(false);
            grpCrustType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictPizza;
        private Label lblTitle;
        private Label label1;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Label lblSize;
        private ComboBox cboSize;
        private GroupBox grpCrustType;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private Label lblToppings;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbItalian;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private CheckBox ckbJalepeno;
        private CheckBox ckbBananaPeppers;
        private RichTextBox rtfOrderSummary;
    }
}
