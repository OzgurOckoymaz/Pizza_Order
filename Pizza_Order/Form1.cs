using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList arr_customers = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            cmbIngredients.Items.Add("Maize");
            cmbIngredients.Items.Add("Green Olive");
            cmbIngredients.Items.Add("Black Olive");
            cmbIngredients.Items.Add("Tomato");
            cmbIngredients.Items.Add("Cheddar");
            cmbIngredients.Items.Add("Pepper");
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            c.Name = textBox1.Text;
            c.Surname = textBox2.Text;
            c.Tel = textBox3.Text;
            c.Address = textBox4.Text;
            arr_customers.Add(c);

            lstCustomers.Items.Clear();
            cmbCustomers.Items.Clear();

            foreach (object items in arr_customers)
            {
                if (items != null)
                {
                    lstCustomers.Items.Add(items);
                    cmbCustomers.Items.Add(items);
                }
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            groupBox2.Visible = true;
        }

        ArrayList arrIngredients = new ArrayList();

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = cmbIngredients.SelectedItem.ToString();
            arrIngredients.Add(selected);

            lstIngredients.Items.Clear();

            foreach (object items in arrIngredients)
            {
                if (items != null)
                {
                    lstIngredients.Items.Add(items);
                }
            }

            cmbIngredients.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = lstIngredients.SelectedItem.ToString();
            int index = arrIngredients.IndexOf(selected);

            arrIngredients[index] = null;

            lstIngredients.Items.Clear();

            foreach (object items in arrIngredients)
            {
                if (items != null)
                {
                    lstIngredients.Items.Add(items);
                }
            }

        }

        ArrayList arrPizIngeridients = new ArrayList();

        private void btnSave2_Click(object sender, EventArgs e)
        {
            Pizzas p = new Pizzas();
            p.Kind = textBox5.Text;
            p.Price = numericUpDown1.Value;
            arrPizIngeridients.Add(p);

            lstPizzaAndPrice.Items.Clear();

            foreach (object items in arrPizIngeridients)
            {
                if (items != null)
                {
                    lstPizzaAndPrice.Items.Add(items);
                }
            }

            cmbPizzaType.Items.Add(p.Kind);

            textBox5.Clear();
            cmbIngredients.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            groupBox3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pizzas p = (Pizzas)lstPizzaAndPrice.SelectedItem;
            int index = arrPizIngeridients.IndexOf(p);

            arrPizIngeridients[index] = null;

            lstPizzaAndPrice.Items.Clear();

            foreach (object items in arrPizIngeridients)
            {
                if (items != null)
                {
                    lstPizzaAndPrice.Items.Add(items);
                }
            }

            cmbPizzaType.Items.Remove(p.Kind);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pizzas p = (Pizzas)lstPizzaAndPrice.SelectedItem;
            int index = arrPizIngeridients.IndexOf(p);

            arrPizIngeridients[index] = null;
            textBox5.Text = p.Kind;
            numericUpDown1.Value = p.Price;

            lstPizzaAndPrice.Items.Clear();

            foreach (object items in arrPizIngeridients)
            {
                if (items != null)
                {
                    lstPizzaAndPrice.Items.Add(items);
                }
            }
        }

        ArrayList arrAddBasket = new ArrayList();

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            Orders o = new Orders();
            o.Customer = cmbCustomers.SelectedItem.ToString();
            o.Type = cmbPizzaType.SelectedItem.ToString();
            o.Amount = Convert.ToInt32(numericUpDown2.Value);
            lstOrderList.Items.Add(o);

            cmbCustomers.SelectedIndex = -1;
            cmbPizzaType.SelectedIndex = -1;
            numericUpDown2.Value = 0;

        }
    }
}
