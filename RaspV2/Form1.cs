using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace RaspV2
{
    public partial class Form1 : Form
    {
        DAL dal = new DAL();
        string r;
        string c;
        string ned;
        int sch;

        public Form1()
        {
            InitializeComponent();
            ArrayList ocnV = dal.GetV();
            ArrayList ocnN = dal.GetN();
            dgv_ocn.DataSource = ocnV;
            cbx_nedeli.Items.AddRange(new object[] { "Верхняя неделя", "Нижняя неделя" });
            //cbx_nedeli.Items.Add("Нижняя неделя");
            cbx_nedeli.SelectedItem = "Верхняя неделя";
            foreach (DataGridViewColumn column in dgv_rasp.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        void cbx_nedeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = cbx_nedeli.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            ned = selectedState;
            if (selectedState == "Верхняя неделя")
            {
                dgv_rasp.Rows.Clear();
                ArrayList ocnV = dal.GetV();
                dgv_ocn.DataSource = ocnV;
                Vnos();
            }
            else
            {
                dgv_rasp.Rows.Clear();
                ArrayList ocnN = dal.GetN();
                dgv_ocn.DataSource = ocnN;
                Vnos();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Vnos();
            cbx_nedeli.SelectedIndexChanged += cbx_nedeli_SelectedIndexChanged;
            while (sch < 1)
            {
                int maxR = 0;
                int maxC = 0;
                for (int i = 0; i < dgv_ocn.RowCount; i++)
                {
                    if (Int32.Parse(dgv_ocn[8, i].Value.ToString()) > maxR)
                        maxR = Int32.Parse(dgv_ocn[8, i].Value.ToString());
                    if (Int32.Parse(dgv_ocn[9, i].Value.ToString()) > maxC)
                        maxC = Int32.Parse(dgv_ocn[9, i].Value.ToString());
                }
                for (int i = 0; i < maxC + 1; i++)
                    dgv_rasp.Columns.Add("", "*");
                //dgv_rasp.Columns.Add("", "*");
                for (int i = 0; i < maxR + 1; i++)
                    dgv_rasp.Rows.Add();
                //dgv_rasp.Rows.Add();
                Form1_upd();
                sch =+ 1;
            }
        }

        void Vnos()
        {
            int maxR = 0;
            int maxC = 0;
            for (int i = 0; i < dgv_ocn.RowCount; i++)
            {
                if (Int32.Parse(dgv_ocn[8, i].Value.ToString()) > maxR)
                    maxR = Int32.Parse(dgv_ocn[8, i].Value.ToString());
                if (Int32.Parse(dgv_ocn[9, i].Value.ToString()) > maxC)
                    maxC = Int32.Parse(dgv_ocn[9, i].Value.ToString());
            }
            if (dgv_rasp.ColumnCount != maxC + 1)
            {
                for (int i = 0; i < maxC + 1; i++)
                    dgv_rasp.Columns.Add("", "*");
            }

            for (int i = 0; i < maxR + 1; i++)
                dgv_rasp.Rows.Add();


            Form1_upd();
        }

        void Form1_upd()
        {
            
            for (int i = 0; i < dgv_ocn.RowCount; i++)
            {
                string text = " ";
                try
                {
                    int row = Int32.Parse(dgv_ocn[8, i].Value.ToString());
                    int column = Int32.Parse(dgv_ocn[9, i].Value.ToString());
                    if (row != 0 || column != 0)
                    {
                        for (int j = 0; j < dgv_ocn.ColumnCount; j++)
                        {
                            if (j > 3 &&j < 8)
                            {
                                text += dgv_ocn[j, i].Value.ToString();
                                text += " ";
                            }
                        }
                        dgv_rasp[column, row].Value = text;
                    }
                }
                catch { }
            }
        }

        private void dgv_rasp_Click(object sender, EventArgs e)
        {
            txbx_Naz.Text = "";
            txbx_prep.Text = "";
            txbx_kab.Text = "";
            int row = Int32.Parse(dgv_rasp.CurrentCell.RowIndex.ToString());
            int column = Int32.Parse(dgv_rasp.CurrentCell.ColumnIndex.ToString());
            for (int i = 0; i < dgv_ocn.RowCount; i++)
            {
                if (row == Int32.Parse(dgv_ocn[8, i].Value.ToString()) && column == Int32.Parse(dgv_ocn[9, i].Value.ToString()))
                {
                    string naz = dgv_ocn[4, i].Value.ToString();
                    string prep = dgv_ocn[5, i].Value.ToString();
                    string kab = dgv_ocn[6, i].Value.ToString();
                    r = row.ToString();
                    c = column.ToString();
                    txbx_Naz.Text = naz;
                    txbx_prep.Text = prep;
                    txbx_kab.Text = kab;
                }
            }
        }

        private void btn_SaveC_Click(object sender, EventArgs e)
        {
            dal.openConnection();
            if (dgv_rasp.CurrentCell.Value == null)
            {
                MessageBox.Show("rrr");
            }
            else 
            {
                if (ned == "Верхняя неделя")
                {
                    string upd = $"UPDATE РасписаниеВ SET[Предмет] = '{txbx_Naz.Text}', " +
                    $"[Преподаватель] = '{txbx_prep.Text}', [Кабинет] = '{txbx_kab.Text}' WHERE [Строка] = '{r}' and [Столбец] = '{c}'";
                    SqlCommand commandupd = new SqlCommand(upd, dal.getConnect());
                    int number = commandupd.ExecuteNonQuery();
                }
                else
                {
                    string upd = $"UPDATE РасписаниеН SET[Предмет] = '{txbx_Naz.Text}', " +
                    $"[Преподаватель] = '{txbx_prep.Text}', [Кабинет] = '{txbx_kab.Text}' WHERE [Строка] = '{r}' and [Столбец] = '{c}'";
                    SqlCommand commandupd = new SqlCommand(upd, dal.getConnect());
                    int number = commandupd.ExecuteNonQuery();
                }
            }
            dal.closedConnection();
            Form1_upd();
        }

        private void btn_addr_Click(object sender, EventArgs e)
        {
            dgv_rasp.Rows.Add();
        }

        private void btn_addc_Click(object sender, EventArgs e)
        {
            dgv_rasp.Columns.Add("", "*");
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
