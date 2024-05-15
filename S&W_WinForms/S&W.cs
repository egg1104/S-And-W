using S_W.DB.Interfaces;
using S_W_HealthStore.Models;

namespace S_W_WinForms
{
    public partial class S_W : Form
    {
        //Creates a Private IUnitOfWork Named unit
        private IUnitOfWork unit;


        //Creates Product Class Object named prod
        public S_W(IUnitOfWork uow)
        {
            unit = uow;
            InitializeComponent();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //Creating a Object of Product Class named prod
            Product prod = new Product();
            //adding a name to prod
            prod.Name = NameTextBox.Text;
            //adding price to prod
            prod.price = Convert.ToDecimal(PriceTextBox.Text);
            //adding quantity to prod
            prod.Quantity = Convert.ToInt32(QuantityTextBox.Text);
            //adding the prod data to the database
            var i = unit.Products.Add(prod);
            NameTextBox.Clear();
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
           
            //removing all items in products Sql Table that have a mathching id
            unit.Products.Delete(Convert.ToInt32(IdTextBox.Text));
            //clears the store items listbox
            StoreItemsList.Items.Clear();
            //this re-adds items back to the list box
            foreach(var item in unit.Products.GetAll()) 
            {
                var show = $"ID: {item.Id}    Name: {item.Name}     ${item.price}      QTY: {item.Quantity}";
                StoreItemsList.Items.Add(show);
            }
            
        }

 

        private void RefreshShoppingList_Click(object sender, EventArgs e)
        {
            //Grabs all items from products and stores it into a listbox
           foreach(var item in unit.Products.GetAll())
            {
                var show = $"ID: {item.Id}    Name: {item.Name}     ${item.price}      QTY: {item.Quantity}";
                StoreItemsList.Items.Add(show);
            }
            
            
        }
    }
}
