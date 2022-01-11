using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Kurs_BD
{
    public partial class Form2 : Form
    {
        Form1 form1;
        DataTable mass = new DataTable() { TableName = "Mass" };

        (double b_w, string rasp,string val, bool HB, double K_hb)[] table1 = new (double b_w, string rasp, string val, bool HB, double K_hb)[64];
        (string Material_det, string term, double HB_min, double HB_max, string nagr, double sg_fp,double N_f0,double sg_hp,double N_h0)[] table2 = new(string Material_det, string term, double HB_min, double HB_max, string nagr, double sg_fp, double N_f0, double sg_hp, double N_h0) [18];
        (string Material, string vid, double K_a)[] table3 = new (string Material, string vid, double K_a)[21];
        (double z_w, double e, double Y_f1)[] table4 = new (double z_w, double e, double Y_f1)[168];

        double Y_f1, K_hl, K_fl, ee, HB, m_f, n_i, K_a, u, t_ba, N_h0, N_he, N_f0, N_fe, N_s, n_ci, a_w, m, K_hb, b_w, d_w, t_bd, t_c, t_ci, K_ma, sg_hp, sg_fp, sg1_hp, sg1_fp, T1, n, T_1i;

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void vibor_z_w_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pole_t_ci_TextChanged(object sender, EventArgs e)
        {

        }

        int i, z_w;
        string Material, Material_det, nagr, rasp, val, vid, term,zacep;
        private void delete_str_Click(object sender, EventArgs e)
        {
            i = mass.Rows.Count + 1;
            if (i > 1)
            {
                mass.Rows[i - 2].Delete();
                i--;
            }
            else
                MessageBox.Show("В таблице отсутствуют строки", "Ошибка");
        }

        private void download_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(ref mass);
            form5.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ref mass);
            form4.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(ref mass);
            form3.Show();
        }

        void calc_K_hb()
        {
            
                bool bolee;
            if (HB >= 351)
                bolee = true;
            else
                bolee = false;

           

          
            foreach (var item in table1)
            {
                if( (item.HB==bolee) && (rasp == item.rasp) && (val ==item.val) && (b_w ==item.b_w))
                {
                    K_hb = item.K_hb;      
                }
            }
            
        }

        bool calc_Sg_N()
        {
            foreach (var item in table2)
            {
                if(item.Material_det==Material_det&&item.term==term&&item.nagr==nagr)
                {
                    sg1_fp = item.sg_fp;
                    sg1_hp = item.sg_hp;
                    N_f0 = item.N_f0;
                    N_h0 = item.N_h0;
                    return true;
                }
            }
            return false;

        }

        void calc_K_a()
        {
            foreach (var item in table3)
            {
                if (item.Material==Material&&item.vid==vid)
                {
                    K_a=item.K_a;
                }
            }

        }

        void calc_Y_f1()
        {
            foreach (var item in table4)
            {
                if (item.z_w == z_w && item.e == ee)
                {
                    Y_f1 = item.Y_f1;
                    
                   
                }
            }

        }

        void calc_a_w()
        {
            t_bd = b_w / d_w;
            
            t_ba = 2 * t_bd / (u + 1);
            if (nagr=="Нереверсивная")
            {
                N_he = 60*t_c * n;
            }
            else
            {
                N_s = 0;
                double summ=0;
                N_s += n_ci;
                summ = Pow(T_1i / T1, 3) * (n_ci / N_s);
                for (int i = 0; i < mass.Rows.Count; i++)
                {
                    var n_ci1 = (double)mass.Rows[i].ItemArray[20];
                    N_s += N_s + n_ci1;
                }
                for (int i = 0; i < mass.Rows.Count; i++)
                {
                    summ += Pow(((double)mass.Rows[i].ItemArray[36]) / ((double)mass.Rows[i].ItemArray[34]), 3) * ((double)mass.Rows[i].ItemArray[20]) / N_s;
                }
                N_he = N_s * summ;
            }


            K_hl = Pow(N_h0/N_he , 1 / 6.0);
            sg_hp = sg1_hp * K_hl;
            if(zacep=="Внешнее")
            {
                a_w = K_a * (u + 1) * Pow(T1*K_hb/u*t_ba*Pow(sg_hp,2), 1 / 3.0);
            }
            else
            {
                a_w = K_a * (u - 1) * Pow(T1 * K_hb / u * t_ba * Pow(sg_hp, 2), 1 / 3.0);
            }
        }

        void calc_m()
        {
            if (HB > 350)
                m_f = 9;
            else
                m_f = 6;

            if (nagr == "Нереверсивная")
            {
                N_fe = 60 * t_c * n;
            }
            else
            {
                double summ = 0;
                N_s = 0;
                N_s += n_ci;
                summ = Pow(T_1i / T1, m_f) * (n_ci / N_s);
                for (int i = 0; i < mass.Rows.Count; i++)
                {
                    n_ci = (double)mass.Rows[i].ItemArray[20];
                    N_s += N_s + n_ci;
                }
                for (int i = 0; i < mass.Rows.Count; i++)
                {
                    summ += Pow(((double)mass.Rows[i].ItemArray[36]) / ((double)mass.Rows[i].ItemArray[34]), m_f) * ((double)mass.Rows[i].ItemArray[20]) / N_s;
                }
                N_fe = N_s * summ;
            }

            K_fl = Pow(N_f0 / N_fe, 1.0 / m_f);
            sg_fp = sg1_fp * K_fl;
            if (zacep == "Внешнее")
            {
                m = K_ma * T1 * (u + 1) * Y_f1 / a_w * b_w * sg_fp;
            }
            else
            {
                m = K_ma * T1 * (u - 1) * Y_f1 / a_w * b_w * sg_fp;
            }
        }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            
            mass.Columns.Add("	i	", typeof(int));   //	0
            mass.Columns.Add("	Y_f1	", typeof(double));    //	1
            mass.Columns.Add("	K_hl	", typeof(double));    //	2
            mass.Columns.Add("	K_fl	", typeof(double));    //	3
            mass.Columns.Add("	z_w	", typeof(int));   //	4
            mass.Columns.Add("	e	", typeof(double));    //	5
            mass.Columns.Add("	HB	", typeof(double));    //	6
            mass.Columns.Add("	m_f	", typeof(double));    //	7
            mass.Columns.Add("	n_i	", typeof(double));    //	8
            mass.Columns.Add("	Material	", typeof(string));    //	9
            mass.Columns.Add("	Material_det	", typeof(string));    //	10
            mass.Columns.Add("	nagr	", typeof(string));    //	11
            mass.Columns.Add("	K_a	", typeof(double));    //	12
            mass.Columns.Add("	u	", typeof(double));    //	13
            mass.Columns.Add("	t_ba	", typeof(double));    //	14
            mass.Columns.Add("	N_h0	", typeof(double));    //	15
            mass.Columns.Add("	N_he	", typeof(double));    //	16
            mass.Columns.Add("	N_f0	", typeof(double));    //	17
            mass.Columns.Add("	N_fe	", typeof(double));    //	18
            mass.Columns.Add("	N_s	", typeof(double));    //	19
            mass.Columns.Add("	n_ci	", typeof(double));    //	20
            mass.Columns.Add("	a_w	", typeof(double));    //	21
            mass.Columns.Add("	m	", typeof(double));    //	22
            mass.Columns.Add("	K_hb	", typeof(double));    //	23
            mass.Columns.Add("	b_w	", typeof(double));    //	24
            mass.Columns.Add("	d_w	", typeof(double));    //	25
            mass.Columns.Add("	t_bd	", typeof(double));    //	26
            mass.Columns.Add("	t_c	", typeof(double));    //	27
            mass.Columns.Add("	t_ci	", typeof(double));    //	28
            mass.Columns.Add("	K_ma	", typeof(double));    //	29
            mass.Columns.Add("	sg_hp	", typeof(double));    //	30
            mass.Columns.Add("	sg_fp	", typeof(double));    //	31
            mass.Columns.Add("	sg1_hp	", typeof(double));    //	32
            mass.Columns.Add("	sg1_fp	", typeof(double));    //	33
            mass.Columns.Add("	T1	", typeof(double));    //	34
            mass.Columns.Add("	n	", typeof(double));    //	35
            mass.Columns.Add("	T_1i	", typeof(double)); //	36
            mass.Columns.Add("	rasp	", typeof(string));    //	37
            mass.Columns.Add("	val	", typeof(string));    //	38
            mass.Columns.Add("	vid	", typeof(string)); //	39
            mass.Columns.Add("	term	", typeof(string));	//	40

            //Таблица 1
            table1[0] = (0.2,  "Симметричное", "-", true, 1);      //	0 
            table1[1] = (0.4,  "Симметричное", "-", true, 1.01);      //	1
            table1[2] = (0.6,  "Симметричное","-", true, 1.03);      //	3
            table1[3] = (0.8,  "Симметричное","-", true, 1.06);      //	4
            table1[4] = (1.0,  "Симметричное","-", true, 1.1);       //	5
            table1[5] = (1.2,  "Симметричное","-", true, 1.13);      //	6
            table1[6] = (1.4,  "Симметричное","-", true, 1.15);      //	7
            table1[7] = (1.6,  "Симметричное","-", true, 1.2);       //	8
            table1[8] = (0.2,  "Симметричное","-", false, 1);     //	9
            table1[9] = (0.4,  "Симметричное","-", false, 1);     //	10
            table1[10] = (0.6, "Симметричное","-", false, 1.01);        //	11
            table1[11] = (0.8, "Симметричное","-", false, 1.03);        //	12
            table1[12] = (1.0, "Симметричное","-", false, 1.04);        //	13
            table1[13] = (1.2, "Симметричное","-", false, 1.05);        //	14
            table1[14] = (1.4, "Симметричное","-", false, 1.07);        //	15
            table1[15] = (1.6, "Симметричное","-", false, 1.08);        //	16
            table1[16] = (0.2, "Консольное", "-",  true, 1.15);     //	17
            table1[17] = (0.4, "Консольное","-", true, 1.35);     //	18
            table1[18] = (0.6, "Консольное","-", true, 1.6);      //	19
            table1[19] = (0.8, "Консольное","-", true, 1.85);     //	20
            table1[20] = (1.0, "Консольное","-", true, 0  );      //	21
            table1[21] = (1.2, "Консольное","-", true, 0   );      //	22
            table1[22] = (1.4, "Консольное","-", true, 0   );      //	23
            table1[23] = (1.6, "Консольное","-", true, 0   );      //	24
            table1[24] = (0.2, "Консольное","-", false, 1.07);        //	25
            table1[25] = (0.4, "Консольное","-", false, 1.15);        //	26
            table1[26] = (0.6, "Консольное","-", false, 1.24);        //	27
            table1[27] = (0.8, "Консольное","-", false, 1.35);        //	28
            table1[28] = (1.0, "Консольное","-", false, 0   );     //	29
            table1[29] = (1.2, "Консольное","-", false, 0   );     //	30
            table1[30] = (1.4, "Консольное","-", false, 0   );     //	31
            table1[31] = (1.6, "Консольное", "-", false, 0   );     //	32
            table1[32] = (0.2, "Несимметричное","Весьма жесткий", true,  1.01);     //	33
            table1[33] = (0.4, "Несимметричное","Весьма жесткий",true,  1.05);     //	34
            table1[34] = (0.6, "Несимметричное","Весьма жесткий",true,  1.09);     //	35
            table1[35] = (0.8, "Несимметричное","Весьма жесткий",true,  1.14);     //	36
            table1[36] = (1.0, "Несимметричное","Весьма жесткий",true,  1.18);     //	37
            table1[37] = (1.2, "Несимметричное","Весьма жесткий",true,  1.25);     //	38
            table1[38] = (1.4, "Несимметричное","Весьма жесткий",true,  1.32);     //	39
            table1[39] = (1.6, "Несимметричное","Весьма жесткий",true,  1.4);      //	40
            table1[40] = (0.2, "Несимметричное","Весьма жесткий",false, 1);      //	41
            table1[41] = (0.4, "Несимметричное","Весьма жесткий",false, 1.02);        //	42
            table1[42] = (0.6, "Несимметричное","Весьма жесткий",false, 1.04);        //	43
            table1[43] = (0.8, "Несимметричное","Весьма жесткий",false, 1.06);        //	44
            table1[44] = (1.0, "Несимметричное","Весьма жесткий",false, 1.08);        //	45
            table1[45] = (1.2, "Несимметричное","Весьма жесткий",false, 1.1);     //	46
            table1[46] = (1.4, "Несимметричное","Весьма жесткий",false, 1.13);        //	47
            table1[47] = (1.6, "Несимметричное","Весьма жесткий",false, 1.16);        //	48
            table1[48] = (0.2, "Несимметричное","Менее жесткий", true,  1.06);     //	49
            table1[49] = (0.4, "Несимметричное","Менее жесткий",true,  1.12);     //	50
            table1[50] = (0.6, "Несимметричное","Менее жесткий",true,  1.2);      //	51
            table1[51] = (0.8, "Несимметричное","Менее жесткий",true,  1.27);     //	52
            table1[52] = (1.0, "Несимметричное","Менее жесткий",true,  1.37);     //	53
            table1[53] = (1.2, "Несимметричное","Менее жесткий",true,  1.5);      //	54
            table1[54] = (1.4, "Несимметричное","Менее жесткий",true,  1.6);      //	55
            table1[55] = (1.6, "Несимметричное","Менее жесткий",true, 0);      //	56
            table1[56] = (0.2, "Несимметричное","Менее жесткий", false, 1.02);        //	57
            table1[57] = (0.4, "Несимметричное","Менее жесткий",false, 1.05);        //	58
            table1[58] = (0.6, "Несимметричное","Менее жесткий",false, 1.08);        //	59
            table1[59] = (0.8, "Несимметричное","Менее жесткий",false, 1.12);        //	60
            table1[60] = (1.0, "Несимметричное","Менее жесткий",false, 1.15);        //	61
            table1[61] = (1.2, "Несимметричное","Менее жесткий",false, 1.18);        //	62
            table1[62] = (1.4, "Несимметричное","Менее жесткий",false, 1.23);        //	63
            table1[63] = (1.6, "Несимметричное", "Менее жесткий", false, 1.28);		//	64

            
            //Таблица 2
            table2[0] = ("Сталь 45", "Улучшение", 240, 280, "Нереверсивная", 195, 4 * Pow(10, 6), 600, 1.5 * Pow(10, 7));    //	0
            table2[1] = ("Сталь 45", "Улучшение", 240, 280, "Реверсивная", 130, 4 * Pow(10, 6), 600, 1.5 * Pow(10, 7));    //	1
            table2[2] = ("Сталь 45", "Закалка ТВЧ поверхностная с охватом дна впадины", 240, 280, "Нереверсивная", 230, 4 * Pow(10, 6), 800, 6 * Pow(10, 7));  //	2
            table2[3] = ("Сталь 45", "Закалка ТВЧ поверхностная с охватом дна впадины", 240, 280, "Реверсивная", 180, 4 * Pow(10, 6), 800, 6 * Pow(10, 7));  //	3
            table2[4] = ("Сталь 40Х", "Нормализация", 210, 230, "Нереверсивная", 200, 4 * Pow(10, 6), 550, Pow(10, 7));  //	4
            table2[5] = ("Сталь 40Х", "Нормализация", 210, 230, "Реверсивная", 230, 4 * Pow(10, 6), 550, Pow(10, 7));  //	5
            table2[6] = ("Сталь 40Х", "Закалка ТВЧ сквозная с охватом дна впадины", 240, 280, "Нереверсивная", 230, 4 * Pow(10, 6), 650, 2.5 * Pow(10, 7));    //	6
            table2[7] = ("Сталь 40Х", "Закалка ТВЧ сквозная с охватом дна впадины", 240, 280, "Реверсивная", 150, 4 * Pow(10, 6), 650, 2.5 * Pow(10, 7));    //	7
            table2[8] = ("Сталь 40Х", "Закалка ТВЧ поверхностная с охватом дна впадины", 250, 280, "Нереверсивная", 270, 4 * Pow(10, 6), 900, 8 * Pow(10, 7));  //	8
            table2[9] = ("Сталь 40Х", "Закалка ТВЧ поверхностная с охватом дна впадины", 250, 280, "Реверсивная", 200, 4 * Pow(10, 6), 900, 8 * Pow(10, 7));  //	9
            table2[10] = ("Сталь 40XH", "Закалка ТВЧ поверхностная с охватом дна впадины", 260, 300, "Нереверсивная", 320, 4 * Pow(10, 6), 1000, Pow(10, 8));    //	10
            table2[11] = ("Сталь 40XH", "Закалка ТВЧ поверхностная с охватом дна впадины", 260, 300, "Реверсивная", 240, 4 * Pow(10, 6), 1000, Pow(10, 8));    //	11
            table2[12] = ("Чугун СЧ 32-52", "Нет", 187, 255, "Нереверсивная", 115, Pow(10, 6), 550, Pow(10, 7)); //	12
            table2[13] = ("Чугун СЧ 32-53", "Нет", 187, 255, "Реверсивная", 80, Pow(10, 6), 550, Pow(10, 7));  //	13
            table2[14] = ("Чугун ВЧ 30-2", "Нет", 197, 265, "Нереверсивная", 120, Pow(10, 6), 600, Pow(10, 7)); //	14
            table2[15] = ("Чугун ВЧ 30-2", "Нет", 197, 265, "Реверсивная", 85, Pow(10, 6), 600, Pow(10, 7));  //	15
            table2[16] = ("Стальное литье 40XЛ-40ГЛ", "Закалка с высоким отпуском", 190, 255, "Нереверсивная", 135, 4 * Pow(10, 6), 600, Pow(10, 7)); //	16
            table2[17] = ("Стальное литье 40XЛ-40ГЛ", "Закалка с высоким отпуском", 190, 255, "Реверсивная", 90, 4 * Pow(10, 6), 600, Pow(10, 7));  //	17

            
            //Таблица 3
            table3[0] = ("Сталь-сталь", "Прямозубые", 495);
            table3[1] = ("Сталь-сталь", "Косозубые", 430);
            table3[2] = ("Сталь-сталь", "Шевронные", 430);
            table3[3] = ("Сталь-чугун", "Прямозубые", 445);
            table3[4] = ("Сталь-чугун", "Косозубые", 390);
            table3[5] = ("Сталь-чугун", "Шевронные", 390);
            table3[6] = ("Сталь-бронза", "Прямозубые", 430);
            table3[7] = ("Сталь-бронза", "Косозубые", 375);
            table3[8] = ("Сталь-бронза", "Шевронные", 375);
            table3[9] = ("Чугун-чугун", "Прямозубые", 415);
            table3[10] =("Чугун-чугун", "Косозубые", 360);
            table3[11] =("Чугун-чугун", "Шевронные", 360);
            table3[12] =("Текстолит-сталь", "Прямозубые", 200);
            table3[13] =("Текстолит-сталь", "Косозубые", 170);
            table3[14] =("Текстолит-сталь", "Шевронные", 170);
            table3[15] =("ДСП-сталь", "Прямозубые", 225);
            table3[16] =("ДСП-сталь", "Косозубые", 195);
            table3[17] =("ДСП-сталь", "Шевронные", 195);
            table3[18] =("Полиамид-сталь", "Прямозубые", 155);
            table3[19] =("Полиамид-сталь", "Косозубые", 135);
            table3[20] =("Полиамид-сталь", "Шевронные", 135);

            //Таблица 4
            table4[0]=(14,0.7,     3.12);
            table4[1]=(14,0.5,     3.42);
            table4[2]=(14,0.3,     3.78);
            table4[3]=(14,0.1,     0);
            table4[4]=(14,0,       0);
            table4[5]=(14,-0.1,    0);
            table4[6]=(14,-0.3,    0);
            table4[7]=(14,-0.5,    0);
            table4[8]=(16,0.7,     3.15);
            table4[9]=(16,0.5,     3.4);
            table4[10]=(16,0.3,    3.72);
            table4[11]=(16,0.1,    0);
            table4[12]=(16,0,      0);
            table4[13]=(16,-0.1,   0);
            table4[14]=(16,-0.3,   0);
            table4[15]=(16,-0.5,   0);
            table4[16]=(17,0.7,    3.16);
            table4[17]=(17,0.5,    3.4);
            table4[18]=(17,0.3,    3.67);
            table4[19]=(17,0.1,    4.03);
            table4[20]=(17,0,      4.26);
            table4[21]=(17,-0.1,   0);
            table4[22]=(17,-0.3,   0);
            table4[23]=(17,-0.5,   0);
            table4[24]=(18,0.7,    3.17);
            table4[25]=(18,0.5,    3.39);
            table4[26]=(18,0.3,    3.64);
            table4[27]=(18,0.1,    3.97);
            table4[28]=(18,0,      4.2);
            table4[29]=(18,-0.1,   0);
            table4[30]=(18,-0.3,   0);
            table4[31]=(18,-0.5,   0);
            table4[32]=(19,0.7,    3.18);
            table4[33]=(19,0.5,    3.39);
            table4[34]=(19,0.3,    3.62);
            table4[35]=(19,0.1,    3.92);
            table4[36]=(19,0,      4.11);
            table4[37]=(19,-0.1,   4.32);
            table4[38]=(19,-0.3,   0);
            table4[39]=(19,-0.5,   0);
            table4[40]=(20,0.7,    3.19);
            table4[41]=(20,0.5,    3.39);
            table4[42]=(20,0.3,    3.61);
            table4[43]=(20,0.1,    3.89);
            table4[44]=(20,0,      4.08);
            table4[45]=(20,-0.1,   4.28);
            table4[46]=(20,-0.3,   0);
            table4[47]=(20,-0.5,   0);
            table4[48]=(21,0.7,    3.2);
            table4[49]=(21,0.5,    3.39);
            table4[50]=(21,0.3,    3.6);
            table4[51]=(21,0.1,    3.85);
            table4[52]=(21,0,      4.01);
            table4[53]=(21,-0.1,   4.22);
            table4[54]=(21,-0.3,   0);
            table4[55]=(21,-0.5,   0);
            table4[56]=(22,0.7,    3.21);
            table4[57]=(22,0.5,    3.39);
            table4[58]=(22,0.3,    3.59);
            table4[59]=(22,0.1,    3.82);
            table4[60]=(22,0,      4);
            table4[61]=(22,-0.1,   4.2);
            table4[62]=(22,-0.3,   0);
            table4[63]=(22,-0.5,   0);
            table4[64]=(24,0.7,    3.23);
            table4[65]=(24,0.5,    3.39);
            table4[66]=(24,0.3,    3.58);
            table4[67]=(24,0.1,    3.79);
            table4[68]=(24,0,      3.92);
            table4[69]=(24,-0.1,   4.1);
            table4[70]=(24,-0.3,   0);
            table4[71]=(24,-0.5,   0);
            table4[72]=(25,0.7,    3.24);
            table4[73]=(25,0.5,    3.39);
            table4[74]=(25,0.3,    3.57);
            table4[75]=(25,0.1,    3.77);
            table4[76]=(25,0,      3.9);
            table4[77]=(25,-0.1,   4.05);
            table4[78]=(25,-0.3,   4.28);
            table4[79]=(25,-0.5,   0);
            table4[80]=(28,0.7,    3.27);
            table4[81]=(28,0.5,    3.4);
            table4[82]=(28,0.3,    3.56);
            table4[83]=(28,0.1,    3.72);
            table4[84]=(28,0,      3.82);
            table4[85]=(28,-0.1,   3.95);
            table4[86]=(28,-0.3,   4.22);
            table4[87]=(28,-0.5,   0);
            table4[88]=(30,0.7,    3.28);
            table4[89]=(30,0.5,    3.4);
            table4[90]=(30,0.3,    3.54);
            table4[91]=(30,0.1,    3.7);
            table4[92]=(30,0,      3.8);
            table4[93]=(30,-0.1,   3.9);
            table4[94]=(30,-0.3,   4.14);
            table4[95]=(30,-0.5,   0);
            table4[96]=(32,0.7,    3.29);
            table4[97]=(32,0.5,    3.41);
            table4[98]=(32,0.3,    3.54);
            table4[99]=(32,0.1,    3.69);
            table4[100]=(32,0,     3.78);
            table4[101]=(32,-0.1,  3.87);
            table4[102]=(32,-0.3,  4.08);
            table4[103]=(32,-0.5,  4.45);
            table4[104]=(37,0.7,   3.32);
            table4[105]=(37,0.5,   3.42);
            table4[106]=(37,0.3,   3.53);
            table4[107]=(37,0.1,   3.64);
            table4[108]=(37,0,     3.71);
            table4[109]=(37,-0.1,  3.8);
            table4[110]=(37,-0.3,  3.96);
            table4[111]=(37,-0.5,  4.2);
            table4[112]=(40,0.7,   3.33);
            table4[113]=(40,0.5,   3.42);
            table4[114]=(40,0.3,   3.53);
            table4[115]=(40,0.1,   3.64);
            table4[116]=(40,0,     3.7);
            table4[117]=(40,-0.1,  3.77);
            table4[118]=(40,-0.3,  3.92);
            table4[119]=(40,-0.5,  4.13);
            table4[120]=(45,0.7,   3.36);
            table4[121]=(45,0.5,   3.43);
            table4[122]=(45,0.3,   3.52);
            table4[123]=(45,0.1,   3.62);
            table4[124]=(45,0,     3.68);
            table4[125]=(45,-0.1,  3.72);
            table4[126]=(45,-0.3,  3.86);
            table4[127]=(45,-0.5,  4.02);
            table4[128]=(50,0.7,   3.38);
            table4[129]=(50,0.5,   3.44);
            table4[130]=(50,0.3,   3.52);
            table4[131]=(50,0.1,   3.6);
            table4[132]=(50,0,     3.65);
            table4[133]=(50,-0.1,  3.7);
            table4[134]=(50,-0.3,  3.81);
            table4[135]=(50,-0.5,  3.96);
            table4[136]=(60,0.7,   3.41);
            table4[137]=(60,0.5,   3.47);
            table4[138]=(60,0.3,   3.53);
            table4[139]=(60,0.1,   3.59);
            table4[140]=(60,0,     3.62);
            table4[141]=(60,-0.1,  3.67);
            table4[142]=(60,-0.3,  3.74);
            table4[143]=(60,-0.5,  3.84);
            table4[144]=(80,0.7,   3.45);
            table4[145]=(80,0.5,   3.5);
            table4[146]=(80,0.3,   3.54);
            table4[147]=(80,0.1,   3.58);
            table4[148]=(80,0,     3.61);
            table4[149]=(80,-0.1,  3.62);
            table4[150]=(80,-0.3,  3.68);
            table4[151]=(80,-0.5,  3.73);
            table4[152]=(100,0.7,  3.49);
            table4[153]=(100,0.5,  3.52);
            table4[154]=(100,0.3,  3.55);
            table4[155]=(100,0.1,  3.58);
            table4[156]=(100,0,    3.6);
            table4[157]=(100,-0.1, 3.61);
            table4[158]=(100,-0.3, 3.65);
            table4[159]=(100,-0.5, 3.68);
            table4[160]=(150,0.7,  0);
            table4[161]=(150,0.5,  0);
            table4[162]=(150,0.3,  0);
            table4[163]=(150,0.1,  0);
            table4[164]=(150,0,    3.6);
            table4[165]=(150,-0.1, 3.63);
            table4[166]=(150,-0.3, 3.63);
            table4[167]=(150,-0.5, 3.63);



            table.DataSource = mass;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                i = mass.Rows.Count + 1;
                this.ee = Convert.ToDouble(vibor_e.SelectedItem);
                t_c = Convert.ToDouble(pole_t_c.Text);
                z_w = Convert.ToInt32(vibor_z_w.SelectedItem);
                HB = Convert.ToDouble(pole_HB.Text);
                n_i = Convert.ToDouble(pole_n_i.Text);
                Material = Convert.ToString(vibor_Material.SelectedItem);
                Material_det = Convert.ToString(vibor_Material_det.SelectedItem);
                nagr = Convert.ToString(vibor_nagr.SelectedItem);
                u = Convert.ToDouble(pole_u.Text);
                b_w = Convert.ToDouble(vibor_b_w.SelectedItem);
                d_w = Convert.ToDouble(pole_d_w.Text);
                t_ci = Convert.ToDouble(pole_t_ci.Text);
                T1 = Convert.ToDouble(pole_T1.Text);
                n = Convert.ToDouble(pole_n.Text);
                T_1i = Convert.ToDouble(pole_T_1i.Text);
                rasp = Convert.ToString(vibor_rasp.SelectedItem);
                val = Convert.ToString(vibor_val.SelectedItem);
                vid = Convert.ToString(vibor_vid.SelectedItem);
                term = Convert.ToString(vibor_term.SelectedItem);
                zacep = Convert.ToString(vibor_zacep.SelectedItem);
                n_ci = 60 / t_ci / n_i;
                if (vid == "Прямозубые")
                    K_ma = 1400;
                else
                    K_ma = 850;
                
                if (rasp == "Симметричное" || rasp == "Консольное")
                    val = "-";

                if (rasp == "Несимметричное" && val == "-")
                {
                    MessageBox.Show("При несимметричном расположении вал не можеть быть \"-\" ", "Ошибка");
                    throw new Exception("error");
                }

                calc_K_hb();


                if (Material_det == "Чугун СЧ32-52" || Material_det == "Чугун ВЧ30-2")
                    term = "Нет";

                if ((Material_det != "Чугун СЧ32-52" || Material_det != "Чугун ВЧ30-2") && term == "Нет")
                {
                    MessageBox.Show("Для такого материала должна быть указана термообработка", "Ошибка");
                    throw new Exception("error");
                }

                if(!calc_Sg_N())
                {
                    MessageBox.Show("Для такого материала должна не может быть такой термообработки", "Ошибка");
                    throw new Exception("error");
                }
                calc_K_a();
                calc_Y_f1();
                calc_a_w();
                calc_m();


                mass.Rows.Add(i, Y_f1, K_hl, K_fl, z_w, ee, HB, m_f, n_i, Material, Material_det, nagr, K_a, u, t_ba, N_h0, N_he, N_f0, N_fe, N_s, n_ci, a_w, m, K_hb, b_w, d_w, t_bd, t_c, t_ci, K_ma, sg_hp, sg_fp, sg1_hp, sg1_fp, T1, n, T_1i, rasp, val, vid, term);
            }
            catch
            {
                MessageBox.Show("Вы ввели недопустимое число", "Ошибка");
            }

            






        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }
    }
}
