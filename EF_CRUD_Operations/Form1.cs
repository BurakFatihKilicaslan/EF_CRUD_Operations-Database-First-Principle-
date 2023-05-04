using EF_CRUD_Operations.Models;
using EF_CRUD_Operations.Repositories;

namespace EF_CRUD_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();
            orderRepository = new OrderRepository();
        }
        EmployeeRepository employeeRepository;
        ShipperRepository shipperRepository;
        OrderRepository orderRepository;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = employeeRepository.GetAllEmployees();
            foreach (Employee employee in employees)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = employee.FirstName + ' ' + employee.LastName;
                lvi.Tag = employee.EmployeeId;
                lstEmployeeName.Items.Add(lvi);
            }

            List<Shipper> shippers = shipperRepository.GetAllShippers();
            foreach (Shipper shiper in shippers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = shiper.CompanyName;
                lvi.Tag = shiper.ShipperId;
                lstCompanyName.Items.Add(lvi);
            }

        }
        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            orderRepository = new OrderRepository();
            bool isEmployeeChecked = lstEmployeeName.SelectedItems.Count > 0;
            bool isShiperChecked = lstCompanyName.SelectedItems.Count > 0;

            if (isEmployeeChecked && isShiperChecked)
            {
                int employeeID = (int)lstEmployeeName.FocusedItem.Tag;
                int shipperID = (int)lstCompanyName.FocusedItem.Tag;
                orderRepository.GetOrdersByEmployeeIDAndShipperID(employeeID, shipperID);
                List<Order> orders = orderRepository.GetOrdersByEmployeeIDAndShipperID(employeeID, shipperID);

                FillOrderListView(orders);
            }
            else if (isEmployeeChecked)
            {
                int employeeID = (int)lstEmployeeName.FocusedItem.Tag;
                List<Order> orders = orderRepository.GetOrdersByShipperID(employeeID);

                FillOrderListView(orders);
            }
            else if (isShiperChecked)
            {
                int shipperID = (int)lstCompanyName.FocusedItem.Tag;
                List<Order> orders = orderRepository.GetOrdersByShipperID(shipperID);

                FillOrderListView(orders);
            }
            else
            {
                List<Order> orders = orderRepository.GetAllOrders();
                FillOrderListView(orders);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstBilgiGoruntule.SelectedItems.Count > 0)
            {
                int orderID = (int)lstBilgiGoruntule.FocusedItem.Tag;
                Form2 form2 = new Form2(orderID);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Herhangi Bir Seçim Yapmadınız");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme Işlemini Onaylıyor Musunuz", "Onay Mesajı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                if (lstBilgiGoruntule.SelectedItems.Count > 0)
                {
                    int orderID = (int)lstBilgiGoruntule.FocusedItem.Tag;
                    int affRows = orderRepository.DeleteOrder(orderID);

                    if (affRows > 0)
                    {
                        MessageBox.Show($"{orderID} idli Sipariş Başarı Ile Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Silme Işlemi Gerçekleştirilemedi");
                    }
                }
            }
        }

        private void FillOrderListView(List<Order> orders)
        {
            if (orders is not null)
            {
                lstBilgiGoruntule.Items.Clear();
                foreach (Order order in orders)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = order.OrderId.ToString();
                    lvi.SubItems.Add(order.OrderDate.Value.ToShortDateString());
                    lvi.SubItems.Add(order.ShipCity);
                    lvi.Tag = order.OrderId;
                    lstBilgiGoruntule.Items.Add(lvi);
                }
            }
        }
    }
}