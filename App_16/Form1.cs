using System;
using System.Reflection;
using System.Windows.Forms;
namespace App_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnDiscover_Click(object sender, EventArgs e)
        {
            lstMethods.Items.Clear();
            lstConstructors.Items.Clear();
            lstProperties.Items.Clear();

            string TypeName = textBox1.Text;
            Type T = Type.GetType(TypeName);

            if (T == null)
            {
                MessageBox.Show("Type not found");
                return;
            }

            MethodInfo[] methods = T.GetMethods();
            ConstructorInfo[] constructors = T.GetConstructors();
            PropertyInfo[] properties = T.GetProperties();

            foreach (MethodInfo method in methods)
            {
                lstMethods.Items.Add(method.Name);
            }

            foreach (ConstructorInfo constructor in constructors)
            {
                lstConstructors.Items.Add(constructor.Name);
            }

            foreach (PropertyInfo property in properties)
            {
                lstProperties.Items.Add(property.Name);
            }
        }
    }
}