using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenterApp.Forms
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            Time = DateTime.Today;
        }

        

        public string NameOrder { get; private set; }

        public string PhoneNumber { get; private set; }

        public string Address { get; private set; }

        public bool IsPickup { get; private set; }

        public DateTime Time { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var correct = true;

            if (nameField.TextLength == 0)
            {
                errorProvider.SetError(nameField, "Пожалуйста, укажите название груза.");
                correct = false;
            }

            if (numberField.TextLength == 0)
            {
                errorProvider.SetError(numberField, "Пожалуйства, укажите номер телефона");
                correct = false;
            }

            if (addressField.TextLength == 0)
            {
                errorProvider.SetError(addressField, "Пожалуйста, укажите адрес груза.");
                correct = false;
            }

           

            if (!correct) return;


            NameOrder = nameField.Text;
            PhoneNumber = numberField.Text;
            Address = addressField.Text;
            IsPickup = IsPickupBox.Checked;
            

            DialogResult = DialogResult.OK;
            Close();


        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            Time = (DateTime)sender.GetType().GetProperty("Value").GetValue(sender);
        }
    }







}
