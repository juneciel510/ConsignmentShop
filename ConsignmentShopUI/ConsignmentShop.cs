using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        private decimal storeProfit = 0;
        private bool extraDetails = false;

        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        public ConsignmentShop()
        {
            InitializeComponent();

            SetupData();

            itemBinding.DataSource= store.Items ;
            itemListbox.DataSource = itemBinding;

            itemListbox.DisplayMember= "Display";
            itemListbox.ValueMember= "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            //vendorListbox.DataSource = vendorsBinding;

            //vendorListbox.DisplayMember = "Display";
            //vendorListbox.ValueMember = "Display";


            //ExtraDetailsVisibility(false);
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetupData()
        {

            store.Name = "Seconds are Better";
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution.",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter (Book 1)",
                Description = "A book about a boy wizard.",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl.",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "15lb Hexagonal Dumbbell Set",
                Description = "Briefly used.",
                Price = 29.99M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Marilyn Manson Shirt",
                Description = "XL size, in new condition.",
                Price = 19.99M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Lightbulbs",
                Description = "Set of 20. Some don't work.",
                Price = 15.55M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Chair",
                Description = "Previously used by gamer. Covered in dorito dust. Cushion sunken in. Please, someone, buy this.",
                Price = 0.99M,
                Owner = store.Vendors[0]
            });

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("I clicked"); // To test the click button function properly
            //
            Item selectedItem = (Item)itemListbox.SelectedItem;

            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);

            store.Items.Remove(selectedItem);
            itemBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            decimal TotalPrice = 0;
            
            foreach (Item item in shoppingCartData)
            {
                TotalPrice += item.Price;
            }

            shoppingCartData.Clear();
            
            
            MessageBox.Show("Total price " + TotalPrice.ToString());
            cartBinding.ResetBindings(false);
        }
    }
}
