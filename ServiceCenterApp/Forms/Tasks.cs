using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Tasks;
using ServiceCenterApp.Forms;


namespace ServiceCenterApp
{
    public partial class Form1 : Form
    {
        private readonly List<SimpleOrder> _orders = new List<SimpleOrder>();

        public Form1()
        {
            InitializeComponent();
            AddToolStripMenuItem.Click += OnAddOrder;
            Status.Items.AddRange("В ожидании", "Выполняется", "Доставлено");
            DeleteToolStripMenuItem.Click += OnDeleteOrder;
            DeleteAll.Click += OnDeleteAllOrders;

            //AddToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            //DeleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;



        }



        private void OnAddOrder(object sender, EventArgs e)
        {
            var addTask = new AddTask();
            var dialogResult = addTask.ShowDialog();

            if (dialogResult != DialogResult.OK) return;


            CreateOrder(addTask.NameOrder, addTask.Address, addTask.PhoneNumber, addTask.IsPickup, addTask.Time);

        }

        private void OnDeleteOrder(object sender, EventArgs e)
        {
            if (OrdersViewer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выделена строка, удалять нечего!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var count = OrdersViewer.SelectedRows.Count;

            foreach (DataGridViewRow row in OrdersViewer.SelectedRows)
            {
                var index = row.Index;
                _orders.RemoveAt(index);
                OrdersViewer.Rows.Remove(row);
            }


        }


        private void OrdersViewer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (OrdersViewer.Rows[e.RowIndex].IsNewRow) return;
            OrdersViewer.Rows[e.RowIndex].ErrorText = "";

            switch (OrdersViewer.Columns[e.ColumnIndex].Name)
            {


                case "Time":
                    if (!DateTime.TryParse(e.FormattedValue.ToString(), out var testData))
                    {
                        e.Cancel = true;
                        OrdersViewer.Rows[e.RowIndex].ErrorText = "Некорректно задана дата!";
                    }

                    if (testData < DateTime.Today)
                    {
                        e.Cancel = true;
                        OrdersViewer.Rows[e.RowIndex].ErrorText = "Вы не можете доставить груз в прошлом";
                    }

                    break;
                case "Destination":
                    if (e.FormattedValue.ToString().Length == 0)
                    {
                        e.Cancel = true;
                        OrdersViewer.Rows[e.RowIndex].ErrorText = "Поле адреса доставки не может быть пустым";
                    }

                    break;
            }
        }

         private static string GetStatusString(StatusType statusType)
         {
             return statusType switch
             {
                  StatusType.Waiting => "В ожидании",
                  StatusType.Completed => "Доставлено",
                  StatusType.Processing => "Выполняется",
                 _ => throw new ArgumentOutOfRangeException(nameof(statusType), statusType, "Нет такого статуса.")
             };

         }

        private static StatusType GetStatusFromString(string statusString)
        {
            return statusString switch
            {
                "В ожидании" => StatusType.Waiting,
                "Выполняется" => StatusType.Processing,
                "Доставлено" => StatusType.Completed,
                _ => throw new ArgumentOutOfRangeException(nameof(statusString), statusString, "Нет такого статуса.")
            };
        }

        /*private static StatusType GetStatusFromString(string statusString)
        {
            
            switch(statusString)
            {
                case "В ожидании":  return StatusType.Waiting;
                case "Выполняется": return StatusType.Processing;
                case "Доставлено": return StatusType.Completed;
                    throw new ArgumentOutOfRangeException(nameof(statusString), statusString, "Нет такого статуса.");
            }
        }*/





        private void CreateOrder(string name, string address, string phonenumber, bool isPickup, DateTime date, int id = -1,
            StatusType status = StatusType.Waiting)
        {
            List<Product> basket = new List<Product>();
            Random rnd = new Random();
            Product a = new Product("qq", "dwede",rnd.Next(1, 100000) );
            Product b = new Product("sd", "dsa", rnd.Next(1, 100000));
            basket.Add(a);
            basket.Add(b);


            if (id == -1) id = _orders.Count == 0 ? 1 : _orders.Last().OrderID + 1;
            if (isPickup == true)
                _orders.Add(new PickupOrder(name, id, phonenumber, isPickup, address, basket, date) { Status = status});
            else
                _orders.Add(new DeliveryOrder(name, id, phonenumber, isPickup, address, basket, date) { Status = status });

            var index = OrdersViewer.Rows.Add();
            OrdersViewer["ID", index].Value = _orders.Last().OrderID;
            OrdersViewer["Title", index].Value = _orders.Last().NName;
            OrdersViewer["Price", index].Value = _orders.Last().Price;
            OrdersViewer["Destination", index].Value = _orders.Last().WayToGet;
            OrdersViewer["Time", index].Value = _orders.Last().Time.ToShortDateString();
            OrdersViewer["Phone", index].Value = _orders.Last().PhoneNumber;
            OrdersViewer["Pickup", index].Value = _orders.Last().IsPickup;
            OrdersViewer["Status", index].Value = GetStatusString(_orders.Last().Status);
          

        }

        private void OnDeleteAllOrders(object sender, EventArgs e)
        {
            _orders.Clear();
            OrdersViewer.Rows.Clear();
        }

        /*private void OnDeleteUnused(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in OrdersViewer.Rows)
            {
                if (_orders[row.Index].Status != StatusType.Completed) continue;
                _orders.RemoveAt(row.Index);
                OrdersViewer.Rows.Remove(row);
            }


        }*/


    }
}
