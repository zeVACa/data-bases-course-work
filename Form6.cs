using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Math;

namespace Kurs_BD
{
    public partial class Form6 : Form
    {
        Form1 form1;
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();

        public Form6(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            table1.Columns.Add("b_w",typeof(double));
            table1.Columns.Add("rasp", typeof(string));
            table1.Columns.Add("val", typeof(string));
            table1.Columns.Add("HB>351", typeof(bool));
            table1.Columns.Add("K_hb", typeof(double));

            table1.Rows.Add(0.2, "Симметричное", "-", true, 1);      //	0 
            table1.Rows.Add(0.4, "Симметричное", "-", true, 1.01);      //	1
            table1.Rows.Add(0.6, "Симметричное", "-", true, 1.03);      //	3
            table1.Rows.Add(0.8, "Симметричное", "-", true, 1.06);      //	4
            table1.Rows.Add(1.0, "Симметричное", "-", true, 1.1);       //	5
            table1.Rows.Add(1.2, "Симметричное", "-", true, 1.13);      //	6
            table1.Rows.Add(1.4, "Симметричное", "-", true, 1.15);      //	7
            table1.Rows.Add(1.6, "Симметричное", "-", true, 1.2);       //	8
            table1.Rows.Add(0.2, "Симметричное", "-", false, 1);     //	9
            table1.Rows.Add(0.4, "Симметричное", "-", false, 1);     //	10
            table1.Rows.Add(0.6, "Симметричное", "-", false, 1.01);        //	11
            table1.Rows.Add(0.8, "Симметричное", "-", false, 1.03);        //	12
            table1.Rows.Add(1.0, "Симметричное", "-", false, 1.04);        //	13
            table1.Rows.Add(1.2, "Симметричное", "-", false, 1.05);        //	14
            table1.Rows.Add(1.4, "Симметричное", "-", false, 1.07);        //	15
            table1.Rows.Add(1.6, "Симметричное", "-", false, 1.08);        //	16
            table1.Rows.Add(0.2, "Консольное", "-", true, 1.15);     //	17
            table1.Rows.Add(0.4, "Консольное", "-", true, 1.35);     //	18
            table1.Rows.Add(0.6, "Консольное", "-", true, 1.6);      //	19
            table1.Rows.Add(0.8, "Консольное", "-", true, 1.85);     //	20
            table1.Rows.Add(1.0, "Консольное", "-", true, 0);      //	21
            table1.Rows.Add(1.2, "Консольное", "-", true, 0);      //	22
            table1.Rows.Add(1.4, "Консольное", "-", true, 0);      //	23
            table1.Rows.Add(1.6, "Консольное", "-", true, 0);      //	24
            table1.Rows.Add(0.2, "Консольное", "-", false, 1.07);        //	25
            table1.Rows.Add(0.4, "Консольное", "-", false, 1.15);        //	26
            table1.Rows.Add(0.6, "Консольное", "-", false, 1.24);        //	27
            table1.Rows.Add(0.8, "Консольное", "-", false, 1.35);        //	28
            table1.Rows.Add(1.0, "Консольное", "-", false, 0);     //	29
            table1.Rows.Add(1.2, "Консольное", "-", false, 0);     //	30
            table1.Rows.Add(1.4, "Консольное", "-", false, 0);     //	31
            table1.Rows.Add(1.6, "Консольное", "-", false, 0);     //	32
            table1.Rows.Add(0.2, "Несимметричное", "Весьма жесткий", true, 1.01);     //	33
            table1.Rows.Add(0.4, "Несимметричное", "Весьма жесткий", true, 1.05);     //	34
            table1.Rows.Add(0.6, "Несимметричное", "Весьма жесткий", true, 1.09);     //	35
            table1.Rows.Add(0.8, "Несимметричное", "Весьма жесткий", true, 1.14);     //	36
            table1.Rows.Add(1.0, "Несимметричное", "Весьма жесткий", true, 1.18);     //	37
            table1.Rows.Add(1.2, "Несимметричное", "Весьма жесткий", true, 1.25);     //	38
            table1.Rows.Add(1.4, "Несимметричное", "Весьма жесткий", true, 1.32);     //	39
            table1.Rows.Add(1.6, "Несимметричное", "Весьма жесткий", true, 1.4);      //	40
            table1.Rows.Add(0.2, "Несимметричное", "Весьма жесткий", false, 1);      //	41
            table1.Rows.Add(0.4, "Несимметричное", "Весьма жесткий", false, 1.02);        //	42
            table1.Rows.Add(0.6, "Несимметричное", "Весьма жесткий", false, 1.04);        //	43
            table1.Rows.Add(0.8, "Несимметричное", "Весьма жесткий", false, 1.06);        //	44
            table1.Rows.Add(1.0, "Несимметричное", "Весьма жесткий", false, 1.08);        //	45
            table1.Rows.Add(1.2, "Несимметричное", "Весьма жесткий", false, 1.1);     //	46
            table1.Rows.Add(1.4, "Несимметричное", "Весьма жесткий", false, 1.13);        //	47
            table1.Rows.Add(1.6, "Несимметричное", "Весьма жесткий", false, 1.16);        //	48
            table1.Rows.Add(0.2, "Несимметричное", "Менее жесткий", true, 1.06);     //	49
            table1.Rows.Add(0.4, "Несимметричное", "Менее жесткий", true, 1.12);     //	50
            table1.Rows.Add(0.6, "Несимметричное", "Менее жесткий", true, 1.2);      //	51
            table1.Rows.Add(0.8, "Несимметричное", "Менее жесткий", true, 1.27);     //	52
            table1.Rows.Add(1.0, "Несимметричное", "Менее жесткий", true, 1.37);     //	53
            table1.Rows.Add(1.2, "Несимметричное", "Менее жесткий", true, 1.5);      //	54
            table1.Rows.Add(1.4, "Несимметричное", "Менее жесткий", true, 1.6);      //	55
            table1.Rows.Add(1.6, "Несимметричное", "Менее жесткий", true, 0);      //	56
            table1.Rows.Add(0.2, "Несимметричное", "Менее жесткий", false, 1.02);        //	57
            table1.Rows.Add(0.4, "Несимметричное", "Менее жесткий", false, 1.05);        //	58
            table1.Rows.Add(0.6, "Несимметричное", "Менее жесткий", false, 1.08);        //	59
            table1.Rows.Add(0.8, "Несимметричное", "Менее жесткий", false, 1.12);        //	60
            table1.Rows.Add(1.0, "Несимметричное", "Менее жесткий", false, 1.15);        //	61
            table1.Rows.Add(1.2, "Несимметричное", "Менее жесткий", false, 1.18);        //	62
            table1.Rows.Add(1.4, "Несимметричное", "Менее жесткий", false, 1.23);        //	63
            table1.Rows.Add(1.6, "Несимметричное", "Менее жесткий", false, 1.28);       //	64

            dataGridView1.DataSource = table1;

            table2.Columns.Add("Material_det", typeof(string));
            table2.Columns.Add("term", typeof(string));
            table2.Columns.Add("HB min", typeof(double));
            table2.Columns.Add("HB max", typeof(double));
            table2.Columns.Add("nagr", typeof(string));
            table2.Columns.Add("sg1_fp", typeof(double));
            table2.Columns.Add("N_f0", typeof(double));
            table2.Columns.Add("sg1_hp", typeof(double));
            table2.Columns.Add("N_h0", typeof(double));

            table2.Rows.Add("Сталь 45", "Улучшение", 240, 280, "Нереверсивная", 195, 4 * Pow(10, 6), 600, 1.5 * Pow(10, 7));    //	0
            table2.Rows.Add("Сталь 45", "Улучшение", 240, 280, "Реверсивная", 130, 4 * Pow(10, 6), 600, 1.5 * Pow(10, 7));    //	1
            table2.Rows.Add("Сталь 45", "Закалка ТВЧ поверхностная с охватом дна впадины", 240, 280, "Нереверсивная", 230, 4 * Pow(10, 6), 800, 6 * Pow(10, 7));  //	2
            table2.Rows.Add("Сталь 45", "Закалка ТВЧ поверхностная с охватом дна впадины", 240, 280, "Реверсивная", 180, 4 * Pow(10, 6), 800, 6 * Pow(10, 7));  //	3
            table2.Rows.Add("Сталь 40X", "Нормализация	", 210, 230, "Нереверсивная", 200, 4 * Pow(10, 6), 550, Pow(10, 7));  //	4
            table2.Rows.Add("Сталь 40X", "Нормализация	", 210, 230, "Реверсивная", 230, 4 * Pow(10, 6), 550, Pow(10, 7));  //	5
            table2.Rows.Add("Сталь 40X", "Закалка ТВЧ сквозная с охватом дна впадины", 240, 280, "Нереверсивная", 230, 4 * Pow(10, 6), 650, 2.5 * Pow(10, 7));    //	6
            table2.Rows.Add("Сталь 40X", "Закалка ТВЧ сквозная с охватом дна впадины", 240, 280, "Реверсивная", 150, 4 * Pow(10, 6), 650, 2.5 * Pow(10, 7));    //	7
            table2.Rows.Add("Сталь 40X", "Закалка ТВЧ поверхностная с охватом дна впадины", 250, 280, "Нереверсивная", 270, 4 * Pow(10, 6), 900, 8 * Pow(10, 7));  //	8
            table2.Rows.Add("Сталь 40X", "Закалка ТВЧ поверхностная с охватом дна впадины", 250, 280, "Реверсивная", 200, 4 * Pow(10, 6), 900, 8 * Pow(10, 7));  //	9
            table2.Rows.Add("Сталь 40XH", "Закалка ТВЧ поверхностная с охватом дна впадины", 260, 300, "Нереверсивная", 320, 4 * Pow(10, 6), 1000, Pow(10, 8));    //	10
            table2.Rows.Add("Сталь 40XH", "Закалка ТВЧ поверхностная с охватом дна впадины", 260, 300, "Реверсивная", 240, 4 * Pow(10, 6), 1000, Pow(10, 8));    //	11
            table2.Rows.Add("Чугун СЧ 32-52", "Нет", 187, 255, "Нереверсивная", 115, Pow(10, 6), 550, Pow(10, 7)); //	12
            table2.Rows.Add("Чугун СЧ 32-53", "Нет", 187, 255, "Реверсивная", 80, Pow(10, 6), 550, Pow(10, 7));  //	13
            table2.Rows.Add("Чугун ВЧ 30-2", "Нет", 197, 265, "Нереверсивная", 120, Pow(10, 6), 600, Pow(10, 7)); //	14
            table2.Rows.Add("Чугун ВЧ 30-2", "Нет", 197, 265, "Реверсивная", 85, Pow(10, 6), 600, Pow(10, 7));  //	15
            table2.Rows.Add("Стальное литье 40XЛ-40ГЛ", "Закалка с высоким отпуском", 190, 255, "Нереверсивная", 135, 4 * Pow(10, 6), 600, Pow(10, 7)); //	16
            table2.Rows.Add("Стальное литье 40XЛ-40ГЛ", "Закалка с высоким отпуском", 190, 255, "Реверсивная", 90, 4 * Pow(10, 6), 600, Pow(10, 7));  //	17

            dataGridView2.DataSource = table2;

            table3.Columns.Add("Material", typeof(string));
            table3.Columns.Add("vid", typeof(string));
            table3.Columns.Add("K_a", typeof(double));

            table3.Rows.Add("Сталь-сталь", "Прямозубые", 495);
            table3.Rows.Add("Сталь-сталь", "Косозубые", 430);
            table3.Rows.Add("Сталь-сталь", "Шевронные", 430);
            table3.Rows.Add("Сталь-чугун", "Прямозубые", 445);
            table3.Rows.Add("Сталь-чугун", "Косозубые", 390);
            table3.Rows.Add("Сталь-чугун", "Шевронные", 390);
            table3.Rows.Add("Сталь-бронза", "Прямозубые", 430);
            table3.Rows.Add("Сталь-бронза", "Косозубые", 375);
            table3.Rows.Add("Сталь-бронза", "Шевронные", 375);
            table3.Rows.Add("Чугун-чугун", "Прямозубые", 415);
            table3.Rows.Add("Чугун-чугун", "Косозубые", 360);
            table3.Rows.Add("Чугун-чугун", "Шевронные", 360);
            table3.Rows.Add("Текстолит-сталь", "Прямозубые", 200);
            table3.Rows.Add("Текстолит-сталь", "Косозубые", 170);
            table3.Rows.Add("Текстолит-сталь", "Шевронные", 170);
            table3.Rows.Add("ДСП-сталь", "Прямозубые", 225);
            table3.Rows.Add("ДСП-сталь", "Косозубые", 195);
            table3.Rows.Add("ДСП-сталь", "Шевронные", 195);
            table3.Rows.Add("Полиамид-сталь", "Прямозубые", 155);
            table3.Rows.Add("Полиамид-сталь", "Косозубые", 135);
            table3.Rows.Add("Полиамид-сталь", "Шевронные", 135);

            dataGridView3.DataSource = table3;

            table4.Columns.Add("z_w", typeof(double));
            table4.Columns.Add("e", typeof(double));
            table4.Columns.Add("Y_f1", typeof(double));

            table4.Rows.Add(14, 0.7, 3.12);
            table4.Rows.Add(14, 0.5, 3.42);
            table4.Rows.Add(14, 0.3, 3.78);
            table4.Rows.Add(14, 0.1, 0);
            table4.Rows.Add(14, 0, 0);
            table4.Rows.Add(14, -0.1, 0);
            table4.Rows.Add(14, -0.3, 0);
            table4.Rows.Add(14, -0.5, 0);
            table4.Rows.Add(16, 0.7, 3.15);
            table4.Rows.Add(16, 0.5, 3.4);
            table4.Rows.Add(16, 0.3, 3.72);
            table4.Rows.Add(16, 0.1, 0);
            table4.Rows.Add(16, 0, 0);
            table4.Rows.Add(16, -0.1, 0);
            table4.Rows.Add(16, -0.3, 0);
            table4.Rows.Add(16, -0.5, 0);
            table4.Rows.Add(17, 0.7, 3.16);
            table4.Rows.Add(17, 0.5, 3.4);
            table4.Rows.Add(17, 0.3, 3.67);
            table4.Rows.Add(17, 0.1, 4.03);
            table4.Rows.Add(17, 0, 4.26);
            table4.Rows.Add(17, -0.1, 0);
            table4.Rows.Add(17, -0.3, 0);
            table4.Rows.Add(17, -0.5, 0);
            table4.Rows.Add(18, 0.7, 3.17);
            table4.Rows.Add(18, 0.5, 3.39);
            table4.Rows.Add(18, 0.3, 3.64);
            table4.Rows.Add(18, 0.1, 3.97);
            table4.Rows.Add(18, 0, 4.2);
            table4.Rows.Add(18, -0.1, 0);
            table4.Rows.Add(18, -0.3, 0);
            table4.Rows.Add(18, -0.5, 0);
            table4.Rows.Add(19, 0.7, 3.18);
            table4.Rows.Add(19, 0.5, 3.39);
            table4.Rows.Add(19, 0.3, 3.62);
            table4.Rows.Add(19, 0.1, 3.92);
            table4.Rows.Add(19, 0, 4.11);
            table4.Rows.Add(19, -0.1, 4.32);
            table4.Rows.Add(19, -0.3, 0);
            table4.Rows.Add(19, -0.5, 0);
            table4.Rows.Add(20, 0.7, 3.19);
            table4.Rows.Add(20, 0.5, 3.39);
            table4.Rows.Add(20, 0.3, 3.61);
            table4.Rows.Add(20, 0.1, 3.89);
            table4.Rows.Add(20, 0, 4.08);
            table4.Rows.Add(20, -0.1, 4.28);
            table4.Rows.Add(20, -0.3, 0);
            table4.Rows.Add(20, -0.5, 0);
            table4.Rows.Add(21, 0.7, 3.2);
            table4.Rows.Add(21, 0.5, 3.39);
            table4.Rows.Add(21, 0.3, 3.6);
            table4.Rows.Add(21, 0.1, 3.85);
            table4.Rows.Add(21, 0, 4.01);
            table4.Rows.Add(21, -0.1, 4.22);
            table4.Rows.Add(21, -0.3, 0);
            table4.Rows.Add(21, -0.5, 0);
            table4.Rows.Add(22, 0.7, 3.21);
            table4.Rows.Add(22, 0.5, 3.39);
            table4.Rows.Add(22, 0.3, 3.59);
            table4.Rows.Add(22, 0.1, 3.82);
            table4.Rows.Add(22, 0, 4);
            table4.Rows.Add(22, -0.1, 4.2);
            table4.Rows.Add(22, -0.3, 0);
            table4.Rows.Add(22, -0.5, 0);
            table4.Rows.Add(24, 0.7, 3.23);
            table4.Rows.Add(24, 0.5, 3.39);
            table4.Rows.Add(24, 0.3, 3.58);
            table4.Rows.Add(24, 0.1, 3.79);
            table4.Rows.Add(24, 0, 3.92);
            table4.Rows.Add(24, -0.1, 4.1);
            table4.Rows.Add(24, -0.3, 0);
            table4.Rows.Add(24, -0.5, 0);
            table4.Rows.Add(25, 0.7, 3.24);
            table4.Rows.Add(25, 0.5, 3.39);
            table4.Rows.Add(25, 0.3, 3.57);
            table4.Rows.Add(25, 0.1, 3.77);
            table4.Rows.Add(25, 0, 3.9);
            table4.Rows.Add(25, -0.1, 4.05);
            table4.Rows.Add(25, -0.3, 4.28);
            table4.Rows.Add(25, -0.5, 0);
            table4.Rows.Add(28, 0.7, 3.27);
            table4.Rows.Add(28, 0.5, 3.4);
            table4.Rows.Add(28, 0.3, 3.56);
            table4.Rows.Add(28, 0.1, 3.72);
            table4.Rows.Add(28, 0, 3.82);
            table4.Rows.Add(28, -0.1, 3.95);
            table4.Rows.Add(28, -0.3, 4.22);
            table4.Rows.Add(28, -0.5, 0);
            table4.Rows.Add(30, 0.7, 3.28);
            table4.Rows.Add(30, 0.5, 3.4);
            table4.Rows.Add(30, 0.3, 3.54);
            table4.Rows.Add(30, 0.1, 3.7);
            table4.Rows.Add(30, 0, 3.8);
            table4.Rows.Add(30, -0.1, 3.9);
            table4.Rows.Add(30, -0.3, 4.14);
            table4.Rows.Add(30, -0.5, 0);
            table4.Rows.Add(32, 0.7, 3.29);
            table4.Rows.Add(32, 0.5, 3.41);
            table4.Rows.Add(32, 0.3, 3.54);
            table4.Rows.Add(32, 0.1, 3.69);
            table4.Rows.Add(32, 0, 3.78);
            table4.Rows.Add(32, -0.1, 3.87);
            table4.Rows.Add(32, -0.3, 4.08);
            table4.Rows.Add(32, -0.5, 4.45);
            table4.Rows.Add(37, 0.7, 3.32);
            table4.Rows.Add(37, 0.5, 3.42);
            table4.Rows.Add(37, 0.3, 3.53);
            table4.Rows.Add(37, 0.1, 3.64);
            table4.Rows.Add(37, 0, 3.71);
            table4.Rows.Add(37, -0.1, 3.8);
            table4.Rows.Add(37, -0.3, 3.96);
            table4.Rows.Add(37, -0.5, 4.2);
            table4.Rows.Add(40, 0.7, 3.33);
            table4.Rows.Add(40, 0.5, 3.42);
            table4.Rows.Add(40, 0.3, 3.53);
            table4.Rows.Add(40, 0.1, 3.64);
            table4.Rows.Add(40, 0, 3.7);
            table4.Rows.Add(40, -0.1, 3.77);
            table4.Rows.Add(40, -0.3, 3.92);
            table4.Rows.Add(40, -0.5, 4.13);
            table4.Rows.Add(45, 0.7, 3.36);
            table4.Rows.Add(45, 0.5, 3.43);
            table4.Rows.Add(45, 0.3, 3.52);
            table4.Rows.Add(45, 0.1, 3.62);
            table4.Rows.Add(45, 0, 3.68);
            table4.Rows.Add(45, -0.1, 3.72);
            table4.Rows.Add(45, -0.3, 3.86);
            table4.Rows.Add(45, -0.5, 4.02);
            table4.Rows.Add(50, 0.7, 3.38);
            table4.Rows.Add(50, 0.5, 3.44);
            table4.Rows.Add(50, 0.3, 3.52);
            table4.Rows.Add(50, 0.1, 3.6);
            table4.Rows.Add(50, 0, 3.65);
            table4.Rows.Add(50, -0.1, 3.7);
            table4.Rows.Add(50, -0.3, 3.81);
            table4.Rows.Add(50, -0.5, 3.96);
            table4.Rows.Add(60, 0.7, 3.41);
            table4.Rows.Add(60, 0.5, 3.47);
            table4.Rows.Add(60, 0.3, 3.53);
            table4.Rows.Add(60, 0.1, 3.59);
            table4.Rows.Add(60, 0, 3.62);
            table4.Rows.Add(60, -0.1, 3.67);
            table4.Rows.Add(60, -0.3, 3.74);
            table4.Rows.Add(60, -0.5, 3.84);
            table4.Rows.Add(80, 0.7, 3.45);
            table4.Rows.Add(80, 0.5, 3.5);
            table4.Rows.Add(80, 0.3, 3.54);
            table4.Rows.Add(80, 0.1, 3.58);
            table4.Rows.Add(80, 0, 3.61);
            table4.Rows.Add(80, -0.1, 3.62);
            table4.Rows.Add(80, -0.3, 3.68);
            table4.Rows.Add(80, -0.5, 3.73);
            table4.Rows.Add(100, 0.7, 3.49);
            table4.Rows.Add(100, 0.5, 3.52);
            table4.Rows.Add(100, 0.3, 3.55);
            table4.Rows.Add(100, 0.1, 3.58);
            table4.Rows.Add(100, 0, 3.6);
            table4.Rows.Add(100, -0.1, 3.61);
            table4.Rows.Add(100, -0.3, 3.65);
            table4.Rows.Add(100, -0.5, 3.68);
            table4.Rows.Add(150, 0.7, 0);
            table4.Rows.Add(150, 0.5, 0);
            table4.Rows.Add(150, 0.3, 0);
            table4.Rows.Add(150, 0.1, 0);
            table4.Rows.Add(150, 0, 3.6);
            table4.Rows.Add(150, -0.1, 3.63);
            table4.Rows.Add(150, -0.3, 3.63);
            table4.Rows.Add(150, -0.5, 3.63);

            dataGridView4.DataSource = table4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
