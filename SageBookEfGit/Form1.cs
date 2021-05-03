using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageBookEfGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
               Books b1 = new Books() { Title = "My Book", Pages = 150 };
               context.Book.Add(b1);
               context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var b1 = context.Book.Where(x => x.Title == "My Book").FirstOrDefault();
                b1.Title = "My Book111";
                context.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var b1 = context.Book.Where(x => x.Title == "Peace").FirstOrDefault();
                context.Book.Remove(b1);
                context.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (MyDbContext context = new MyDbContext())
            {
                var res = context.Book.Where(x => x.Id > 0).ToList();
                dataGridView1.DataSource = res;
            }
        }
    }
}
