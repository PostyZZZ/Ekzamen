using Ekzamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ekzamen
{
    public partial class Form1 : Form
    {
        private DataTable productData;
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager("Host=db.edu.cchgeu.ru;Username=postgres;Password=postgres;database=Teschindb;");
            productData = dbManager.GetProductData();

            foreach (DataRow row in productData.Rows)
            {
                string imagePath = row["ImagePath"].ToString();
                string article = row["article"].ToString();
                string name = row["Name"].ToString();
                string typeproduct = row["TypeProduct"].ToString();
                string numpeople = row["NumPeople"].ToString();
                string cexnumber = row["CexNumber"].ToString();
                string agentprice = row["agentprice"].ToString();
                string descript = row["descript"].ToString();

                UserControl1 UserControl1 = new UserControl1(imagePath, article, name, typeproduct, numpeople, cexnumber, agentprice, descript);
                flowLayoutPanel1.Controls.Add(UserControl1);


            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim().ToLower();
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in productData.Rows)
            {
                string name = row["Name"].ToString().ToLower();
                if (name.Contains(searchKeyword))
                {
                    string imagePath = row["ImagePath"].ToString();
                    string article = row["article"].ToString();
                    string typeproduct = row["TypeProduct"].ToString();
                    string numpeople = row["NumPeople"].ToString();
                    string cexnumber = row["CexNumber"].ToString();
                    string agentprice = row["agentprice"].ToString();
                    string descript = row["descript"].ToString();
                    UserControl1 productControl = new UserControl1(imagePath, article, row["Name"].ToString(), typeproduct, numpeople, cexnumber, agentprice, descript);
                    flowLayoutPanel1.Controls.Add(productControl);
                }
            }
        }        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedSorting = comboBox1.SelectedItem.ToString();


            if (selectedSorting == "А-Я")
            {
                productData.DefaultView.Sort = "Name ASC";
            }
            else if (selectedSorting == "Я-А")
            {
                productData.DefaultView.Sort = "Name DESC";
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRowView rowView in productData.DefaultView)
            {
                DataRow row = rowView.Row;
                string imagePath = row["ImagePath"].ToString();
                string article = row["article"].ToString();
                string name = row["Name"].ToString();
                string typeproduct = row["TypeProduct"].ToString();
                string numpeople = row["NumPeople"].ToString();
                string cexnumber = row["CexNumber"].ToString();
                string agentprice = row["agentprice"].ToString();
                string descript = row["descript"].ToString();
                UserControl1 productControl = new UserControl1(imagePath, article, row["Name"].ToString(), typeproduct, numpeople, cexnumber, agentprice, descript);
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedSorting = comboBox2.SelectedItem.ToString();


            if (selectedSorting == "По возрастанию")
            {
                productData.DefaultView.Sort = "agentprice ASC";
            }
            else if (selectedSorting == "По убыванию")
            {
                productData.DefaultView.Sort = "agentprice DESC";
            }

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRowView rowView in productData.DefaultView)
            {
                DataRow row = rowView.Row;
                string imagePath = row["ImagePath"].ToString();
                string article = row["article"].ToString();
                string name = row["Name"].ToString();
                string typeproduct = row["TypeProduct"].ToString();
                string numpeople = row["NumPeople"].ToString();
                string cexnumber = row["CexNumber"].ToString();
                string agentprice = row["agentprice"].ToString();
                string descript = row["descript"].ToString();
                UserControl1 productControl = new UserControl1(imagePath, article, row["Name"].ToString(), typeproduct, numpeople, cexnumber, agentprice, descript);
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }
    }
}
    



﻿

        
