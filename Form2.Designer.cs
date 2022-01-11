namespace Kurs_BD
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.vibor_Material = new System.Windows.Forms.ComboBox();
            this.vibor_nagr = new System.Windows.Forms.ComboBox();
            this.vibor_Material_det = new System.Windows.Forms.ComboBox();
            this.vibor_vid = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.vibor_e = new System.Windows.Forms.ComboBox();
            this.pole_u = new System.Windows.Forms.TextBox();
            this.pole_d_w = new System.Windows.Forms.TextBox();
            this.pole_HB = new System.Windows.Forms.TextBox();
            this.pole_n = new System.Windows.Forms.TextBox();
            this.pole_t_c = new System.Windows.Forms.TextBox();
            this.pole_T_1i = new System.Windows.Forms.TextBox();
            this.pole_n_i = new System.Windows.Forms.TextBox();
            this.pole_t_ci = new System.Windows.Forms.TextBox();
            this.vibor_rasp = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.vibor_val = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pole_T1 = new System.Windows.Forms.TextBox();
            this.vibor_term = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.vibor_z_w = new System.Windows.Forms.ComboBox();
            this.download = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.delete_str = new System.Windows.Forms.Button();
            this.vibor_b_w = new System.Windows.Forms.ComboBox();
            this.vibor_zacep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(295, 717);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(21, 30);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(959, 314);
            this.table.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1195, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Крутящий момент на шестерне, T1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1179, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ширина венца колеса, b_w";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1085, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Материал шестерни и колеса, Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1248, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Число зубьев, z_w";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1290, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Передаточное число, u";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(888, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Частота вращения, n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(904, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(535, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Полное число работы передачи за расчетный срок службы, t_ч";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1271, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Твердость материала, HB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(888, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Диаметр колеса, d_w";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1183, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Коэффициент смещения, e";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(916, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Материал и марка детали, Material_det";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1267, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "Вид нагрузки, nagr";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(948, 620);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(496, 21);
            this.label14.TabIndex = 25;
            this.label14.Text = "Полное число часов работы передачи на i-ой ступени, t_чi";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1126, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(342, 21);
            this.label15.TabIndex = 24;
            this.label15.Text = "Перемена напряжения i-ой ступени, n_i";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(878, 692);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(561, 21);
            this.label25.TabIndex = 23;
            this.label25.Text = "Крутящий момент на i-ой ступени циклограммы напряжения, T_1i";
            // 
            // vibor_Material
            // 
            this.vibor_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_Material.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_Material.FormattingEnabled = true;
            this.vibor_Material.Items.AddRange(new object[] {
            "Сталь-сталь",
            "Сталь-чугун",
            "Сталь-бронза",
            "Чугун-чугун",
            "Текстолит-сталь",
            "ДСП-сталь",
            "Полиамид-сталь"});
            this.vibor_Material.Location = new System.Drawing.Point(1478, 130);
            this.vibor_Material.Name = "vibor_Material";
            this.vibor_Material.Size = new System.Drawing.Size(186, 34);
            this.vibor_Material.TabIndex = 28;
            // 
            // vibor_nagr
            // 
            this.vibor_nagr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_nagr.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_nagr.FormattingEnabled = true;
            this.vibor_nagr.Items.AddRange(new object[] {
            "Нереверсивная",
            "Реверсивная"});
            this.vibor_nagr.Location = new System.Drawing.Point(1478, 333);
            this.vibor_nagr.Name = "vibor_nagr";
            this.vibor_nagr.Size = new System.Drawing.Size(186, 34);
            this.vibor_nagr.TabIndex = 29;
            // 
            // vibor_Material_det
            // 
            this.vibor_Material_det.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_Material_det.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_Material_det.FormattingEnabled = true;
            this.vibor_Material_det.Items.AddRange(new object[] {
            "Сталь 45",
            "Сталь 40Х",
            "Сталь 40ХН",
            "Чугун СЧ32-52 ",
            "Чугун ВЧ30-2",
            "Стальное литье 40ХЛ-40ГЛ"});
            this.vibor_Material_det.Location = new System.Drawing.Point(1335, 377);
            this.vibor_Material_det.Name = "vibor_Material_det";
            this.vibor_Material_det.Size = new System.Drawing.Size(329, 34);
            this.vibor_Material_det.TabIndex = 30;
            // 
            // vibor_vid
            // 
            this.vibor_vid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_vid.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.vibor_vid.FormattingEnabled = true;
            this.vibor_vid.Items.AddRange(new object[] {
            "Прямозубые",
            "Косозубые",
            "Шевронные"});
            this.vibor_vid.Location = new System.Drawing.Point(1478, 49);
            this.vibor_vid.Name = "vibor_vid";
            this.vibor_vid.Size = new System.Drawing.Size(186, 34);
            this.vibor_vid.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1290, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 21);
            this.label16.TabIndex = 31;
            this.label16.Text = "Вид колес, vid";
            // 
            // vibor_e
            // 
            this.vibor_e.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_e.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_e.FormattingEnabled = true;
            this.vibor_e.Items.AddRange(new object[] {
            "0,7",
            "0,5",
            "0,3",
            "0,1",
            "0",
            "-0,1",
            "-0,3",
            "-0,5"});
            this.vibor_e.Location = new System.Drawing.Point(1478, 90);
            this.vibor_e.Name = "vibor_e";
            this.vibor_e.Size = new System.Drawing.Size(186, 34);
            this.vibor_e.TabIndex = 33;
            // 
            // pole_u
            // 
            this.pole_u.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_u.Location = new System.Drawing.Point(1535, 521);
            this.pole_u.Name = "pole_u";
            this.pole_u.Size = new System.Drawing.Size(134, 25);
            this.pole_u.TabIndex = 35;
            // 
            // pole_d_w
            // 
            this.pole_d_w.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_d_w.Location = new System.Drawing.Point(1118, 552);
            this.pole_d_w.Name = "pole_d_w";
            this.pole_d_w.Size = new System.Drawing.Size(134, 25);
            this.pole_d_w.TabIndex = 38;
            // 
            // pole_HB
            // 
            this.pole_HB.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_HB.Location = new System.Drawing.Point(1535, 552);
            this.pole_HB.Name = "pole_HB";
            this.pole_HB.Size = new System.Drawing.Size(134, 25);
            this.pole_HB.TabIndex = 39;
            // 
            // pole_n
            // 
            this.pole_n.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_n.Location = new System.Drawing.Point(1118, 521);
            this.pole_n.Name = "pole_n";
            this.pole_n.Size = new System.Drawing.Size(134, 25);
            this.pole_n.TabIndex = 40;
            // 
            // pole_t_c
            // 
            this.pole_t_c.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_t_c.Location = new System.Drawing.Point(1535, 649);
            this.pole_t_c.Name = "pole_t_c";
            this.pole_t_c.Size = new System.Drawing.Size(134, 25);
            this.pole_t_c.TabIndex = 41;
            // 
            // pole_T_1i
            // 
            this.pole_T_1i.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_T_1i.Location = new System.Drawing.Point(1535, 692);
            this.pole_T_1i.Name = "pole_T_1i";
            this.pole_T_1i.Size = new System.Drawing.Size(134, 25);
            this.pole_T_1i.TabIndex = 42;
            // 
            // pole_n_i
            // 
            this.pole_n_i.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_n_i.Location = new System.Drawing.Point(1536, 583);
            this.pole_n_i.Name = "pole_n_i";
            this.pole_n_i.Size = new System.Drawing.Size(134, 25);
            this.pole_n_i.TabIndex = 43;
            // 
            // pole_t_ci
            // 
            this.pole_t_ci.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_t_ci.Location = new System.Drawing.Point(1535, 618);
            this.pole_t_ci.Name = "pole_t_ci";
            this.pole_t_ci.Size = new System.Drawing.Size(134, 25);
            this.pole_t_ci.TabIndex = 44;
            this.pole_t_ci.TextChanged += new System.EventHandler(this.pole_t_ci_TextChanged);
            // 
            // vibor_rasp
            // 
            this.vibor_rasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_rasp.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_rasp.FormattingEnabled = true;
            this.vibor_rasp.Items.AddRange(new object[] {
            "Симметричное",
            "Несимметричное",
            "Консольное"});
            this.vibor_rasp.Location = new System.Drawing.Point(1478, 9);
            this.vibor_rasp.Name = "vibor_rasp";
            this.vibor_rasp.Size = new System.Drawing.Size(186, 34);
            this.vibor_rasp.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1085, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(336, 21);
            this.label17.TabIndex = 45;
            this.label17.Text = "Расположение относительно опор, rasp";
            // 
            // vibor_val
            // 
            this.vibor_val.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_val.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_val.FormattingEnabled = true;
            this.vibor_val.Items.AddRange(new object[] {
            "Весьма жесткий",
            "Менее жесткий",
            "-"});
            this.vibor_val.Location = new System.Drawing.Point(1478, 293);
            this.vibor_val.Name = "vibor_val";
            this.vibor_val.Size = new System.Drawing.Size(186, 34);
            this.vibor_val.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1379, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 21);
            this.label18.TabIndex = 47;
            this.label18.Text = "Вал, val";
            // 
            // pole_T1
            // 
            this.pole_T1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.pole_T1.Location = new System.Drawing.Point(1535, 481);
            this.pole_T1.Name = "pole_T1";
            this.pole_T1.Size = new System.Drawing.Size(134, 25);
            this.pole_T1.TabIndex = 49;
            // 
            // vibor_term
            // 
            this.vibor_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_term.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_term.FormattingEnabled = true;
            this.vibor_term.Items.AddRange(new object[] {
            "Нет",
            "Улучшение",
            "Закалка ТВЧ поверхностная с охватом дна впадины",
            "Нормализация",
            "Закалка ТВЧ сквозная с охватом дна впадины",
            "Закалка с высоким отпуском"});
            this.vibor_term.Location = new System.Drawing.Point(1082, 432);
            this.vibor_term.Name = "vibor_term";
            this.vibor_term.Size = new System.Drawing.Size(582, 34);
            this.vibor_term.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(875, 437);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(197, 21);
            this.label19.TabIndex = 50;
            this.label19.Text = "Термообработка, term";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(295, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 89);
            this.button2.TabIndex = 52;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vibor_z_w
            // 
            this.vibor_z_w.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_z_w.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_z_w.FormattingEnabled = true;
            this.vibor_z_w.Items.AddRange(new object[] {
            "14",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "24",
            "25",
            "28",
            "30",
            "32",
            "37",
            "40",
            "45",
            "50",
            "60",
            "80",
            "100",
            "150"});
            this.vibor_z_w.Location = new System.Drawing.Point(1478, 213);
            this.vibor_z_w.Name = "vibor_z_w";
            this.vibor_z_w.Size = new System.Drawing.Size(186, 34);
            this.vibor_z_w.TabIndex = 53;
            this.vibor_z_w.SelectedIndexChanged += new System.EventHandler(this.vibor_z_w_SelectedIndexChanged);
            // 
            // download
            // 
            this.download.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.download.Location = new System.Drawing.Point(520, 371);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(322, 94);
            this.download.TabIndex = 56;
            this.download.Text = "Загрузить";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(73, 371);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(322, 94);
            this.save.TabIndex = 57;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(73, 481);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(322, 94);
            this.delete.TabIndex = 58;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // delete_str
            // 
            this.delete_str.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold);
            this.delete_str.Location = new System.Drawing.Point(520, 481);
            this.delete_str.Name = "delete_str";
            this.delete_str.Size = new System.Drawing.Size(322, 94);
            this.delete_str.TabIndex = 59;
            this.delete_str.Text = "Удалить строку";
            this.delete_str.UseVisualStyleBackColor = true;
            this.delete_str.Click += new System.EventHandler(this.delete_str_Click);
            // 
            // vibor_b_w
            // 
            this.vibor_b_w.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_b_w.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_b_w.FormattingEnabled = true;
            this.vibor_b_w.Items.AddRange(new object[] {
            "0,2",
            "0,4",
            "0,6",
            "0,8",
            "1,0",
            "1,2",
            "1,4",
            "1,6"});
            this.vibor_b_w.Location = new System.Drawing.Point(1478, 173);
            this.vibor_b_w.Name = "vibor_b_w";
            this.vibor_b_w.Size = new System.Drawing.Size(84, 34);
            this.vibor_b_w.TabIndex = 60;
            // 
            // vibor_zacep
            // 
            this.vibor_zacep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vibor_zacep.Font = new System.Drawing.Font("KacstBook", 10.2F, System.Drawing.FontStyle.Bold);
            this.vibor_zacep.FormattingEnabled = true;
            this.vibor_zacep.Items.AddRange(new object[] {
            "Внешнее",
            "Внутреннее"});
            this.vibor_zacep.Location = new System.Drawing.Point(1478, 253);
            this.vibor_zacep.Name = "vibor_zacep";
            this.vibor_zacep.Size = new System.Drawing.Size(186, 34);
            this.vibor_zacep.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1229, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 61;
            this.label4.Text = "Вид зацепления, zacep";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 883);
            this.Controls.Add(this.vibor_zacep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vibor_b_w);
            this.Controls.Add(this.delete_str);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.download);
            this.Controls.Add(this.vibor_z_w);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vibor_term);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pole_T1);
            this.Controls.Add(this.vibor_val);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.vibor_rasp);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pole_t_ci);
            this.Controls.Add(this.pole_n_i);
            this.Controls.Add(this.pole_T_1i);
            this.Controls.Add(this.pole_t_c);
            this.Controls.Add(this.pole_n);
            this.Controls.Add(this.pole_HB);
            this.Controls.Add(this.pole_d_w);
            this.Controls.Add(this.pole_u);
            this.Controls.Add(this.vibor_e);
            this.Controls.Add(this.vibor_vid);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vibor_Material_det);
            this.Controls.Add(this.vibor_nagr);
            this.Controls.Add(this.vibor_Material);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1700, 930);
            this.MinimumSize = new System.Drawing.Size(1700, 930);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox vibor_Material;
        private System.Windows.Forms.ComboBox vibor_nagr;
        private System.Windows.Forms.ComboBox vibor_Material_det;
        private System.Windows.Forms.ComboBox vibor_vid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox vibor_e;
        private System.Windows.Forms.TextBox pole_u;
        private System.Windows.Forms.TextBox pole_d_w;
        private System.Windows.Forms.TextBox pole_HB;
        private System.Windows.Forms.TextBox pole_n;
        private System.Windows.Forms.TextBox pole_t_c;
        private System.Windows.Forms.TextBox pole_T_1i;
        private System.Windows.Forms.TextBox pole_n_i;
        private System.Windows.Forms.TextBox pole_t_ci;
        private System.Windows.Forms.ComboBox vibor_rasp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox vibor_val;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox pole_T1;
        private System.Windows.Forms.ComboBox vibor_term;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox vibor_z_w;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button delete_str;
        private System.Windows.Forms.ComboBox vibor_b_w;
        private System.Windows.Forms.ComboBox vibor_zacep;
        private System.Windows.Forms.Label label4;
    }
}