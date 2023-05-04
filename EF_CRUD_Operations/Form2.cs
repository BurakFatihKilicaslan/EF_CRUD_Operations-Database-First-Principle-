using EF_CRUD_Operations.Models;
using EF_CRUD_Operations.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CRUD_Operations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public Form2(int orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }
        EmployeeRepository employeeRepository;
        ShipperRepository shipperRepository;
        OrderRepository orderRepository;
        int orderID = 0;
        Order order;
        private void Form2_Load(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            shipperRepository = new ShipperRepository();
            orderRepository = new OrderRepository();

            List<Employee> employees = employeeRepository.GetAllEmployees();
            cmbEmployee.DataSource = employees;
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "EmployeeId";

            List<Shipper> shippers = shipperRepository.GetAllShippers();
            cmbShipper.DataSource = shippers;
            cmbShipper.DisplayMember = "CompanyName";
            cmbShipper.ValueMember = "ShipperId";

            if (orderID > 0)
            {
                btnAdd.Text = "Update";
                order = orderRepository.GetOrderByID(orderID);
                cmbEmployee.SelectedValue = order.EmployeeId;
                dtpOrderDate.Value = order.OrderDate.Value;          
                txtShipCity.Text = order.ShipCity;
                cmbShipper.SelectedValue = order.ShipVia;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            orderRepository = new OrderRepository();

            if (orderID > 0) //(orderID is not null)
            {
                order.EmployeeId = (int)cmbEmployee.SelectedValue;
                order.OrderDate = dtpOrderDate.Value;               
                order.ShipCity = txtShipCity.Text;
                order.ShipVia = (int)cmbShipper.SelectedValue;
                int affRows = orderRepository.UpdateOrder(order);
                if (affRows > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu. Güncellenemedi");
                }
            }
            else
            {
                order = new Order();   //newleme sebebimiz orderId secilmediyse hata vermesin diye..
                order.EmployeeId = (int)cmbEmployee.SelectedValue;
                order.OrderDate = dtpOrderDate.Value;               
                order.ShipCity = txtShipCity.Text;
                order.ShipVia = (int)cmbShipper.SelectedValue;
                int affRows = orderRepository.AddOrder(order);
                if (affRows > 0)
                {
                    MessageBox.Show("Ekleme Başarılı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Beklenmeyen Bir Hata Oluştu");
                }
            }
        }
    }
}
