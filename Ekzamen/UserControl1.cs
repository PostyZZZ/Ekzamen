using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string imagepath, string article, string name, string typeproduct, string numpeople, string cexnumber, string agentprice, string descript)
        {
            InitializeComponent();

            pictureBox.Image = Image.FromFile(imagepath);
            LabelArticle.Text = "Артикул:" + article;
            LabelName.Text = "Название: " + name;
            labelTyperoduct.Text = "Тип: " + typeproduct;
            labelnumpeople.Text = "Работники: " + numpeople;
            labelCexnumber.Text = "Номер цеха: " + cexnumber;
            LabelPrice.Text = "Цена: " + agentprice;
            Labesdescript.Text = "Описание:" + descript;
        }
    }
}
